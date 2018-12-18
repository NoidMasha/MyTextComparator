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

namespace TextComparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                CheckFileExists = true,
                CheckPathExists = true
            };
            //openFileDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                aFilePathTextBox.Text = openFileDialog.FileName;
                Stream fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                aFileContentTextBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void aFilePathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(aFilePathTextBox.Text))
                {
                    MessageBox.Show("Fill path field.");
                    return;
                }

                aFilePathTextBox.Text = aFilePathTextBox.Text.Trim();
                if (File.Exists(aFilePathTextBox.Text) == false)
                {
                    MessageBox.Show("File does not exist.\nCheck path or filename.");
                    return;
                }

                StreamReader stream = null;

                try
                {
                    stream = new StreamReader(path: aFilePathTextBox.Text, encoding: Encoding.ASCII);
                    aFileContentTextBox.Text = stream.ReadToEnd();
                    stream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                        stream = null;
                    }
                }
            }
        }

        private void bLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                CheckFileExists = true,
                CheckPathExists = true
            };
            //openFileDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bFilePathTextBox.Text = openFileDialog.FileName;
                Stream fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                bFileContentTextBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }



        private void bFilePathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(bFilePathTextBox.Text))
                {
                    MessageBox.Show("Fill path field.");
                    return;
                }

                bFilePathTextBox.Text = bFilePathTextBox.Text.Trim();
                if (File.Exists(bFilePathTextBox.Text) == false)
                {
                    MessageBox.Show("File does not exist.\nCheck path or filename.");
                    return;
                }

                StreamReader stream = null;

                try
                {
                    stream = new StreamReader(path: bFilePathTextBox.Text, encoding: Encoding.ASCII);
                    bFileContentTextBox.Text = stream.ReadToEnd();
                    stream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                        stream = null;
                    }
                }
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            compare();
        }

        private void compare()
        {
            if (string.Compare(aFilePathTextBox.Text, bFilePathTextBox.Text, true) == 0 &&
                !string.IsNullOrWhiteSpace(aFilePathTextBox.Text) &&
                !string.IsNullOrWhiteSpace(aFilePathTextBox.Text))
            {
                MessageBox.Show("Same file is selected for A and B !");
                return;
            }

            if (string.Compare(aFileContentTextBox.Text, bFileContentTextBox.Text, true) == 0)
            {
                MessageBox.Show("Files are the same.");
                showDiffsButton.Enabled = false;
                return;
            }
            MessageBox.Show("Files are NOT the same!!!");
            showDiffsButton.Enabled = true;
        }

        private Form2 diffForm = null;
        private void showDiffsButton_Click(object sender, EventArgs e)
        {
            if (diffForm == null) diffForm = new Form2();
            diffForm.TextA = aFileContentTextBox.Text;
            diffForm.TextB = bFileContentTextBox.Text;
            diffForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aFileContentTextBox.Clear();
            aFilePathTextBox.Clear();
            bFileContentTextBox.Clear();
            bFilePathTextBox.Clear();
        }

        private void aFileContentTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!addCheckBox.Checked && files.GetLength(0) > 1) return;
            foreach (var file in files)
            {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".txt", StringComparison.CurrentCultureIgnoreCase))
                    e.Effect = DragDropEffects.Link;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void aFileContentTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            aFileContentTextBox.Text = string.Empty;
            foreach (var file in files)
            {
                aFilePathTextBox.Text = (string)file;
                StreamReader reader = new StreamReader(path: aFilePathTextBox.Text, encoding: System.Text.Encoding.UTF8);
                
                aFileContentTextBox.Text += reader.ReadToEnd();
                aFileContentTextBox.Text += Environment.NewLine;
                reader.Close();
            }
        }

        private void bFileContentTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!addCheckBox.Checked && files.GetLength(0) > 1) return;
            foreach (var file in files)
            {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".txt", StringComparison.CurrentCultureIgnoreCase))
                    e.Effect = DragDropEffects.Link;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void bFileContentTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            bFileContentTextBox.Text = string.Empty;
            foreach (var file in files)
            {
                bFilePathTextBox.Text = (string)file;
                StreamReader reader = new StreamReader(path: bFilePathTextBox.Text, encoding: System.Text.Encoding.UTF8);
                
                bFileContentTextBox.Text += reader.ReadToEnd();
                bFileContentTextBox.Text += Environment.NewLine;
                reader.Close();
            }
        }
    }
}
