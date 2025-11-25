namespace OneShotPOS
{
    partial class UC_Receptionist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            pnlTables = new FlowLayoutPanel();
            btnReserve = new SiticoneNetCoreUI.SiticoneButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 13;
            label2.Text = "Monitor and manage billiards tables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 12;
            label1.Text = "Table Management";
            // 
            // pnlTables
            // 
            pnlTables.AutoScroll = true;
            pnlTables.Location = new Point(25, 116);
            pnlTables.Name = "pnlTables";
            pnlTables.Size = new Size(1697, 606);
            pnlTables.TabIndex = 14;
            // 
            // btnReserve
            // 
            btnReserve.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnReserve.AccessibleName = "New Reservation";
            btnReserve.AutoSizeBasedOnText = false;
            btnReserve.BackColor = Color.Transparent;
            btnReserve.BadgeBackColor = Color.Black;
            btnReserve.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnReserve.BadgeValue = 0;
            btnReserve.BadgeValueForeColor = Color.White;
            btnReserve.BorderColor = Color.FromArgb(213, 216, 220);
            btnReserve.BorderWidth = 1;
            btnReserve.ButtonBackColor = Color.Black;
            btnReserve.ButtonImage = null;
            btnReserve.ButtonTextLeftPadding = 0;
            btnReserve.CanBeep = true;
            btnReserve.CanGlow = false;
            btnReserve.CanShake = true;
            btnReserve.ContextMenuStripEx = null;
            btnReserve.CornerRadiusBottomLeft = 14;
            btnReserve.CornerRadiusBottomRight = 14;
            btnReserve.CornerRadiusTopLeft = 14;
            btnReserve.CornerRadiusTopRight = 14;
            btnReserve.CustomCursor = Cursors.Default;
            btnReserve.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnReserve.EnableLongPress = false;
            btnReserve.EnableRippleEffect = true;
            btnReserve.EnableShadow = false;
            btnReserve.EnableTextWrapping = false;
            btnReserve.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReserve.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnReserve.GlowIntensity = 100;
            btnReserve.GlowRadius = 20F;
            btnReserve.GradientBackground = false;
            btnReserve.GradientColor = Color.FromArgb(0, 227, 64);
            btnReserve.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnReserve.HintText = null;
            btnReserve.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnReserve.HoverFontStyle = FontStyle.Regular;
            btnReserve.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnReserve.HoverTransitionDuration = 250;
            btnReserve.ImageAlign = ContentAlignment.MiddleLeft;
            btnReserve.ImagePadding = 5;
            btnReserve.ImageSize = new Size(16, 16);
            btnReserve.IsRadial = false;
            btnReserve.IsReadOnly = false;
            btnReserve.IsToggleButton = false;
            btnReserve.IsToggled = false;
            btnReserve.Location = new Point(1460, 26);
            btnReserve.LongPressDurationMS = 1000;
            btnReserve.Name = "btnReserve";
            btnReserve.NormalFontStyle = FontStyle.Regular;
            btnReserve.ParticleColor = Color.FromArgb(200, 200, 200);
            btnReserve.ParticleCount = 15;
            btnReserve.PressAnimationScale = 0.97F;
            btnReserve.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnReserve.PressedFontStyle = FontStyle.Regular;
            btnReserve.PressTransitionDuration = 150;
            btnReserve.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnReserve.RippleColor = Color.White;
            btnReserve.RippleRadiusMultiplier = 0.6F;
            btnReserve.ShadowBlur = 5;
            btnReserve.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnReserve.ShadowOffset = new Point(0, 2);
            btnReserve.ShakeDuration = 500;
            btnReserve.ShakeIntensity = 5;
            btnReserve.Size = new Size(169, 51);
            btnReserve.TabIndex = 15;
            btnReserve.Text = "New Reservation";
            btnReserve.TextAlign = ContentAlignment.MiddleCenter;
            btnReserve.TextColor = Color.White;
            btnReserve.TooltipText = null;
            btnReserve.UseAdvancedRendering = true;
            btnReserve.UseParticles = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // UC_Receptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReserve);
            Controls.Add(pnlTables);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Receptionist";
            Size = new Size(1700, 1041);
            Load += UC_Receptionist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private FlowLayoutPanel pnlTables;
        private SiticoneNetCoreUI.SiticoneButton btnReserve;
    }
}
