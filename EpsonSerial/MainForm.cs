using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EpsonSerial
{
    public partial class MainForm : Form
    {
        private EpsonProjector projector;
        private bool ignoreDropDownSelect = true;

        private ContextMenu trayMenu;
        private MenuItem Source;
        private MenuItem SourceComponent;
        private MenuItem SourceHDMI1;
        private MenuItem SourceHDMI2;
        private MenuItem SourcePC;
        private MenuItem SourceSVideo;
        private MenuItem SourceVideo;

        public MainForm(EpsonProjector projector)
        {
            InitializeComponent();

            notifyIcon.Icon = new Icon(SystemIcons.Application, 40, 40);
            notifyIcon.Visible = true;

            trayMenu = new ContextMenu();

            SourceComponent = new MenuItem("Component", OnSourceComponent);
            SourceHDMI1 = new MenuItem("HDMI1", OnSourceHDMI1);
            SourceHDMI2 = new MenuItem("HDMI2", OnSourceHDMI2);
            SourcePC = new MenuItem("PC", OnSourcePC);
            SourceSVideo = new MenuItem("S-Video", OnSourceSVideo);
            SourceVideo = new MenuItem("Video", OnSourceVideo);

            Source = new MenuItem("Source", new MenuItem[] {
                SourceComponent,
                SourceHDMI1,
                SourceHDMI2,
                SourcePC,
                SourceSVideo,
                SourceVideo,
            });

            trayMenu.MenuItems.Add(Source);
            trayMenu.MenuItems.Add("Exit", OnExit);
            notifyIcon.ContextMenu = trayMenu;

            this.projector = projector;

            setupEnumSelect<ColorMode>(colorMode);
            setupEnumSelect<Source>(source);
            setupEnumSelect<AspectRatio>(aspectRatio);
            setupEnumSelect<Luminance>(luminance);
            setupEnumSelect<Sharpness>(sharpSelect);

            updateControls();
            ignoreDropDownSelect = false;
        }

        private void OnSourceSVideo(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.SVideo;
            SourceSVideo.Checked = true;
        }

        private void OnSourceVideo(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.Video;
            SourceVideo.Checked = true;
        }

        private void OnSourceHDMI1(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.HDMI1;
            SourceHDMI1.Checked = true;
        }

        private void OnSourceHDMI2(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.HDMI2;
            SourceHDMI2.Checked = true;
        }

        private void OnSourcePC(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.PC;
            SourcePC.Checked = true;
        }

        private void OnSourceComponent(object sender, EventArgs e)
        {
            foreach (var item in Source.MenuItems.Cast<MenuItem>())
                item.Checked = false;

            projector.Source = EpsonSerial.Source.Component;
            SourceComponent.Checked = true;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setupEnumSelect<T>(ComboBox box)
        {
            var dataTable = new DataTable(typeof(T).Name);
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            foreach (var e in EnumUtil.GetValues<T>())
            {
                if (e.ToString() == "Error")
                    continue;

                dataTable.Rows.Add(e, e.ToString());
            }

            box.DataSource = dataTable;
            box.DisplayMember = "Name";
            box.ValueMember = "Id";
        }

        private void updateControls()
        {
            if (!projector.Valid)
                return;

            var pwrStatus = projector.PowerStatus;
            if (pwrStatus == PowerStatus.On)
            {
                colorMode.Enabled = true;
                colorMode.SelectedValue = projector.ColorMode;

                source.Enabled = true;
                source.SelectedValue = projector.Source;

                aspectRatio.Enabled = true;
                aspectRatio.SelectedValue = projector.AspectRatio;

                luminance.Enabled = true;
                luminance.SelectedValue = projector.Luminance;

                brightness.Enabled = true;
                brightness.Value = projector.Brightness;

                contrast.Enabled = true;
                contrast.Value = projector.Contrast;

                saturation.Enabled = true;
                saturation.Value = projector.Density;

                tint.Enabled = true;
                tint.Value = projector.Tint;

                sharp.Enabled = true;
                sharpSelect.Enabled = true;
                sharpSelect.SelectedValue = Sharpness.Standard;
                sharp.Value = projector.Sharpness(Sharpness.Standard);

                colorTemp.Enabled = true;
                colorTemp.Value = projector.ColorTemperature;

                fleshColor.Enabled = true;
                fleshColor.Value = projector.FleshColor;

                offsetR.Enabled = true;
                offsetG.Enabled = true;
                offsetB.Enabled = true;
                offsetR.Value = projector.OffsetRed;
                offsetG.Value = projector.OffsetGreen;
                offsetB.Value = projector.OffsetBlue;

                gainR.Enabled = true;
                gainG.Enabled = true;
                gainB.Enabled = true;
                gainR.Value = projector.GainRed;
                gainG.Value = projector.GainGreen;
                gainB.Value = projector.GainBlue;

                verticalFlip.Enabled = true;
                hortizontalFlip.Enabled = true;
                verticalFlip.Checked = (projector.VerticalReverse == Switch.ON);
                hortizontalFlip.Checked = (projector.HorizontalReverse == Switch.ON);

                var temp = projector.HorizontalPosition;
                if (temp >= 0)
                {
                    horizontalPos.Enabled = true;
                    horizontalPos.Value = projector.HorizontalPosition;
                }
                else
                {
                    horizontalPos.Enabled = false;
                }

                temp = projector.VerticalPosition;
                if (temp >= 0)
                {
                    verticalPos.Enabled = true;
                    verticalPos.Value = projector.VerticalPosition;
                }
                else
                {
                    verticalPos.Enabled = false;
                }

                temp = projector.Tracking;
                if (temp >= 0)
                {
                    tracking.Enabled = true;
                    tracking.Value = projector.Tracking;
                }
                else
                {
                    tracking.Enabled = false;
                }

                temp = projector.Sync;
                if (temp >= 0)
                {
                    sync.Enabled = true;
                    sync.Value = projector.Sync;
                }
                else
                {
                    sync.Enabled = false;
                }

                powerOn.Enabled = false;
                powerOff.Enabled = true;

                foreach (var item in Source.MenuItems.Cast<MenuItem>())
                    item.Checked = false;

                switch (projector.Source)
                {
                    case EpsonSerial.Source.HDMI1:
                        SourceHDMI1.Checked = true;
                        break;
                    case EpsonSerial.Source.HDMI2:
                        SourceHDMI2.Checked = true;
                        break;
                    case EpsonSerial.Source.PC:
                        SourcePC.Checked = true;
                        break;
                    case EpsonSerial.Source.Component:
                        SourceComponent.Checked = true;
                        break;
                    case EpsonSerial.Source.Video:
                        SourceVideo.Checked = true;
                        break;
                }
                Source.Enabled = true;
            }
            else if (pwrStatus == PowerStatus.Standby)
            {
                colorMode.Enabled = false;
                source.Enabled = false;
                aspectRatio.Enabled = false;
                luminance.Enabled = false;

                brightness.Enabled = false;
                contrast.Enabled = false;
                saturation.Enabled = false;
                tint.Enabled = false;
                colorTemp.Enabled = false;
                fleshColor.Enabled = false;

                sharp.Enabled = false;
                sharpSelect.Enabled = false;

                horizontalPos.Enabled = false;
                verticalPos.Enabled = false;
                tracking.Enabled = false;
                sync.Enabled = false;

                offsetR.Enabled = false;
                offsetG.Enabled = false;
                offsetB.Enabled = false;

                gainR.Enabled = false;
                gainG.Enabled = false;
                gainB.Enabled = false;

                verticalFlip.Enabled = false;
                hortizontalFlip.Enabled = false;

                powerOn.Enabled = true;
                powerOff.Enabled = false;

                Source.Enabled = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            projector.Dispose();
            base.OnClosed(e);
        }

        private void powerOn_Click(object sender, EventArgs e)
        {
            projector.Power = Switch.ON;
            updateControls();
        }

        private void powerOff_Click(object sender, EventArgs e)
        {
            projector.Power = Switch.OFF;
            updateControls();
        }

        private T SelectedEnum<T>(ComboBox box)
        {
            var rowView = (DataRowView)box.SelectedItem;

            return (T)Enum.Parse(typeof(T), (string)rowView.Row["Id"]);
        }

        private void colorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectMode = SelectedEnum<ColorMode>(colorMode);
            if (selectMode != projector.ColorMode)
                projector.ColorMode = selectMode;
        }

        private void source_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectSource = SelectedEnum<Source>(source);
            if (selectSource != projector.Source)
                projector.Source = selectSource;
        }

        private void aspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectAspect = SelectedEnum<AspectRatio>(aspectRatio);
            if (selectAspect != projector.AspectRatio)
                projector.AspectRatio = selectAspect;
        }

        private void luminance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectLuminance = SelectedEnum<Luminance>(luminance);
            if (selectLuminance != projector.Luminance)
                projector.Luminance = selectLuminance;
        }

        private void brightness_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Brightness = (int)brightness.Value;
        }

        private void contrast_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Contrast = (int)contrast.Value;
        }

        private void density_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Density = (int)saturation.Value;
        }

        private void tint_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Tint = (int)tint.Value;
        }

        private void sharp_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectSharpness = SelectedEnum<Sharpness>(sharpSelect);
            projector.Sharpness(selectSharpness, (int)sharp.Value);
        }

        private void sharpSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            var selectSharpness = SelectedEnum<Sharpness>(sharpSelect);
            sharp.Value = projector.Sharpness(selectSharpness);
        }

        private void colorTemp_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.ColorTemperature = (int)colorTemp.Value;
        }

        private void fleshColor_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.FleshColor = (int)fleshColor.Value;
        }

        private void horizontalPos_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.HorizontalPosition = (int)horizontalPos.Value;
        }

        private void verticalPos_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.VerticalPosition = (int)verticalPos.Value;
        }

        private void tracking_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Tracking = (int)tracking.Value;
        }

        private void sync_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.Sync = (int)sync.Value;
        }

        private void offsetR_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.OffsetRed = (int)offsetR.Value;
        }

        private void offsetG_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.OffsetGreen = (int)offsetG.Value;
        }

        private void offsetB_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.OffsetBlue = (int)offsetB.Value;
        }

        private void gainR_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.GainRed = (int)gainR.Value;
        }

        private void gainG_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.GainGreen = (int)gainG.Value;
        }

        private void gainB_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.GainBlue = (int)gainB.Value;
        }

        private void verticalFlip_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.VerticalReverse = (verticalFlip.Checked) ? Switch.ON : Switch.OFF;
        }

        private void hortizontalFlip_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreDropDownSelect)
                return;

            projector.HorizontalReverse = (hortizontalFlip.Checked) ? Switch.ON : Switch.OFF;
        }
    }
}
