namespace Project_managment
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
        static Form2 f2 = new ();
        static Form3 f3 = new ();
        static Form4 f4 = new ();
        static Form5 f5 = new ();
        static Form f6 = new ();
        public Form1()
        {
            InitializeComponent();
        }

        private void ProjectInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();

        }

        private void RequirmentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f5.Show();
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f6.Show();
        }
    }
}
