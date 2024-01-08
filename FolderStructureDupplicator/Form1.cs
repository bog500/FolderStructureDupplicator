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

namespace FolderStructureDupplicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ((Control)sender).Enabled = false;
            DirectoryInfo diSrc = new DirectoryInfo(txtFolderSource.Text);
            DirectoryInfo diDes = new DirectoryInfo(txtFolderDest.Text);
            Explore(diSrc, diDes);
            ((Control)sender).Enabled = true;
            MessageBox.Show("Completed");
        }

        private void Explore(DirectoryInfo diSrc, DirectoryInfo diDes)
        {
            if(diDes.Exists == false)
            {
                diDes.Create();
            }

            foreach(var sub in diSrc.GetDirectories())
            {
                string subDesStr = Path.Combine(diDes.FullName, sub.Name);
                DirectoryInfo subDes = new DirectoryInfo(subDesStr);
                Explore(sub, subDes);
            }
        }
    }
}
