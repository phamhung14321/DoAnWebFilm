using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class Form2 : Form
    {   

        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MovieService movieService = new MovieService();
            List<string> summaries = movieService.GetAllSummaries();

            StringBuilder sb = new StringBuilder();
            foreach (var summary in summaries)
            {
                sb.AppendLine(summary);
                sb.AppendLine("--------------------------------------------------"); 
            }

            richTextBox1.Text = sb.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void SetPicture(Image image)
        {
            pictureBox1.Image = image; // Gán hình ảnh vào PictureBox của Form2
        }
    }
}
    }

}
