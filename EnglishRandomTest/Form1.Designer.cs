namespace EnglishRandomTest
{
    partial class Form1
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
            txt = new Label();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.BackColor = Color.Red;
            txt.FlatStyle = FlatStyle.Flat;
            txt.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.Transparent;
            txt.Location = new Point(119, 347);
            txt.Name = "txt";
            txt.Size = new Size(62, 23);
            txt.TabIndex = 0;
            txt.Text = "LABEL";
            txt.Click += txt_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(457, 712);
            btn1.Name = "btn1";
            btn1.Size = new Size(235, 78);
            btn1.TabIndex = 1;
            btn1.Text = "RandomTest1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(849, 712);
            btn2.Name = "btn2";
            btn2.Size = new Size(235, 78);
            btn2.TabIndex = 2;
            btn2.Text = "RandomTest2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1731, 1010);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txt);
            Name = "Form1";
            Text = "Practice English";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt;
        private Button btn1;
        private Button btn2;
    }
}
