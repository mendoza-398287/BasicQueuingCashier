namespace BasicQueuingCashier
{
    partial class QueuingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblNote = new Label();
            btnCashier = new Button();
            lblQueue = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblNote);
            panelMain.Controls.Add(btnCashier);
            panelMain.Controls.Add(lblQueue);
            panelMain.Controls.Add(lblTitle);
            panelMain.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMain.Location = new Point(27, 31);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(559, 307);
            panelMain.TabIndex = 0;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.Red;
            lblNote.Location = new Point(39, 201);
            lblNote.Margin = new Padding(4, 0, 4, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(207, 20);
            lblNote.TabIndex = 3;
            lblNote.Text = "*Click to get a number";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.Highlight;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Location = new Point(80, 93);
            btnCashier.Margin = new Padding(4, 5, 4, 5);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(120, 103);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(248, 116);
            lblQueue.Margin = new Padding(4, 0, 4, 0);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(238, 51);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10000";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(267, 93);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Position in Queue";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(613, 369);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblTitle;
    }
}