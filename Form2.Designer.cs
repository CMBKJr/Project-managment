namespace Project_managment
{
    partial class Form2
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
            ManagerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TeammateBox = new TextBox();
            TeammateList = new ListBox();
            SaveForm2Btn = new Button();
            TeamBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 39);
            label1.Name = "label1";
            label1.Size = new Size(169, 22);
            label1.TabIndex = 0;
            label1.Text = "Project Description";
            // 
            // ManagerName
            // 
            ManagerName.Location = new Point(130, 84);
            ManagerName.Name = "ManagerName";
            ManagerName.Size = new Size(136, 23);
            ManagerName.TabIndex = 1;
            ManagerName.TextChanged += ManagerName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 84);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 2;
            label2.Text = "Manager Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 148);
            label3.Name = "label3";
            label3.Size = new Size(135, 19);
            label3.TabIndex = 4;
            label3.Text = "Teammate Names:";
            // 
            // TeammateBox
            // 
            TeammateBox.Location = new Point(145, 148);
            TeammateBox.Name = "TeammateBox";
            TeammateBox.Size = new Size(138, 23);
            TeammateBox.TabIndex = 5;
            TeammateBox.TextChanged += TeammateBox_TextChanged;
            // 
            // TeammateList
            // 
            TeammateList.FormattingEnabled = true;
            TeammateList.ItemHeight = 15;
            TeammateList.Location = new Point(12, 182);
            TeammateList.Name = "TeammateList";
            TeammateList.Size = new Size(231, 214);
            TeammateList.TabIndex = 6;
            TeammateList.Click += TeammateList_Click;
            TeammateList.SelectedIndexChanged += TeammateList_SelectedIndexChanged;
            // 
            // SaveForm2Btn
            // 
            SaveForm2Btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveForm2Btn.Location = new Point(249, 415);
            SaveForm2Btn.Name = "SaveForm2Btn";
            SaveForm2Btn.Size = new Size(134, 23);
            SaveForm2Btn.TabIndex = 7;
            SaveForm2Btn.Text = "Save and Continue";
            SaveForm2Btn.UseVisualStyleBackColor = true;
            SaveForm2Btn.Click += SaveForm2Btn_Click;
            // 
            // TeamBtn
            // 
            TeamBtn.Location = new Point(289, 148);
            TeamBtn.Name = "TeamBtn";
            TeamBtn.Size = new Size(75, 23);
            TeamBtn.TabIndex = 8;
            TeamBtn.Text = "Add";
            TeamBtn.UseVisualStyleBackColor = true;
            TeamBtn.Click += TeamBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 450);
            Controls.Add(TeamBtn);
            Controls.Add(SaveForm2Btn);
            Controls.Add(TeammateList);
            Controls.Add(TeammateBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ManagerName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ManagerName;
        private Label label2;
        private Label label3;
        private TextBox TeammateBox;
        private ListBox TeammateList;
        private Button SaveForm2Btn;
        private Button TeamBtn;
    }
}