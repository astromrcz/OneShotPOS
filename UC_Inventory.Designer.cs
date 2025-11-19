namespace OneShotPOS
{
    partial class UC_Inventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvInventory;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            label2 = new Label();
            label3 = new Label();
            btnAddItem = new SiticoneNetCoreUI.SiticoneButton();
            InventoryPanel = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            lblInventoryItems = new Label();
            siticoneAdvancedPanel1 = new SiticoneNetCoreUI.SiticoneAdvancedPanel();
            siticoneDropdown1 = new SiticoneNetCoreUI.SiticoneDropdown();
            siticoneTextBox1 = new SiticoneNetCoreUI.SiticoneTextBox();
            InventoryPanel.SuspendLayout();
            siticoneAdvancedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(253, 21);
            label2.TabIndex = 3;
            label2.Text = "Track and Manage your Stock Levels.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 26);
            label3.Name = "label3";
            label3.Size = new Size(202, 30);
            label3.TabIndex = 2;
            label3.Text = "Inventory Manager";
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
            btnAddItem.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "+ Add Item";
            btnAddItem.TextAlign = ContentAlignment.MiddleCenter;
            btnAddItem.TextColor = Color.White;
            btnAddItem.TooltipText = null;
            btnAddItem.UseAdvancedRendering = true;
            btnAddItem.UseParticles = false;
            // 
            // InventoryPanel
            // 
            InventoryPanel.ActiveBackColor = Color.Empty;
            InventoryPanel.ActiveBorderColor = Color.Empty;
            InventoryPanel.AdvancedBorderStyle = SiticoneNetCoreUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            InventoryPanel.AnimationDuration = 500;
            InventoryPanel.AnimationType = SiticoneNetCoreUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            InventoryPanel.BackColor = Color.White;
            InventoryPanel.BackgroundImageCustom = null;
            InventoryPanel.BackgroundImageOpacity = 1F;
            InventoryPanel.BackgroundImageSizeMode = SiticoneNetCoreUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            InventoryPanel.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            InventoryPanel.BorderColor = Color.Gray;
            InventoryPanel.BorderDashPattern = null;
            InventoryPanel.BorderGlowColor = Color.Cyan;
            InventoryPanel.BorderGlowSize = 3F;
            InventoryPanel.BorderWidth = 1F;
            InventoryPanel.BottomLeftRadius = 5;
            InventoryPanel.BottomRightRadius = 5;
            InventoryPanel.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            InventoryPanel.Controls.Add(lblInventoryItems);
            InventoryPanel.CornerPadding = new Padding(5);
            InventoryPanel.DisabledBackColor = Color.Empty;
            InventoryPanel.DisabledBorderColor = Color.Empty;
            InventoryPanel.DoubleBorderSpacing = 2F;
            InventoryPanel.EasingType = SiticoneNetCoreUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            InventoryPanel.EnableAnimation = false;
            InventoryPanel.EnableBackgroundImage = false;
            InventoryPanel.EnableBorderGlow = false;
            InventoryPanel.EnableDoubleBorder = false;
            InventoryPanel.EnableGradient = false;
            InventoryPanel.EnableInnerShadow = false;
            InventoryPanel.EnableShadow = false;
            InventoryPanel.EnableSmartPadding = true;
            InventoryPanel.EnableStateStyles = false;
            InventoryPanel.FlowDirectionCustom = FlowDirection.LeftToRight;
            InventoryPanel.GradientAngle = 90F;
            InventoryPanel.GradientEndColor = Color.LightGray;
            InventoryPanel.GradientStartColor = Color.White;
            InventoryPanel.GradientType = SiticoneNetCoreUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            InventoryPanel.HoverBackColor = Color.Empty;
            InventoryPanel.HoverBorderColor = Color.Empty;
            InventoryPanel.InnerShadowColor = Color.Black;
            InventoryPanel.InnerShadowDepth = 3;
            InventoryPanel.InnerShadowOpacity = 0.2F;
            InventoryPanel.Location = new Point(44, 220);
            InventoryPanel.Name = "InventoryPanel";
            InventoryPanel.Padding = new Padding(10);
            InventoryPanel.RadialGradientCenter = (PointF)resources.GetObject("InventoryPanel.RadialGradientCenter");
            InventoryPanel.RadialGradientRadius = 1F;
            InventoryPanel.ScaleRatio = 0.8F;
            InventoryPanel.SecondaryBorderColor = Color.DarkGray;
            InventoryPanel.ShadowBlur = 10;
            InventoryPanel.ShadowColor = Color.Black;
            InventoryPanel.ShadowDepth = 5;
            InventoryPanel.ShadowOffset = new Point(2, 2);
            InventoryPanel.ShadowOpacity = 0.3F;
            InventoryPanel.Size = new Size(1604, 775);
            InventoryPanel.SlideDirection = new Point(0, -30);
            InventoryPanel.TabIndex = 7;
            InventoryPanel.TopLeftRadius = 5;
            InventoryPanel.TopRightRadius = 5;
            // 
            // lblInventoryItems
            // 
            lblInventoryItems.AutoSize = true;
            lblInventoryItems.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryItems.Location = new Point(13, 30);
            lblInventoryItems.Name = "lblInventoryItems";
            lblInventoryItems.Size = new Size(141, 26);
            lblInventoryItems.TabIndex = 2;
            lblInventoryItems.Text = "Inventory Items";
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
            siticoneAdvancedPanel1.Controls.Add(siticoneDropdown1);
            siticoneAdvancedPanel1.Controls.Add(siticoneTextBox1);
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
            siticoneAdvancedPanel1.Location = new Point(44, 117);
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
            siticoneAdvancedPanel1.Size = new Size(1604, 87);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 11;
            siticoneAdvancedPanel1.TopLeftRadius = 5;
            siticoneAdvancedPanel1.TopRightRadius = 5;
            // 
            // siticoneDropdown1
            // 
            siticoneDropdown1.AllowMultipleSelection = false;
            siticoneDropdown1.BackColor = Color.FromArgb(240, 245, 255);
            siticoneDropdown1.BorderColor = Color.FromArgb(100, 150, 220);
            siticoneDropdown1.CanBeep = false;
            siticoneDropdown1.CanShake = true;
            siticoneDropdown1.CornerRadius = 13;
            siticoneDropdown1.DataSource = null;
            siticoneDropdown1.DisplayMember = null;
            siticoneDropdown1.DropdownBackColor = Color.FromArgb(245, 250, 255);
            siticoneDropdown1.DropdownWidth = 0;
            siticoneDropdown1.DropShadowEnabled = false;
            siticoneDropdown1.Font = new Font("Segoe UI", 10F);
            siticoneDropdown1.ForeColor = Color.FromArgb(40, 40, 100);
            siticoneDropdown1.HoveredItemBackColor = Color.FromArgb(220, 235, 255);
            siticoneDropdown1.HoveredItemTextColor = Color.FromArgb(40, 40, 100);
            siticoneDropdown1.IsReadonly = false;
            siticoneDropdown1.ItemHeight = 30;
            siticoneDropdown1.Location = new Point(1339, 23);
            siticoneDropdown1.MaxDropDownItems = 8;
            siticoneDropdown1.Name = "siticoneDropdown1";
            siticoneDropdown1.PlaceholderColor = Color.FromArgb(150, 170, 200);
            siticoneDropdown1.PlaceholderDisappearsOnFocus = false;
            siticoneDropdown1.PlaceholderText = "Select an option";
            siticoneDropdown1.SelectedIndex = -1;
            siticoneDropdown1.SelectedItem = null;
            siticoneDropdown1.SelectedItemBackColor = Color.Black;
            siticoneDropdown1.SelectedItemTextColor = Color.White;
            siticoneDropdown1.SelectedValue = null;
            siticoneDropdown1.Size = new Size(252, 40);
            siticoneDropdown1.TabIndex = 1;
            siticoneDropdown1.Text = "siticoneDropdown1";
            siticoneDropdown1.UnselectedItemTextColor = Color.FromArgb(40, 40, 100);
            siticoneDropdown1.ValueMember = null;
            // 
            // siticoneTextBox1
            // 
            siticoneTextBox1.AccessibleDescription = "A customizable text input field.";
            siticoneTextBox1.AccessibleName = "Text Box";
            siticoneTextBox1.AccessibleRole = AccessibleRole.Text;
            siticoneTextBox1.BackColor = Color.Transparent;
            siticoneTextBox1.BlinkCount = 3;
            siticoneTextBox1.BlinkShadow = false;
            siticoneTextBox1.BorderColor1 = Color.LightSlateGray;
            siticoneTextBox1.BorderColor2 = Color.LightSlateGray;
            siticoneTextBox1.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.CanShake = true;
            siticoneTextBox1.ContinuousBlink = false;
            siticoneTextBox1.CornerRadiusBottomLeft = 13;
            siticoneTextBox1.CornerRadiusBottomRight = 13;
            siticoneTextBox1.CornerRadiusTopLeft = 13;
            siticoneTextBox1.CornerRadiusTopRight = 13;
            siticoneTextBox1.CursorBlinkRate = 500;
            siticoneTextBox1.CursorColor = Color.Black;
            siticoneTextBox1.CursorHeight = 26;
            siticoneTextBox1.CursorOffset = 0;
            siticoneTextBox1.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            siticoneTextBox1.CursorWidth = 1;
            siticoneTextBox1.DisabledBackColor = Color.WhiteSmoke;
            siticoneTextBox1.DisabledBorderColor = Color.LightGray;
            siticoneTextBox1.DisabledTextColor = Color.Gray;
            siticoneTextBox1.EnableDropShadow = false;
            siticoneTextBox1.FillColor1 = Color.White;
            siticoneTextBox1.FillColor2 = Color.White;
            siticoneTextBox1.Font = new Font("Segoe UI", 9.5F);
            siticoneTextBox1.ForeColor = Color.DimGray;
            siticoneTextBox1.HoverBorderColor1 = Color.Gray;
            siticoneTextBox1.HoverBorderColor2 = Color.Gray;
            siticoneTextBox1.IsEnabled = true;
            siticoneTextBox1.Location = new Point(14, 23);
            siticoneTextBox1.Name = "siticoneTextBox1";
            siticoneTextBox1.PlaceholderColor = Color.Gray;
            siticoneTextBox1.PlaceholderText = "Search Products...";
            siticoneTextBox1.ReadOnlyBorderColor1 = Color.LightGray;
            siticoneTextBox1.ReadOnlyBorderColor2 = Color.LightGray;
            siticoneTextBox1.ReadOnlyFillColor1 = Color.WhiteSmoke;
            siticoneTextBox1.ReadOnlyFillColor2 = Color.WhiteSmoke;
            siticoneTextBox1.ReadOnlyPlaceholderColor = Color.DarkGray;
            siticoneTextBox1.SelectionBackColor = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.ShadowAnimationDuration = 1;
            siticoneTextBox1.ShadowBlur = 10;
            siticoneTextBox1.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            siticoneTextBox1.Size = new Size(1306, 40);
            siticoneTextBox1.SolidBorderColor = Color.LightSlateGray;
            siticoneTextBox1.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.SolidBorderHoverColor = Color.Gray;
            siticoneTextBox1.SolidFillColor = Color.White;
            siticoneTextBox1.TabIndex = 0;
            siticoneTextBox1.TextPadding = new Padding(16, 0, 6, 0);
            siticoneTextBox1.ValidationErrorMessage = "Invalid input.";
            siticoneTextBox1.ValidationFunction = null;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneAdvancedPanel1);
            Controls.Add(InventoryPanel);
            Controls.Add(btnAddItem);
            Controls.Add(label2);
            Controls.Add(label3);
            Margin = new Padding(0);
            Name = "UC_Inventory";
            Size = new Size(1700, 1041);
            Load += UC_Inventory_Load;
            InventoryPanel.ResumeLayout(false);
            InventoryPanel.PerformLayout();
            siticoneAdvancedPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private SiticoneNetCoreUI.SiticoneButton btnAddItem;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel InventoryPanel;
        private Label lblInventoryItems;
        private SiticoneNetCoreUI.SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private SiticoneNetCoreUI.SiticoneDropdown siticoneDropdown1;
        private SiticoneNetCoreUI.SiticoneTextBox siticoneTextBox1;
    }
}
