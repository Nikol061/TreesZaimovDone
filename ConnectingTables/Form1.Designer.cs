namespace ConnectingTables
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
            lbl = new Label();
            lbl2 = new Label();
            btn = new Button();
            txt = new TextBox();
            txt2 = new TextBox();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl.Location = new Point(113, 37);
            lbl.Name = "lbl";
            lbl.Size = new Size(56, 21);
            lbl.TabIndex = 0;
            lbl.Text = "Name:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl2.Location = new Point(485, 37);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(83, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Name_BG:";
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btn.Location = new Point(157, 217);
            btn.Name = "btn";
            btn.Size = new Size(364, 127);
            btn.TabIndex = 2;
            btn.Text = "Insert Into Razred:";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txt
            // 
            txt.Location = new Point(79, 86);
            txt.Name = "txt";
            txt.Size = new Size(189, 23);
            txt.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(446, 86);
            txt2.Name = "txt2";
            txt2.Size = new Size(182, 23);
            txt2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 417);
            Controls.Add(txt2);
            Controls.Add(txt);
            Controls.Add(btn);
            Controls.Add(lbl2);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label lbl2;
        private Button btn;
        private TextBox txt;
        private TextBox txt2;
    }
}
