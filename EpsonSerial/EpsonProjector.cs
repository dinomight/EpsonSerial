using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Globalization;
using System.Drawing;
using log4net;

namespace EpsonSerial
{
    public enum Source
    {
        Error = 0xFF,
        Component = 0x14,
        HDMI1 = 0x30,
        HDMI2 = 0xA0,
        PC = 0x21,
        SVideo = 0x42,
        Video = 0x41,
    }

    public enum ColorMode
    {
        Error = 0xFF,
        Cinema = 0x15,
        Dynamic = 0x06,
        LivingRoom = 0x0C,
        Natural = 0x07,
        xvColor = 0x0B,
    }

    public enum PowerStatus
    {
        Error = 0xFF,
        Standby = 0x00,
        On = 0x01,
        WarpUp = 0x02,
        CoolDown = 0x03,
        AbnormalStandby = 0x05,
    }

    public enum AspectRatio
    {
        Error = 0xFF,
        Auto = 0x30,
        Full = 0x40,
        Normal = 0x00,
        Wide = 0x70,
        Zoom = 0x50,
    }

    public enum Luminance
    {
        Error = 0xFF,
        Eco = 0x01,
        Normal = 0x00,
    }

    public enum Sharpness
    {
        Standard = 0x00,
        HighPass = 0x01,
        LowPass = 0x02,
        Horizontal = 0x04,
        Vertical = 0x05,
    }

    public enum Gamma
    {
        Error = 0xFF,
        G2_0 = 0x20,
        G2_1 = 0x21,
        G2_2 = 0x22,
        G2_3 = 0x23,
        G2_4 = 0x24,
        Custom = 0xF0,
    }

    public enum GammaStep
    {
        Tone1 = 0x00,
        Tone2 = 0x01,
        Tone3 = 0x02,
        Tone4 = 0x03,
        Tone5 = 0x04,
        Tone6 = 0x05,
        Tone7 = 0x06,
        Tone8 = 0x07,
        Tone9 = 0x08,
    }

    public enum Color
    {
        Error = 0xFF,
        RGB_RGBCMY = 0x07,
    }

    public enum Background
    {
        Error = 0xFF,
        Black = 0x00,
        Blue = 0x01,
        Logo = 0x02,
    }

    public enum Speed
    {
        Error = 0xFF,
        S9600 = 0x00,
        S18200 = 0x01,
        S38400 = 0x02,
        S57600 = 0x03,
    }

    public enum Switch
    {
        ON,
        OFF,
    }

    // http://stackoverflow.com/a/972323
    public static class EnumUtil
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static T Parse<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }

    public class EpsonProjectorException : Exception
    {
        public EpsonProjectorException(string message)
            :base(message)
        {
        }

        public EpsonProjectorException(string message, Exception innerException)
            :base(message, innerException)
        {
        }
    }

    public class EpsonProjector
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EpsonProjector));

        protected int QueryInt(string query, NumberStyles style = NumberStyles.Integer)
        {
            var resp = Write(query);
            if (resp.Length == 0 || resp == "ERR")
                return -1;

            var pieces = resp.Split('=');

            return Int32.Parse(pieces[1], style);
        }

        protected T QueryEnum<T>(string query)
        {
            var resp = Write(query);
            if (resp.Length == 0 || resp == "ERR")
                throw new EpsonProjectorException("Received error response from query '" + query + "'");

            var pieces = resp.Split('=');

            return EnumUtil.Parse<T>(pieces[1]);
        }

        public int Brightness
        {
            get
            {
                return QueryInt("BRIGHT?");
            }
            set
            {
                Write(String.Format("BRIGHT {0}", value));
            }
        }

        public int Contrast
        {
            get
            {
                return QueryInt("CONTRAST?");
            }
            set
            {
                Write(String.Format("CONTRAST {0}", value));
            }
        }

        public int Density
        {
            get
            {
                return QueryInt("DENSITY?");
            }
            set
            {
                Write(String.Format("DENSITY {0}", value));
            }
        }

        public int Tint
        {
            get
            {
                return QueryInt("TINT?");
            }
            set
            {
                Write(String.Format("TINT {0}", value));
            }
        }

        public int Sharpness(Sharpness sharpness)
        {
            return QueryInt(String.Format("SHARP? {0,2:X2}", (int)sharpness));
        }

        public void Sharpness(Sharpness sharpness, int value)
        {
            Write(String.Format("SHARP {0} {1,2:X2}", value, (int)sharpness));
        }

        public int GammaStep(GammaStep step)
        {
            return QueryInt(String.Format("GAMMALV? {0,2:X2}", (int)step));
        }

        public void GammaStep(GammaStep step, int value)
        {
            Write(String.Format("GAMMALV {1,2:X2} {0}", value, (int)step));
        }

        public Luminance Luminance
        {
            get
            {
                var luminance = QueryInt("LUMINANCE?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Luminance), luminance))
                    return (Luminance)luminance;

                return Luminance.Error;
            }
            set
            {
                Write(String.Format("LUMINANCE {0,2:X2}", (int)value));
            }
        }

        public Gamma Gamma
        {
            get
            {
                var gamma = QueryInt("GAMMA?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Gamma), gamma))
                    return (Gamma)gamma;

                return Gamma.Error;
            }
            set
            {
                Write(String.Format("GAMMA {0,2:X2}", (int)value));
            }
        }

        public void LoadMemory(int number)
        {
            Write(String.Format("POPMEM 02 {0,2:X2}", number));
        }

        public void SaveMemory(int number)
        {
            Write(String.Format("PUSHMEM 02 {0,2:X2}", number));
        }

        /// <summary>
        /// Erases all of the memory on the projector.
        /// </summary>
        public void EraseMemory()
        {
            Write("ERASEMEM 00");
        }

        /// <summary>
        /// Erases the specified advanced memory number.
        /// </summary>
        /// <param name="number">Number of the memory item to be erased.</param>
        public void EraseMemory(int number)
        {
            Write(String.Format("ERASEMEM 02 {0,2:X2}", number));
        }

        public Color Color
        {
            get
            {
                var color = QueryInt("CSEL?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Color), color))
                    return (Color)color;

                return Color.Error;
            }
        }

        public Switch Mute
        {
            get
            {
                return QueryEnum<Switch>("MUTE?");
            }
            set
            {
                Write(String.Format("MUTE {0}", value));
            }
        }

        public Switch HorizontalReverse
        {
            get
            {
                return QueryEnum<Switch>("HREVERSE?");
            }
            set
            {
                Write(String.Format("HREVERSE {0}", value));
            }
        }

        public Switch VerticalReverse
        {
            get
            {
                return QueryEnum<Switch>("VREVERSE?");
            }
            set
            {
                Write(String.Format("VREVERSE {0}", value));
            }
        }

        public Background Background
        {
            get
            {
                var background = QueryInt("MSEL?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Background), background))
                    return (Background)background;

                return Background.Error;
            }
            set
            {
                Write(String.Format("MSEL {0,2:X2}", (int)value));
            }
        }

        public void ResetAll()
        {
            Write("INITALL");
        }

        public Speed Speed
        {
            get
            {
                var speed = QueryInt("SPEED?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Speed), speed))
                    return (Speed)speed;

                return Speed.Error;
            }
            set
            {
                Write(String.Format("SPEED {0}", (int)value));
            }
        }

        public int LampTime
        {
            get
            {
                return QueryInt("LAMP?");
            }
        }

        public AspectRatio AspectRatio
        {
            get
            {
                var aspect = QueryInt("ASPECT?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(AspectRatio), aspect))
                    return (AspectRatio)aspect;

                return AspectRatio.Error;
            }
            set
            {
                Write(String.Format("ASPECT {0,2:X2}", (int)value));
            }
        }

        public int ColorTemperature
        {
            get
            {
                return QueryInt("CTEMP?");
            }
            set
            {
                Write(String.Format("CTEMP {0}", value));
            }
        }

        public int HorizontalPosition
        {
            get
            {
                return QueryInt("HPOS?");
            }
            set
            {
                Write(String.Format("HPOS {0}", value));
            }
        }

        public int VerticalPosition
        {
            get
            {
                return QueryInt("VPOS?");
            }
            set
            {
                Write(String.Format("VPOS {0}", value));
            }
        }

        public int Tracking
        {
            get
            {
                return QueryInt("TRACKIOK?");
            }
            set
            {
                Write(String.Format("TRACKIOK {0}", value));
            }
        }

        public int Sync
        {
            get
            {
                return QueryInt("SYNC?");
            }
            set
            {
                Write(String.Format("SYNC {0}", value));
            }
        }

        public int FleshColor
        {
            get
            {
                return QueryInt("FCOLOR?");
            }
            set
            {
                Write(String.Format("FCOLOR {0}", value));
            }
        }

        public int OffsetRed
        {
            get
            {
                return QueryInt("OFFSETR?");
            }
            set
            {
                Write(String.Format("OFFSETR {0}", value));
            }
        }

        public int OffsetGreen
        {
            get
            {
                return QueryInt("OFFSETG?");
            }
            set
            {
                Write(String.Format("OFFSETG {0}", value));
            }
        }

        public int OffsetBlue
        {
            get
            {
                return QueryInt("OFFSETB?");
            }
            set
            {
                Write(String.Format("OFFSETB {0}", value));
            }
        }

        public int GainRed
        {
            get
            {
                return QueryInt("GAINR?");
            }
            set
            {
                Write(String.Format("GAINR {0}", value));
            }
        }

        public int GainGreen
        {
            get
            {
                return QueryInt("GAING?");
            }
            set
            {
                Write(String.Format("GAING {0}", value));
            }
        }

        public int GainBlue
        {
            get
            {
                return QueryInt("GAINB?");
            }
            set
            {
                Write(String.Format("GAINB {0}", value));
            }
        }

        public Source Source
        { 
            get
            {
                var source = QueryInt("SOURCE?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(Source), source))
                    return (Source)source;

                return Source.Error;
            }
            set
            {
                Write(String.Format("SOURCE {0,2:X2}", (int)value));
            }
        }

        public ColorMode ColorMode
        {
            get
            {
                var colorMode = QueryInt("CMODE?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(ColorMode), colorMode))
                    return (ColorMode)colorMode;

                return ColorMode.Error;
            }
            set
            {
                Write(String.Format("CMODE {0,2:X2}", (int)value));
            }
        }

        public PowerStatus PowerStatus
        {
            get
            {
                var pwrStatus = QueryInt("PWR?", NumberStyles.HexNumber);
                if (Enum.IsDefined(typeof(PowerStatus), pwrStatus))
                    return (PowerStatus)pwrStatus;

                return PowerStatus.Error;
            }
        }

        public Switch Power
        {
            set
            {
                Write(String.Format("PWR {0}", value));
            }
        }

        public bool Valid { get; set; }

        private SerialPort Port { get; set; }

        private string Write(string cmd)
        {
            log.Debug("CMD: " + cmd);

            Port.WriteLine(cmd);
            string resp = "";
            while (true)
            {
                var ch = Port.ReadChar();
                if (ch == ':')
                    break;

                resp += (char)ch;
            }

            resp = resp.Trim();

            log.Debug("RSP: " + resp);

            return resp;
        }

        public EpsonProjector()
        {
            Port = new SerialPort();

            Port.BaudRate = 9600;
            Port.Parity = Parity.None;
            Port.StopBits = StopBits.One;
            Port.DataBits = 8;
            Port.Handshake = Handshake.None;
            Port.NewLine = "\r";
            
            Valid = false;
        }

        public bool SetPortName(string portName)
        {
            if (Port.IsOpen)
                Port.Close();

            Port.PortName = portName;
            Valid = false;

            try
            {
                Port.Open();
            }
            catch (Exception)
            {
                return false;
            }

            Port.WriteLine("");
            Port.ReadTimeout = 1000;
            int resp = 0;
            try
            {
                while (true)
                {
                    resp = Port.ReadChar();
                    if (resp == ':')
                        break;
                }
            }
            catch (TimeoutException)
            {
                log.Warn(portName + ": Port read timeout");
            }

            if (resp != ':')
            {
                log.Warn(portName + ": Unable to verify projector connection");
                Port.Close();
                return false;
            }

            Port.ReadTimeout = -1;
            Valid = true;

            return true;
        }

        public void Dispose()
        {
            Port.Close();
            Valid = false;
        }
    }
}
