using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using log4net.Config;
using log4net;
using System.Threading;

namespace EpsonSerial
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var projector = new EpsonProjector();
            Thread.CurrentThread.Name = "Main";

            var showGui = true;

            if (args.Length > 0)
                showGui = false;

            var portName = "";
            if (!args.Contains("--port"))
            {
                log.Info("No port specified");
                foreach (var name in SerialPort.GetPortNames())
                {
                    if (projector.SetPortName(name))
                    {
                        portName = name;
                        break;
                    }
                }

                if (portName.Length == 0)
                    log.Warn("Could not find a working default COM port with a projector.");
            }

            for (int i = 0; i < args.Length; ++i)
            {
                var arg = args[i];
                if (arg == "--port")
                {
                    ++i;
                    if (i >= args.Length)
                    {
                        log.Error("You must provide the target port name.");
                        return;
                    }

                    portName = args[i];
                    if (!projector.SetPortName(portName))
                    {
                        log.Error("Failed to detect a project on port '" + portName + "'");
                        return;
                    }
                }
                else if (arg == "--off")
                {
                    projector.Power = Switch.OFF;
                }
                else if (arg == "--on")
                {
                    projector.Power = Switch.ON;
                }
                else if (arg == "--mute")
                {
                    projector.Mute = Switch.ON;
                }
                else if (arg == "--unmute")
                {
                    projector.Mute = Switch.OFF;
                }
                else if (arg == "--source")
                {
                    ++i;
                    if (i >= args.Length)
                    {
                        log.Error("You must provide a source to switch to");
                        return;
                    }

                    var sourceName = args[i];
                    Source source;
                    if (!Enum.TryParse<Source>(sourceName, true, out source))
                    {
                        log.Error("Invalid source provided: " + sourceName);
                        return;
                    }

                    projector.Source = source;
                }
                else if (arg == "--cmode")
                {
                    ++i;
                    if (i >= args.Length)
                    {
                        log.Error("You must provide a color mode to switch to");
                        return;
                    }

                    var cmodeName = args[i];
                    ColorMode cmode;
                    if (!Enum.TryParse<ColorMode>(cmodeName, true, out cmode))
                    {
                        log.Error("Invalid color mode provided: " + cmodeName);
                        return;
                    }

                    projector.ColorMode = cmode;
                }
                else if (arg == "--mem")
                {
                    ++i;
                    if (i >= args.Length)
                    {
                        log.Error("You must provide a memory slot to load");
                        return;
                    }

                    var memName = args[i];
                    int number;
                    if (!Int32.TryParse(memName, out number) || number > 10 || number < 0)
                    {
                        log.Error("Invalid memory slot provided: " + memName);
                        return;
                    }

                    projector.LoadMemory(number);
                }
                else
                {
                    log.Error("Invalid command line parameter: " + arg);
                    return;
                }
            }

            if (showGui)
            {
                log.Debug("Launching GUI");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(projector));
            }
        }
    }
}
