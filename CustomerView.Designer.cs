namespace BasicQueuingCashier
{
    partial class CustomerView
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
            panelMain = new Panel();
            lblTitle = new Label();
            lblNowServing = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblNowServing);
            panelMain.Location = new Point(27, 31);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(559, 307);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(215, 118);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "*Now Serving";
            // 
            // lblNowServing
            // 
            lblNowServing.AutoSize = true;
            lblNowServing.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNowServing.Location = new Point(167, 141);
            lblNowServing.Margin = new Padding(4, 0, 4, 0);
            lblNowServing.Name = "lblNowServing";
            lblNowServing.Size = new Size(238, 51);
            lblNowServing.TabIndex = 1;
            lblNowServing.Text = "P - 10001";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(613, 369);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerView";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNowServing;
    }
}