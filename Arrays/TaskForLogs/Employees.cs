using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskForLogs.Enums;

namespace TaskForLogs
{
    public partial class Employees : Form
    {
        public string LastUploadImage { get; set; }
        public string LastUploadCV { get; set; }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            gridEmployees.DataSource = VirtualDatabase.Employess;
            if (!Directory.Exists(GlobalSettings.Waiting_Uploads_Path))
            {
                Directory.CreateDirectory(GlobalSettings.Waiting_Uploads_Path);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GenderEnum gender = GenderEnum.Male;
            if (checkMale.Checked)
            {
                gender = GenderEnum.Male;
            }
            else if(checkFemail.Checked)
            {
                gender = GenderEnum.Femail;
            }

            Employee employee = new Employee(txtName.Text,txtSurname.Text,dtDOB.Value, gender, richJobDetails.Text);
            VirtualDatabase.Employess.Add(employee);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedEmployee = gridEmployees.SelectedRows[0].Index;
            var employee = VirtualDatabase.Employess[selectedEmployee];
            VirtualDatabase.Employess.Remove(employee);
        }

        private void btnUploadİmag_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File | *.jpg";
            dialog.Multiselect = false;

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if ((reader.BaseStream.Length / 1024) > 500)
                    {

                        MessageBox.Show("Max image size  limit is 500 kb", "Image size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    }
                    else
                    {
                        var newFileName = GlobalSettings.Waiting_Uploads_Path + DateTime.Now.Ticks+".jpg";
                        LastUploadImage = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        btnUploadİmag.Enabled = false;
                    }
                }
            }
        }

        private void btnCv_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File | *.pdf";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if ((reader.BaseStream.Length / 1024) > 2000)
                    {

                        MessageBox.Show("Max image size  limit is 500 kb", "Image size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    }
                    else
                    {
                        var newFileName = GlobalSettings.Waiting_Uploads_Path + DateTime.Now.Ticks + ".pdf";
                        LastUploadCV = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        btnCv.Enabled = false;
                    }
                }
            }
        }
    }
}
