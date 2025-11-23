namespace OneShotPOS
{
    partial class UC_Inventory
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
            btnAddItem = new SiticoneNetCoreUI.SiticoneButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(304, 21);
            label2.TabIndex = 5;
            label2.Text = "Track/Manage Products and Inventory items";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(347, 30);
            label1.TabIndex = 4;
            label1.Text = "Products and Inventory Manager";
            // 
            // btnAddItem
            // 
            btnAddItem.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnAddItem.AccessibleName = "+ Add Item";
            btnAddItem.AutoSizeBasedOnText = false;
            btnAddItem.BackColor = Color.Transparent;
            btnAddItem.BadgeBackColor = Color.Black;
            btnAddItem.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAddItem.BadgeValue = 0;
            btnAddItem.BadgeValueForeColor = Color.White;
            btnAddItem.BorderColor = Color.FromArgb(213, 216, 220);
            btnAddItem.BorderWidth = 1;
            btnAddItem.ButtonBackColor = Color.Black;
            btnAddItem.ButtonImage = null;
            btnAddItem.ButtonTextLeftPadding = 0;
            btnAddItem.CanBeep = true;
            btnAddItem.CanGlow = false;
            btnAddItem.CanShake = true;
            btnAddItem.ContextMenuStripEx = null;
            btnAddItem.CornerRadiusBottomLeft = 14;
            btnAddItem.CornerRadiusBottomRight = 14;
            btnAddItem.CornerRadiusTopLeft = 14;
            btnAddItem.CornerRadiusTopRight = 14;
            btnAddItem.CustomCursor = Cursors.Default;
            btnAddItem.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnAddItem.EnableLongPress = false;
            btnAddItem.EnableRippleEffect = true;
            btnAddItem.EnableShadow = false;
            btnAddItem.EnableTextWrapping = false;
            btnAddItem.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnAddItem.GlowIntensity = 100;
            btnAddItem.GlowRadius = 20F;
            btnAddItem.GradientBackground = false;
            btnAddItem.GradientColor = Color.FromArgb(0, 227, 64);
            btnAddItem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnAddItem.HintText = null;
            btnAddItem.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnAddItem.HoverFontStyle = FontStyle.Regular;
            btnAddItem.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnAddItem.HoverTransitionDuration = 250;
            btnAddItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddItem.ImagePadding = 5;
            btnAddItem.ImageSize = new Size(16, 16);
            btnAddItem.IsRadial = false;
            btnAddItem.IsReadOnly = false;
            btnAddItem.IsToggleButton = false;
            btnAddItem.IsToggled = false;
            btnAddItem.Location = new Point(1494, 33);
            btnAddItem.LongPressDurationMS = 1000;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.NormalFontStyle = FontStyle.Regular;
            btnAddItem.ParticleColor = Color.FromArgb(200, 200, 200);
            btnAddItem.ParticleCount = 15;
            btnAddItem.PressAnimationScale = 0.97F;
            btnAddItem.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnAddItem.PressedFontStyle = FontStyle.Regular;
            btnAddItem.PressTransitionDuration = 150;
            btnAddItem.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnAddItem.RippleColor = Color.White;
            btnAddItem.RippleRadiusMultiplier = 0.6F;
            btnAddItem.ShadowBlur = 5;
            btnAddItem.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnAddItem.ShadowOffset = new Point(0, 2);
            btnAddItem.ShakeDuration = 500;
            btnAddItem.ShakeIntensity = 5;
            btnAddItem.Size = new Size(156, 48);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "+ Add Item";
            btnAddItem.TextAlign = ContentAlignment.MiddleCenter;
            btnAddItem.TextColor = Color.White;
            btnAddItem.TooltipText = null;
            btnAddItem.UseAdvancedRendering = true;
            btnAddItem.UseParticles = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Inventory";
            Size = new Size(1700, 1041);
            Load += UC_Inventory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneButton btnAddItem;
    }
}
