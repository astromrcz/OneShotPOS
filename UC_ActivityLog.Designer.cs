namespace OneShotPOS
{
    partial class UC_ActivityLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ActivityLog));
            label2 = new Label();
            label1 = new Label();
            panelActivityTimeline = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            lblActivityTimeline = new Label();
            panelActivityTimeline.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(282, 21);
            label2.TabIndex = 11;
            label2.Text = "Track all system activities and user actions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 10;
            label1.Text = "Activity Log";
            // 
            // panelActivityTimeline
            // 
            panelActivityTimeline.ActiveBackColor = Color.Empty;
            panelActivityTimeline.ActiveBorderColor = Color.Empty;
            panelActivityTimeline.AdvancedBorderStyle = SiticoneNetCoreUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            panelActivityTimeline.AnimationDuration = 500;
            panelActivityTimeline.AnimationType = SiticoneNetCoreUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            panelActivityTimeline.BackColor = Color.White;
            panelActivityTimeline.BackgroundImageCustom = null;
            panelActivityTimeline.BackgroundImageOpacity = 1F;
            panelActivityTimeline.BackgroundImageSizeMode = SiticoneNetCoreUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            panelActivityTimeline.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            panelActivityTimeline.BorderColor = Color.Gray;
            panelActivityTimeline.BorderDashPattern = null;
            panelActivityTimeline.BorderGlowColor = Color.Cyan;
            panelActivityTimeline.BorderGlowSize = 3F;
            panelActivityTimeline.BorderWidth = 1F;
            panelActivityTimeline.BottomLeftRadius = 5;
            panelActivityTimeline.BottomRightRadius = 5;
            panelActivityTimeline.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            panelActivityTimeline.Controls.Add(lblActivityTimeline);
            panelActivityTimeline.CornerPadding = new Padding(5);
            panelActivityTimeline.DisabledBackColor = Color.Empty;
            panelActivityTimeline.DisabledBorderColor = Color.Empty;
            panelActivityTimeline.DoubleBorderSpacing = 2F;
            panelActivityTimeline.EasingType = SiticoneNetCoreUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            panelActivityTimeline.EnableAnimation = false;
            panelActivityTimeline.EnableBackgroundImage = false;
            panelActivityTimeline.EnableBorderGlow = false;
            panelActivityTimeline.EnableDoubleBorder = false;
            panelActivityTimeline.EnableGradient = false;
            panelActivityTimeline.EnableInnerShadow = false;
            panelActivityTimeline.EnableShadow = false;
            panelActivityTimeline.EnableSmartPadding = true;
            panelActivityTimeline.EnableStateStyles = false;
            panelActivityTimeline.FlowDirectionCustom = FlowDirection.LeftToRight;
            panelActivityTimeline.GradientAngle = 90F;
            panelActivityTimeline.GradientEndColor = Color.LightGray;
            panelActivityTimeline.GradientStartColor = Color.White;
            panelActivityTimeline.GradientType = SiticoneNetCoreUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            panelActivityTimeline.HoverBackColor = Color.Empty;
            panelActivityTimeline.HoverBorderColor = Color.Empty;
            panelActivityTimeline.InnerShadowColor = Color.Black;
            panelActivityTimeline.InnerShadowDepth = 3;
            panelActivityTimeline.InnerShadowOpacity = 0.2F;
            panelActivityTimeline.Location = new Point(44, 96);
            panelActivityTimeline.Name = "panelActivityTimeline";
            panelActivityTimeline.Padding = new Padding(10);
            panelActivityTimeline.RadialGradientCenter = (PointF)resources.GetObject("panelActivityTimeline.RadialGradientCenter");
            panelActivityTimeline.RadialGradientRadius = 1F;
            panelActivityTimeline.ScaleRatio = 0.8F;
            panelActivityTimeline.SecondaryBorderColor = Color.DarkGray;
            panelActivityTimeline.ShadowBlur = 10;
            panelActivityTimeline.ShadowColor = Color.Black;
            panelActivityTimeline.ShadowDepth = 5;
            panelActivityTimeline.ShadowOffset = new Point(2, 2);
            panelActivityTimeline.ShadowOpacity = 0.3F;
            panelActivityTimeline.Size = new Size(1604, 903);
            panelActivityTimeline.SlideDirection = new Point(0, -30);
            panelActivityTimeline.TabIndex = 13;
            panelActivityTimeline.TopLeftRadius = 5;
            panelActivityTimeline.TopRightRadius = 5;
            // 
            // lblActivityTimeline
            // 
            lblActivityTimeline.AutoSize = true;
            lblActivityTimeline.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActivityTimeline.Location = new Point(14, 38);
            lblActivityTimeline.Name = "lblActivityTimeline";
            lblActivityTimeline.Size = new Size(166, 25);
            lblActivityTimeline.TabIndex = 1;
            lblActivityTimeline.Text = "lblActivityTimeline";
            // 
            // UC_ActivityLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelActivityTimeline);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_ActivityLog";
            Size = new Size(1651, 1002);
            Load += UC_ActivityLog_Load;
            panelActivityTimeline.ResumeLayout(false);
            panelActivityTimeline.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel panelActivityTimeline;
        private Label lblActivityTimeline;
    }
}
