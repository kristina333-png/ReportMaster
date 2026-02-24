namespace WinFormsApp3
{
    partial class information
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
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Location = new Point(411, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 513);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(26, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 81);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(162, 26);
            label4.Name = "label4";
            label4.Size = new Size(26, 30);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 0;
            label1.Text = "Сейчас денег";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(26, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 81);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(111, 25);
            label5.Name = "label5";
            label5.Size = new Size(26, 30);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 1;
            label2.Text = "Доходы";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(26, 420);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 81);
            panel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(89, 26);
            label6.Name = "label6";
            label6.Size = new Size(26, 30);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 2;
            label3.Text = "Траты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(522, 6);
            label7.Name = "label7";
            label7.Size = new Size(245, 30);
            label7.TabIndex = 2;
            label7.Text = "История всех средств";
            // 
            // information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(862, 572);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "information";
            Text = "information";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label7;
    }
}