namespace OneShotPOS
{
    partial class ReceptionistDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistDashboard));
            panelSidebar = new SiticoneNetCoreUI.SiticonePinnablePanel();
            label3 = new Label();
            label2 = new Label();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            label1 = new Label();
            siticoneLabel1 = new SiticoneNetCoreUI.SiticoneLabel();
            btnLogout = new SiticoneNetCoreUI.SiticoneButton();
            panelMain = new SiticoneNetCoreUI.SiticonePinnablePanel();
            panelSidebar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BorderColor = Color.DarkGray;
            panelSidebar.BorderRadius = 0;
            panelSidebar.Controls.Add(label3);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(siticonePanel1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.GradientBorderEndColor = Color.Gray;
            panelSidebar.GradientBorderStartColor = Color.DarkGray;
            panelSidebar.HoverBorderColor = Color.Gray;
            panelSidebar.HoverGradientBorderEndColor = Color.DarkGray;
            panelSidebar.HoverGradientBorderStartColor = Color.Gray;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(5);
            panelSidebar.PatternOpacity = 0.7F;
            panelSidebar.PinIconBorderColor = Color.Red;
            panelSidebar.PinIconColor = Color.DarkGray;
            panelSidebar.PinIconPinned = (Image)resources.GetObject("panelSidebar.PinIconPinned");
            panelSidebar.PinIconUnpinned = (Image)resources.GetObject("panelSidebar.PinIconUnpinned");
            panelSidebar.PinnedBorderColor = Color.DodgerBlue;
            panelSidebar.PinnedGradientBorderEndColor = Color.RoyalBlue;
            panelSidebar.PinnedGradientBorderStartColor = Color.DodgerBlue;
            panelSidebar.PinnedIconColor = Color.DodgerBlue;
            panelSidebar.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            panelSidebar.Size = new Size(204, 1041);
            panelSidebar.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 180);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 8;
            label3.Text = "lblUserRole";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 159);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 7;
            label2.Text = "lblLoggedInUser";
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(label1);
            siticonePanel1.Controls.Add(siticoneLabel1);
            siticonePanel1.CornerRadiusBottomLeft = 0F;
            siticonePanel1.CornerRadiusBottomRight = 0F;
            siticonePanel1.CornerRadiusTopLeft = 0F;
            siticonePanel1.CornerRadiusTopRight = 0F;
            siticonePanel1.Dock = DockStyle.Top;
            siticonePanel1.EnableAcrylicEffect = false;
            siticonePanel1.EnableMicaEffect = false;
            siticonePanel1.EnableRippleEffect = false;
            siticonePanel1.FillColor = Color.White;
            siticonePanel1.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel1.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel1.Location = new Point(5, 5);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(194, 100);
            siticonePanel1.TabIndex = 3;
            siticonePanel1.TabStop = true;
            siticonePanel1.TrackSystemTheme = false;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.BackColor = Color.Transparent;
            siticoneLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.Location = new Point(78, 20);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(82, 23);
            siticoneLabel1.TabIndex = 0;
            siticoneLabel1.Text = "One Shot";
            // 
            // btnLogout
            // 
            btnLogout.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnLogout.AccessibleName = "Log Out";
            btnLogout.AutoSizeBasedOnText = false;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BadgeBackColor = Color.Black;
            btnLogout.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLogout.BadgeValue = 0;
            btnLogout.BadgeValueForeColor = Color.White;
            btnLogout.BorderColor = Color.FromArgb(60, 60, 60);
            btnLogout.BorderWidth = 2;
            btnLogout.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnLogout.ButtonImage = null;
            btnLogout.ButtonTextLeftPadding = 0;
            btnLogout.CanBeep = true;
            btnLogout.CanGlow = false;
            btnLogout.CanShake = true;
            btnLogout.ContextMenuStripEx = null;
            btnLogout.CornerRadiusBottomLeft = 6;
            btnLogout.CornerRadiusBottomRight = 6;
            btnLogout.CornerRadiusTopLeft = 6;
            btnLogout.CornerRadiusTopRight = 6;
            btnLogout.CustomCursor = Cursors.Default;
            btnLogout.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.EnableLongPress = false;
            btnLogout.EnableRippleEffect = true;
            btnLogout.EnableShadow = true;
            btnLogout.EnableTextWrapping = false;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F);
            btnLogout.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnLogout.GlowIntensity = 100;
            btnLogout.GlowRadius = 20F;
            btnLogout.GradientBackground = false;
            btnLogout.GradientColor = Color.FromArgb(0, 227, 64);
            btnLogout.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnLogout.HintText = null;
            btnLogout.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnLogout.HoverFontStyle = FontStyle.Regular;
            btnLogout.HoverTextColor = Color.White;
            btnLogout.HoverTransitionDuration = 250;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.ImagePadding = 5;
            btnLogout.ImageSize = new Size(16, 16);
            btnLogout.IsRadial = false;
            btnLogout.IsReadOnly = false;
            btnLogout.IsToggleButton = false;
            btnLogout.IsToggled = false;
            btnLogout.Location = new Point(5, 993);
            btnLogout.LongPressDurationMS = 1000;
            btnLogout.Name = "btnLogout";
            btnLogout.NormalFontStyle = FontStyle.Regular;
            btnLogout.ParticleColor = Color.FromArgb(200, 200, 200);
            btnLogout.ParticleCount = 15;
            btnLogout.PressAnimationScale = 0.97F;
            btnLogout.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnLogout.PressedFontStyle = FontStyle.Regular;
            btnLogout.PressTransitionDuration = 150;
            btnLogout.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnLogout.RippleColor = Color.FromArgb(100, 100, 100);
            btnLogout.RippleOpacity = 0.3F;
            btnLogout.RippleRadiusMultiplier = 0.6F;
            btnLogout.ShadowBlur = 6;
            btnLogout.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnLogout.ShadowOffset = new Point(0, 2);
            btnLogout.ShakeDuration = 500;
            btnLogout.ShakeIntensity = 5;
            btnLogout.Size = new Size(194, 43);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleCenter;
            btnLogout.TextColor = Color.White;
            btnLogout.TooltipText = null;
            btnLogout.UseAdvancedRendering = true;
            btnLogout.UseParticles = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Transparent;
            panelMain.BorderColor = Color.DarkGray;
            panelMain.BorderRadius = 0;
            panelMain.Dock = DockStyle.Fill;
            panelMain.GradientBorderEndColor = Color.Gray;
            panelMain.GradientBorderStartColor = Color.DarkGray;
            panelMain.HoverBorderColor = Color.Gray;
            panelMain.HoverGradientBorderEndColor = Color.DarkGray;
            panelMain.HoverGradientBorderStartColor = Color.Gray;
            panelMain.Location = new Point(204, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(5);
            panelMain.PatternOpacity = 0.7F;
            panelMain.PinIconBorderColor = Color.Red;
            panelMain.PinIconColor = Color.DarkGray;
            panelMain.PinIconPinned = (Image)resources.GetObject("panelMain.PinIconPinned");
            panelMain.PinIconUnpinned = (Image)resources.GetObject("panelMain.PinIconUnpinned");
            panelMain.PinnedBorderColor = Color.DodgerBlue;
            panelMain.PinnedGradientBorderEndColor = Color.RoyalBlue;
            panelMain.PinnedGradientBorderStartColor = Color.DodgerBlue;
            panelMain.PinnedIconColor = Color.DodgerBlue;
            panelMain.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            panelMain.Size = new Size(1700, 1041);
            panelMain.TabIndex = 1;
            // 
            // ReceptionistDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReceptionistDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReceptionistDashboard";
            WindowState = FormWindowState.Maximized;
            Load += MainDashboard_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePinnablePanel panelSidebar;
        private SiticoneNetCoreUI.SiticoneButton btnLogout;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel1;
        private SiticoneNetCoreUI.SiticonePinnablePanel panelMain;
        private Label label1;
        private Label label3;
        private Label label2;
    }

}
