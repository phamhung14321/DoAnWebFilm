using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=YourDatabaseName;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

        }
        private void LoadImagesFromDatabase()
        {
            string query = "SELECT MovieImage FROM Movies"; // Lấy tất cả ảnh từ bảng Movies
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Đọc dữ liệu ảnh từ cơ sở dữ liệu
                            byte[] imageData = (byte[])reader["MovieImage"];

                            if (imageData != null)
                            {
                                // Chuyển byte array sang Image
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image image = Image.FromStream(ms);

                                    // Tạo một PictureBox mới
                                    PictureBox pb = new PictureBox();
                                    pb.Image = image;
                                    pb.Size = new Size(120, 180); // Kích thước của PictureBox
                                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pb.Click += PictureBox_Click; // Gán sự kiện click nếu cần

                                    // Thêm PictureBox vào FlowLayoutPanel
                                    flowLayoutPanel1.Controls.Add(pb);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            LoadImagesFromDatabase();
        }
        private void AssignClickEventToPictureBoxes()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictureBox = control as PictureBox;
                    pictureBox.Click += PictureBox_Click; // Gán sự kiện Click
                }
            }
        }

        // Sự kiện khi nhấn vào một PictureBox bất kỳ
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Lấy PictureBox mà người dùng vừa nhấn vào
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null && clickedPictureBox.Image != null)
            {
                // Mở Form2 và truyền hình ảnh sang
                Form2 form2 = new Form2();
                form2.SetPicture(clickedPictureBox.Image); // Truyền ảnh của PictureBox được nhấn
                form2.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
