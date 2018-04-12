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

namespace Engraver_s_Friend
{
    /*
    * Application Author: Jeremy Booth
    * Company of Ownership: Bell Company, Inc.
    * This application is the property of Bell Company, Inc and it's subsidiaries.
    * It is not to be used for any purposes not expressly defined by Bell Company, Inc.
    * This application may not be reproduced, modified or redistributed without written approval from Bell Company, Inc.
    * 
    * Persons and Entities who may make changes to the function of this application, general or otherwise,
    * who shall not be considered subject to the aforementioned terms of use are as follows:
    * Bell Company, Inc.
    * Neil H. Bell
    * Virginia Bell
    * Christopher Bell
    * Burt Bagley
    * Jeremy Booth
    * 
    * Bell Company, Inc reserves the right to modify these Terms of Use at any time for any reason. 
    */
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void SSImport_Click(object sender, EventArgs e)
        {

        }

        private void SSBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f1 = new FolderBrowserDialog();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    SSPATH.Text = f1.SelectedPath;
                }
            }
            catch
            {

            }
        }

        private void DBBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f2 = new FolderBrowserDialog();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    DBPATH.Text = f2.SelectedPath;
                }
            }
            catch
            {

            }
        }
    }
}
