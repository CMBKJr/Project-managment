using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_managment
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        static Form2 f2 = new();
        static Form3 f3 = new();
        static Form4 f4 = new();
        static Form5 f5 = new();
        static Form f6 = new();
        List<String> Risk = new List<String>();
        public Form4()
        {
            InitializeComponent();
        }

        private void RiskList_TextChanged(object sender, EventArgs e)
        {

        }

        private void RiskBtn_Click(object sender, EventArgs e)
        {
            Risk.Add(RiskText.Text);
            RiskList.DataSource = null;
            RiskList.DataSource = Risk;
        }

        private void RiskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitForm4Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void RiskList_Click(object sender, EventArgs e)
        {
            Risk.RemoveAt(RiskList.SelectedIndex);
            RiskList.DataSource = null;
            RiskList.DataSource = Risk;
        }
    }
}
