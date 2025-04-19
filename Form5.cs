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
    public partial class Form5 : System.Windows.Forms.Form
    {
        static Form2 f2 = new();
        static Form3 f3 = new();
        static Form4 f4 = new();
        static Form5 f5 = new();
        static Form f6 = new();
        List<String> Func = new List<String>();
        List<String> NonFunc = new List<String>();
        public Form5()
        {
            InitializeComponent();
        }

        private void FuncText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FuncBtn_Click(object sender, EventArgs e)
        {
            Func.Add(FuncText.Text);
            FuncList.DataSource = null;
            FuncList.DataSource = Func;
        }

        private void FuncList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NonFuncText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NonFuncBtn_Click(object sender, EventArgs e)
        {
            NonFunc.Add(NonFuncText.Text);
            NonFuncList.DataSource = null;
            NonFuncList.DataSource = NonFunc;
        }

        private void NonFuncList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveForm5Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void FuncList_Click(object sender, EventArgs e)
        {
            Func.RemoveAt(FuncList.SelectedIndex);
            FuncList.DataSource = null;
            FuncList.DataSource = Func;
        }

        private void NonFuncList_Click(object sender, EventArgs e)
        {
            NonFunc.RemoveAt(NonFuncList.SelectedIndex);
            NonFuncList.DataSource = null;
            NonFuncList.DataSource = NonFunc;
        }
    }
}
