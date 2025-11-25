namespace OneShotPOS
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            dropTables = new SiticoneNetCoreUI.SiticoneDropdown();
            label4 = new Label();
            txtCustomerName = new SiticoneNetCoreUI.SiticoneTextBox();
            label5 = new Label();
            txtPhoneNum = new SiticoneNetCoreUI.SiticoneTextBox();
            label6 = new Label();
            dtpReservation = new SiticoneNetCoreUI.SiticoneDateTimePicker();
            btnCancel = new SiticoneNetCoreUI.SiticoneButton();
            btnCreateReservation = new SiticoneNetCoreUI.SiticoneButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 6;
            label2.Text = "Reserve a table for a customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 5;
            label1.Text = "Create Reservation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 7;
            label3.Text = "Select Table";
            // 
            // dropTables
            // 
            dropTables.AllowMultipleSelection = false;
            dropTables.BackColor = Color.FromArgb(240, 245, 255);
            dropTables.BorderColor = Color.FromArgb(100, 150, 220);
            dropTables.CanBeep = false;
            dropTables.CanShake = true;
            dropTables.DataSource = null;
            dropTables.DisplayMember = null;
            dropTables.DropdownBackColor = Color.FromArgb(245, 250, 255);
            dropTables.DropdownWidth = 0;
            dropTables.DropShadowEnabled = false;
            dropTables.Font = new Font("Segoe UI", 10F);
            dropTables.ForeColor = Color.FromArgb(40, 40, 100);
            dropTables.HoveredItemBackColor = Color.FromArgb(220, 235, 255);
            dropTables.HoveredItemTextColor = Color.FromArgb(40, 40, 100);
            dropTables.IsReadonly = false;
            dropTables.ItemHeight = 30;
            dropTables.Location = new Point(12, 119);
            dropTables.MaxDropDownItems = 8;
            dropTables.Name = "dropTables";
            dropTables.PlaceholderColor = Color.FromArgb(150, 170, 200);
            dropTables.PlaceholderDisappearsOnFocus = false;
            dropTables.PlaceholderText = "Select an option";
            dropTables.SelectedIndex = -1;
            dropTables.SelectedItem = null;
            dropTables.SelectedItemBackColor = Color.FromArgb(70, 130, 220);
            dropTables.SelectedItemTextColor = Color.White;
            dropTables.SelectedValue = null;
            dropTables.Size = new Size(377, 40);
            dropTables.TabIndex = 8;
            dropTables.Text = "siticoneDropdown1";
            dropTables.UnselectedItemTextColor = Color.FromArgb(40, 40, 100);
            dropTables.ValueMember = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 9;
            label4.Text = "Customer Name *";
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
            txtCustomerName.Location = new Point(12, 194);
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
            txtCustomerName.Size = new Size(377, 40);
            txtCustomerName.SolidBorderColor = Color.LightSlateGray;
            txtCustomerName.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtCustomerName.SolidBorderHoverColor = Color.Gray;
            txtCustomerName.SolidFillColor = Color.White;
            txtCustomerName.TabIndex = 10;
            txtCustomerName.Text = "Enter Customer name...";
            txtCustomerName.TextPadding = new Padding(16, 0, 6, 0);
            txtCustomerName.ValidationErrorMessage = "Invalid input.";
            txtCustomerName.ValidationFunction = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 11;
            label5.Text = "Phone Number *";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.AccessibleDescription = "A customizable text input field.";
            txtPhoneNum.AccessibleName = "Text Box";
            txtPhoneNum.AccessibleRole = AccessibleRole.Text;
            txtPhoneNum.BackColor = Color.Transparent;
            txtPhoneNum.BlinkCount = 3;
            txtPhoneNum.BlinkShadow = false;
            txtPhoneNum.BorderColor1 = Color.LightSlateGray;
            txtPhoneNum.BorderColor2 = Color.LightSlateGray;
            txtPhoneNum.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            txtPhoneNum.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            txtPhoneNum.CanShake = true;
            txtPhoneNum.ContinuousBlink = false;
            txtPhoneNum.CursorBlinkRate = 500;
            txtPhoneNum.CursorColor = Color.Black;
            txtPhoneNum.CursorHeight = 26;
            txtPhoneNum.CursorOffset = 0;
            txtPhoneNum.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            txtPhoneNum.CursorWidth = 1;
            txtPhoneNum.DisabledBackColor = Color.WhiteSmoke;
            txtPhoneNum.DisabledBorderColor = Color.LightGray;
            txtPhoneNum.DisabledTextColor = Color.Gray;
            txtPhoneNum.EnableDropShadow = false;
            txtPhoneNum.FillColor1 = Color.White;
            txtPhoneNum.FillColor2 = Color.White;
            txtPhoneNum.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNum.ForeColor = Color.DimGray;
            txtPhoneNum.HoverBorderColor1 = Color.Gray;
            txtPhoneNum.HoverBorderColor2 = Color.Gray;
            txtPhoneNum.IsEnabled = true;
            txtPhoneNum.Location = new Point(12, 270);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PlaceholderColor = Color.Gray;
            txtPhoneNum.PlaceholderText = "Enter text here...";
            txtPhoneNum.ReadOnlyBorderColor1 = Color.LightGray;
            txtPhoneNum.ReadOnlyBorderColor2 = Color.LightGray;
            txtPhoneNum.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtPhoneNum.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtPhoneNum.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtPhoneNum.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtPhoneNum.ShadowAnimationDuration = 1;
            txtPhoneNum.ShadowBlur = 10;
            txtPhoneNum.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            txtPhoneNum.Size = new Size(377, 40);
            txtPhoneNum.SolidBorderColor = Color.LightSlateGray;
            txtPhoneNum.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            txtPhoneNum.SolidBorderHoverColor = Color.Gray;
            txtPhoneNum.SolidFillColor = Color.White;
            txtPhoneNum.TabIndex = 12;
            txtPhoneNum.Text = "Enter Phone number...";
            txtPhoneNum.TextPadding = new Padding(16, 0, 6, 0);
            txtPhoneNum.ValidationErrorMessage = "Invalid input.";
            txtPhoneNum.ValidationFunction = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 13;
            label6.Text = "Reservation Time *";
            // 
            // dtpReservation
            // 
            dtpReservation.AutoScaleFonts = true;
            dtpReservation.BackColor = Color.Transparent;
            dtpReservation.BaseCalendarFormSize = new Size(535, 460);
            dtpReservation.BorderColor = Color.Gray;
            dtpReservation.BorderWidth = 2;
            dtpReservation.BottomLeftBorderRadius = 22;
            dtpReservation.BottomRightBorderRadius = 22;
            dtpReservation.CalendarBackgroundColor = Color.White;
            dtpReservation.CalendarChevronColor = Color.Gray;
            dtpReservation.CalendarChevronHoverColor = Color.Blue;
            dtpReservation.CalendarDayButtonBackColor = Color.White;
            dtpReservation.CalendarDayButtonForeColor = Color.Black;
            dtpReservation.CalendarDayHeaderBackColor = Color.White;
            dtpReservation.CalendarDayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpReservation.CalendarDayLabelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpReservation.CalendarDisabledDateBackColor = Color.LightGray;
            dtpReservation.CalendarDisabledDateForeColor = Color.DarkGray;
            dtpReservation.CalendarFormAnimationSpeed = 15;
            dtpReservation.CalendarFormAnimationStep = 0.08D;
            dtpReservation.CalendarFormBackColor = Color.White;
            dtpReservation.CalendarFormBorderColor = Color.FromArgb(220, 220, 220);
            dtpReservation.CalendarFormBorderWidth = 2;
            dtpReservation.CalendarFormCornerRadius = 2;
            dtpReservation.CalendarFormFadeOutStep = 0.1D;
            dtpReservation.CalendarFormHeight = 460;
            dtpReservation.CalendarFormShadowColor = Color.FromArgb(50, 0, 0, 0);
            dtpReservation.CalendarFormShadowDepth = 5;
            dtpReservation.CalendarFormWidth = 535;
            dtpReservation.CalendarGridMargin = new Padding(8);
            dtpReservation.CalendarGridPadding = new Padding(5);
            dtpReservation.CalendarLockedDateBackColor = Color.LightGray;
            dtpReservation.CalendarLockedDateForeColor = Color.DarkGray;
            dtpReservation.CalendarLockedDates = (List<DateTime>)resources.GetObject("dtpReservation.CalendarLockedDates");
            dtpReservation.CalendarMargin = 5;
            dtpReservation.CalendarMaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpReservation.CalendarMaxYear = 2125;
            dtpReservation.CalendarMinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpReservation.CalendarMinYear = 1925;
            dtpReservation.CalendarRangeDateBackColor = Color.LightBlue;
            dtpReservation.CalendarRangeEndDateBackColor = Color.DodgerBlue;
            dtpReservation.CalendarRangeSelectedForeColor = Color.Black;
            dtpReservation.CalendarRangeStartDateBackColor = Color.DodgerBlue;
            dtpReservation.CalendarSelectedDateBackColor = Color.Black;
            dtpReservation.CalendarSelectedDateForeColor = Color.White;
            dtpReservation.CalendarSelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpReservation.CalendarTodayBackColor = Color.White;
            dtpReservation.CalendarTodayForeColor = Color.Black;
            dtpReservation.CalendarYearPickerHeight = 10;
            dtpReservation.CanBeep = true;
            dtpReservation.CanShake = true;
            dtpReservation.ChevronColor = Color.Gray;
            dtpReservation.ChevronHoverBackColor = Color.FromArgb(220, 225, 245);
            dtpReservation.ChevronHoverColor = Color.Black;
            dtpReservation.ChevronPanelBorderRadius = 16;
            dtpReservation.ChevronPanelHeight = 32;
            dtpReservation.ChevronPenThickness = 1.8F;
            dtpReservation.ChevronRightMargin = 18;
            dtpReservation.ChevronSize = new Size(9, 14);
            dtpReservation.ChevronStep = 15F;
            dtpReservation.ChevronTimerInterval = 15;
            dtpReservation.ClearIconColor = Color.Gray;
            dtpReservation.ClearIconHoverColor = Color.Red;
            dtpReservation.ClearIconRightMargin = 48;
            dtpReservation.ClearIconSize = 11;
            dtpReservation.ContainerPanelMargin = new Padding(5);
            dtpReservation.ContainerPanelPadding = new Padding(0);
            dtpReservation.CustomDateFormat = "d";
            dtpReservation.CustomDateFormatter = null;
            dtpReservation.DateFormat = SiticoneNetCoreUI.DateFormat.LongDate;
            dtpReservation.DayButtonBorderRadius = 16;
            dtpReservation.DayButtonClickBackColor = Color.FromArgb(220, 230, 250);
            dtpReservation.DayButtonFont = new Font("Segoe UI", 10.5F);
            dtpReservation.DayButtonHoverBackColor = Color.FromArgb(235, 240, 255);
            dtpReservation.DayButtonHoverForeColor = Color.Black;
            dtpReservation.DayButtonMargin = new Padding(3);
            dtpReservation.DayButtonRowHeight = 16.66F;
            dtpReservation.DayHeaderFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpReservation.DayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpReservation.DayHeaderMargin = new Padding(1, 1, 1, 8);
            dtpReservation.DayHeaderRowHeight = 30F;
            dtpReservation.DisabledDayFont = new Font("Segoe UI", 10F, FontStyle.Italic);
            dtpReservation.DropdownBackColor = Color.White;
            dtpReservation.DropdownFont = new Font("Segoe UI", 11F);
            dtpReservation.DropdownHeight = 250;
            dtpReservation.FillColor = Color.White;
            dtpReservation.FirstDayOfWeek = DayOfWeek.Sunday;
            dtpReservation.Font = new Font("Segoe UI", 10F);
            dtpReservation.ForeColor = Color.DimGray;
            dtpReservation.GradientEndColor = Color.Gray;
            dtpReservation.GradientStartColor = Color.White;
            dtpReservation.HighlightWeekends = true;
            dtpReservation.IconSize = 16;
            dtpReservation.IsReadonly = false;
            dtpReservation.Location = new Point(12, 348);
            dtpReservation.LockedDates = (List<DateTime>)resources.GetObject("dtpReservation.LockedDates");
            dtpReservation.MakeRadial = true;
            dtpReservation.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpReservation.MaxFontScale = 1.8F;
            dtpReservation.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpReservation.MinFontScale = 0.4F;
            dtpReservation.MinimumFormSize = new Size(150, 150);
            dtpReservation.MonthChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpReservation.MonthChevronSpacing = 5;
            dtpReservation.MonthComboBoxMargin = new Padding(0, 17, 5, 0);
            dtpReservation.MonthComboBoxSize = new Size(130, 30);
            dtpReservation.Name = "dtpReservation";
            dtpReservation.NavigationFlowPadding = new Padding(12, 0, 12, 0);
            dtpReservation.NavigationPanelBackColor = Color.FromArgb(245, 245, 250);
            dtpReservation.NavigationPanelHeight = 65;
            dtpReservation.NextMonthPanelWidth = 34;
            dtpReservation.NextYearPanelWidth = 40;
            dtpReservation.PlaceholderText = "Select a date, dates or range...";
            dtpReservation.PrevMonthPanelWidth = 34;
            dtpReservation.PrevYearPanelWidth = 40;
            dtpReservation.RangeStartEndCornerRadius = 16;
            dtpReservation.ReadonlyBorderColor = Color.Gray;
            dtpReservation.ReadonlyFillColor = Color.LightGray;
            dtpReservation.ReadOnlyForeColor = Color.DarkGray;
            dtpReservation.ReadonlyPlaceHolderColor = Color.DarkGray;
            dtpReservation.SelectedDate = null;
            dtpReservation.SelectedDateBorderColor = Color.Black;
            dtpReservation.SelectedDateBorderThickness = 1F;
            dtpReservation.SelectedDates = (List<DateTime>)resources.GetObject("dtpReservation.SelectedDates");
            dtpReservation.SelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpReservation.ShakeAmplitude = 4;
            dtpReservation.ShakeTimerInterval = 30;
            dtpReservation.ShakeTotalShakes = 8;
            dtpReservation.ShowClearButton = true;
            dtpReservation.ShowMonthYearNavigation = true;
            dtpReservation.ShowTodayButton = true;
            dtpReservation.Size = new Size(377, 45);
            dtpReservation.TabIndex = 14;
            dtpReservation.Text = "siticoneDateTimePicker1";
            dtpReservation.TodayBorderColor = Color.Black;
            dtpReservation.TodayBorderThickness = 2F;
            dtpReservation.TodayButtonBackColor = Color.Black;
            dtpReservation.TodayButtonBorderRadius = 16;
            dtpReservation.TodayButtonClickBackColor = Color.Black;
            dtpReservation.TodayButtonFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpReservation.TodayButtonForeColor = Color.White;
            dtpReservation.TodayButtonHoverBackColor = Color.FromArgb(64, 64, 64);
            dtpReservation.TodayButtonMargin = new Padding(0, 17, 15, 0);
            dtpReservation.TodayButtonSize = new Size(70, 35);
            dtpReservation.TodayButtonText = "Today";
            dtpReservation.TodayTextColor = Color.Black;
            dtpReservation.TodayTextFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpReservation.TopLeftBorderRadius = 22;
            dtpReservation.TopRightBorderRadius = 22;
            dtpReservation.UseCalendarFormAnimation = true;
            dtpReservation.UseCalendarFormShadow = true;
            dtpReservation.UseChevronAnimation = true;
            dtpReservation.UseGradientFill = false;
            dtpReservation.Value = null;
            dtpReservation.WeekendDayBackColor = Color.FromArgb(250, 250, 250);
            dtpReservation.WeekendDayForeColor = Color.FromArgb(180, 0, 0);
            dtpReservation.YearChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpReservation.YearChevronSpacing = 1;
            dtpReservation.YearComboBoxMargin = new Padding(5, 17, 0, 0);
            dtpReservation.YearComboBoxSize = new Size(90, 30);
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
            btnCancel.Location = new Point(273, 408);
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
            btnCancel.Size = new Size(124, 44);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextColor = Color.Black;
            btnCancel.TooltipText = null;
            btnCancel.UseAdvancedRendering = true;
            btnCancel.UseParticles = false;
            // 
            // btnCreateReservation
            // 
            btnCreateReservation.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnCreateReservation.AccessibleName = "Create Reservation";
            btnCreateReservation.AutoSizeBasedOnText = false;
            btnCreateReservation.BackColor = Color.Transparent;
            btnCreateReservation.BadgeBackColor = Color.Black;
            btnCreateReservation.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCreateReservation.BadgeValue = 0;
            btnCreateReservation.BadgeValueForeColor = Color.White;
            btnCreateReservation.BorderColor = Color.FromArgb(60, 60, 60);
            btnCreateReservation.BorderWidth = 2;
            btnCreateReservation.ButtonBackColor = Color.FromArgb(30, 30, 30);
            btnCreateReservation.ButtonImage = null;
            btnCreateReservation.ButtonTextLeftPadding = 0;
            btnCreateReservation.CanBeep = true;
            btnCreateReservation.CanGlow = false;
            btnCreateReservation.CanShake = true;
            btnCreateReservation.ContextMenuStripEx = null;
            btnCreateReservation.CornerRadiusBottomLeft = 6;
            btnCreateReservation.CornerRadiusBottomRight = 6;
            btnCreateReservation.CornerRadiusTopLeft = 6;
            btnCreateReservation.CornerRadiusTopRight = 6;
            btnCreateReservation.CustomCursor = Cursors.Default;
            btnCreateReservation.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnCreateReservation.EnableLongPress = false;
            btnCreateReservation.EnableRippleEffect = true;
            btnCreateReservation.EnableShadow = true;
            btnCreateReservation.EnableTextWrapping = false;
            btnCreateReservation.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateReservation.GlowColor = Color.FromArgb(30, 255, 255, 255);
            btnCreateReservation.GlowIntensity = 100;
            btnCreateReservation.GlowRadius = 20F;
            btnCreateReservation.GradientBackground = false;
            btnCreateReservation.GradientColor = Color.FromArgb(0, 227, 64);
            btnCreateReservation.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnCreateReservation.HintText = null;
            btnCreateReservation.HoverBackColor = Color.FromArgb(50, 50, 50);
            btnCreateReservation.HoverFontStyle = FontStyle.Regular;
            btnCreateReservation.HoverTextColor = Color.White;
            btnCreateReservation.HoverTransitionDuration = 250;
            btnCreateReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateReservation.ImagePadding = 5;
            btnCreateReservation.ImageSize = new Size(16, 16);
            btnCreateReservation.IsRadial = false;
            btnCreateReservation.IsReadOnly = false;
            btnCreateReservation.IsToggleButton = false;
            btnCreateReservation.IsToggled = false;
            btnCreateReservation.Location = new Point(12, 408);
            btnCreateReservation.LongPressDurationMS = 1000;
            btnCreateReservation.Name = "btnCreateReservation";
            btnCreateReservation.NormalFontStyle = FontStyle.Regular;
            btnCreateReservation.ParticleColor = Color.FromArgb(200, 200, 200);
            btnCreateReservation.ParticleCount = 15;
            btnCreateReservation.PressAnimationScale = 0.97F;
            btnCreateReservation.PressedBackColor = Color.FromArgb(40, 40, 40);
            btnCreateReservation.PressedFontStyle = FontStyle.Regular;
            btnCreateReservation.PressTransitionDuration = 150;
            btnCreateReservation.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnCreateReservation.RippleColor = Color.FromArgb(100, 100, 100);
            btnCreateReservation.RippleOpacity = 0.3F;
            btnCreateReservation.RippleRadiusMultiplier = 0.6F;
            btnCreateReservation.ShadowBlur = 6;
            btnCreateReservation.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            btnCreateReservation.ShadowOffset = new Point(0, 2);
            btnCreateReservation.ShakeDuration = 500;
            btnCreateReservation.ShakeIntensity = 5;
            btnCreateReservation.Size = new Size(255, 44);
            btnCreateReservation.TabIndex = 15;
            btnCreateReservation.Text = "Create Reservation";
            btnCreateReservation.TextAlign = ContentAlignment.MiddleCenter;
            btnCreateReservation.TextColor = Color.White;
            btnCreateReservation.TooltipText = null;
            btnCreateReservation.UseAdvancedRendering = true;
            btnCreateReservation.UseParticles = false;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 469);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateReservation);
            Controls.Add(dtpReservation);
            Controls.Add(label6);
            Controls.Add(txtPhoneNum);
            Controls.Add(label5);
            Controls.Add(txtCustomerName);
            Controls.Add(label4);
            Controls.Add(dropTables);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += Reservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private SiticoneNetCoreUI.SiticoneDropdown dropTables;
        private Label label4;
        private SiticoneNetCoreUI.SiticoneTextBox txtCustomerName;
        private Label label5;
        private SiticoneNetCoreUI.SiticoneTextBox txtPhoneNum;
        private Label label6;
        private SiticoneNetCoreUI.SiticoneDateTimePicker dtpReservation;
        private SiticoneNetCoreUI.SiticoneButton btnCancel;
        private SiticoneNetCoreUI.SiticoneButton btnCreateReservation;
    }
}