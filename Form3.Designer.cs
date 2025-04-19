namespace Project_managment
{
    partial class Form3
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
            label1 = new Label();
            HighLvlText = new TextBox();
            SaveForm3Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 51);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 1;
            label1.Text = "High-Level Description";
            // 
            // HighLvlText
            // 
            HighLvlText.Location = new Point(32, 103);
            HighLvlText.Multiline = true;
            HighLvlText.Name = "HighLvlText";
            HighLvlText.Size = new Size(343, 243);
            HighLvlText.TabIndex = 2;
            HighLvlText.TextChanged += HighLvlText_TextChanged;
            // 
            // SaveForm3Btn
            // 
            SaveForm3Btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveForm3Btn.Location = new Point(252, 415);
            SaveForm3Btn.Name = "SaveForm3Btn";
            SaveForm3Btn.Size = new Size(137, 23);
            SaveForm3Btn.TabIndex = 3;
            SaveForm3Btn.Text = "Save and Continue";
            SaveForm3Btn.UseVisualStyleBackColor = true;
            SaveForm3Btn.Click += SaveForm3Btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(SaveForm3Btn);
            Controls.Add(HighLvlText);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox HighLvlText;
        private Button SaveForm3Btn;
    }
}