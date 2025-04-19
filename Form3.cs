namespace Project_managment
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        static Form2 f2 = new();
        static Form3 f3 = new();
        static Form4 f4 = new();
        static Form5 f5 = new();
        static Form f6 = new();
        public Form3()
        {
            InitializeComponent();
        }

        private void HighLvlText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveForm3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            f4.Show();
        }
    }
}
