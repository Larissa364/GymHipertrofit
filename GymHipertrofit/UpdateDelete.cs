using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymHipertrofit
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UT3K1PR\SQLEXPRESS;Initial Catalog=GymHipertrofitDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            LastNameTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            CPFtb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmailTb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
            AddressTb.Text = MemberSDGV.SelectedRows[0].Cells[7].Value.ToString();
            ContratoTb.Text = MemberSDGV.SelectedRows[0].Cells[8].Value.ToString();
            TimingTb.Text = MemberSDGV.SelectedRows[0].Cells[9].Value.ToString();
            FoneTb.Text = MemberSDGV.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            LastNameTb.Text = "";
            CPFtb.Text = "";
            GenderTb.Text = "";
            AgeTb.Text = "";
            EmailTb.Text = "";
            AddressTb.Text = "";
            ContratoTb.Text = "";
            TimingTb.Text = "";
            FoneTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || LastNameTb.Text == "" || CPFtb.Text == "" || GenderTb.Text == "" || AgeTb.Text == "" || EmailTb.Text == "" || AddressTb.Text == "" || ContratoTb.Text == "" || TimingTb.Text == "" || FoneTb.Text == "")
            {
                MessageBox.Show("Faltando informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set Nome='" + NameTb.Text + "', Sobrenome='" + LastNameTb.Text + "', CPF='" + CPFtb.Text + "', Genero='" + GenderTb.Text + "', Idade='" + AgeTb.Text + "', Email='" + EmailTb.Text + "', Endereco='" + AddressTb.Text + "', Contrato='" + ContratoTb + "', Horario='" + TimingTb + "', Tel='" + FoneTb + "' where ID=" + key + ";";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro atualizado com sucesso");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Selecione o membro para ser deletado");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where Id=" + key + " ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro deletado com sucesso");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    } 
}

