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
using System.Drawing.Printing;
using System.IO;



namespace GymHipertrofit
{
    public partial class Treino1 : Form
    {

        public Treino1()
        {
            InitializeComponent();
        }

        private void populate()
        {

        }


        private void filterByNome()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            filterByNome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            populate();
        }
        private void ViewFichas_Load(object sender, EventArgs e)
        { }





        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void treino1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TreinoPri_Enter(object sender, EventArgs e)
        {

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var image = new Bitmap(this.Width, this.Height);
            var graphics = Graphics.FromImage(image);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            e.Graphics.DrawImage(image, -7, -3);
        }


            private void imprimirButton_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        // C#
        Bitmap captura = null;

        private void CapturarForm()
        {
            captura = new Bitmap(this.Width, this.Height);
            var graphics = Graphics.FromImage(captura);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
        }
        // C#
        private void imprimirButton_Click(object sender, EventArgs e)
        {
            CapturarForm();
            printDocument1.Print();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox89_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox91_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox93_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox94_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox97_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox98_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox108_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox109_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}