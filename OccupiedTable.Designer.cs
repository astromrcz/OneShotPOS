namespace OneShotPOS
{
    partial class OccupiedTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OccupiedTable));
            numMin = new NumericUpDown();
            label2 = new Label();
            btnEndTable = new SiticoneNetCoreUI.SiticoneButton();
            lblAvailability = new Label();
            lblTblNumber = new Label();
            siticoneAdvancedPanel1 = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            label4 = new Label();
            btnExtend = new SiticoneNetCoreUI.SiticoneButton();
            label3 = new Label();
            lblElapsedTime = new Label();
            pnlCurrentBill = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            siticoneAdvancedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // numMin
            // 
            numMin.BorderStyle = BorderStyle.FixedSingle;
            numMin.Increment = new decimal(new int[] { 30, 0, 0, 0 });
            numMin.Location = new Point(14, 40);
            numMin.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numMin.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numMin.Name = "numMin";
            numMin.Size = new Size(331, 23);
            numMin.TabIndex = 15;
            numMin.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 14;
            label2.Text = "Extend Time";
            // 
            // btnEndTable
            // 
            btnEndTable.AccessibleDescription = "Button with mnemonic ' '";
            btnEndTable.AccessibleName = "End  Pay";
            btnEndTable.AutoSizeBasedOnText = false;
            btnEndTable.BackColor = Color.Transparent;
            btnEndTable.BadgeBackColor = Color.Black;
            btnEndTable.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnEndTable.BadgeValue = 0;
            btnEndTable.BadgeValueForeColor = Color.White;
            btnEndTable.BorderColor = Color.FromArgb(213, 216, 220);
            btnEndTable.BorderWidth = 1;
            btnEndTable.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnEndTable.ButtonImage = null;
            btnEndTable.ButtonTextLeftPadding = 0;
            btnEndTable.CanBeep = true;
            btnEndTable.CanGlow = false;
            btnEndTable.CanShake = true;
            btnEndTable.ContextMenuStripEx = null;
            btnEndTable.CornerRadiusBottomLeft = 6;
            btnEndTable.CornerRadiusBottomRight = 6;
            btnEndTable.CornerRadiusTopLeft = 6;
            btnEndTable.CornerRadiusTopRight = 6;
            btnEndTable.CustomCursor = Cursors.Default;
            btnEndTable.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnEndTable.EnableLongPress = false;
            btnEndTable.EnableRippleEffect = true;
            btnEndTable.EnableShadow = false;
            btnEndTable.EnableTextWrapping = false;
            btnEndTable.Font = new Font("Segoe UI Semibold", 10.2F);
            btnEndTable.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnEndTable.GlowIntensity = 100;
            btnEndTable.GlowRadius = 20F;
            btnEndTable.GradientBackground = false;
            btnEndTable.GradientColor = Color.FromArgb(0, 227, 64);
            btnEndTable.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnEndTable.HintText = null;
            btnEndTable.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnEndTable.HoverFontStyle = FontStyle.Regular;
            btnEndTable.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnEndTable.HoverTransitionDuration = 250;
            btnEndTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnEndTable.ImagePadding = 5;
            btnEndTable.ImageSize = new Size(16, 16);
            btnEndTable.IsRadial = false;
            btnEndTable.IsReadOnly = false;
            btnEndTable.IsToggleButton = false;
            btnEndTable.IsToggled = false;
            btnEndTable.Location = new Point(12, 517);
            btnEndTable.LongPressDurationMS = 1000;
            btnEndTable.Name = "btnEndTable";
            btnEndTable.NormalFontStyle = FontStyle.Regular;
            btnEndTable.ParticleColor = Color.FromArgb(200, 200, 200);
            btnEndTable.ParticleCount = 15;
            btnEndTable.PressAnimationScale = 0.97F;
            btnEndTable.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnEndTable.PressedFontStyle = FontStyle.Regular;
            btnEndTable.PressTransitionDuration = 150;
            btnEndTable.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnEndTable.RippleColor = Color.FromArgb(0, 0, 0);
            btnEndTable.RippleRadiusMultiplier = 0.6F;
            btnEndTable.ShadowBlur = 5;
            btnEndTable.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnEndTable.ShadowOffset = new Point(0, 2);
            btnEndTable.ShakeDuration = 500;
            btnEndTable.ShakeIntensity = 5;
            btnEndTable.Size = new Size(428, 33);
            btnEndTable.TabIndex = 13;
            btnEndTable.Text = "End & Pay";
            btnEndTable.TextAlign = ContentAlignment.MiddleCenter;
            btnEndTable.TextColor = Color.FromArgb(0, 0, 0);
            btnEndTable.TooltipText = null;
            btnEndTable.UseAdvancedRendering = true;
            btnEndTable.UseParticles = false;
            btnEndTable.Click += btnEndTable_Click;
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(12, 30);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(93, 20);
            lblAvailability.TabIndex = 10;
            lblAvailability.Text = "lblAvailability";
            // 
            // lblTblNumber
            // 
            lblTblNumber.AutoSize = true;
            lblTblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTblNumber.Location = new Point(12, 9);
            lblTblNumber.Name = "lblTblNumber";
            lblTblNumber.Size = new Size(117, 21);
            lblTblNumber.TabIndex = 9;
            lblTblNumber.Text = "lblTblNumber";
            // 
            // siticoneAdvancedPanel1
            // 
            siticoneAdvancedPanel1.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel1.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel1.AdvancedBorderStyle = SiticoneNetCoreUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            siticoneAdvancedPanel1.AnimationDuration = 500;
            siticoneAdvancedPanel1.AnimationType = SiticoneNetCoreUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel1.BackColor = Color.PaleGoldenrod;
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
            siticoneAdvancedPanel1.Controls.Add(label4);
            siticoneAdvancedPanel1.Controls.Add(btnExtend);
            siticoneAdvancedPanel1.Controls.Add(label3);
            siticoneAdvancedPanel1.Controls.Add(numMin);
            siticoneAdvancedPanel1.Controls.Add(label2);
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
            siticoneAdvancedPanel1.Location = new Point(12, 108);
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
            siticoneAdvancedPanel1.Size = new Size(428, 170);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 16;
            siticoneAdvancedPanel1.TopLeftRadius = 5;
            siticoneAdvancedPanel1.TopRightRadius = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 138);
            label4.Name = "label4";
            label4.Size = new Size(285, 15);
            label4.TabIndex = 20;
            label4.Text = "Queue will be automatically notified of the extension";
            // 
            // btnExtend
            // 
            btnExtend.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnExtend.AccessibleName = "Extend";
            btnExtend.AutoSizeBasedOnText = false;
            btnExtend.BackColor = Color.Transparent;
            btnExtend.BadgeBackColor = Color.Black;
            btnExtend.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnExtend.BadgeValue = 0;
            btnExtend.BadgeValueForeColor = Color.White;
            btnExtend.BorderColor = Color.FromArgb(213, 216, 220);
            btnExtend.BorderWidth = 1;
            btnExtend.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnExtend.ButtonImage = null;
            btnExtend.ButtonTextLeftPadding = 0;
            btnExtend.CanBeep = true;
            btnExtend.CanGlow = false;
            btnExtend.CanShake = true;
            btnExtend.ContextMenuStripEx = null;
            btnExtend.CornerRadiusBottomLeft = 6;
            btnExtend.CornerRadiusBottomRight = 6;
            btnExtend.CornerRadiusTopLeft = 6;
            btnExtend.CornerRadiusTopRight = 6;
            btnExtend.CustomCursor = Cursors.Default;
            btnExtend.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnExtend.EnableLongPress = false;
            btnExtend.EnableRippleEffect = true;
            btnExtend.EnableShadow = false;
            btnExtend.EnableTextWrapping = false;
            btnExtend.Font = new Font("Segoe UI Semibold", 10.2F);
            btnExtend.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnExtend.GlowIntensity = 100;
            btnExtend.GlowRadius = 20F;
            btnExtend.GradientBackground = false;
            btnExtend.GradientColor = Color.FromArgb(0, 227, 64);
            btnExtend.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnExtend.HintText = null;
            btnExtend.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnExtend.HoverFontStyle = FontStyle.Regular;
            btnExtend.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnExtend.HoverTransitionDuration = 250;
            btnExtend.ImageAlign = ContentAlignment.MiddleLeft;
            btnExtend.ImagePadding = 5;
            btnExtend.ImageSize = new Size(16, 16);
            btnExtend.IsRadial = false;
            btnExtend.IsReadOnly = false;
            btnExtend.IsToggleButton = false;
            btnExtend.IsToggled = false;
            btnExtend.Location = new Point(13, 93);
            btnExtend.LongPressDurationMS = 1000;
            btnExtend.Name = "btnExtend";
            btnExtend.NormalFontStyle = FontStyle.Regular;
            btnExtend.ParticleColor = Color.FromArgb(200, 200, 200);
            btnExtend.ParticleCount = 15;
            btnExtend.PressAnimationScale = 0.97F;
            btnExtend.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnExtend.PressedFontStyle = FontStyle.Regular;
            btnExtend.PressTransitionDuration = 150;
            btnExtend.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnExtend.RippleColor = Color.FromArgb(0, 0, 0);
            btnExtend.RippleRadiusMultiplier = 0.6F;
            btnExtend.ShadowBlur = 5;
            btnExtend.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnExtend.ShadowOffset = new Point(0, 2);
            btnExtend.ShakeDuration = 500;
            btnExtend.ShakeIntensity = 5;
            btnExtend.Size = new Size(402, 33);
            btnExtend.TabIndex = 19;
            btnExtend.Text = "Extend";
            btnExtend.TextAlign = ContentAlignment.MiddleCenter;
            btnExtend.TextColor = Color.FromArgb(0, 0, 0);
            btnExtend.TooltipText = null;
            btnExtend.UseAdvancedRendering = true;
            btnExtend.UseParticles = false;
            btnExtend.Click += btnExtend_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 40);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 16;
            label3.Text = "minutes";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblElapsedTime.Location = new Point(12, 71);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(107, 20);
            lblElapsedTime.TabIndex = 18;
            lblElapsedTime.Text = "lblElapsedTime";
            // 
            // pnlCurrentBill
            // 
            pnlCurrentBill.ActiveBackColor = Color.Empty;
            pnlCurrentBill.ActiveBorderColor = Color.Empty;
            pnlCurrentBill.AdvancedBorderStyle = SiticoneNetCoreUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            pnlCurrentBill.AnimationDuration = 500;
            pnlCurrentBill.AnimationType = SiticoneNetCoreUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            pnlCurrentBill.AutoScroll = true;
            pnlCurrentBill.BackColor = Color.White;
            pnlCurrentBill.BackgroundImageCustom = null;
            pnlCurrentBill.BackgroundImageOpacity = 1F;
            pnlCurrentBill.BackgroundImageSizeMode = SiticoneNetCoreUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            pnlCurrentBill.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            pnlCurrentBill.BorderColor = Color.Gray;
            pnlCurrentBill.BorderDashPattern = null;
            pnlCurrentBill.BorderGlowColor = Color.Cyan;
            pnlCurrentBill.BorderGlowSize = 3F;
            pnlCurrentBill.BorderWidth = 1F;
            pnlCurrentBill.BottomLeftRadius = 5;
            pnlCurrentBill.BottomRightRadius = 5;
            pnlCurrentBill.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            pnlCurrentBill.CornerPadding = new Padding(5);
            pnlCurrentBill.DisabledBackColor = Color.Empty;
            pnlCurrentBill.DisabledBorderColor = Color.Empty;
            pnlCurrentBill.DoubleBorderSpacing = 2F;
            pnlCurrentBill.EasingType = SiticoneNetCoreUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            pnlCurrentBill.EnableAnimation = false;
            pnlCurrentBill.EnableBackgroundImage = false;
            pnlCurrentBill.EnableBorderGlow = false;
            pnlCurrentBill.EnableDoubleBorder = false;
            pnlCurrentBill.EnableGradient = false;
            pnlCurrentBill.EnableInnerShadow = false;
            pnlCurrentBill.EnableShadow = false;
            pnlCurrentBill.EnableSmartPadding = true;
            pnlCurrentBill.EnableStateStyles = false;
            pnlCurrentBill.FlowDirectionCustom = FlowDirection.LeftToRight;
            pnlCurrentBill.GradientAngle = 90F;
            pnlCurrentBill.GradientEndColor = Color.LightGray;
            pnlCurrentBill.GradientStartColor = Color.White;
            pnlCurrentBill.GradientType = SiticoneNetCoreUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            pnlCurrentBill.HoverBackColor = Color.Empty;
            pnlCurrentBill.HoverBorderColor = Color.Empty;
            pnlCurrentBill.InnerShadowColor = Color.Black;
            pnlCurrentBill.InnerShadowDepth = 3;
            pnlCurrentBill.InnerShadowOpacity = 0.2F;
            pnlCurrentBill.Location = new Point(12, 299);
            pnlCurrentBill.Name = "pnlCurrentBill";
            pnlCurrentBill.Padding = new Padding(10);
            pnlCurrentBill.RadialGradientCenter = (PointF)resources.GetObject("pnlCurrentBill.RadialGradientCenter");
            pnlCurrentBill.RadialGradientRadius = 1F;
            pnlCurrentBill.ScaleRatio = 0.8F;
            pnlCurrentBill.SecondaryBorderColor = Color.DarkGray;
            pnlCurrentBill.ShadowBlur = 10;
            pnlCurrentBill.ShadowColor = Color.Black;
            pnlCurrentBill.ShadowDepth = 5;
            pnlCurrentBill.ShadowOffset = new Point(2, 2);
            pnlCurrentBill.ShadowOpacity = 0.3F;
            pnlCurrentBill.Size = new Size(428, 212);
            pnlCurrentBill.SlideDirection = new Point(0, -30);
            pnlCurrentBill.TabIndex = 19;
            pnlCurrentBill.TopLeftRadius = 5;
            pnlCurrentBill.TopRightRadius = 5;
            // 
            // OccupiedTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 562);
            Controls.Add(pnlCurrentBill);
            Controls.Add(lblElapsedTime);
            Controls.Add(siticoneAdvancedPanel1);
            Controls.Add(btnEndTable);
            Controls.Add(lblAvailability);
            Controls.Add(lblTblNumber);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OccupiedTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OccupiedTable";
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            siticoneAdvancedPanel1.ResumeLayout(false);
            siticoneAdvancedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMin;
        private Label label2;
        private SiticoneNetCoreUI.SiticoneButton btnEndTable;
        private Label lblAvailability;
        private Label lblTblNumber;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private Label lblElapsedTime;
        private Label label4;
        private SiticoneNetCoreUI.SiticoneButton btnExtend;
        private Label label3;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel pnlCurrentBill;
    }
}