using LicensePlateSDK;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LicensePlateWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Btn_MouseEnter(object sender, EventArgs e)
        {
            Browse_h_Btn.Show();
            Browse_Btn.Hide();
        }

        private void Browse_h_Btn_MouseLeave(object sender, EventArgs e)
        {
            Browse_Btn.Show();
            Browse_h_Btn.Hide();
        }

        private void Browse_h_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Browse_md_Btn.Show();
            Browse_h_Btn.Hide();
        }

        private void Browse_h_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            Browse_h_Btn.Show();
            Browse_md_Btn.Hide();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures(*.jpg) | *.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
                fileAddress_txt.Text = openFile.FileName;
        }

        private void fileAddress_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox.Image = Image.FromFile(fileAddress_txt.Text);
            }
            catch (Exception)
            {
                //do nothing
            }
        }

        private void Proccess_Btn_MouseEnter(object sender, EventArgs e)
        {
            Proccess_h_Btn.Show();
            Proccess_Btn.Hide();
        }

        private void Proccess_h_Btn_MouseLeave(object sender, EventArgs e)
        {
            Proccess_Btn.Show();
            Proccess_h_Btn.Hide();
        }

        private void Proccess_h_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Proccess_md_Btn.Show();
            Proccess_h_Btn.Hide();
        }

        private void Proccess_h_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            Proccess_h_Btn.Show();
            Proccess_md_Btn.Hide();
            Plate_lbl.Text = ProccessPicture(pictureBox.Image);
        }

        private string ProccessPicture(Image image)
        {
            if (!LicensePlate.IsActivated())
                MessageBox.Show(this, "LicensePlateSDK is not activated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    LicensePlate.Initialize();
                }
                catch (Exception)
                {
                    //do nothing
                }

                try
                {
                    //return LicensePlate.Predict(image);
                    string str = LicensePlate.Predict(image);
                    string result = "";
                    result += str.Substring(3, 6);
                    result += str[2];
                    result += str.Substring(0, 2);
                    return result;
                    
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Invalid Image!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return "";
        }
    }
}
