using System;
using System.IO;
using System.Windows.Forms;

namespace Text_Packer
{
    /// <summary>
    /// The main form.
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }

        /// <summary>
        /// Show an exception.
        /// </summary>
        /// <param name="ex">The exception to show.</param>
        private void ShowException(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        /// <summary>
        /// Gets the full path of data file.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The events arguments.</param>
        private void BtnOpenDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FDialog = new OpenFileDialog
            {
                Title = "Open packet file...",
                FileName = Path.GetFileName(TBoxDataFile.Text),
                Filter = "All files|*.*"
            };

            if (FDialog.ShowDialog() == DialogResult.OK)
                TBoxDataFile.Text = FDialog.FileName;

            if (TBoxTextFile.Text == string.Empty && TBoxDataFile.Text != string.Empty)
                TBoxTextFile.Text = Path.Combine(Path.GetDirectoryName(TBoxDataFile.Text), Path.GetFileNameWithoutExtension(TBoxDataFile.Text) + ".TXT");
        }
        /// <summary>
        /// Gets the full path of text file.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The events arguments.</param>
        private void BtnOpenTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FDialog = new OpenFileDialog
            {
                Title = "Open packet file...",
                FileName = Path.GetFileName(TBoxDataFile.Text),
                Filter = "Text files|*.txt|All files|*.*"
            };

            if (FDialog.ShowDialog() == DialogResult.OK)
                TBoxTextFile.Text = FDialog.FileName;
        }

        /// <summary>
        /// Extracts text from a data buffer.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The events arguments.</param>
        private void BtnExtract_Click(object sender, EventArgs e)
        {
            byte[] buffer;
            string[] result;
            byte bits;

            try
            {
                buffer = File.ReadAllBytes(Path.GetFullPath(TBoxDataFile.Text));
                if (RBtn16Bits.Checked)
                    bits = 16;
                else if (RBtn32Bits.Checked)
                    bits = 32;
                else
                    bits = 16;

                result = Lib.TextPacker.Extract(bits, buffer);

                File.WriteAllLines(Path.GetFullPath(TBoxTextFile.Text), result);

                TitleInfo.Text = "Texts extracted from " + Path.GetFileName(TBoxDataFile.Text);
            }
            catch (Exception ex) { ShowException(ex); }
        }
        /// <summary>
        /// Inserts text into a data buffer.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The events arguments.</param>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            byte[] buffer;
            string[] result;
            byte bits;

            try
            {
                result = File.ReadAllLines(Path.GetFullPath(TBoxTextFile.Text));
                if (RBtn16Bits.Checked)
                    bits = 16;
                else if (RBtn32Bits.Checked)
                    bits = 32;
                else
                    bits = 16;

                buffer = Lib.TextPacker.Insert(bits, result);

                File.WriteAllBytes(Path.GetFullPath(TBoxDataFile.Text), buffer);

                TitleInfo.Text = "Texts inserted from " + Path.GetFileName(TBoxTextFile.Text);
            }
            catch (Exception ex) { ShowException(ex); }
        }
    }
}
