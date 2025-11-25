namespace OneShotPOS
{
    partial class StartTable
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
            components = new System.ComponentModel.Container();
            lblTblNumber = new Label();
            lblAvailability = new Label();
            label1 = new Label();
            txtCustomerName = new SiticoneNetCoreUI.SiticoneTextBox();
            btnStartTable = new SiticoneNetCoreUI.SiticoneButton();
            label2 = new Label();
            siticoneGaugeNumeric1 = new SiticoneNetCoreUI.SiticoneGaugeNumeric();
            numHours = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            SuspendLayout();
            // 
            // lblTblNumber
            // 
            lblTblNumber.AutoSize = true;
            lblTblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTblNumber.Location = new Point(12, 22);
            lblTblNumber.Name = "lblTblNumber";
            lblTblNumber.Size = new Size(117, 21);
            lblTblNumber.TabIndex = 0;
            lblTblNumber.Text = "lblTblNumber";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(12, 43);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(93, 20);
            lblAvailability.TabIndex = 1;
            lblAvailability.Text = "lblAvailability";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 2;
            label1.Text = "Customer Name (Optional)";
            // 
            // txtCustomerName
            // 
            txtCustomerName.AccessibleDescription = "A customizable text input field.";
            txtCustomerName.AccessibleName = "Text Box";
            txtCustomerName.AccessibleRole = AccessibleRole.Text;
            txtCustomerName.BackColor = Color.Transparent;
            txtCustomerName.BlinkCount = 3;
            txtCustomerName.BlinkShadow = false;
            txtCustomerName.BorderColor1 = Color.LightSlateGray;
            txtCustomerName.BorderColor2 = Color.LightSlateGray;
            txtCustomerName.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            txtCustomerName.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            txtCustomerName.CanShake = true;
            txtCustomerName.ContinuousBlink = false;
            txtCustomerName.CursorBlinkRate = 500;
            txtCustomerName.CursorColor = Color.Black;
            txtCustomerName.CursorHeight = 26;
            txtCustomerName.CursorOffset = 0;
            txtCustomerName.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            txtCustomerName.CursorWidth = 1;
            txtCustomerName.DisabledBackColor = Color.WhiteSmoke;
            txtCustomerName.DisabledBorderColor = Color.LightGray;
            txtCustomerName.DisabledTextColor = Color.Gray;
            txtCustomerName.EnableDropShadow = false;
            txtCustomerName.FillColor1 = Color.White;
            txtCustomerName.FillColor2 = Color.White;
            txtCustomerName.Font = new Font("Segoe UI", 9.5F);
            txtCustomerName.ForeColor = Color.DimGray;
            txtCustomerName.HoverBorderColor1 = Color.Gray;
            txtCustomerName.HoverBorderColor2 = Color.Gray;
            txtCustomerName.IsEnabled = true;
            txtCustomerName.Location = new Point(12, 108);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderColor = Color.Gray;
            txtCustomerName.PlaceholderText = "Enter Customer name...";
            txtCustomerName.ReadOnlyBorderColor1 = Color.LightGray;
            txtCustomerName.ReadOnlyBorderColor2 = Color.LightGray;
            txtCustomerName.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtCustomerName.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtCustomerName.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtCustomerName.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtCustomerName.ShadowAnimationDuration = 1;
            txtCustomerName.ShadowBlur = 10;
            txtCustomerName.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            txtCustomerName.Size = new Size(511, 40);
            txtCustomerName.SolidBorderColor = Color.LightSlateGray;
            txtCustomerName.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtCustomerName.SolidBorderHoverColor = Color.Gray;
            txtCustomerName.SolidFillColor = Color.White;
            txtCustomerName.TabIndex = 3;
            txtCustomerName.TextPadding = new Padding(16, 0, 6, 0);
            txtCustomerName.ValidationErrorMessage = "Invalid input.";
            txtCustomerName.ValidationFunction = null;
            // 
            // btnStartTable
            // 
            btnStartTable.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnStartTable.AccessibleName = "Start Table";
            btnStartTable.AutoSizeBasedOnText = false;
            btnStartTable.BackColor = Color.Transparent;
            btnStartTable.BadgeBackColor = Color.Black;
            btnStartTable.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnStartTable.BadgeValue = 0;
            btnStartTable.BadgeValueForeColor = Color.White;
            btnStartTable.BorderColor = Color.FromArgb(213, 216, 220);
            btnStartTable.BorderWidth = 1;
            btnStartTable.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnStartTable.ButtonImage = null;
            btnStartTable.ButtonTextLeftPadding = 0;
            btnStartTable.CanBeep = true;
            btnStartTable.CanGlow = false;
            btnStartTable.CanShake = true;
            btnStartTable.ContextMenuStripEx = null;
            btnStartTable.CornerRadiusBottomLeft = 6;
            btnStartTable.CornerRadiusBottomRight = 6;
            btnStartTable.CornerRadiusTopLeft = 6;
            btnStartTable.CornerRadiusTopRight = 6;
            btnStartTable.CustomCursor = Cursors.Default;
            btnStartTable.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnStartTable.EnableLongPress = false;
            btnStartTable.EnableRippleEffect = true;
            btnStartTable.EnableShadow = false;
            btnStartTable.EnableTextWrapping = false;
            btnStartTable.Font = new Font("Segoe UI Semibold", 10.2F);
            btnStartTable.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnStartTable.GlowIntensity = 100;
            btnStartTable.GlowRadius = 20F;
            btnStartTable.GradientBackground = false;
            btnStartTable.GradientColor = Color.FromArgb(0, 227, 64);
            btnStartTable.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnStartTable.HintText = null;
            btnStartTable.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnStartTable.HoverFontStyle = FontStyle.Regular;
            btnStartTable.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnStartTable.HoverTransitionDuration = 250;
            btnStartTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartTable.ImagePadding = 5;
            btnStartTable.ImageSize = new Size(16, 16);
            btnStartTable.IsRadial = false;
            btnStartTable.IsReadOnly = false;
            btnStartTable.IsToggleButton = false;
            btnStartTable.IsToggled = false;
            btnStartTable.Location = new Point(12, 217);
            btnStartTable.LongPressDurationMS = 1000;
            btnStartTable.Name = "btnStartTable";
            btnStartTable.NormalFontStyle = FontStyle.Regular;
            btnStartTable.ParticleColor = Color.FromArgb(200, 200, 200);
            btnStartTable.ParticleCount = 15;
            btnStartTable.PressAnimationScale = 0.97F;
            btnStartTable.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnStartTable.PressedFontStyle = FontStyle.Regular;
            btnStartTable.PressTransitionDuration = 150;
            btnStartTable.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnStartTable.RippleColor = Color.FromArgb(0, 0, 0);
            btnStartTable.RippleRadiusMultiplier = 0.6F;
            btnStartTable.ShadowBlur = 5;
            btnStartTable.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnStartTable.ShadowOffset = new Point(0, 2);
            btnStartTable.ShakeDuration = 500;
            btnStartTable.ShakeIntensity = 5;
            btnStartTable.Size = new Size(511, 33);
            btnStartTable.TabIndex = 4;
            btnStartTable.Text = "Start Table";
            btnStartTable.TextAlign = ContentAlignment.MiddleCenter;
            btnStartTable.TextColor = Color.FromArgb(0, 0, 0);
            btnStartTable.TooltipText = null;
            btnStartTable.UseAdvancedRendering = true;
            btnStartTable.UseParticles = false;
            btnStartTable.Click += BtnStartTable_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Duration (Hour/s)";
            // 
            // siticoneGaugeNumeric1
            // 
            siticoneGaugeNumeric1.AmbientLightIntensity = 0.5F;
            siticoneGaugeNumeric1.AnimationSpeed = 5F;
            siticoneGaugeNumeric1.BackColor = Color.Transparent;
            siticoneGaugeNumeric1.BevelDepth = 1;
            siticoneGaugeNumeric1.BlurRadius = 5;
            siticoneGaugeNumeric1.CustomGradientColors = new Color[]
    {
    Color.Blue,
    Color.Red
    };
            siticoneGaugeNumeric1.CustomGradientPositions = new float[]
    {
    0F,
    1F
    };
            siticoneGaugeNumeric1.DialColor = Color.FromArgb(50, 50, 50);
            siticoneGaugeNumeric1.EnableDynamicLighting = false;
            siticoneGaugeNumeric1.EnableGlowEffect = false;
            siticoneGaugeNumeric1.GaugeBackColor = Color.FromArgb(240, 240, 240);
            siticoneGaugeNumeric1.GaugeEndColor = Color.FromArgb(0, 210, 255);
            siticoneGaugeNumeric1.GaugeStartColor = Color.FromArgb(0, 120, 255);
            siticoneGaugeNumeric1.GaugeThickness = 5F;
            siticoneGaugeNumeric1.Glossiness = 0.7F;
            siticoneGaugeNumeric1.InnerShadowDepth = 0F;
            siticoneGaugeNumeric1.InteractiveMode = false;
            siticoneGaugeNumeric1.LabelColor = Color.DarkGray;
            siticoneGaugeNumeric1.LightSource = new Point(0, -1);
            siticoneGaugeNumeric1.Location = new Point(64, 366);
            siticoneGaugeNumeric1.MajorTickCount = 10;
            siticoneGaugeNumeric1.MajorTickLength = 15F;
            siticoneGaugeNumeric1.MaximumSize = new Size(1000, 1000);
            siticoneGaugeNumeric1.MaxValue = 100F;
            siticoneGaugeNumeric1.MetalBaseColor = Color.FromArgb(180, 180, 180);
            siticoneGaugeNumeric1.MinimumSize = new Size(50, 50);
            siticoneGaugeNumeric1.MinorTickCount = 5;
            siticoneGaugeNumeric1.MinValue = 0F;
            siticoneGaugeNumeric1.Name = "siticoneGaugeNumeric1";
            siticoneGaugeNumeric1.NeonColor = Color.Blue;
            siticoneGaugeNumeric1.NeonIntensity = 0.5F;
            siticoneGaugeNumeric1.PulseIntensity = 0.2F;
            siticoneGaugeNumeric1.ReflectionOpacity = 0F;
            siticoneGaugeNumeric1.RimHighlightColor = Color.FromArgb(240, 240, 240);
            siticoneGaugeNumeric1.RimShadowColor = Color.FromArgb(40, 40, 40);
            siticoneGaugeNumeric1.RimThickness = 10F;
            siticoneGaugeNumeric1.ScaleLabelsFontFamily = "Segoe UI";
            siticoneGaugeNumeric1.ScaleLabelsFontSize = 9F;
            siticoneGaugeNumeric1.ScaleLabelsFontStyle = FontStyle.Regular;
            siticoneGaugeNumeric1.ShadowColor = Color.Empty;
            siticoneGaugeNumeric1.ShadowOffset = 0;
            siticoneGaugeNumeric1.ShadowOpacity = 0F;
            siticoneGaugeNumeric1.ShowAnimation = true;
            siticoneGaugeNumeric1.ShowGaugeText = true;
            siticoneGaugeNumeric1.ShowMinMaxLabels = true;
            siticoneGaugeNumeric1.ShowScaleMarkers = true;
            siticoneGaugeNumeric1.ShowTooltip = false;
            siticoneGaugeNumeric1.Size = new Size(50, 50);
            siticoneGaugeNumeric1.TabIndex = 7;
            siticoneGaugeNumeric1.TextColor = Color.Black;
            siticoneGaugeNumeric1.TextSize = 30F;
            siticoneGaugeNumeric1.TextureStyle = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            siticoneGaugeNumeric1.Theme = SiticoneNetCoreUI.Helpers.ThemeManager.Gauge.GaugeThemes.DefaultLight;
            siticoneGaugeNumeric1.TickColor = Color.Gray;
            siticoneGaugeNumeric1.TooltipFormat = "{0:F1}";
            siticoneGaugeNumeric1.Use3DEffect = false;
            siticoneGaugeNumeric1.UseBlurEffect = false;
            siticoneGaugeNumeric1.UseCustomGradient = false;
            siticoneGaugeNumeric1.UseDynamicLighting = false;
            siticoneGaugeNumeric1.UseGlassEffect = false;
            siticoneGaugeNumeric1.UseGradient = true;
            siticoneGaugeNumeric1.UseInnerShadow = true;
            siticoneGaugeNumeric1.UseMetallicEffect = false;
            siticoneGaugeNumeric1.UseNeonEffect = false;
            siticoneGaugeNumeric1.UsePulseAnimation = false;
            siticoneGaugeNumeric1.UseRainbowMode = true;
            siticoneGaugeNumeric1.UseReflection = false;
            siticoneGaugeNumeric1.UseShadowEffect = false;
            siticoneGaugeNumeric1.UseTexture = false;
            siticoneGaugeNumeric1.Value = 23F;
            siticoneGaugeNumeric1.ValueFontFamily = "Segoe UI";
            siticoneGaugeNumeric1.ValueFontStyle = FontStyle.Bold;
            // 
            // numHours
            // 
            numHours.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numHours.Location = new Point(12, 169);
            numHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(120, 23);
            numHours.TabIndex = 8;
            // 
            // StartTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 262);
            Controls.Add(numHours);
            Controls.Add(siticoneGaugeNumeric1);
            Controls.Add(label2);
            Controls.Add(btnStartTable);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(lblAvailability);
            Controls.Add(lblTblNumber);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartTable";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTblNumber;
        private Label lblAvailability;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneTextBox txtCustomerName;
        private SiticoneNetCoreUI.SiticoneButton btnStartTable;
        private Label label2;
        private SiticoneNetCoreUI.SiticoneGaugeNumeric siticoneGaugeNumeric1;
        private NumericUpDown numHours;
    }
}