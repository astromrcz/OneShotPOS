namespace OneShotPOS
{
    partial class AddQueue
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
            lblAvailability = new Label();
            lblTblNumber = new Label();
            label1 = new Label();
            txtCustomerName = new SiticoneNetCoreUI.SiticoneTextBox();
            label2 = new Label();
            txtGroupSize = new SiticoneNetCoreUI.SiticoneTextBox();
            label3 = new Label();
            txtPhoneNo = new SiticoneNetCoreUI.SiticoneTextBox();
            btnCancel = new SiticoneNetCoreUI.SiticoneButton();
            BtnAddQueue = new SiticoneNetCoreUI.SiticoneButton();
            SuspendLayout();
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(12, 30);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(234, 20);
            lblAvailability.TabIndex = 12;
            lblAvailability.Text = "Add a new customer to the waitlist";
            // 
            // lblTblNumber
            // 
            lblTblNumber.AutoSize = true;
            lblTblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTblNumber.Location = new Point(12, 9);
            lblTblNumber.Name = "lblTblNumber";
            lblTblNumber.Size = new Size(115, 21);
            lblTblNumber.TabIndex = 11;
            lblTblNumber.Text = "Add to Queue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 13;
            label1.Text = "Customer Name *";
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
            txtCustomerName.Location = new Point(12, 96);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderColor = Color.Gray;
            txtCustomerName.PlaceholderText = "Enter text here...";
            txtCustomerName.ReadOnlyBorderColor1 = Color.LightGray;
            txtCustomerName.ReadOnlyBorderColor2 = Color.LightGray;
            txtCustomerName.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtCustomerName.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtCustomerName.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtCustomerName.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtCustomerName.ShadowAnimationDuration = 1;
            txtCustomerName.ShadowBlur = 10;
            txtCustomerName.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            txtCustomerName.Size = new Size(477, 40);
            txtCustomerName.SolidBorderColor = Color.LightSlateGray;
            txtCustomerName.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtCustomerName.SolidBorderHoverColor = Color.Gray;
            txtCustomerName.SolidFillColor = Color.White;
            txtCustomerName.TabIndex = 14;
            txtCustomerName.TextPadding = new Padding(16, 0, 6, 0);
            txtCustomerName.ValidationErrorMessage = "Invalid input.";
            txtCustomerName.ValidationFunction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 226);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 15;
            label2.Text = "Group Size *";
            // 
            // txtGroupSize
            // 
            txtGroupSize.AccessibleDescription = "A customizable text input field.";
            txtGroupSize.AccessibleName = "Text Box";
            txtGroupSize.AccessibleRole = AccessibleRole.Text;
            txtGroupSize.BackColor = Color.Transparent;
            txtGroupSize.BlinkCount = 3;
            txtGroupSize.BlinkShadow = false;
            txtGroupSize.BorderColor1 = Color.LightSlateGray;
            txtGroupSize.BorderColor2 = Color.LightSlateGray;
            txtGroupSize.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            txtGroupSize.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            txtGroupSize.CanShake = true;
            txtGroupSize.ContinuousBlink = false;
            txtGroupSize.CursorBlinkRate = 500;
            txtGroupSize.CursorColor = Color.Black;
            txtGroupSize.CursorHeight = 26;
            txtGroupSize.CursorOffset = 0;
            txtGroupSize.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            txtGroupSize.CursorWidth = 1;
            txtGroupSize.DisabledBackColor = Color.WhiteSmoke;
            txtGroupSize.DisabledBorderColor = Color.LightGray;
            txtGroupSize.DisabledTextColor = Color.Gray;
            txtGroupSize.EnableDropShadow = false;
            txtGroupSize.FillColor1 = Color.White;
            txtGroupSize.FillColor2 = Color.White;
            txtGroupSize.Font = new Font("Segoe UI", 9.5F);
            txtGroupSize.ForeColor = Color.DimGray;
            txtGroupSize.HoverBorderColor1 = Color.Gray;
            txtGroupSize.HoverBorderColor2 = Color.Gray;
            txtGroupSize.IsEnabled = true;
            txtGroupSize.Location = new Point(12, 249);
            txtGroupSize.Name = "txtGroupSize";
            txtGroupSize.PlaceholderColor = Color.Gray;
            txtGroupSize.PlaceholderText = "Enter text here...";
            txtGroupSize.ReadOnlyBorderColor1 = Color.LightGray;
            txtGroupSize.ReadOnlyBorderColor2 = Color.LightGray;
            txtGroupSize.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtGroupSize.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtGroupSize.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtGroupSize.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtGroupSize.ShadowAnimationDuration = 1;
            txtGroupSize.ShadowBlur = 10;
            txtGroupSize.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            txtGroupSize.Size = new Size(171, 40);
            txtGroupSize.SolidBorderColor = Color.LightSlateGray;
            txtGroupSize.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtGroupSize.SolidBorderHoverColor = Color.Gray;
            txtGroupSize.SolidFillColor = Color.White;
            txtGroupSize.TabIndex = 16;
            txtGroupSize.TextPadding = new Padding(16, 0, 6, 0);
            txtGroupSize.ValidationErrorMessage = "Invalid input.";
            txtGroupSize.ValidationFunction = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 17;
            label3.Text = "Phone No*";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.AccessibleDescription = "A customizable text input field.";
            txtPhoneNo.AccessibleName = "Text Box";
            txtPhoneNo.AccessibleRole = AccessibleRole.Text;
            txtPhoneNo.BackColor = Color.Transparent;
            txtPhoneNo.BlinkCount = 3;
            txtPhoneNo.BlinkShadow = false;
            txtPhoneNo.BorderColor1 = Color.LightSlateGray;
            txtPhoneNo.BorderColor2 = Color.LightSlateGray;
            txtPhoneNo.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            txtPhoneNo.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            txtPhoneNo.CanShake = true;
            txtPhoneNo.ContinuousBlink = false;
            txtPhoneNo.CursorBlinkRate = 500;
            txtPhoneNo.CursorColor = Color.Black;
            txtPhoneNo.CursorHeight = 26;
            txtPhoneNo.CursorOffset = 0;
            txtPhoneNo.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            txtPhoneNo.CursorWidth = 1;
            txtPhoneNo.DisabledBackColor = Color.WhiteSmoke;
            txtPhoneNo.DisabledBorderColor = Color.LightGray;
            txtPhoneNo.DisabledTextColor = Color.Gray;
            txtPhoneNo.EnableDropShadow = false;
            txtPhoneNo.FillColor1 = Color.White;
            txtPhoneNo.FillColor2 = Color.White;
            txtPhoneNo.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNo.ForeColor = Color.DimGray;
            txtPhoneNo.HoverBorderColor1 = Color.Gray;
            txtPhoneNo.HoverBorderColor2 = Color.Gray;
            txtPhoneNo.IsEnabled = true;
            txtPhoneNo.Location = new Point(12, 172);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.PlaceholderColor = Color.Gray;
            txtPhoneNo.PlaceholderText = "Enter text here...";
            txtPhoneNo.ReadOnlyBorderColor1 = Color.LightGray;
            txtPhoneNo.ReadOnlyBorderColor2 = Color.LightGray;
            txtPhoneNo.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtPhoneNo.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtPhoneNo.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtPhoneNo.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtPhoneNo.ShadowAnimationDuration = 1;
            txtPhoneNo.ShadowBlur = 10;
            txtPhoneNo.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            txtPhoneNo.Size = new Size(477, 40);
            txtPhoneNo.SolidBorderColor = Color.LightSlateGray;
            txtPhoneNo.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtPhoneNo.SolidBorderHoverColor = Color.Gray;
            txtPhoneNo.SolidFillColor = Color.White;
            txtPhoneNo.TabIndex = 18;
            txtPhoneNo.TextPadding = new Padding(16, 0, 6, 0);
            txtPhoneNo.ValidationErrorMessage = "Invalid input.";
            txtPhoneNo.ValidationFunction = null;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnCancel.AccessibleName = "Cancel";
            btnCancel.AutoSizeBasedOnText = false;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BadgeBackColor = Color.Black;
            btnCancel.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCancel.BadgeValue = 0;
            btnCancel.BadgeValueForeColor = Color.White;
            btnCancel.BorderColor = Color.Silver;
            btnCancel.BorderWidth = 2;
            btnCancel.ButtonBackColor = Color.White;
            btnCancel.ButtonImage = null;
            btnCancel.ButtonTextLeftPadding = 0;
            btnCancel.CanBeep = true;
            btnCancel.CanGlow = false;
            btnCancel.CanShake = true;
            btnCancel.ContextMenuStripEx = null;
            btnCancel.CornerRadiusBottomLeft = 6;
            btnCancel.CornerRadiusBottomRight = 6;
            btnCancel.CornerRadiusTopLeft = 6;
            btnCancel.CornerRadiusTopRight = 6;
            btnCancel.CustomCursor = Cursors.Default;
            btnCancel.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnCancel.EnableLongPress = false;
            btnCancel.EnableRippleEffect = true;
            btnCancel.EnableShadow = true;
            btnCancel.EnableTextWrapping = false;
            btnCancel.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnCancel.GlowIntensity = 100;
            btnCancel.GlowRadius = 20F;
            btnCancel.GradientBackground = false;
            btnCancel.GradientColor = Color.FromArgb(0, 227, 64);
            btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnCancel.HintText = null;
            btnCancel.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnCancel.HoverFontStyle = FontStyle.Regular;
            btnCancel.HoverTextColor = Color.White;
            btnCancel.HoverTransitionDuration = 250;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.ImagePadding = 5;
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.IsRadial = false;
            btnCancel.IsReadOnly = false;
            btnCancel.IsToggleButton = false;
            btnCancel.IsToggled = false;
            btnCancel.Location = new Point(344, 312);
            btnCancel.LongPressDurationMS = 1000;
            btnCancel.Name = "btnCancel";
            btnCancel.NormalFontStyle = FontStyle.Regular;
            btnCancel.ParticleColor = Color.FromArgb(200, 200, 200);
            btnCancel.ParticleCount = 15;
            btnCancel.PressAnimationScale = 0.97F;
            btnCancel.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnCancel.PressedFontStyle = FontStyle.Regular;
            btnCancel.PressTransitionDuration = 150;
            btnCancel.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnCancel.RippleColor = Color.FromArgb(100, 100, 100);
            btnCancel.RippleOpacity = 0.3F;
            btnCancel.RippleRadiusMultiplier = 0.6F;
            btnCancel.ShadowBlur = 6;
            btnCancel.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnCancel.ShadowOffset = new Point(0, 2);
            btnCancel.ShakeDuration = 500;
            btnCancel.ShakeIntensity = 5;
            btnCancel.Size = new Size(145, 44);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextColor = Color.Black;
            btnCancel.TooltipText = null;
            btnCancel.UseAdvancedRendering = true;
            btnCancel.UseParticles = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // BtnAddQueue
            // 
            BtnAddQueue.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            BtnAddQueue.AccessibleName = "Add to Queue";
            BtnAddQueue.AutoSizeBasedOnText = false;
            BtnAddQueue.BackColor = Color.Transparent;
            BtnAddQueue.BadgeBackColor = Color.Black;
            BtnAddQueue.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            BtnAddQueue.BadgeValue = 0;
            BtnAddQueue.BadgeValueForeColor = Color.White;
            BtnAddQueue.BorderColor = Color.FromArgb(60, 60, 60);
            BtnAddQueue.BorderWidth = 2;
            BtnAddQueue.ButtonBackColor = Color.FromArgb(30, 30, 30);
            BtnAddQueue.ButtonImage = null;
            BtnAddQueue.ButtonTextLeftPadding = 0;
            BtnAddQueue.CanBeep = true;
            BtnAddQueue.CanGlow = false;
            BtnAddQueue.CanShake = true;
            BtnAddQueue.ContextMenuStripEx = null;
            BtnAddQueue.CornerRadiusBottomLeft = 6;
            BtnAddQueue.CornerRadiusBottomRight = 6;
            BtnAddQueue.CornerRadiusTopLeft = 6;
            BtnAddQueue.CornerRadiusTopRight = 6;
            BtnAddQueue.CustomCursor = Cursors.Default;
            BtnAddQueue.DisabledTextColor = Color.FromArgb(150, 150, 150);
            BtnAddQueue.EnableLongPress = false;
            BtnAddQueue.EnableRippleEffect = true;
            BtnAddQueue.EnableShadow = true;
            BtnAddQueue.EnableTextWrapping = false;
            BtnAddQueue.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddQueue.GlowColor = Color.FromArgb(30, 255, 255, 255);
            BtnAddQueue.GlowIntensity = 100;
            BtnAddQueue.GlowRadius = 20F;
            BtnAddQueue.GradientBackground = false;
            BtnAddQueue.GradientColor = Color.FromArgb(0, 227, 64);
            BtnAddQueue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            BtnAddQueue.HintText = null;
            BtnAddQueue.HoverBackColor = Color.FromArgb(50, 50, 50);
            BtnAddQueue.HoverFontStyle = FontStyle.Regular;
            BtnAddQueue.HoverTextColor = Color.White;
            BtnAddQueue.HoverTransitionDuration = 250;
            BtnAddQueue.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddQueue.ImagePadding = 5;
            BtnAddQueue.ImageSize = new Size(16, 16);
            BtnAddQueue.IsRadial = false;
            BtnAddQueue.IsReadOnly = false;
            BtnAddQueue.IsToggleButton = false;
            BtnAddQueue.IsToggled = false;
            BtnAddQueue.Location = new Point(12, 312);
            BtnAddQueue.LongPressDurationMS = 1000;
            BtnAddQueue.Name = "BtnAddQueue";
            BtnAddQueue.NormalFontStyle = FontStyle.Regular;
            BtnAddQueue.ParticleColor = Color.FromArgb(200, 200, 200);
            BtnAddQueue.ParticleCount = 15;
            BtnAddQueue.PressAnimationScale = 0.97F;
            BtnAddQueue.PressedBackColor = Color.FromArgb(40, 40, 40);
            BtnAddQueue.PressedFontStyle = FontStyle.Regular;
            BtnAddQueue.PressTransitionDuration = 150;
            BtnAddQueue.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            BtnAddQueue.RippleColor = Color.FromArgb(100, 100, 100);
            BtnAddQueue.RippleOpacity = 0.3F;
            BtnAddQueue.RippleRadiusMultiplier = 0.6F;
            BtnAddQueue.ShadowBlur = 6;
            BtnAddQueue.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            BtnAddQueue.ShadowOffset = new Point(0, 2);
            BtnAddQueue.ShakeDuration = 500;
            BtnAddQueue.ShakeIntensity = 5;
            BtnAddQueue.Size = new Size(326, 44);
            BtnAddQueue.TabIndex = 19;
            BtnAddQueue.Text = "Add to Queue";
            BtnAddQueue.TextAlign = ContentAlignment.MiddleCenter;
            BtnAddQueue.TextColor = Color.White;
            BtnAddQueue.TooltipText = null;
            BtnAddQueue.UseAdvancedRendering = true;
            BtnAddQueue.UseParticles = false;
            BtnAddQueue.Click += BtnAddQueue_Click;
            // 
            // AddQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 368);
            Controls.Add(btnCancel);
            Controls.Add(BtnAddQueue);
            Controls.Add(txtPhoneNo);
            Controls.Add(label3);
            Controls.Add(txtGroupSize);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(lblAvailability);
            Controls.Add(lblTblNumber);
            Name = "AddQueue";
            Text = "AddQueue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAvailability;
        private Label lblTblNumber;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneTextBox txtCustomerName;
        private Label label2;
        private SiticoneNetCoreUI.SiticoneTextBox txtGroupSize;
        private Label label3;
        private SiticoneNetCoreUI.SiticoneTextBox txtPhoneNo;
        private SiticoneNetCoreUI.SiticoneButton btnCancel;
        private SiticoneNetCoreUI.SiticoneButton BtnAddQueue;
    }
}