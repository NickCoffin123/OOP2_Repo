namespace ReadWriteSettings
{
    partial class frmSettings
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabMovement = new System.Windows.Forms.TabPage();
            this.cboInvertYAxis = new System.Windows.Forms.ComboBox();
            this.nudControler = new System.Windows.Forms.NumericUpDown();
            this.nudMouse = new System.Windows.Forms.NumericUpDown();
            this.cboAutoJump = new System.Windows.Forms.ComboBox();
            this.cboInputDevice = new System.Windows.Forms.ComboBox();
            this.lblAutoJumpDescription = new System.Windows.Forms.Label();
            this.lblInvertYAxisDescription = new System.Windows.Forms.Label();
            this.lblControllerSensitivityDescription = new System.Windows.Forms.Label();
            this.lblMouseSensitivityDescription = new System.Windows.Forms.Label();
            this.lblInvertYAxis = new System.Windows.Forms.Label();
            this.lblAutoJump = new System.Windows.Forms.Label();
            this.lblMouseSensitivity = new System.Windows.Forms.Label();
            this.lblControllerSensitivity = new System.Windows.Forms.Label();
            this.lblInputDeviceDescription = new System.Windows.Forms.Label();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.cboFancyGraphics = new System.Windows.Forms.ComboBox();
            this.cboVSync = new System.Windows.Forms.ComboBox();
            this.cboFullscreen = new System.Windows.Forms.ComboBox();
            this.cboRayTracing = new System.Windows.Forms.ComboBox();
            this.cboUpscaling = new System.Windows.Forms.ComboBox();
            this.nudRenderDistance = new System.Windows.Forms.NumericUpDown();
            this.nudFieldofView = new System.Windows.Forms.NumericUpDown();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.lblUpscalingDescription = new System.Windows.Forms.Label();
            this.lblFancyGraphicsDescription = new System.Windows.Forms.Label();
            this.lblRayTracingDescription = new System.Windows.Forms.Label();
            this.lblVSyncDescription = new System.Windows.Forms.Label();
            this.lblFieldofViewDescription = new System.Windows.Forms.Label();
            this.lblFullscreenDescription = new System.Windows.Forms.Label();
            this.lblRenderDistanceDescription = new System.Windows.Forms.Label();
            this.lblBrightnessDescription = new System.Windows.Forms.Label();
            this.lblFancyGraphics = new System.Windows.Forms.Label();
            this.lblVSync = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.lblRenderDistance = new System.Windows.Forms.Label();
            this.lblFieldofView = new System.Windows.Forms.Label();
            this.lblRayTracing = new System.Windows.Forms.Label();
            this.lblUpscaling = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.nudMusic = new System.Windows.Forms.NumericUpDown();
            this.nudSound = new System.Windows.Forms.NumericUpDown();
            this.lblSoundDescription = new System.Windows.Forms.Label();
            this.lblMusicDescription = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.tabInterface = new System.Windows.Forms.TabPage();
            this.cboCameraPerspective = new System.Windows.Forms.ComboBox();
            this.cboShowCoordinates = new System.Windows.Forms.ComboBox();
            this.nudHUDTransparency = new System.Windows.Forms.NumericUpDown();
            this.lblHudTransparencyDescription = new System.Windows.Forms.Label();
            this.lblShowCoordinatesDescription = new System.Windows.Forms.Label();
            this.lblCameraPerspectiveDescription = new System.Windows.Forms.Label();
            this.lblHUDTransparency = new System.Windows.Forms.Label();
            this.lblShowCoordinates = new System.Windows.Forms.Label();
            this.lblCameraPerspective = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveBinary = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabSettings.SuspendLayout();
            this.tabMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudControler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse)).BeginInit();
            this.tabVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            this.tabAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSound)).BeginInit();
            this.tabInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHUDTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(-1, -2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(804, 67);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Settings";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabMovement);
            this.tabSettings.Controls.Add(this.tabVideo);
            this.tabSettings.Controls.Add(this.tabAudio);
            this.tabSettings.Controls.Add(this.tabInterface);
            this.tabSettings.Location = new System.Drawing.Point(-2, 124);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(805, 285);
            this.tabSettings.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tabSettings, "Settings tabs");
            // 
            // tabMovement
            // 
            this.tabMovement.BackgroundImage = global::ReadWriteSettings.Properties.Resources.minecraftbackground;
            this.tabMovement.Controls.Add(this.cboInvertYAxis);
            this.tabMovement.Controls.Add(this.nudControler);
            this.tabMovement.Controls.Add(this.nudMouse);
            this.tabMovement.Controls.Add(this.cboAutoJump);
            this.tabMovement.Controls.Add(this.cboInputDevice);
            this.tabMovement.Controls.Add(this.lblAutoJumpDescription);
            this.tabMovement.Controls.Add(this.lblInvertYAxisDescription);
            this.tabMovement.Controls.Add(this.lblControllerSensitivityDescription);
            this.tabMovement.Controls.Add(this.lblMouseSensitivityDescription);
            this.tabMovement.Controls.Add(this.lblInvertYAxis);
            this.tabMovement.Controls.Add(this.lblAutoJump);
            this.tabMovement.Controls.Add(this.lblMouseSensitivity);
            this.tabMovement.Controls.Add(this.lblControllerSensitivity);
            this.tabMovement.Controls.Add(this.lblInputDeviceDescription);
            this.tabMovement.Controls.Add(this.lblInputDevice);
            this.tabMovement.Location = new System.Drawing.Point(4, 22);
            this.tabMovement.Name = "tabMovement";
            this.tabMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovement.Size = new System.Drawing.Size(797, 259);
            this.tabMovement.TabIndex = 0;
            this.tabMovement.Text = "Movement";
            this.tabMovement.UseVisualStyleBackColor = true;
            // 
            // cboInvertYAxis
            // 
            this.cboInvertYAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvertYAxis.FormattingEnabled = true;
            this.cboInvertYAxis.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboInvertYAxis.Location = new System.Drawing.Point(626, 223);
            this.cboInvertYAxis.Name = "cboInvertYAxis";
            this.cboInvertYAxis.Size = new System.Drawing.Size(121, 21);
            this.cboInvertYAxis.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cboInvertYAxis, "Invert Y-axis");
            // 
            // nudControler
            // 
            this.nudControler.Location = new System.Drawing.Point(625, 175);
            this.nudControler.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudControler.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudControler.Name = "nudControler";
            this.nudControler.Size = new System.Drawing.Size(120, 20);
            this.nudControler.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nudControler, "Controler sensitivity");
            this.nudControler.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudMouse
            // 
            this.nudMouse.Location = new System.Drawing.Point(626, 126);
            this.nudMouse.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudMouse.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMouse.Name = "nudMouse";
            this.nudMouse.Size = new System.Drawing.Size(120, 20);
            this.nudMouse.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nudMouse, "Mouse sensitivity");
            this.nudMouse.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cboAutoJump
            // 
            this.cboAutoJump.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutoJump.FormattingEnabled = true;
            this.cboAutoJump.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboAutoJump.Location = new System.Drawing.Point(625, 76);
            this.cboAutoJump.Name = "cboAutoJump";
            this.cboAutoJump.Size = new System.Drawing.Size(121, 21);
            this.cboAutoJump.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboAutoJump, "Auto-jump");
            // 
            // cboInputDevice
            // 
            this.cboInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInputDevice.FormattingEnabled = true;
            this.cboInputDevice.Items.AddRange(new object[] {
            "Keyboard",
            "Controller",
            "Touch"});
            this.cboInputDevice.Location = new System.Drawing.Point(625, 27);
            this.cboInputDevice.Name = "cboInputDevice";
            this.cboInputDevice.Size = new System.Drawing.Size(121, 21);
            this.cboInputDevice.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboInputDevice, "Input device");
            this.cboInputDevice.SelectedIndexChanged += new System.EventHandler(this.cboInputDevice_SelectedIndexChanged);
            // 
            // lblAutoJumpDescription
            // 
            this.lblAutoJumpDescription.AutoSize = true;
            this.lblAutoJumpDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoJumpDescription.ForeColor = System.Drawing.Color.White;
            this.lblAutoJumpDescription.Location = new System.Drawing.Point(196, 77);
            this.lblAutoJumpDescription.Name = "lblAutoJumpDescription";
            this.lblAutoJumpDescription.Size = new System.Drawing.Size(345, 20);
            this.lblAutoJumpDescription.TabIndex = 10;
            this.lblAutoJumpDescription.Text = "Automatically jumps when you approach a block";
            // 
            // lblInvertYAxisDescription
            // 
            this.lblInvertYAxisDescription.AutoSize = true;
            this.lblInvertYAxisDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertYAxisDescription.ForeColor = System.Drawing.Color.White;
            this.lblInvertYAxisDescription.Location = new System.Drawing.Point(196, 224);
            this.lblInvertYAxisDescription.Name = "lblInvertYAxisDescription";
            this.lblInvertYAxisDescription.Size = new System.Drawing.Size(286, 20);
            this.lblInvertYAxisDescription.TabIndex = 9;
            this.lblInvertYAxisDescription.Text = "Inverts the Y-Axis for mouse movement";
            // 
            // lblControllerSensitivityDescription
            // 
            this.lblControllerSensitivityDescription.AutoSize = true;
            this.lblControllerSensitivityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControllerSensitivityDescription.ForeColor = System.Drawing.Color.White;
            this.lblControllerSensitivityDescription.Location = new System.Drawing.Point(196, 175);
            this.lblControllerSensitivityDescription.Name = "lblControllerSensitivityDescription";
            this.lblControllerSensitivityDescription.Size = new System.Drawing.Size(345, 20);
            this.lblControllerSensitivityDescription.TabIndex = 8;
            this.lblControllerSensitivityDescription.Text = "Adjusts the sensitivity of the stick on a controller";
            // 
            // lblMouseSensitivityDescription
            // 
            this.lblMouseSensitivityDescription.AutoSize = true;
            this.lblMouseSensitivityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseSensitivityDescription.ForeColor = System.Drawing.Color.White;
            this.lblMouseSensitivityDescription.Location = new System.Drawing.Point(196, 126);
            this.lblMouseSensitivityDescription.Name = "lblMouseSensitivityDescription";
            this.lblMouseSensitivityDescription.Size = new System.Drawing.Size(254, 20);
            this.lblMouseSensitivityDescription.TabIndex = 7;
            this.lblMouseSensitivityDescription.Text = "Adjusts the sensitivty of the mouse";
            // 
            // lblInvertYAxis
            // 
            this.lblInvertYAxis.AutoSize = true;
            this.lblInvertYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertYAxis.ForeColor = System.Drawing.Color.White;
            this.lblInvertYAxis.Location = new System.Drawing.Point(9, 224);
            this.lblInvertYAxis.Name = "lblInvertYAxis";
            this.lblInvertYAxis.Size = new System.Drawing.Size(98, 20);
            this.lblInvertYAxis.TabIndex = 6;
            this.lblInvertYAxis.Text = "Invert Y-Axis";
            // 
            // lblAutoJump
            // 
            this.lblAutoJump.AutoSize = true;
            this.lblAutoJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoJump.ForeColor = System.Drawing.Color.White;
            this.lblAutoJump.Location = new System.Drawing.Point(9, 77);
            this.lblAutoJump.Name = "lblAutoJump";
            this.lblAutoJump.Size = new System.Drawing.Size(87, 20);
            this.lblAutoJump.TabIndex = 5;
            this.lblAutoJump.Text = "Auto-Jump";
            // 
            // lblMouseSensitivity
            // 
            this.lblMouseSensitivity.AutoSize = true;
            this.lblMouseSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseSensitivity.ForeColor = System.Drawing.Color.White;
            this.lblMouseSensitivity.Location = new System.Drawing.Point(9, 126);
            this.lblMouseSensitivity.Name = "lblMouseSensitivity";
            this.lblMouseSensitivity.Size = new System.Drawing.Size(131, 20);
            this.lblMouseSensitivity.TabIndex = 4;
            this.lblMouseSensitivity.Text = "Mouse Sensitivity";
            // 
            // lblControllerSensitivity
            // 
            this.lblControllerSensitivity.AutoSize = true;
            this.lblControllerSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControllerSensitivity.ForeColor = System.Drawing.Color.White;
            this.lblControllerSensitivity.Location = new System.Drawing.Point(9, 175);
            this.lblControllerSensitivity.Name = "lblControllerSensitivity";
            this.lblControllerSensitivity.Size = new System.Drawing.Size(151, 20);
            this.lblControllerSensitivity.TabIndex = 3;
            this.lblControllerSensitivity.Text = "Controller Sensitivity";
            // 
            // lblInputDeviceDescription
            // 
            this.lblInputDeviceDescription.AutoSize = true;
            this.lblInputDeviceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDeviceDescription.ForeColor = System.Drawing.Color.White;
            this.lblInputDeviceDescription.Location = new System.Drawing.Point(196, 28);
            this.lblInputDeviceDescription.Name = "lblInputDeviceDescription";
            this.lblInputDeviceDescription.Size = new System.Drawing.Size(372, 20);
            this.lblInputDeviceDescription.TabIndex = 1;
            this.lblInputDeviceDescription.Text = "Allows the user to choose their primary input device ";
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDevice.ForeColor = System.Drawing.Color.White;
            this.lblInputDevice.Location = new System.Drawing.Point(9, 28);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(98, 20);
            this.lblInputDevice.TabIndex = 0;
            this.lblInputDevice.Text = "Input Device";
            // 
            // tabVideo
            // 
            this.tabVideo.BackgroundImage = global::ReadWriteSettings.Properties.Resources.minecraftbackground;
            this.tabVideo.Controls.Add(this.cboFancyGraphics);
            this.tabVideo.Controls.Add(this.cboVSync);
            this.tabVideo.Controls.Add(this.cboFullscreen);
            this.tabVideo.Controls.Add(this.cboRayTracing);
            this.tabVideo.Controls.Add(this.cboUpscaling);
            this.tabVideo.Controls.Add(this.nudRenderDistance);
            this.tabVideo.Controls.Add(this.nudFieldofView);
            this.tabVideo.Controls.Add(this.nudBrightness);
            this.tabVideo.Controls.Add(this.lblUpscalingDescription);
            this.tabVideo.Controls.Add(this.lblFancyGraphicsDescription);
            this.tabVideo.Controls.Add(this.lblRayTracingDescription);
            this.tabVideo.Controls.Add(this.lblVSyncDescription);
            this.tabVideo.Controls.Add(this.lblFieldofViewDescription);
            this.tabVideo.Controls.Add(this.lblFullscreenDescription);
            this.tabVideo.Controls.Add(this.lblRenderDistanceDescription);
            this.tabVideo.Controls.Add(this.lblBrightnessDescription);
            this.tabVideo.Controls.Add(this.lblFancyGraphics);
            this.tabVideo.Controls.Add(this.lblVSync);
            this.tabVideo.Controls.Add(this.lblFullscreen);
            this.tabVideo.Controls.Add(this.lblRenderDistance);
            this.tabVideo.Controls.Add(this.lblFieldofView);
            this.tabVideo.Controls.Add(this.lblRayTracing);
            this.tabVideo.Controls.Add(this.lblUpscaling);
            this.tabVideo.Controls.Add(this.lblBrightness);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(797, 259);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // cboFancyGraphics
            // 
            this.cboFancyGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFancyGraphics.FormattingEnabled = true;
            this.cboFancyGraphics.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboFancyGraphics.Location = new System.Drawing.Point(657, 45);
            this.cboFancyGraphics.Name = "cboFancyGraphics";
            this.cboFancyGraphics.Size = new System.Drawing.Size(121, 21);
            this.cboFancyGraphics.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboFancyGraphics, "Fancy graphics");
            // 
            // cboVSync
            // 
            this.cboVSync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVSync.FormattingEnabled = true;
            this.cboVSync.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboVSync.Location = new System.Drawing.Point(657, 75);
            this.cboVSync.Name = "cboVSync";
            this.cboVSync.Size = new System.Drawing.Size(121, 21);
            this.cboVSync.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboVSync, "V-sync");
            // 
            // cboFullscreen
            // 
            this.cboFullscreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFullscreen.FormattingEnabled = true;
            this.cboFullscreen.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboFullscreen.Location = new System.Drawing.Point(657, 105);
            this.cboFullscreen.Name = "cboFullscreen";
            this.cboFullscreen.Size = new System.Drawing.Size(121, 21);
            this.cboFullscreen.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cboFullscreen, "Fullscreen");
            // 
            // cboRayTracing
            // 
            this.cboRayTracing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRayTracing.FormattingEnabled = true;
            this.cboRayTracing.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboRayTracing.Location = new System.Drawing.Point(657, 193);
            this.cboRayTracing.Name = "cboRayTracing";
            this.cboRayTracing.Size = new System.Drawing.Size(121, 21);
            this.cboRayTracing.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboRayTracing, "Ray tracing");
            this.cboRayTracing.SelectedIndexChanged += new System.EventHandler(this.cboRayTracing_SelectedIndexChanged);
            // 
            // cboUpscaling
            // 
            this.cboUpscaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpscaling.FormattingEnabled = true;
            this.cboUpscaling.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboUpscaling.Location = new System.Drawing.Point(657, 223);
            this.cboUpscaling.Name = "cboUpscaling";
            this.cboUpscaling.Size = new System.Drawing.Size(121, 21);
            this.cboUpscaling.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cboUpscaling, "Upscaling");
            // 
            // nudRenderDistance
            // 
            this.nudRenderDistance.Location = new System.Drawing.Point(658, 135);
            this.nudRenderDistance.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudRenderDistance.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenderDistance.Name = "nudRenderDistance";
            this.nudRenderDistance.Size = new System.Drawing.Size(120, 20);
            this.nudRenderDistance.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nudRenderDistance, "Render distance");
            this.nudRenderDistance.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nudFieldofView
            // 
            this.nudFieldofView.Location = new System.Drawing.Point(658, 164);
            this.nudFieldofView.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudFieldofView.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFieldofView.Name = "nudFieldofView";
            this.nudFieldofView.Size = new System.Drawing.Size(120, 20);
            this.nudFieldofView.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nudFieldofView, "Field of view");
            this.nudFieldofView.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // nudBrightness
            // 
            this.nudBrightness.Location = new System.Drawing.Point(658, 16);
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(120, 20);
            this.nudBrightness.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nudBrightness, "Brightness");
            this.nudBrightness.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblUpscalingDescription
            // 
            this.lblUpscalingDescription.AutoSize = true;
            this.lblUpscalingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpscalingDescription.ForeColor = System.Drawing.Color.White;
            this.lblUpscalingDescription.Location = new System.Drawing.Point(245, 226);
            this.lblUpscalingDescription.Name = "lblUpscalingDescription";
            this.lblUpscalingDescription.Size = new System.Drawing.Size(282, 16);
            this.lblUpscalingDescription.TabIndex = 27;
            this.lblUpscalingDescription.Text = "Toggles automated upscaling of the resolution";
            // 
            // lblFancyGraphicsDescription
            // 
            this.lblFancyGraphicsDescription.AutoSize = true;
            this.lblFancyGraphicsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancyGraphicsDescription.ForeColor = System.Drawing.Color.White;
            this.lblFancyGraphicsDescription.Location = new System.Drawing.Point(245, 46);
            this.lblFancyGraphicsDescription.Name = "lblFancyGraphicsDescription";
            this.lblFancyGraphicsDescription.Size = new System.Drawing.Size(227, 16);
            this.lblFancyGraphicsDescription.TabIndex = 26;
            this.lblFancyGraphicsDescription.Text = "Enables advanced graphics features";
            // 
            // lblRayTracingDescription
            // 
            this.lblRayTracingDescription.AutoSize = true;
            this.lblRayTracingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRayTracingDescription.ForeColor = System.Drawing.Color.White;
            this.lblRayTracingDescription.Location = new System.Drawing.Point(245, 196);
            this.lblRayTracingDescription.Name = "lblRayTracingDescription";
            this.lblRayTracingDescription.Size = new System.Drawing.Size(195, 16);
            this.lblRayTracingDescription.TabIndex = 25;
            this.lblRayTracingDescription.Text = "Toggles ray tracing capabilities";
            // 
            // lblVSyncDescription
            // 
            this.lblVSyncDescription.AutoSize = true;
            this.lblVSyncDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSyncDescription.ForeColor = System.Drawing.Color.White;
            this.lblVSyncDescription.Location = new System.Drawing.Point(245, 76);
            this.lblVSyncDescription.Name = "lblVSyncDescription";
            this.lblVSyncDescription.Size = new System.Drawing.Size(344, 16);
            this.lblVSyncDescription.TabIndex = 24;
            this.lblVSyncDescription.Text = "Synchornizes the frame rate with the monitors refresh rate ";
            // 
            // lblFieldofViewDescription
            // 
            this.lblFieldofViewDescription.AutoSize = true;
            this.lblFieldofViewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldofViewDescription.ForeColor = System.Drawing.Color.White;
            this.lblFieldofViewDescription.Location = new System.Drawing.Point(245, 166);
            this.lblFieldofViewDescription.Name = "lblFieldofViewDescription";
            this.lblFieldofViewDescription.Size = new System.Drawing.Size(195, 16);
            this.lblFieldofViewDescription.TabIndex = 23;
            this.lblFieldofViewDescription.Text = "Adjusts the player\'s field of view";
            // 
            // lblFullscreenDescription
            // 
            this.lblFullscreenDescription.AutoSize = true;
            this.lblFullscreenDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullscreenDescription.ForeColor = System.Drawing.Color.White;
            this.lblFullscreenDescription.Location = new System.Drawing.Point(245, 106);
            this.lblFullscreenDescription.Name = "lblFullscreenDescription";
            this.lblFullscreenDescription.Size = new System.Drawing.Size(249, 16);
            this.lblFullscreenDescription.TabIndex = 22;
            this.lblFullscreenDescription.Text = "Toggles Full-screen vs Windowed Mode";
            // 
            // lblRenderDistanceDescription
            // 
            this.lblRenderDistanceDescription.AutoSize = true;
            this.lblRenderDistanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderDistanceDescription.ForeColor = System.Drawing.Color.White;
            this.lblRenderDistanceDescription.Location = new System.Drawing.Point(245, 136);
            this.lblRenderDistanceDescription.Name = "lblRenderDistanceDescription";
            this.lblRenderDistanceDescription.Size = new System.Drawing.Size(227, 16);
            this.lblRenderDistanceDescription.TabIndex = 21;
            this.lblRenderDistanceDescription.Text = "Sets how far you can see in the game";
            // 
            // lblBrightnessDescription
            // 
            this.lblBrightnessDescription.AutoSize = true;
            this.lblBrightnessDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessDescription.ForeColor = System.Drawing.Color.White;
            this.lblBrightnessDescription.Location = new System.Drawing.Point(245, 16);
            this.lblBrightnessDescription.Name = "lblBrightnessDescription";
            this.lblBrightnessDescription.Size = new System.Drawing.Size(203, 16);
            this.lblBrightnessDescription.TabIndex = 20;
            this.lblBrightnessDescription.Text = "Adjust the brightness of the game";
            // 
            // lblFancyGraphics
            // 
            this.lblFancyGraphics.AutoSize = true;
            this.lblFancyGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancyGraphics.ForeColor = System.Drawing.Color.White;
            this.lblFancyGraphics.Location = new System.Drawing.Point(81, 46);
            this.lblFancyGraphics.Name = "lblFancyGraphics";
            this.lblFancyGraphics.Size = new System.Drawing.Size(101, 16);
            this.lblFancyGraphics.TabIndex = 19;
            this.lblFancyGraphics.Text = "Fancy Graphics";
            // 
            // lblVSync
            // 
            this.lblVSync.AutoSize = true;
            this.lblVSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSync.ForeColor = System.Drawing.Color.White;
            this.lblVSync.Location = new System.Drawing.Point(81, 76);
            this.lblVSync.Name = "lblVSync";
            this.lblVSync.Size = new System.Drawing.Size(50, 16);
            this.lblVSync.TabIndex = 18;
            this.lblVSync.Text = "V-Sync";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullscreen.ForeColor = System.Drawing.Color.White;
            this.lblFullscreen.Location = new System.Drawing.Point(81, 106);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(69, 16);
            this.lblFullscreen.TabIndex = 17;
            this.lblFullscreen.Text = "Fullscreen";
            // 
            // lblRenderDistance
            // 
            this.lblRenderDistance.AutoSize = true;
            this.lblRenderDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderDistance.ForeColor = System.Drawing.Color.White;
            this.lblRenderDistance.Location = new System.Drawing.Point(81, 136);
            this.lblRenderDistance.Name = "lblRenderDistance";
            this.lblRenderDistance.Size = new System.Drawing.Size(108, 16);
            this.lblRenderDistance.TabIndex = 16;
            this.lblRenderDistance.Text = "Render Distance";
            // 
            // lblFieldofView
            // 
            this.lblFieldofView.AutoSize = true;
            this.lblFieldofView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldofView.ForeColor = System.Drawing.Color.White;
            this.lblFieldofView.Location = new System.Drawing.Point(81, 166);
            this.lblFieldofView.Name = "lblFieldofView";
            this.lblFieldofView.Size = new System.Drawing.Size(83, 16);
            this.lblFieldofView.TabIndex = 15;
            this.lblFieldofView.Text = "Field of View";
            // 
            // lblRayTracing
            // 
            this.lblRayTracing.AutoSize = true;
            this.lblRayTracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRayTracing.ForeColor = System.Drawing.Color.White;
            this.lblRayTracing.Location = new System.Drawing.Point(81, 196);
            this.lblRayTracing.Name = "lblRayTracing";
            this.lblRayTracing.Size = new System.Drawing.Size(81, 16);
            this.lblRayTracing.TabIndex = 14;
            this.lblRayTracing.Text = "Ray Tracing";
            // 
            // lblUpscaling
            // 
            this.lblUpscaling.AutoSize = true;
            this.lblUpscaling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpscaling.ForeColor = System.Drawing.Color.White;
            this.lblUpscaling.Location = new System.Drawing.Point(81, 226);
            this.lblUpscaling.Name = "lblUpscaling";
            this.lblUpscaling.Size = new System.Drawing.Size(68, 16);
            this.lblUpscaling.TabIndex = 13;
            this.lblUpscaling.Text = "Upscaling";
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.ForeColor = System.Drawing.Color.White;
            this.lblBrightness.Location = new System.Drawing.Point(81, 16);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(70, 16);
            this.lblBrightness.TabIndex = 11;
            this.lblBrightness.Text = "Brightness";
            // 
            // tabAudio
            // 
            this.tabAudio.BackgroundImage = global::ReadWriteSettings.Properties.Resources.minecraftbackground;
            this.tabAudio.Controls.Add(this.nudMusic);
            this.tabAudio.Controls.Add(this.nudSound);
            this.tabAudio.Controls.Add(this.lblSoundDescription);
            this.tabAudio.Controls.Add(this.lblMusicDescription);
            this.tabAudio.Controls.Add(this.lblSound);
            this.tabAudio.Controls.Add(this.lblMusic);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(797, 259);
            this.tabAudio.TabIndex = 2;
            this.tabAudio.Text = "Audio";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // nudMusic
            // 
            this.nudMusic.Location = new System.Drawing.Point(615, 88);
            this.nudMusic.Name = "nudMusic";
            this.nudMusic.Size = new System.Drawing.Size(120, 20);
            this.nudMusic.TabIndex = 16;
            this.toolTip1.SetToolTip(this.nudMusic, "Music");
            this.nudMusic.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudSound
            // 
            this.nudSound.Location = new System.Drawing.Point(615, 151);
            this.nudSound.Name = "nudSound";
            this.nudSound.Size = new System.Drawing.Size(120, 20);
            this.nudSound.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nudSound, "Sound");
            this.nudSound.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblSoundDescription
            // 
            this.lblSoundDescription.AutoSize = true;
            this.lblSoundDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundDescription.ForeColor = System.Drawing.Color.White;
            this.lblSoundDescription.Location = new System.Drawing.Point(282, 151);
            this.lblSoundDescription.Name = "lblSoundDescription";
            this.lblSoundDescription.Size = new System.Drawing.Size(258, 20);
            this.lblSoundDescription.TabIndex = 15;
            this.lblSoundDescription.Text = "Sets the volume of in-game sounds";
            // 
            // lblMusicDescription
            // 
            this.lblMusicDescription.AutoSize = true;
            this.lblMusicDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicDescription.ForeColor = System.Drawing.Color.White;
            this.lblMusicDescription.Location = new System.Drawing.Point(282, 88);
            this.lblMusicDescription.Name = "lblMusicDescription";
            this.lblMusicDescription.Size = new System.Drawing.Size(213, 20);
            this.lblMusicDescription.TabIndex = 14;
            this.lblMusicDescription.Text = "Sets the volume of the music";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.ForeColor = System.Drawing.Color.White;
            this.lblSound.Location = new System.Drawing.Point(146, 151);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(56, 20);
            this.lblSound.TabIndex = 13;
            this.lblSound.Text = "Sound";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.Color.White;
            this.lblMusic.Location = new System.Drawing.Point(146, 88);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(50, 20);
            this.lblMusic.TabIndex = 12;
            this.lblMusic.Text = "Music";
            // 
            // tabInterface
            // 
            this.tabInterface.BackgroundImage = global::ReadWriteSettings.Properties.Resources.minecraftbackground;
            this.tabInterface.Controls.Add(this.cboCameraPerspective);
            this.tabInterface.Controls.Add(this.cboShowCoordinates);
            this.tabInterface.Controls.Add(this.nudHUDTransparency);
            this.tabInterface.Controls.Add(this.lblHudTransparencyDescription);
            this.tabInterface.Controls.Add(this.lblShowCoordinatesDescription);
            this.tabInterface.Controls.Add(this.lblCameraPerspectiveDescription);
            this.tabInterface.Controls.Add(this.lblHUDTransparency);
            this.tabInterface.Controls.Add(this.lblShowCoordinates);
            this.tabInterface.Controls.Add(this.lblCameraPerspective);
            this.tabInterface.Location = new System.Drawing.Point(4, 22);
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterface.Size = new System.Drawing.Size(797, 259);
            this.tabInterface.TabIndex = 3;
            this.tabInterface.Text = "Interface";
            this.tabInterface.UseVisualStyleBackColor = true;
            // 
            // cboCameraPerspective
            // 
            this.cboCameraPerspective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameraPerspective.FormattingEnabled = true;
            this.cboCameraPerspective.Items.AddRange(new object[] {
            "First-person",
            "Third-person front,",
            "Third-person back"});
            this.cboCameraPerspective.Location = new System.Drawing.Point(656, 197);
            this.cboCameraPerspective.Name = "cboCameraPerspective";
            this.cboCameraPerspective.Size = new System.Drawing.Size(121, 21);
            this.cboCameraPerspective.TabIndex = 20;
            this.toolTip1.SetToolTip(this.cboCameraPerspective, "Game perspective");
            // 
            // cboShowCoordinates
            // 
            this.cboShowCoordinates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShowCoordinates.FormattingEnabled = true;
            this.cboShowCoordinates.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboShowCoordinates.Location = new System.Drawing.Point(656, 122);
            this.cboShowCoordinates.Name = "cboShowCoordinates";
            this.cboShowCoordinates.Size = new System.Drawing.Size(121, 21);
            this.cboShowCoordinates.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cboShowCoordinates, "Show coordinates");
            // 
            // nudHUDTransparency
            // 
            this.nudHUDTransparency.Location = new System.Drawing.Point(657, 54);
            this.nudHUDTransparency.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudHUDTransparency.Name = "nudHUDTransparency";
            this.nudHUDTransparency.Size = new System.Drawing.Size(120, 20);
            this.nudHUDTransparency.TabIndex = 18;
            this.toolTip1.SetToolTip(this.nudHUDTransparency, "HUDD transparency");
            this.nudHUDTransparency.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblHudTransparencyDescription
            // 
            this.lblHudTransparencyDescription.AutoSize = true;
            this.lblHudTransparencyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHudTransparencyDescription.ForeColor = System.Drawing.Color.White;
            this.lblHudTransparencyDescription.Location = new System.Drawing.Point(217, 51);
            this.lblHudTransparencyDescription.Name = "lblHudTransparencyDescription";
            this.lblHudTransparencyDescription.Size = new System.Drawing.Size(331, 20);
            this.lblHudTransparencyDescription.TabIndex = 18;
            this.lblHudTransparencyDescription.Text = "Set the transparency value for the hud display";
            // 
            // lblShowCoordinatesDescription
            // 
            this.lblShowCoordinatesDescription.AutoSize = true;
            this.lblShowCoordinatesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoordinatesDescription.ForeColor = System.Drawing.Color.White;
            this.lblShowCoordinatesDescription.Location = new System.Drawing.Point(217, 123);
            this.lblShowCoordinatesDescription.Name = "lblShowCoordinatesDescription";
            this.lblShowCoordinatesDescription.Size = new System.Drawing.Size(396, 20);
            this.lblShowCoordinatesDescription.TabIndex = 17;
            this.lblShowCoordinatesDescription.Text = "Displays the current location coordinates on the screen";
            // 
            // lblCameraPerspectiveDescription
            // 
            this.lblCameraPerspectiveDescription.AutoSize = true;
            this.lblCameraPerspectiveDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraPerspectiveDescription.ForeColor = System.Drawing.Color.White;
            this.lblCameraPerspectiveDescription.Location = new System.Drawing.Point(217, 195);
            this.lblCameraPerspectiveDescription.Name = "lblCameraPerspectiveDescription";
            this.lblCameraPerspectiveDescription.Size = new System.Drawing.Size(381, 20);
            this.lblCameraPerspectiveDescription.TabIndex = 16;
            this.lblCameraPerspectiveDescription.Text = "Sets the perspective the camera is given in the game";
            // 
            // lblHUDTransparency
            // 
            this.lblHUDTransparency.AutoSize = true;
            this.lblHUDTransparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHUDTransparency.ForeColor = System.Drawing.Color.White;
            this.lblHUDTransparency.Location = new System.Drawing.Point(37, 51);
            this.lblHUDTransparency.Name = "lblHUDTransparency";
            this.lblHUDTransparency.Size = new System.Drawing.Size(145, 20);
            this.lblHUDTransparency.TabIndex = 15;
            this.lblHUDTransparency.Text = "HUD Transparency";
            // 
            // lblShowCoordinates
            // 
            this.lblShowCoordinates.AutoSize = true;
            this.lblShowCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoordinates.ForeColor = System.Drawing.Color.White;
            this.lblShowCoordinates.Location = new System.Drawing.Point(37, 123);
            this.lblShowCoordinates.Name = "lblShowCoordinates";
            this.lblShowCoordinates.Size = new System.Drawing.Size(139, 20);
            this.lblShowCoordinates.TabIndex = 14;
            this.lblShowCoordinates.Text = "Show Coordinates";
            // 
            // lblCameraPerspective
            // 
            this.lblCameraPerspective.AutoSize = true;
            this.lblCameraPerspective.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraPerspective.ForeColor = System.Drawing.Color.White;
            this.lblCameraPerspective.Location = new System.Drawing.Point(37, 195);
            this.lblCameraPerspective.Name = "lblCameraPerspective";
            this.lblCameraPerspective.Size = new System.Drawing.Size(151, 20);
            this.lblCameraPerspective.TabIndex = 13;
            this.lblCameraPerspective.Text = "Camera Perspective";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.toolTip1.SetToolTip(this.btnLoad, "Load file");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(583, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveBinary
            // 
            this.btnSaveBinary.Location = new System.Drawing.Point(684, 80);
            this.btnSaveBinary.Name = "btnSaveBinary";
            this.btnSaveBinary.Size = new System.Drawing.Size(95, 29);
            this.btnSaveBinary.TabIndex = 22;
            this.btnSaveBinary.Text = "Save Binary";
            this.toolTip1.SetToolTip(this.btnSaveBinary, "Save binary");
            this.btnSaveBinary.UseVisualStyleBackColor = true;
            this.btnSaveBinary.Click += new System.EventHandler(this.btnSaveBinary_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(125, 89);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(436, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReadWriteSettings.Properties.Resources.minecraftbackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveBinary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tabMovement.ResumeLayout(false);
            this.tabMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudControler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse)).EndInit();
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            this.tabAudio.ResumeLayout(false);
            this.tabAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSound)).EndInit();
            this.tabInterface.ResumeLayout(false);
            this.tabInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHUDTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabMovement;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.TabPage tabInterface;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveBinary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblAutoJumpDescription;
        private System.Windows.Forms.Label lblInvertYAxisDescription;
        private System.Windows.Forms.Label lblControllerSensitivityDescription;
        private System.Windows.Forms.Label lblMouseSensitivityDescription;
        private System.Windows.Forms.Label lblInvertYAxis;
        private System.Windows.Forms.Label lblAutoJump;
        private System.Windows.Forms.Label lblMouseSensitivity;
        private System.Windows.Forms.Label lblControllerSensitivity;
        private System.Windows.Forms.Label lblInputDeviceDescription;
        private System.Windows.Forms.Label lblInputDevice;
        private System.Windows.Forms.ComboBox cboInputDevice;
        private System.Windows.Forms.ComboBox cboAutoJump;
        private System.Windows.Forms.NumericUpDown nudControler;
        private System.Windows.Forms.NumericUpDown nudMouse;
        private System.Windows.Forms.ComboBox cboInvertYAxis;
        private System.Windows.Forms.Label lblFancyGraphics;
        private System.Windows.Forms.Label lblVSync;
        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.Label lblRenderDistance;
        private System.Windows.Forms.Label lblFieldofView;
        private System.Windows.Forms.Label lblRayTracing;
        private System.Windows.Forms.Label lblUpscaling;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblUpscalingDescription;
        private System.Windows.Forms.Label lblFancyGraphicsDescription;
        private System.Windows.Forms.Label lblRayTracingDescription;
        private System.Windows.Forms.Label lblVSyncDescription;
        private System.Windows.Forms.Label lblFieldofViewDescription;
        private System.Windows.Forms.Label lblFullscreenDescription;
        private System.Windows.Forms.Label lblRenderDistanceDescription;
        private System.Windows.Forms.Label lblBrightnessDescription;
        private System.Windows.Forms.NumericUpDown nudRenderDistance;
        private System.Windows.Forms.NumericUpDown nudFieldofView;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.ComboBox cboFancyGraphics;
        private System.Windows.Forms.ComboBox cboVSync;
        private System.Windows.Forms.ComboBox cboFullscreen;
        private System.Windows.Forms.ComboBox cboRayTracing;
        private System.Windows.Forms.ComboBox cboUpscaling;
        private System.Windows.Forms.Label lblSoundDescription;
        private System.Windows.Forms.Label lblMusicDescription;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.NumericUpDown nudMusic;
        private System.Windows.Forms.NumericUpDown nudSound;
        private System.Windows.Forms.Label lblHUDTransparency;
        private System.Windows.Forms.Label lblShowCoordinates;
        private System.Windows.Forms.Label lblCameraPerspective;
        private System.Windows.Forms.Label lblHudTransparencyDescription;
        private System.Windows.Forms.Label lblShowCoordinatesDescription;
        private System.Windows.Forms.Label lblCameraPerspectiveDescription;
        private System.Windows.Forms.ComboBox cboCameraPerspective;
        private System.Windows.Forms.ComboBox cboShowCoordinates;
        private System.Windows.Forms.NumericUpDown nudHUDTransparency;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}