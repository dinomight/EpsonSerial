namespace EpsonSerial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.powerOn = new System.Windows.Forms.Button();
            this.powerOff = new System.Windows.Forms.Button();
            this.powerControlGroupBox = new System.Windows.Forms.GroupBox();
            this.colorMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aspectRatio = new System.Windows.Forms.ComboBox();
            this.luminance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brightness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.contrast = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.saturation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tint = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.sharp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.sharpSelect = new System.Windows.Forms.ComboBox();
            this.colorTemp = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.fleshColor = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.horizontalPos = new System.Windows.Forms.NumericUpDown();
            this.verticalPos = new System.Windows.Forms.NumericUpDown();
            this.tracking = new System.Windows.Forms.NumericUpDown();
            this.sync = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.offsetR = new System.Windows.Forms.NumericUpDown();
            this.offsetG = new System.Windows.Forms.NumericUpDown();
            this.offsetB = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gainB = new System.Windows.Forms.NumericUpDown();
            this.gainG = new System.Windows.Forms.NumericUpDown();
            this.gainR = new System.Windows.Forms.NumericUpDown();
            this.verticalFlip = new System.Windows.Forms.CheckBox();
            this.hortizontalFlip = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.powerControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleshColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainR)).BeginInit();
            this.SuspendLayout();
            // 
            // powerOn
            // 
            this.powerOn.Location = new System.Drawing.Point(6, 21);
            this.powerOn.Name = "powerOn";
            this.powerOn.Size = new System.Drawing.Size(151, 23);
            this.powerOn.TabIndex = 0;
            this.powerOn.Text = "On";
            this.powerOn.UseVisualStyleBackColor = true;
            this.powerOn.Click += new System.EventHandler(this.powerOn_Click);
            // 
            // powerOff
            // 
            this.powerOff.Location = new System.Drawing.Point(163, 21);
            this.powerOff.Name = "powerOff";
            this.powerOff.Size = new System.Drawing.Size(145, 23);
            this.powerOff.TabIndex = 1;
            this.powerOff.Text = "Off";
            this.powerOff.UseVisualStyleBackColor = true;
            this.powerOff.Click += new System.EventHandler(this.powerOff_Click);
            // 
            // powerControlGroupBox
            // 
            this.powerControlGroupBox.Controls.Add(this.powerOn);
            this.powerControlGroupBox.Controls.Add(this.powerOff);
            this.powerControlGroupBox.Location = new System.Drawing.Point(12, 12);
            this.powerControlGroupBox.Name = "powerControlGroupBox";
            this.powerControlGroupBox.Size = new System.Drawing.Size(314, 57);
            this.powerControlGroupBox.TabIndex = 3;
            this.powerControlGroupBox.TabStop = false;
            this.powerControlGroupBox.Text = "Power Controls";
            // 
            // colorMode
            // 
            this.colorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorMode.FormattingEnabled = true;
            this.colorMode.Location = new System.Drawing.Point(113, 73);
            this.colorMode.Name = "colorMode";
            this.colorMode.Size = new System.Drawing.Size(213, 24);
            this.colorMode.TabIndex = 4;
            this.colorMode.SelectedIndexChanged += new System.EventHandler(this.colorMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source:";
            // 
            // source
            // 
            this.source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(113, 104);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(213, 24);
            this.source.TabIndex = 7;
            this.source.SelectedIndexChanged += new System.EventHandler(this.source_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aspect Ratio:";
            // 
            // aspectRatio
            // 
            this.aspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectRatio.FormattingEnabled = true;
            this.aspectRatio.Location = new System.Drawing.Point(113, 134);
            this.aspectRatio.Name = "aspectRatio";
            this.aspectRatio.Size = new System.Drawing.Size(213, 24);
            this.aspectRatio.TabIndex = 9;
            this.aspectRatio.SelectedIndexChanged += new System.EventHandler(this.aspectRatio_SelectedIndexChanged);
            // 
            // luminance
            // 
            this.luminance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.luminance.FormattingEnabled = true;
            this.luminance.Location = new System.Drawing.Point(113, 165);
            this.luminance.Name = "luminance";
            this.luminance.Size = new System.Drawing.Size(213, 24);
            this.luminance.TabIndex = 10;
            this.luminance.SelectedIndexChanged += new System.EventHandler(this.luminance_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Luminance:";
            // 
            // brightness
            // 
            this.brightness.Location = new System.Drawing.Point(113, 196);
            this.brightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(213, 22);
            this.brightness.TabIndex = 12;
            this.brightness.ValueChanged += new System.EventHandler(this.brightness_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Brightness:";
            // 
            // contrast
            // 
            this.contrast.Location = new System.Drawing.Point(113, 225);
            this.contrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(213, 22);
            this.contrast.TabIndex = 14;
            this.contrast.ValueChanged += new System.EventHandler(this.contrast_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contrast:";
            // 
            // saturation
            // 
            this.saturation.Location = new System.Drawing.Point(113, 254);
            this.saturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.saturation.Name = "saturation";
            this.saturation.Size = new System.Drawing.Size(213, 22);
            this.saturation.TabIndex = 16;
            this.saturation.ValueChanged += new System.EventHandler(this.density_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Saturation:";
            // 
            // tint
            // 
            this.tint.Location = new System.Drawing.Point(113, 283);
            this.tint.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tint.Name = "tint";
            this.tint.Size = new System.Drawing.Size(213, 22);
            this.tint.TabIndex = 18;
            this.tint.ValueChanged += new System.EventHandler(this.tint_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tint:";
            // 
            // sharp
            // 
            this.sharp.Location = new System.Drawing.Point(113, 313);
            this.sharp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sharp.Name = "sharp";
            this.sharp.Size = new System.Drawing.Size(56, 22);
            this.sharp.TabIndex = 20;
            this.sharp.ValueChanged += new System.EventHandler(this.sharp_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sharpness:";
            // 
            // sharpSelect
            // 
            this.sharpSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sharpSelect.FormattingEnabled = true;
            this.sharpSelect.Location = new System.Drawing.Point(176, 312);
            this.sharpSelect.Name = "sharpSelect";
            this.sharpSelect.Size = new System.Drawing.Size(150, 24);
            this.sharpSelect.TabIndex = 22;
            this.sharpSelect.SelectedIndexChanged += new System.EventHandler(this.sharpSelect_SelectedIndexChanged);
            // 
            // colorTemp
            // 
            this.colorTemp.Location = new System.Drawing.Point(113, 342);
            this.colorTemp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorTemp.Name = "colorTemp";
            this.colorTemp.Size = new System.Drawing.Size(213, 22);
            this.colorTemp.TabIndex = 23;
            this.colorTemp.ValueChanged += new System.EventHandler(this.colorTemp_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Color Temp:";
            // 
            // fleshColor
            // 
            this.fleshColor.Location = new System.Drawing.Point(113, 371);
            this.fleshColor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fleshColor.Name = "fleshColor";
            this.fleshColor.Size = new System.Drawing.Size(213, 22);
            this.fleshColor.TabIndex = 25;
            this.fleshColor.ValueChanged += new System.EventHandler(this.fleshColor_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Skin Tone:";
            // 
            // horizontalPos
            // 
            this.horizontalPos.Location = new System.Drawing.Point(113, 400);
            this.horizontalPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.horizontalPos.Name = "horizontalPos";
            this.horizontalPos.Size = new System.Drawing.Size(213, 22);
            this.horizontalPos.TabIndex = 27;
            this.horizontalPos.ValueChanged += new System.EventHandler(this.horizontalPos_ValueChanged);
            // 
            // verticalPos
            // 
            this.verticalPos.Location = new System.Drawing.Point(113, 429);
            this.verticalPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.verticalPos.Name = "verticalPos";
            this.verticalPos.Size = new System.Drawing.Size(213, 22);
            this.verticalPos.TabIndex = 28;
            this.verticalPos.ValueChanged += new System.EventHandler(this.verticalPos_ValueChanged);
            // 
            // tracking
            // 
            this.tracking.Location = new System.Drawing.Point(113, 458);
            this.tracking.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tracking.Name = "tracking";
            this.tracking.Size = new System.Drawing.Size(213, 22);
            this.tracking.TabIndex = 29;
            this.tracking.ValueChanged += new System.EventHandler(this.tracking_ValueChanged);
            // 
            // sync
            // 
            this.sync.Location = new System.Drawing.Point(113, 487);
            this.sync.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sync.Name = "sync";
            this.sync.Size = new System.Drawing.Size(213, 22);
            this.sync.TabIndex = 30;
            this.sync.ValueChanged += new System.EventHandler(this.sync_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Horizontal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Vertical:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Tracking:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sync:";
            // 
            // offsetR
            // 
            this.offsetR.Location = new System.Drawing.Point(113, 516);
            this.offsetR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.offsetR.Name = "offsetR";
            this.offsetR.Size = new System.Drawing.Size(56, 22);
            this.offsetR.TabIndex = 35;
            this.offsetR.ValueChanged += new System.EventHandler(this.offsetR_ValueChanged);
            // 
            // offsetG
            // 
            this.offsetG.Location = new System.Drawing.Point(175, 515);
            this.offsetG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.offsetG.Name = "offsetG";
            this.offsetG.Size = new System.Drawing.Size(56, 22);
            this.offsetG.TabIndex = 36;
            this.offsetG.ValueChanged += new System.EventHandler(this.offsetG_ValueChanged);
            // 
            // offsetB
            // 
            this.offsetB.Location = new System.Drawing.Point(237, 515);
            this.offsetB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.offsetB.Name = "offsetB";
            this.offsetB.Size = new System.Drawing.Size(56, 22);
            this.offsetB.TabIndex = 37;
            this.offsetB.ValueChanged += new System.EventHandler(this.offsetB_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 518);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Offset (RGB):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 545);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Gain (RGB):";
            // 
            // gainB
            // 
            this.gainB.Location = new System.Drawing.Point(237, 543);
            this.gainB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gainB.Name = "gainB";
            this.gainB.Size = new System.Drawing.Size(56, 22);
            this.gainB.TabIndex = 41;
            this.gainB.ValueChanged += new System.EventHandler(this.gainB_ValueChanged);
            // 
            // gainG
            // 
            this.gainG.Location = new System.Drawing.Point(175, 543);
            this.gainG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gainG.Name = "gainG";
            this.gainG.Size = new System.Drawing.Size(56, 22);
            this.gainG.TabIndex = 40;
            this.gainG.ValueChanged += new System.EventHandler(this.gainG_ValueChanged);
            // 
            // gainR
            // 
            this.gainR.Location = new System.Drawing.Point(113, 544);
            this.gainR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gainR.Name = "gainR";
            this.gainR.Size = new System.Drawing.Size(56, 22);
            this.gainR.TabIndex = 39;
            this.gainR.ValueChanged += new System.EventHandler(this.gainR_ValueChanged);
            // 
            // verticalFlip
            // 
            this.verticalFlip.AutoSize = true;
            this.verticalFlip.Location = new System.Drawing.Point(12, 578);
            this.verticalFlip.Name = "verticalFlip";
            this.verticalFlip.Size = new System.Drawing.Size(103, 21);
            this.verticalFlip.TabIndex = 43;
            this.verticalFlip.Text = "Vertical Flip";
            this.verticalFlip.UseVisualStyleBackColor = true;
            this.verticalFlip.CheckedChanged += new System.EventHandler(this.verticalFlip_CheckedChanged);
            // 
            // hortizontalFlip
            // 
            this.hortizontalFlip.AutoSize = true;
            this.hortizontalFlip.Location = new System.Drawing.Point(121, 578);
            this.hortizontalFlip.Name = "hortizontalFlip";
            this.hortizontalFlip.Size = new System.Drawing.Size(120, 21);
            this.hortizontalFlip.TabIndex = 44;
            this.hortizontalFlip.Text = "Horizontal Flip";
            this.hortizontalFlip.UseVisualStyleBackColor = true;
            this.hortizontalFlip.CheckedChanged += new System.EventHandler(this.hortizontalFlip_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "SerialBitch";
            this.notifyIcon.Text = "SerialBitch";
            this.notifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 739);
            this.Controls.Add(this.hortizontalFlip);
            this.Controls.Add(this.verticalFlip);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gainB);
            this.Controls.Add(this.gainG);
            this.Controls.Add(this.gainR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.offsetB);
            this.Controls.Add(this.offsetG);
            this.Controls.Add(this.offsetR);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sync);
            this.Controls.Add(this.tracking);
            this.Controls.Add(this.verticalPos);
            this.Controls.Add(this.horizontalPos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fleshColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.colorTemp);
            this.Controls.Add(this.sharpSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sharp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saturation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contrast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.luminance);
            this.Controls.Add(this.aspectRatio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.source);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorMode);
            this.Controls.Add(this.powerControlGroupBox);
            this.Name = "MainForm";
            this.Text = "SerialBitch";
            this.powerControlGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleshColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerOn;
        private System.Windows.Forms.Button powerOff;
        private System.Windows.Forms.GroupBox powerControlGroupBox;
        private System.Windows.Forms.ComboBox colorMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox aspectRatio;
        private System.Windows.Forms.ComboBox luminance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown brightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown contrast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown saturation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown sharp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sharpSelect;
        private System.Windows.Forms.NumericUpDown colorTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown fleshColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown horizontalPos;
        private System.Windows.Forms.NumericUpDown verticalPos;
        private System.Windows.Forms.NumericUpDown tracking;
        private System.Windows.Forms.NumericUpDown sync;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown offsetR;
        private System.Windows.Forms.NumericUpDown offsetG;
        private System.Windows.Forms.NumericUpDown offsetB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown gainB;
        private System.Windows.Forms.NumericUpDown gainG;
        private System.Windows.Forms.NumericUpDown gainR;
        private System.Windows.Forms.CheckBox verticalFlip;
        private System.Windows.Forms.CheckBox hortizontalFlip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

