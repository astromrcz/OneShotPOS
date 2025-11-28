namespace OneShotPOS
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            panelSidebar = new SiticoneNetCoreUI.SiticonePinnablePanel();
            label1 = new Label();
            btnActivityLog = new SiticoneNetCoreUI.SiticoneButton();
            btnEmployees = new SiticoneNetCoreUI.SiticoneButton();
            lblUserRole = new Label();
            lblLoggedInUser = new Label();
            btnProducts = new SiticoneNetCoreUI.SiticoneButton();
            btnOverview = new SiticoneNetCoreUI.SiticoneButton();
            btnLogout = new SiticoneNetCoreUI.SiticoneButton();
            panelMain = new SiticoneNetCoreUI.SiticonePinnablePanel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BorderColor = Color.DarkGray;
            panelSidebar.BorderRadius = 0;
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnActivityLog);
            panelSidebar.Controls.Add(btnEmployees);
            panelSidebar.Controls.Add(lblUserRole);
            panelSidebar.Controls.Add(lblLoggedInUser);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Controls.Add(btnOverview);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(3, 15, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 64);
            label1.TabIndex = 13;
            label1.Text = "One Shot Bar\r\n    and Billiards";
            // 
            // btnActivityLog
            // 
            btnActivityLog.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnActivityLog.AccessibleName = "Activity Log";
            btnActivityLog.AutoSizeBasedOnText = false;
            btnActivityLog.BackColor = Color.Transparent;
            btnActivityLog.BadgeBackColor = Color.Black;
            btnActivityLog.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnActivityLog.BadgeValue = 0;
            btnActivityLog.BadgeValueForeColor = Color.White;
            btnActivityLog.BorderColor = Color.FromArgb(60, 60, 60);
            btnActivityLog.BorderWidth = 2;
            btnActivityLog.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnActivityLog.ButtonImage = null;
            btnActivityLog.ButtonTextLeftPadding = 0;
            btnActivityLog.CanBeep = true;
            btnActivityLog.CanGlow = false;
            btnActivityLog.CanShake = true;
            btnActivityLog.ContextMenuStripEx = null;
            btnActivityLog.CornerRadiusBottomLeft = 6;
            btnActivityLog.CornerRadiusBottomRight = 6;
            btnActivityLog.CornerRadiusTopLeft = 6;
            btnActivityLog.CornerRadiusTopRight = 6;
            btnActivityLog.CustomCursor = Cursors.Default;
            btnActivityLog.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnActivityLog.EnableLongPress = false;
            btnActivityLog.EnableRippleEffect = true;
            btnActivityLog.EnableShadow = true;
            btnActivityLog.EnableTextWrapping = false;
            btnActivityLog.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActivityLog.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnActivityLog.GlowIntensity = 100;
            btnActivityLog.GlowRadius = 20F;
            btnActivityLog.GradientBackground = false;
            btnActivityLog.GradientColor = Color.FromArgb(0, 227, 64);
            btnActivityLog.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnActivityLog.HintText = null;
            btnActivityLog.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnActivityLog.HoverFontStyle = FontStyle.Regular;
            btnActivityLog.HoverTextColor = Color.White;
            btnActivityLog.HoverTransitionDuration = 250;
            btnActivityLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivityLog.ImagePadding = 5;
            btnActivityLog.ImageSize = new Size(16, 16);
            btnActivityLog.IsRadial = false;
            btnActivityLog.IsReadOnly = false;
            btnActivityLog.IsToggleButton = false;
            btnActivityLog.IsToggled = false;
            btnActivityLog.Location = new Point(13, 427);
            btnActivityLog.LongPressDurationMS = 1000;
            btnActivityLog.Name = "btnActivityLog";
            btnActivityLog.NormalFontStyle = FontStyle.Regular;
            btnActivityLog.ParticleColor = Color.FromArgb(200, 200, 200);
            btnActivityLog.ParticleCount = 15;
            btnActivityLog.PressAnimationScale = 0.97F;
            btnActivityLog.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnActivityLog.PressedFontStyle = FontStyle.Regular;
            btnActivityLog.PressTransitionDuration = 150;
            btnActivityLog.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnActivityLog.RippleColor = Color.FromArgb(100, 100, 100);
            btnActivityLog.RippleOpacity = 0.3F;
            btnActivityLog.RippleRadiusMultiplier = 0.6F;
            btnActivityLog.ShadowBlur = 6;
            btnActivityLog.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnActivityLog.ShadowOffset = new Point(0, 2);
            btnActivityLog.ShakeDuration = 500;
            btnActivityLog.ShakeIntensity = 5;
            btnActivityLog.Size = new Size(180, 43);
            btnActivityLog.TabIndex = 12;
            btnActivityLog.Text = "Activity Log";
            btnActivityLog.TextAlign = ContentAlignment.MiddleCenter;
            btnActivityLog.TextColor = Color.White;
            btnActivityLog.TooltipText = null;
            btnActivityLog.UseAdvancedRendering = true;
            btnActivityLog.UseParticles = false;
            btnActivityLog.Click += btnActivityLog_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnEmployees.AccessibleName = "Employees";
            btnEmployees.AutoSizeBasedOnText = false;
            btnEmployees.BackColor = Color.Transparent;
            btnEmployees.BadgeBackColor = Color.Black;
            btnEmployees.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnEmployees.BadgeValue = 0;
            btnEmployees.BadgeValueForeColor = Color.White;
            btnEmployees.BorderColor = Color.FromArgb(60, 60, 60);
            btnEmployees.BorderWidth = 2;
            btnEmployees.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnEmployees.ButtonImage = null;
            btnEmployees.ButtonTextLeftPadding = 0;
            btnEmployees.CanBeep = true;
            btnEmployees.CanGlow = false;
            btnEmployees.CanShake = true;
            btnEmployees.ContextMenuStripEx = null;
            btnEmployees.CornerRadiusBottomLeft = 6;
            btnEmployees.CornerRadiusBottomRight = 6;
            btnEmployees.CornerRadiusTopLeft = 6;
            btnEmployees.CornerRadiusTopRight = 6;
            btnEmployees.CustomCursor = Cursors.Default;
            btnEmployees.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnEmployees.EnableLongPress = false;
            btnEmployees.EnableRippleEffect = true;
            btnEmployees.EnableShadow = true;
            btnEmployees.EnableTextWrapping = false;
            btnEmployees.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnEmployees.GlowIntensity = 100;
            btnEmployees.GlowRadius = 20F;
            btnEmployees.GradientBackground = false;
            btnEmployees.GradientColor = Color.FromArgb(0, 227, 64);
            btnEmployees.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnEmployees.HintText = null;
            btnEmployees.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnEmployees.HoverFontStyle = FontStyle.Regular;
            btnEmployees.HoverTextColor = Color.White;
            btnEmployees.HoverTransitionDuration = 250;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.ImagePadding = 5;
            btnEmployees.ImageSize = new Size(16, 16);
            btnEmployees.IsRadial = false;
            btnEmployees.IsReadOnly = false;
            btnEmployees.IsToggleButton = false;
            btnEmployees.IsToggled = false;
            btnEmployees.Location = new Point(13, 378);
            btnEmployees.LongPressDurationMS = 1000;
            btnEmployees.Name = "btnEmployees";
            btnEmployees.NormalFontStyle = FontStyle.Regular;
            btnEmployees.ParticleColor = Color.FromArgb(200, 200, 200);
            btnEmployees.ParticleCount = 15;
            btnEmployees.PressAnimationScale = 0.97F;
            btnEmployees.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnEmployees.PressedFontStyle = FontStyle.Regular;
            btnEmployees.PressTransitionDuration = 150;
            btnEmployees.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnEmployees.RippleColor = Color.FromArgb(100, 100, 100);
            btnEmployees.RippleOpacity = 0.3F;
            btnEmployees.RippleRadiusMultiplier = 0.6F;
            btnEmployees.ShadowBlur = 6;
            btnEmployees.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnEmployees.ShadowOffset = new Point(0, 2);
            btnEmployees.ShakeDuration = 500;
            btnEmployees.ShakeIntensity = 5;
            btnEmployees.Size = new Size(180, 43);
            btnEmployees.TabIndex = 11;
            btnEmployees.Text = "Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleCenter;
            btnEmployees.TextColor = Color.White;
            btnEmployees.TooltipText = null;
            btnEmployees.UseAdvancedRendering = true;
            btnEmployees.UseParticles = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRole.Location = new Point(13, 177);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(94, 21);
            lblUserRole.TabIndex = 8;
            lblUserRole.Text = "lblUserRole";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.Location = new Point(13, 156);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(132, 21);
            lblLoggedInUser.TabIndex = 7;
            lblLoggedInUser.Text = "lblLoggedInUser";
            // 
            // btnProducts
            // 
            btnProducts.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnProducts.AccessibleName = "Inventory";
            btnProducts.AutoSizeBasedOnText = false;
            btnProducts.BackColor = Color.Transparent;
            btnProducts.BadgeBackColor = Color.Black;
            btnProducts.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProducts.BadgeValue = 0;
            btnProducts.BadgeValueForeColor = Color.White;
            btnProducts.BorderColor = Color.FromArgb(60, 60, 60);
            btnProducts.BorderWidth = 2;
            btnProducts.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnProducts.ButtonImage = null;
            btnProducts.ButtonTextLeftPadding = 0;
            btnProducts.CanBeep = true;
            btnProducts.CanGlow = false;
            btnProducts.CanShake = true;
            btnProducts.ContextMenuStripEx = null;
            btnProducts.CornerRadiusBottomLeft = 6;
            btnProducts.CornerRadiusBottomRight = 6;
            btnProducts.CornerRadiusTopLeft = 6;
            btnProducts.CornerRadiusTopRight = 6;
            btnProducts.CustomCursor = Cursors.Default;
            btnProducts.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnProducts.EnableLongPress = false;
            btnProducts.EnableRippleEffect = true;
            btnProducts.EnableShadow = true;
            btnProducts.EnableTextWrapping = false;
            btnProducts.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnProducts.GlowIntensity = 100;
            btnProducts.GlowRadius = 20F;
            btnProducts.GradientBackground = false;
            btnProducts.GradientColor = Color.FromArgb(0, 227, 64);
            btnProducts.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnProducts.HintText = null;
            btnProducts.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnProducts.HoverFontStyle = FontStyle.Regular;
            btnProducts.HoverTextColor = Color.White;
            btnProducts.HoverTransitionDuration = 250;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.ImagePadding = 5;
            btnProducts.ImageSize = new Size(16, 16);
            btnProducts.IsRadial = false;
            btnProducts.IsReadOnly = false;
            btnProducts.IsToggleButton = false;
            btnProducts.IsToggled = false;
            btnProducts.Location = new Point(13, 329);
            btnProducts.LongPressDurationMS = 1000;
            btnProducts.Name = "btnProducts";
            btnProducts.NormalFontStyle = FontStyle.Regular;
            btnProducts.ParticleColor = Color.FromArgb(200, 200, 200);
            btnProducts.ParticleCount = 15;
            btnProducts.PressAnimationScale = 0.97F;
            btnProducts.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnProducts.PressedFontStyle = FontStyle.Regular;
            btnProducts.PressTransitionDuration = 150;
            btnProducts.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnProducts.RippleColor = Color.FromArgb(100, 100, 100);
            btnProducts.RippleOpacity = 0.3F;
            btnProducts.RippleRadiusMultiplier = 0.6F;
            btnProducts.ShadowBlur = 6;
            btnProducts.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnProducts.ShadowOffset = new Point(0, 2);
            btnProducts.ShakeDuration = 500;
            btnProducts.ShakeIntensity = 5;
            btnProducts.Size = new Size(180, 43);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Inventory";
            btnProducts.TextAlign = ContentAlignment.MiddleCenter;
            btnProducts.TextColor = Color.White;
            btnProducts.TooltipText = null;
            btnProducts.UseAdvancedRendering = true;
            btnProducts.UseParticles = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOverview
            // 
            btnOverview.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnOverview.AccessibleName = "Overview";
            btnOverview.AutoSizeBasedOnText = false;
            btnOverview.BackColor = Color.Transparent;
            btnOverview.BadgeBackColor = Color.Black;
            btnOverview.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOverview.BadgeValue = 0;
            btnOverview.BadgeValueForeColor = Color.White;
            btnOverview.BorderColor = Color.FromArgb(60, 60, 60);
            btnOverview.BorderWidth = 2;
            btnOverview.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnOverview.ButtonImage = null;
            btnOverview.ButtonTextLeftPadding = 0;
            btnOverview.CanBeep = true;
            btnOverview.CanGlow = false;
            btnOverview.CanShake = true;
            btnOverview.ContextMenuStripEx = null;
            btnOverview.CornerRadiusBottomLeft = 6;
            btnOverview.CornerRadiusBottomRight = 6;
            btnOverview.CornerRadiusTopLeft = 6;
            btnOverview.CornerRadiusTopRight = 6;
            btnOverview.CustomCursor = Cursors.Default;
            btnOverview.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnOverview.EnableLongPress = false;
            btnOverview.EnableRippleEffect = true;
            btnOverview.EnableShadow = true;
            btnOverview.EnableTextWrapping = false;
            btnOverview.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverview.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnOverview.GlowIntensity = 100;
            btnOverview.GlowRadius = 20F;
            btnOverview.GradientBackground = false;
            btnOverview.GradientColor = Color.FromArgb(0, 227, 64);
            btnOverview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnOverview.HintText = null;
            btnOverview.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnOverview.HoverFontStyle = FontStyle.Regular;
            btnOverview.HoverTextColor = Color.White;
            btnOverview.HoverTransitionDuration = 250;
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.ImagePadding = 5;
            btnOverview.ImageSize = new Size(16, 16);
            btnOverview.IsRadial = false;
            btnOverview.IsReadOnly = false;
            btnOverview.IsToggleButton = false;
            btnOverview.IsToggled = false;
            btnOverview.Location = new Point(12, 280);
            btnOverview.LongPressDurationMS = 1000;
            btnOverview.Name = "btnOverview";
            btnOverview.NormalFontStyle = FontStyle.Regular;
            btnOverview.ParticleColor = Color.FromArgb(200, 200, 200);
            btnOverview.ParticleCount = 15;
            btnOverview.PressAnimationScale = 0.97F;
            btnOverview.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnOverview.PressedFontStyle = FontStyle.Regular;
            btnOverview.PressTransitionDuration = 150;
            btnOverview.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnOverview.RippleColor = Color.FromArgb(100, 100, 100);
            btnOverview.RippleOpacity = 0.3F;
            btnOverview.RippleRadiusMultiplier = 0.6F;
            btnOverview.ShadowBlur = 6;
            btnOverview.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnOverview.ShadowOffset = new Point(0, 2);
            btnOverview.ShakeDuration = 500;
            btnOverview.ShakeIntensity = 5;
            btnOverview.Size = new Size(180, 43);
            btnOverview.TabIndex = 2;
            btnOverview.Text = "Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleCenter;
            btnOverview.TextColor = Color.White;
            btnOverview.TooltipText = null;
            btnOverview.UseAdvancedRendering = true;
            btnOverview.UseParticles = false;
            btnOverview.Click += btnOverview_Click_1;
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
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDashboard";
            WindowState = FormWindowState.Maximized;
            Load += MainDashboard_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePinnablePanel panelSidebar;
        private SiticoneNetCoreUI.SiticoneButton btnLogout;
        private SiticoneNetCoreUI.SiticonePinnablePanel panelMain;
        private SiticoneNetCoreUI.SiticoneButton btnOverview;
        private SiticoneNetCoreUI.SiticoneButton btnProducts;
        private Label lblUserRole;
        private Label lblLoggedInUser;
        private SiticoneNetCoreUI.SiticoneButton btnEmployees;
        private SiticoneNetCoreUI.SiticoneButton btnActivityLog;
        private Label label1;
    }

}
