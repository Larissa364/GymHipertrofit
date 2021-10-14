using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymHipertrofit
{
    public partial class AddFichas : Form
    {
        public AddFichas()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UT3K1PR\SQLEXPRESS;Initial Catalog=GymHipertrofitDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void AddFichas_Load(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NameFc.Text==""|| ObjetivoFc.Text==""|| DateFc.Text==""|| DivisãoFc.Text==""|| Exercícios.Text == "" || Exercicios2.Text == "" || Exercicios3.Text == "" || Exercicios4.Text == "" || Exercicios5.Text == "" || Exercicios6.Text == "" || Series1.Text == "" || Series2.Text == "" || Series3.Text ==""|| Series4.Text ==""|| Series5.Text==""|| Series6.Text== ""|| Repeticoes1.Text == "" || Repeticoes2.Text == "" || Repeticoes3.Text == "" || Repeticoes4.Text == "" || Repeticoes5.Text == "" || Repeticoes6.Text == "") 

            {
                MessageBox.Show("Está faltando informação");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FichasTbl (Nome, Objetivo, Data, Treino, Exercicio, Series, Repetições)values('"+NameFc.Text+"', '"+ObjetivoFc.Text+"', '"+DateFc.Text+"', '"+DivisãoFc.Text+"', '" + Exercícios.Text + "' ,'" + Exercicios2.Text + "', '" + Exercicios3.Text + "', '" + Exercicios4.Text + "','" + Exercicios5.Text + "', '" + Exercicios6.Text + "', '" + Series1.Text + "', '" + Series2.Text + "', '" + Series3.Text + "', '"+ Series4.Text +"', '"+Series5.Text+"', '"+Series6.Text+ "','" + Repeticoes1.Text + "','" + Repeticoes2.Text + "', '" + Repeticoes3.Text + "', '" + Repeticoes4.Text + "', '" + Repeticoes5.Text + "', '" + Repeticoes6.Text + "')";
                    MessageBox.Show("Adicionado com sucesso");
                    Con.Close();
                    NameFc.Text = "";
                    ObjetivoFc.Text = "";
                    DateFc.Text = "";
                    DivisãoFc.Text = "";
                    Exercícios.Text = "";
                    Exercicios2.Text =  "";
                    Exercicios3.Text = "";
                    Exercicios4.Text = "";
                    Exercicios5.Text = "";
                    Exercicios6.Text = "";
                    Series1.Text = "";
                    Series2.Text = "";
                    Series3.Text = "";
                    Series4.Text = "";
                    Series5.Text = "";
                    Series6.Text = "";
                    Repeticoes1.Text = "";
                    Repeticoes2.Text = "";
                    Repeticoes3.Text = "";
                    Repeticoes4.Text = "";
                    Repeticoes5.Text = "";
                    Repeticoes6.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NameFc.Text = "";
            ObjetivoFc.Text = "";
            DateFc.Text = "";
            DivisãoFc.Text = "";
            Exercícios.Text = "";
            Exercicios2.Text = "";
            Exercicios3.Text = "";
            Exercicios4.Text = "";
            Exercicios5.Text = "";
            Exercicios6.Text = "";
            Series1.Text = "";
            Series2.Text = "";
            Series3.Text = "";
            Series4.Text = "";
            Series5.Text = "";
            Series6.Text = "";
            Repeticoes1.Text = "";
            Repeticoes2.Text = "";
            Repeticoes3.Text = "";
            Repeticoes4.Text = "";
            Repeticoes5.Text = "";
            Repeticoes6.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
