using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Dredge
{
    public partial class Dredge : Form
    {
        public Dredge()
        {
            InitializeComponent();
        }

        private List<string> allFiles = new List<string>();
        private List<string> allTypes = new List<string>();

        private void txtOPath_TextClick(object sender, EventArgs e)
        {
            fbdRead.ShowDialog();

            txtOPath.Text = fbdRead.SelectedPath;

            if (txtOPath.BackColor == Color.Red && !string.IsNullOrEmpty(txtOPath.Text))
            {
                txtOPath.BackColor = Color.White;
            }
        }

        private void txtDPath_TextClick(object sender, EventArgs e)
        {
            fbdCopy.ShowDialog();

            txtDPath.Text = fbdCopy.SelectedPath;

            if (txtDPath.BackColor == Color.Red && !string.IsNullOrEmpty(txtDPath.Text))
            {
                txtDPath.BackColor = Color.White;
            }
        }

        private void btnREAD_Click(object sender, EventArgs e)
        {
            if (!bgwRead.IsBusy)
            {
                allFiles.Clear();
                if (!string.IsNullOrEmpty(txtOPath.Text))
                {
                    if (ValidaSelecaoTypeFile())
                    {
                        lstAllFiles.DataSource = null;
                        lstAllFiles.Items.Clear();

                        pgbREAD.Value = 0;

                        bgwRead.RunWorkerAsync();
                    }
                }
                else
                {
                    txtOPath.BackColor = Color.Red;
                } 
            }
        }

        private List<string> GetAllCheckedTypes()
        {
            List<string> retorno = new List<string>();

            if (chkALL.Checked)
            {
                retorno.Add("ALL");
            }
            if (chkBMP.Checked)
            {
                retorno.Add("BMP");
            }
            if (chkGIF.Checked)
            {
                retorno.Add("GIF");
            }
            if (chkJPEG.Checked)
            {
                retorno.Add("JPEG");
            }
            if (chkJPG.Checked)
            {
                retorno.Add("JPG");
            }
            if (chkPNG.Checked)
            {
                retorno.Add("PNG");
            }
            if (chkYOURTYPE.Checked)
            {
                retorno.Add(txtYOURTYPE.Text.ToUpper());
            }

            return retorno;
        }

        private List<string> GetFilesFromDirectory(string p)
        {
            List<string> retono = new List<string>();
            foreach (string item in Directory.GetDirectories(p))
            {
                foreach (string r_item in GetFilesFromDirectory(item))
                {
                    retono.Add(r_item);
                }
            }

            foreach (string subitem in Directory.GetFiles(p))
            {
                if (ValidaFile(subitem))
                {
                    retono.Add(subitem);
                    bgwRead.ReportProgress(0, subitem);
                }
            }

            return retono;
        }

        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkALL.Checked)
            {
                chkJPG.Checked = false;
                chkJPEG.Checked = false;
                chkPNG.Checked = false;
                chkBMP.Checked = false;
                chkGIF.Checked = false;
                chkYOURTYPE.Checked = false;
                chkALL.Checked = true;
            }
            ValidaSelecaoTypeFile();
        }

        private bool ValidaSelecaoTypeFile()
        {
            if (chkALL.Checked || chkBMP.Checked || chkGIF.Checked || chkJPEG.Checked || chkJPG.Checked || chkPNG.Checked || chkYOURTYPE.Checked)
            {
                filesType.ForeColor = Color.Black;
                return true;
            }
            else
            {
                filesType.ForeColor = Color.Red;
                return false;
            }
        }

        private bool ValidaFile(string f)
        {
            if (chkALL.Checked)
            {
                return true;
            }
            else
            {
                FileInfo file = new FileInfo(f);

                if (!string.IsNullOrEmpty(file.Extension) && allTypes.Exists(x => x.Equals(file.Extension.Remove(0,1).ToUpper())))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void chkALL_UnCheck(object sender, EventArgs e)
        {
            chkALL.Checked = false;
            ValidaSelecaoTypeFile();
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            if (!bgwCopy.IsBusy)
            {
                if (!string.IsNullOrEmpty(txtDPath.Text))
                {
                    bgwCopy.RunWorkerAsync();
                }
                else
                {
                    txtDPath.BackColor = Color.Red;
                } 
            }
        }

        private void Copy()
        {
            bgwCopy.WorkerReportsProgress = true;
            int count = 0, files = 0;
            string filename = txtFileName.Text;

            foreach (string item in allFiles)
            {
                
                //pgbCOPY.Value++;
                if (string.IsNullOrEmpty(txtFileName.Text))
                {
                    filename = new FileInfo(item).Name;
                    filename = filename.Substring(0, filename.LastIndexOf(".")).Replace(" ", "_");
                }
                else
                {
                    count++;
                    filename = txtFileName.Text + "_" + count.ToString("000000");
                }

                //lblFilesLeft.Text = "Files Left: " + (pgbCOPY.Maximum - pgbCOPY.Value).ToString();
                string newFile = txtDPath.Text + "\\" + filename + item.Substring(item.LastIndexOf("."), (item.Length - item.LastIndexOf(".")));

                while (File.Exists(newFile))
                {
                    count++;
                    if (string.IsNullOrEmpty(txtFileName.Text))
                    {
                        filename = new FileInfo(item).Name;
                        filename = filename.Substring(0, filename.LastIndexOf(".")).Replace(" ", "_") + "_" + count.ToString("000000");
                    }
                    else
                    {
                        filename = txtFileName.Text + "_" + count.ToString("000000");
                    }
                    newFile = txtDPath.Text + "\\" + filename + item.Substring(item.LastIndexOf("."), (item.Length - item.LastIndexOf(".")));
                }

                newFile = txtDPath.Text + "\\" + filename + item.Substring(item.LastIndexOf("."), (item.Length - item.LastIndexOf(".")));

                File.Copy(item, newFile, true);
                files++;
                bgwCopy.ReportProgress((int)files * 100 / allFiles.Count,allFiles.Count-files);

                if (chkRemove.Checked)
                {
                    File.Delete(item);
                }
            }

            bgwCopy.WorkerReportsProgress = false;
        }

        private void CleanProgram()
        {
            MessageBox.Show("Operação realizada com sucesso!", "Operação Concluida!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOPath.Text = string.Empty;
            txtDPath.Text = string.Empty;

            allFiles.Clear();
            allTypes.Clear();

            lstAllFiles.DataSource = new List<string>();

            lblTotalFiles.Visible = false;
            lblFilesLeft.Visible = false;

            chkRemove.Enabled = false;
            txtFileName.Enabled = false;
            txtDPath.Enabled = false;
            btnCOPY.Enabled = false;

            txtFileName.Text = string.Empty;
            chkALL.Checked = true;

            pgbREAD.Value = 0;
            pgbCOPY.Value = 0;
        }

        private void bgwCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            Copy();
        }

        private void bgwCopy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CleanProgram();
        }

        private void bgwCopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbCOPY.Value = e.ProgressPercentage;
            lblFilesLeft.Text = "Files Left: " + ((int)e.UserState).ToString();
        }

        private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
        {
            allTypes = GetAllCheckedTypes();

            allFiles = GetFilesFromDirectory(txtOPath.Text);
        }

        private void bgwRead_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lstAllFiles.Items.Clear();
            lstAllFiles.DataSource = allFiles;

            if (allFiles.Count > 0)
            {
                chkRemove.Enabled = true;
                txtFileName.Enabled = true;
                txtDPath.Enabled = true;
                btnCOPY.Enabled = true;
                pgbCOPY.Enabled = true;
            }
            else
            {
                chkRemove.Enabled = false;
                txtFileName.Enabled = false;
                txtDPath.Enabled = false;
                btnCOPY.Enabled = false;
                pgbCOPY.Enabled = false;
            }

            lblTotalFiles.Visible = true;
            lblTotalFiles.Text = "Total Files: " + allFiles.Count.ToString();
            lblFilesLeft.Visible = true;
            lblFilesLeft.Text = "Files Left: " + allFiles.Count.ToString();

            pgbREAD.Value = 100;
        }

        private void bgwRead_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbREAD.Value = 50;
            lstAllFiles.Items.Add((string)e.UserState);
        }
    }
}
