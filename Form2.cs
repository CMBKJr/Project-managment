namespace Project_managment
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        List<String> Teammates = new List<String>();
        static Form2 f2 = new();
        static Form3 f3 = new();
        static Form4 f4 = new();
        static Form5 f5 = new();
        static Form f6 = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void TeammateList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManagerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeammateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamBtn_Click(object sender, EventArgs e)
        {
            Teammates.Add(TeammateBox.Text);
            TeammateList.DataSource = null;
            TeammateList.DataSource = Teammates;

        }

        private void SaveForm2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.Show();
        }

        private void TeammateList_Click(object sender, EventArgs e)
        {
            Teammates.RemoveAt(TeammateList.SelectedIndex);
            TeammateList.DataSource = null;
            TeammateList.DataSource = Teammates;
        }
    }
}
