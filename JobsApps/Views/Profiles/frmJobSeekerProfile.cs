using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views.Profiles
{
    public partial class frmJobSeekerProfile : Form
    {
        public frmJobSeekerProfile()
        {
            InitializeComponent();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form passwordForm = new Form()
            {
                Text = "Change Password",
                Size = new Size(350, 200),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblCurrentPassword = new Label()
            {
                Text = "Current Password:",
                Location = new Point(20, 20),
                Size = new Size(130, 20)
            };

            Label lblNewPassword = new Label()
            {
                Text = "New Password:",
                Location = new Point(20, 50),
                Size = new Size(130, 20)
            };

            Label lblConfirmPassword = new Label()
            {
                Text = "Confirm Password:",
                Location = new Point(20, 80),
                Size = new Size(130, 20)
            };

            TextBox txtCurrentPassword = new TextBox()
            {
                Location = new Point(150, 20),
                Size = new Size(160, 20),
                UseSystemPasswordChar = true
            };

            TextBox txtNewPassword = new TextBox()
            {
                Location = new Point(150, 50),
                Size = new Size(160, 20),
                UseSystemPasswordChar = true
            };

            TextBox txtConfirmPassword = new TextBox()
            {
                Location = new Point(150, 80),
                Size = new Size(160, 20),
                UseSystemPasswordChar = true
            };

            Button btnOK = new Button()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(150, 120),
                Size = new Size(75, 23)
            };

            Button btnCancel = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(235, 120),
                Size = new Size(75, 23)
            };

            btnOK.Click += (s, args) =>
            {
                if (string.IsNullOrEmpty(txtCurrentPassword.Text) ||
                    string.IsNullOrEmpty(txtNewPassword.Text) ||
                    string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("All fields are required.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordForm.DialogResult = DialogResult.None;
                    return;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("New password and confirmation do not match.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordForm.DialogResult = DialogResult.None;
                    return;
                }

                MessageBox.Show("Password changed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            passwordForm.Controls.AddRange(new Control[] {
                lblCurrentPassword, txtCurrentPassword,
                lblNewPassword, txtNewPassword,
                lblConfirmPassword, txtConfirmPassword,
                btnOK, btnCancel
            });

            passwordForm.AcceptButton = btnOK;
            passwordForm.CancelButton = btnCancel;

            passwordForm.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select a PDF File";

                openFileDialog.Multiselect = false;

                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        MessageBox.Show($"Selected file: {selectedFilePath}", "File Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // TODO: Handle the PDF file
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error handling the selected file: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkEditPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|JPEG Files|*.jpg;*.jpeg|PNG Files|*.png|GIF Files|*.gif|BMP Files|*.bmp|All Files|*.*";
                openFileDialog.Title = "Select Profile Picture";

                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedImagePath = openFileDialog.FileName;

                        using (Image img = Image.FromFile(selectedImagePath))
                        {
                            if (img.Width < 100 || img.Height < 100)
                            {
                                MessageBox.Show("Image is too small. Please select an image that is at least 100x100 pixels.",
                                    "Image Size Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            Image profileImage = ResizeImage(img, 100, 140);

                            profilePictureBox.Image = profileImage;
                            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                            MessageBox.Show($"Profile picture selected: {Path.GetFileName(selectedImagePath)}",
                                "Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("The selected file is not a valid image file or is corrupted.",
                            "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing image: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Image ResizeImage(Image sourceImage, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;

            float aspectRatio = (float)sourceImage.Width / sourceImage.Height;

            if (aspectRatio > 1)
            {
                newWidth = maxWidth;
                newHeight = (int)(maxWidth / aspectRatio);
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(maxHeight * aspectRatio);
            }

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                graphics.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
