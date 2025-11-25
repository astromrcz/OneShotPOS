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
            btnQueue = new SiticoneNetCoreUI.SiticoneButton();
            btnTables = new SiticoneNetCoreUI.SiticoneButton();
            lblUserRole = new Label();
            lblLoggedInUser = new Label();
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
            panelSidebar.Controls.Add(btnQueue);
            panelSidebar.Controls.Add(btnTables);
            panelSidebar.Controls.Add(lblUserRole);
            panelSidebar.Controls.Add(lblLoggedInUser);
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
            // btnQueue
            // 
            btnQueue.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnQueue.AccessibleName = "Queue";
            btnQueue.AutoSizeBasedOnText = false;
            btnQueue.BackColor = Color.Transparent;
            btnQueue.BadgeBackColor = Color.Black;
            btnQueue.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnQueue.BadgeValue = 0;
            btnQueue.BadgeValueForeColor = Color.White;
            btnQueue.BorderColor = Color.FromArgb(213, 216, 220);
            btnQueue.BorderWidth = 1;
            btnQueue.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnQueue.ButtonImage = null;
            btnQueue.ButtonTextLeftPadding = 0;
            btnQueue.CanBeep = true;
            btnQueue.CanGlow = false;
            btnQueue.CanShake = true;
            btnQueue.ContextMenuStripEx = null;
            btnQueue.CornerRadiusBottomLeft = 6;
            btnQueue.CornerRadiusBottomRight = 6;
            btnQueue.CornerRadiusTopLeft = 6;
            btnQueue.CornerRadiusTopRight = 6;
            btnQueue.CustomCursor = Cursors.Default;
            btnQueue.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnQueue.EnableLongPress = false;
            btnQueue.EnableRippleEffect = true;
            btnQueue.EnableShadow = false;
            btnQueue.EnableTextWrapping = false;
            btnQueue.Font = new Font("Segoe UI Semibold", 10.2F);
            btnQueue.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnQueue.GlowIntensity = 100;
            btnQueue.GlowRadius = 20F;
            btnQueue.GradientBackground = false;
            btnQueue.GradientColor = Color.FromArgb(0, 227, 64);
            btnQueue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnQueue.HintText = null;
            btnQueue.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnQueue.HoverFontStyle = FontStyle.Regular;
            btnQueue.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnQueue.HoverTransitionDuration = 250;
            btnQueue.ImageAlign = ContentAlignment.MiddleLeft;
            btnQueue.ImagePadding = 5;
            btnQueue.ImageSize = new Size(16, 16);
            btnQueue.IsRadial = false;
            btnQueue.IsReadOnly = false;
            btnQueue.IsToggleButton = false;
            btnQueue.IsToggled = false;
            btnQueue.Location = new Point(8, 327);
            btnQueue.LongPressDurationMS = 1000;
            btnQueue.Name = "btnQueue";
            btnQueue.NormalFontStyle = FontStyle.Regular;
            btnQueue.ParticleColor = Color.FromArgb(200, 200, 200);
            btnQueue.ParticleCount = 15;
            btnQueue.PressAnimationScale = 0.97F;
            btnQueue.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnQueue.PressedFontStyle = FontStyle.Regular;
            btnQueue.PressTransitionDuration = 150;
            btnQueue.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnQueue.RippleColor = Color.FromArgb(0, 0, 0);
            btnQueue.RippleRadiusMultiplier = 0.6F;
            btnQueue.ShadowBlur = 5;
            btnQueue.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnQueue.ShadowOffset = new Point(0, 2);
            btnQueue.ShakeDuration = 500;
            btnQueue.ShakeIntensity = 5;
            btnQueue.Size = new Size(190, 50);
            btnQueue.TabIndex = 10;
            btnQueue.Text = "Queue";
            btnQueue.TextAlign = ContentAlignment.MiddleCenter;
            btnQueue.TextColor = Color.FromArgb(0, 0, 0);
            btnQueue.TooltipText = null;
            btnQueue.UseAdvancedRendering = true;
            btnQueue.UseParticles = false;
            btnQueue.Click += btnQueue_Click;
            // 
            // btnTables
            // 
            btnTables.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnTables.AccessibleName = "Tables";
            btnTables.AutoSizeBasedOnText = false;
            btnTables.BackColor = Color.Transparent;
            btnTables.BadgeBackColor = Color.Black;
            btnTables.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnTables.BadgeValue = 0;
            btnTables.BadgeValueForeColor = Color.White;
            btnTables.BorderColor = Color.FromArgb(213, 216, 220);
            btnTables.BorderWidth = 1;
            btnTables.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnTables.ButtonImage = null;
            btnTables.ButtonTextLeftPadding = 0;
            btnTables.CanBeep = true;
            btnTables.CanGlow = false;
            btnTables.CanShake = true;
            btnTables.ContextMenuStripEx = null;
            btnTables.CornerRadiusBottomLeft = 6;
            btnTables.CornerRadiusBottomRight = 6;
            btnTables.CornerRadiusTopLeft = 6;
            btnTables.CornerRadiusTopRight = 6;
            btnTables.CustomCursor = Cursors.Default;
            btnTables.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnTables.EnableLongPress = false;
            btnTables.EnableRippleEffect = true;
            btnTables.EnableShadow = false;
            btnTables.EnableTextWrapping = false;
            btnTables.Font = new Font("Segoe UI Semibold", 10.2F);
            btnTables.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnTables.GlowIntensity = 100;
            btnTables.GlowRadius = 20F;
            btnTables.GradientBackground = false;
            btnTables.GradientColor = Color.FromArgb(0, 227, 64);
            btnTables.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnTables.HintText = null;
            btnTables.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnTables.HoverFontStyle = FontStyle.Regular;
            btnTables.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnTables.HoverTransitionDuration = 250;
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnTables.ImagePadding = 5;
            btnTables.ImageSize = new Size(16, 16);
            btnTables.IsRadial = false;
            btnTables.IsReadOnly = false;
            btnTables.IsToggleButton = false;
            btnTables.IsToggled = false;
            btnTables.Location = new Point(8, 261);
            btnTables.LongPressDurationMS = 1000;
            btnTables.Name = "btnTables";
            btnTables.NormalFontStyle = FontStyle.Regular;
            btnTables.ParticleColor = Color.FromArgb(200, 200, 200);
            btnTables.ParticleCount = 15;
            btnTables.PressAnimationScale = 0.97F;
            btnTables.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnTables.PressedFontStyle = FontStyle.Regular;
            btnTables.PressTransitionDuration = 150;
            btnTables.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnTables.RippleColor = Color.FromArgb(0, 0, 0);
            btnTables.RippleRadiusMultiplier = 0.6F;
            btnTables.ShadowBlur = 5;
            btnTables.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnTables.ShadowOffset = new Point(0, 2);
            btnTables.ShakeDuration = 500;
            btnTables.ShakeIntensity = 5;
            btnTables.Size = new Size(190, 50);
            btnTables.TabIndex = 9;
            btnTables.Text = "Tables";
            btnTables.TextAlign = ContentAlignment.MiddleCenter;
            btnTables.TextColor = Color.FromArgb(0, 0, 0);
            btnTables.TooltipText = null;
            btnTables.UseAdvancedRendering = true;
            btnTables.UseParticles = false;
            btnTables.Click += btnTables_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRole.Location = new Point(33, 180);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(94, 21);
            lblUserRole.TabIndex = 8;
            lblUserRole.Text = "lblUserRole";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.Location = new Point(33, 159);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(132, 21);
            lblLoggedInUser.TabIndex = 7;
            lblLoggedInUser.Text = "lblLoggedInUser";
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
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePinnablePanel panelSidebar;
        private SiticoneNetCoreUI.SiticoneButton btnLogout;
        private SiticoneNetCoreUI.SiticonePinnablePanel panelMain;
        private Label lblUserRole;
        private Label lblLoggedInUser;
        private SiticoneNetCoreUI.SiticoneButton btnQueue;
        private SiticoneNetCoreUI.SiticoneButton btnTables;
    }

}
