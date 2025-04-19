namespace Project_managment
{
    partial class Form5
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
            label2 = new Label();
            label3 = new Label();
            FuncText = new TextBox();
            NonFuncText = new TextBox();
            FuncList = new ListBox();
            NonFuncList = new ListBox();
            SaveForm5Btn = new Button();
            FuncBtn = new Button();
            NonFuncBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 58);
            label1.Name = "label1";
            label1.Size = new Size(372, 22);
            label1.TabIndex = 0;
            label1.Text = "Functional and Non Functional Requirments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 121);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 1;
            label2.Text = "Functional:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 126);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 2;
            label3.Text = "Non Functional:";
            // 
            // FuncText
            // 
            FuncText.Location = new Point(29, 153);
            FuncText.Name = "FuncText";
            FuncText.Size = new Size(159, 23);
            FuncText.TabIndex = 3;
            FuncText.TextChanged += FuncText_TextChanged;
            // 
            // NonFuncText
            // 
            NonFuncText.Location = new Point(297, 157);
            NonFuncText.Name = "NonFuncText";
            NonFuncText.Size = new Size(169, 23);
            NonFuncText.TabIndex = 4;
            NonFuncText.TextChanged += NonFuncText_TextChanged;
            // 
            // FuncList
            // 
            FuncList.FormattingEnabled = true;
            FuncList.ItemHeight = 15;
            FuncList.Location = new Point(29, 192);
            FuncList.Name = "FuncList";
            FuncList.Size = new Size(159, 184);
            FuncList.TabIndex = 5;
            FuncList.Click += FuncList_Click;
            FuncList.SelectedIndexChanged += FuncList_SelectedIndexChanged;
            // 
            // NonFuncList
            // 
            NonFuncList.FormattingEnabled = true;
            NonFuncList.ItemHeight = 15;
            NonFuncList.Location = new Point(297, 192);
            NonFuncList.Name = "NonFuncList";
            NonFuncList.Size = new Size(168, 184);
            NonFuncList.TabIndex = 6;
            NonFuncList.Click += NonFuncList_Click;
            NonFuncList.SelectedIndexChanged += NonFuncList_SelectedIndexChanged;
            // 
            // SaveForm5Btn
            // 
            SaveForm5Btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveForm5Btn.Location = new Point(415, 415);
            SaveForm5Btn.Name = "SaveForm5Btn";
            SaveForm5Btn.Size = new Size(75, 23);
            SaveForm5Btn.TabIndex = 7;
            SaveForm5Btn.Text = "Save";
            SaveForm5Btn.UseVisualStyleBackColor = true;
            SaveForm5Btn.Click += SaveForm5Btn_Click;
            // 
            // FuncBtn
            // 
            FuncBtn.Location = new Point(109, 121);
            FuncBtn.Name = "FuncBtn";
            FuncBtn.Size = new Size(75, 23);
            FuncBtn.TabIndex = 8;
            FuncBtn.Text = "Add";
            FuncBtn.UseVisualStyleBackColor = true;
            FuncBtn.Click += FuncBtn_Click;
            // 
            // NonFuncBtn
            // 
            NonFuncBtn.Location = new Point(398, 125);
            NonFuncBtn.Name = "NonFuncBtn";
            NonFuncBtn.Size = new Size(68, 23);
            NonFuncBtn.TabIndex = 9;
            NonFuncBtn.Text = "Add";
            NonFuncBtn.UseVisualStyleBackColor = true;
            NonFuncBtn.Click += NonFuncBtn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(NonFuncBtn);
            Controls.Add(FuncBtn);
            Controls.Add(SaveForm5Btn);
            Controls.Add(NonFuncList);
            Controls.Add(FuncList);
            Controls.Add(NonFuncText);
            Controls.Add(FuncText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FuncText;
        private TextBox NonFuncText;
        private ListBox FuncList;
        private ListBox NonFuncList;
        private Button SaveForm5Btn;
        private Button FuncBtn;
        private Button NonFuncBtn;
    }
}