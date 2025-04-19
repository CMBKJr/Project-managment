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
    public partial class Form : System.Windows.Forms.Form
    {
        static Form2 f2 = new();
        static Form3 f3 = new();
        static Form4 f4 = new();
        static Form5 f5 = new();
        static Form f6 = new();

        int Ra = 0;
        int De = 0;
        int Co = 0;
        int Te = 0;
        int Pm = 0;

        public Form()
        {
            InitializeComponent();
           
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RaT = Convert.ToInt32(RaText.Text);
            int DeT = Convert.ToInt32(DesignText.Text);
            int CoT = Convert.ToInt32(CodeText.Text);
            int TeT = Convert.ToInt32(TestText.Text);
            int PmT = Convert.ToInt32(ProManText.Text);
            Ra += RaT;
            De += DeT;
            Co += CoT;
            Te += TeT;
            Pm += PmT;

            RAhours.Text = Convert.ToString(Ra);
            Designhours.Text = Convert.ToString(De);
            Codehours.Text = Convert.ToString(Co);
            Testhours.Text = Convert.ToString(Te);
            ProManhours.Text = Convert.ToString(Pm);

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void RaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesignText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
          
        }
    }
}
