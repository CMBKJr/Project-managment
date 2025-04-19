namespace Project_managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            ProjectInfoBtn = new Button();
            RequirmentBtn = new Button();
            ManageBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 124);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 0;
            label1.Text = "Project Managment";
            // 
            // ProjectInfoBtn
            // 
            ProjectInfoBtn.Location = new Point(81, 159);
            ProjectInfoBtn.Name = "ProjectInfoBtn";
            ProjectInfoBtn.Size = new Size(202, 23);
            ProjectInfoBtn.TabIndex = 1;
            ProjectInfoBtn.Text = "Project Information(Start here)";
            ProjectInfoBtn.UseVisualStyleBackColor = true;
            ProjectInfoBtn.Click += ProjectInfoBtn_Click;
            // 
            // RequirmentBtn
            // 
            RequirmentBtn.Location = new Point(140, 203);
            RequirmentBtn.Name = "RequirmentBtn";
            RequirmentBtn.Size = new Size(86, 23);
            RequirmentBtn.TabIndex = 2;
            RequirmentBtn.Text = "Requirments";
            RequirmentBtn.UseVisualStyleBackColor = true;
            RequirmentBtn.Click += RequirmentBtn_Click;
            // 
            // ManageBtn
            // 
            ManageBtn.Location = new Point(120, 243);
            ManageBtn.Name = "ManageBtn";
            ManageBtn.Size = new Size(126, 23);
            ManageBtn.TabIndex = 3;
            ManageBtn.Text = "Manage project";
            ManageBtn.UseVisualStyleBackColor = true;
            ManageBtn.Click += ManageBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 383);
            Controls.Add(ManageBtn);
            Controls.Add(RequirmentBtn);
            Controls.Add(ProjectInfoBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ProjectInfoBtn;
        private Button RequirmentBtn;
        private Button ManageBtn;
        private PictureBox pictureBox1;
    }
}
