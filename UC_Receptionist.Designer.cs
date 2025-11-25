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
            pnlTables.Location = new Point(44, 116);
            pnlTables.Name = "pnlTables";
            pnlTables.Size = new Size(1619, 606);
            pnlTables.TabIndex = 14;
            // 
            // UC_Receptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
