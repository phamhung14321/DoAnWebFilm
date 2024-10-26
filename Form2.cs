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
using System.IO;

namespace DoAnWinform
{
    public partial class Form2 : Form
    {
        private MovieService movieService;

        public Form2()
        {
            InitializeComponent();
            movieService = new MovieService();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var summaries = movieService.GetAllSummaries();
            int movieId = 1;

            foreach (var summary in summaries)
            {
                richTextBox1.AppendText(summary + Environment.NewLine + Environment.NewLine);
            }
            richTextBox1.Enabled = false;
            textBox1.Enabled = false;
            string imagePath = movieService.GetMovieImageUrl(movieId);
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đường dẫn hình ảnh không hợp lệ hoặc tệp không tồn tại.");
            }
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
        public void SetPicture(Image image)
        {
            pictureBox1.Image = image; // Gán hình ảnh vào PictureBox của Form2
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


    }
}
