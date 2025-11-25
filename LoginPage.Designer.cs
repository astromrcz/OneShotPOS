namespace OneShotPOS
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txtPassword = new SiticoneNetCoreUI.SiticoneTextBoxAdvanced();
            txtUsername = new SiticoneNetCoreUI.SiticoneTextBoxAdvanced();
            btnLogin = new SiticoneNetCoreUI.SiticoneActivityButton();
            lblUsername = new SiticoneNetCoreUI.SiticoneLabel();
            lblPassword = new SiticoneNetCoreUI.SiticoneLabel();
            siticoneAdvancedPanel1 = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            siticoneCloseButton1 = new SiticoneNetCoreUI.SiticoneCloseButton();
            siticoneLabel2 = new SiticoneNetCoreUI.SiticoneLabel();
            siticoneLabel1 = new SiticoneNetCoreUI.SiticoneLabel();
            imageList1 = new ImageList(components);
            mySiticoneLicenseSettings1 = new SiticoneNetCoreUI.MySiticoneLicenseSettings();
            siticoneAdvancedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "";
            txtPassword.AccessibleName = "txtPassword";
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BackgroundColor = Color.FromArgb(250, 250, 250);
            txtPassword.BackgroundImageLayout = ImageLayout.Center;
            txtPassword.BorderColor = Color.Black;
            txtPassword.BottomLeftCornerRadius = 12;
            txtPassword.BottomRightCornerRadius = 12;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.ErrorColor = Color.Black;
            txtPassword.FocusBorderColor = Color.FromArgb(0, 123, 255);
            txtPassword.FocusImage = null;
            txtPassword.ForeColor = Color.FromArgb(30, 30, 30);
            txtPassword.HoverBorderColor = Color.FromArgb(150, 150, 150);
            txtPassword.HoverImage = null;
            txtPassword.IdleImage = null;
            txtPassword.InputType = SiticoneNetCoreUI.AdvancedTextBoxInputType.Password;
            txtPassword.Location = new Point(25, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderColor = Color.FromArgb(108, 117, 125);
            txtPassword.PlaceholderFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtPassword.PlaceholderText = "Password";
            txtPassword.ReadOnlyColors.BackgroundColor = Color.FromArgb(245, 245, 245);
            txtPassword.ReadOnlyColors.BorderColor = Color.FromArgb(200, 200, 200);
            txtPassword.ReadOnlyColors.PlaceholderColor = Color.FromArgb(150, 150, 150);
            txtPassword.ReadOnlyColors.TextColor = Color.FromArgb(100, 100, 100);
            txtPassword.Size = new Size(260, 42);
            txtPassword.TabIndex = 0;
            txtPassword.TextColor = Color.FromArgb(30, 30, 30);
            txtPassword.TextContent = "";
            txtPassword.TopLeftCornerRadius = 12;
            txtPassword.TopRightCornerRadius = 12;
            txtPassword.ValidationPattern = "";
            txtPassword.TextContentChanged += siticoneTextBoxAdvanced1_TextContentChanged;
            // 
            // txtUsername
            // 
            txtUsername.AccessibleDescription = "txtUsername";
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BackgroundColor = Color.FromArgb(250, 250, 250);
            txtUsername.BorderColor = Color.Black;
            txtUsername.BottomLeftCornerRadius = 12;
            txtUsername.BottomRightCornerRadius = 12;
            txtUsername.FocusBorderColor = Color.FromArgb(0, 123, 255);
            txtUsername.FocusImage = null;
            txtUsername.ForeColor = Color.FromArgb(30, 30, 30);
            txtUsername.HoverBorderColor = Color.FromArgb(150, 150, 150);
            txtUsername.HoverImage = null;
            txtUsername.IdleImage = null;
            txtUsername.Location = new Point(25, 182);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderColor = Color.FromArgb(108, 117, 125);
            txtUsername.PlaceholderFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtUsername.PlaceholderText = "Enter your Username";
            txtUsername.ReadOnlyColors.BackgroundColor = Color.FromArgb(245, 245, 245);
            txtUsername.ReadOnlyColors.BorderColor = Color.FromArgb(200, 200, 200);
            txtUsername.ReadOnlyColors.PlaceholderColor = Color.FromArgb(150, 150, 150);
            txtUsername.ReadOnlyColors.TextColor = Color.FromArgb(100, 100, 100);
            txtUsername.Size = new Size(260, 42);
            txtUsername.TabIndex = 0;
            txtUsername.TextColor = Color.FromArgb(30, 30, 30);
            txtUsername.TextContent = "";
            txtUsername.TopLeftCornerRadius = 12;
            txtUsername.TopRightCornerRadius = 12;
            txtUsername.ValidationPattern = "";
            // 
            // btnLogin
            // 
            btnLogin.ActivityDuration = 2000;
            btnLogin.ActivityIndicatorColor = Color.FromArgb(240, 240, 240);
            btnLogin.ActivityIndicatorSize = 4;
            btnLogin.ActivityIndicatorSpeed = 100;
            btnLogin.ActivityText = "Logging In...";
            btnLogin.AnimationEasing = SiticoneNetCoreUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BaseColor = Color.FromArgb(50, 50, 50);
            btnLogin.BorderColor = Color.FromArgb(80, 80, 80);
            btnLogin.BorderWidth = 2;
            btnLogin.CornerRadiusBottomLeft = 35;
            btnLogin.CornerRadiusBottomRight = 35;
            btnLogin.CornerRadiusTopLeft = 35;
            btnLogin.CornerRadiusTopRight = 35;
            btnLogin.DisabledColor = Color.FromArgb(160, 160, 160);
            btnLogin.Elevation = 2F;
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.HoverAnimationDuration = 200;
            btnLogin.HoverColor = Color.FromArgb(70, 70, 70);
            btnLogin.Location = new Point(71, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.PressAnimationDuration = 150;
            btnLogin.PressedColor = Color.FromArgb(30, 30, 30);
            btnLogin.PressedElevation = 1F;
            btnLogin.RippleColor = Color.FromArgb(100, 150, 150, 150);
            btnLogin.RippleDuration = 1800;
            btnLogin.RippleSize = 5;
            btnLogin.ShowActivityText = true;
            btnLogin.Size = new Size(173, 39);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.FromArgb(240, 240, 240);
            btnLogin.Theme = SiticoneNetCoreUI.SiticoneActivityButton.ActivityButtonTheme.Dark;
            btnLogin.UltraPerformanceMode = true;
            btnLogin.UseAnimation = true;
            btnLogin.UseElevation = true;
            btnLogin.UseRippleEffect = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.FlatStyle = FlatStyle.System;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(25, 156);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.FlatStyle = FlatStyle.System;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(25, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // siticoneAdvancedPanel1
            // 
            siticoneAdvancedPanel1.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel1.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel1.AdvancedBorderStyle = SiticoneNetCoreUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            siticoneAdvancedPanel1.AnimationDuration = 500;
            siticoneAdvancedPanel1.AnimationType = SiticoneNetCoreUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel1.BackColor = Color.White;
            siticoneAdvancedPanel1.BackgroundImageCustom = null;
            siticoneAdvancedPanel1.BackgroundImageOpacity = 1F;
            siticoneAdvancedPanel1.BackgroundImageSizeMode = SiticoneNetCoreUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            siticoneAdvancedPanel1.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            siticoneAdvancedPanel1.BorderColor = Color.Gray;
            siticoneAdvancedPanel1.BorderDashPattern = null;
            siticoneAdvancedPanel1.BorderGlowColor = Color.Cyan;
            siticoneAdvancedPanel1.BorderGlowSize = 3F;
            siticoneAdvancedPanel1.BorderWidth = 1F;
            siticoneAdvancedPanel1.BottomLeftRadius = 5;
            siticoneAdvancedPanel1.BottomRightRadius = 5;
            siticoneAdvancedPanel1.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            siticoneAdvancedPanel1.Controls.Add(siticoneCloseButton1);
            siticoneAdvancedPanel1.Controls.Add(siticoneLabel2);
            siticoneAdvancedPanel1.Controls.Add(siticoneLabel1);
            siticoneAdvancedPanel1.Controls.Add(lblPassword);
            siticoneAdvancedPanel1.Controls.Add(txtPassword);
            siticoneAdvancedPanel1.Controls.Add(lblUsername);
            siticoneAdvancedPanel1.Controls.Add(txtUsername);
            siticoneAdvancedPanel1.Controls.Add(btnLogin);
            siticoneAdvancedPanel1.CornerPadding = new Padding(5);
            siticoneAdvancedPanel1.DisabledBackColor = Color.Empty;
            siticoneAdvancedPanel1.DisabledBorderColor = Color.Empty;
            siticoneAdvancedPanel1.DoubleBorderSpacing = 2F;
            siticoneAdvancedPanel1.EasingType = SiticoneNetCoreUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            siticoneAdvancedPanel1.EnableAnimation = false;
            siticoneAdvancedPanel1.EnableBackgroundImage = false;
            siticoneAdvancedPanel1.EnableBorderGlow = false;
            siticoneAdvancedPanel1.EnableDoubleBorder = false;
            siticoneAdvancedPanel1.EnableGradient = false;
            siticoneAdvancedPanel1.EnableInnerShadow = false;
            siticoneAdvancedPanel1.EnableShadow = false;
            siticoneAdvancedPanel1.EnableSmartPadding = true;
            siticoneAdvancedPanel1.EnableStateStyles = false;
            siticoneAdvancedPanel1.FlowDirectionCustom = FlowDirection.LeftToRight;
            siticoneAdvancedPanel1.GradientAngle = 90F;
            siticoneAdvancedPanel1.GradientEndColor = Color.LightGray;
            siticoneAdvancedPanel1.GradientStartColor = Color.White;
            siticoneAdvancedPanel1.GradientType = SiticoneNetCoreUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            siticoneAdvancedPanel1.HoverBackColor = Color.Empty;
            siticoneAdvancedPanel1.HoverBorderColor = Color.Empty;
            siticoneAdvancedPanel1.InnerShadowColor = Color.Black;
            siticoneAdvancedPanel1.InnerShadowDepth = 3;
            siticoneAdvancedPanel1.InnerShadowOpacity = 0.2F;
            siticoneAdvancedPanel1.Location = new Point(2, -1);
            siticoneAdvancedPanel1.Name = "siticoneAdvancedPanel1";
            siticoneAdvancedPanel1.Padding = new Padding(10);
            siticoneAdvancedPanel1.RadialGradientCenter = (PointF)resources.GetObject("siticoneAdvancedPanel1.RadialGradientCenter");
            siticoneAdvancedPanel1.RadialGradientRadius = 1F;
            siticoneAdvancedPanel1.ScaleRatio = 0.8F;
            siticoneAdvancedPanel1.SecondaryBorderColor = Color.DarkGray;
            siticoneAdvancedPanel1.ShadowBlur = 10;
            siticoneAdvancedPanel1.ShadowColor = Color.Black;
            siticoneAdvancedPanel1.ShadowDepth = 5;
            siticoneAdvancedPanel1.ShadowOffset = new Point(2, 2);
            siticoneAdvancedPanel1.ShadowOpacity = 0.3F;
            siticoneAdvancedPanel1.Size = new Size(309, 410);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 4;
            siticoneAdvancedPanel1.TopLeftRadius = 5;
            siticoneAdvancedPanel1.TopRightRadius = 5;
            // 
            // siticoneCloseButton1
            // 
            siticoneCloseButton1.BackgroundImageLayout = ImageLayout.None;
            siticoneCloseButton1.CountdownFont = new Font("Segoe UI", 9F);
            siticoneCloseButton1.Cursor = Cursors.Default;
            siticoneCloseButton1.EnableConfirmation = true;
            siticoneCloseButton1.EnableShakeAnimation = true;
            siticoneCloseButton1.Location = new Point(269, 10);
            siticoneCloseButton1.Name = "siticoneCloseButton1";
            siticoneCloseButton1.Size = new Size(32, 32);
            siticoneCloseButton1.TabIndex = 6;
            siticoneCloseButton1.Text = "siticoneCloseButton1";
            siticoneCloseButton1.TooltipText = "Close button";
            siticoneCloseButton1.Click += siticoneCloseButton1_Click;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.BackColor = Color.Transparent;
            siticoneLabel2.FlatStyle = FlatStyle.System;
            siticoneLabel2.Font = new Font("Segoe UI", 10F);
            siticoneLabel2.Location = new Point(90, 117);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(127, 23);
            siticoneLabel2.TabIndex = 5;
            siticoneLabel2.Text = "Point of Sale System";
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.BackColor = Color.Transparent;
            siticoneLabel1.FlatStyle = FlatStyle.System;
            siticoneLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.Location = new Point(81, 94);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(145, 23);
            siticoneLabel1.TabIndex = 4;
            siticoneLabel1.Text = "One Shot Bar & Billiards";
            siticoneLabel1.Click += siticoneLabel1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "oneshotlogo.jpg");
            // 
            // LoginPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(311, 410);
            Controls.Add(siticoneAdvancedPanel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginPage";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += LoginPage_Load;
            siticoneAdvancedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneTextBoxAdvanced txtPassword;
        private SiticoneNetCoreUI.SiticoneTextBoxAdvanced txtUsername;
        private SiticoneNetCoreUI.SiticoneActivityButton btnLogin;
        private SiticoneNetCoreUI.SiticoneLabel lblUsername;
        private SiticoneNetCoreUI.SiticoneLabel lblPassword;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private ImageList imageList1;
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel1;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel2;
        private SiticoneNetCoreUI.SiticoneCloseButton siticoneCloseButton1;
    }
}
