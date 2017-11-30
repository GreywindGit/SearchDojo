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

namespace SearchDojo
{
    public partial class Matcher : System.Windows.Forms.Form
    {
        public Matcher()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            lvMatches.Items.Clear();
            if (!String.IsNullOrEmpty(tbPattern.Text) && !String.IsNullOrEmpty(rtbText.Text))
            {
                List<string> result = RegexManager.SearchAndGetMatches(rtbText.Text, tbPattern.Text);
                try
                {
                    foreach (string item in result)
                    {
                        lvMatches.Items.Add(item);
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult fileToOpen = openFileDialog.ShowDialog();
            if (fileToOpen == DialogResult.OK)
            {
                string openedFileName = openFileDialog.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(openedFileName))
                    {
                        rtbText.Text = reader.ReadToEnd();
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
