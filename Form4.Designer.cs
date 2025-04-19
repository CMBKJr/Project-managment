namespace Project_managment
{
    partial class Form4
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
            RiskText = new TextBox();
            RiskList = new ListBox();
            SubmitForm4Btn = new Button();
            RiskBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 45);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 0;
            label1.Text = "Risks and Status";
            // 
            // RiskText
            // 
            RiskText.Location = new Point(73, 108);
            RiskText.Name = "RiskText";
            RiskText.Size = new Size(227, 23);
            RiskText.TabIndex = 1;
            RiskText.TextChanged += RiskList_TextChanged;
            // 
            // RiskList
            // 
            RiskList.FormattingEnabled = true;
            RiskList.ItemHeight = 15;
            RiskList.Location = new Point(73, 178);
            RiskList.Name = "RiskList";
            RiskList.Size = new Size(227, 214);
            RiskList.TabIndex = 2;
            RiskList.Click += RiskList_Click;
            RiskList.SelectedIndexChanged += RiskList_SelectedIndexChanged;
            // 
            // SubmitForm4Btn
            // 
            SubmitForm4Btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitForm4Btn.Location = new Point(284, 415);
            SubmitForm4Btn.Name = "SubmitForm4Btn";
            SubmitForm4Btn.Size = new Size(83, 23);
            SubmitForm4Btn.TabIndex = 3;
            SubmitForm4Btn.Text = "Submit";
            SubmitForm4Btn.UseVisualStyleBackColor = true;
            SubmitForm4Btn.Click += SubmitForm4Btn_Click;
            // 
            // RiskBtn
            // 
            RiskBtn.Location = new Point(153, 137);
            RiskBtn.Name = "RiskBtn";
            RiskBtn.Size = new Size(75, 23);
            RiskBtn.TabIndex = 4;
            RiskBtn.Text = "Add";
            RiskBtn.UseVisualStyleBackColor = true;
            RiskBtn.Click += RiskBtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(RiskBtn);
            Controls.Add(SubmitForm4Btn);
            Controls.Add(RiskList);
            Controls.Add(RiskText);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RiskText;
        private ListBox RiskList;
        private Button SubmitForm4Btn;
        private Button RiskBtn;
    }
}