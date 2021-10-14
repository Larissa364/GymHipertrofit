using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymHipertrofit
{
    public partial class LoginGym : Form
    {
        public LoginGym()
        {
            InitializeComponent();
        }


        private void LoginGym_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTB.Text = "";
            PassTB.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTB.Text == "" || PassTB.Text == "")
            {
                MessageBox.Show("Está Faltando informação");
            }
            else if (UidTB.Text == "Paulo" && PassTB.Text== "987654321")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Id ou senha incorreta");
            }
        }
    }
}
