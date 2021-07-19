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

namespace Exercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btCopy_Click(object sender, EventArgs e) {
            if (fbdFolder.ShowDialog() == DialogResult.OK) {
                var direct = new DirectoryInfo(fbdFolder.SelectedPath);
                var directs = direct.GetFiles();

                if (fbd2.ShowDialog() == DialogResult.OK) {
                    var newDirec = new DirectoryInfo(fbd2.SelectedPath);
                    foreach (var file in directs) { 
                        File.Copy(file.FullName,$"{newDirec.FullName}/{file}_dak",overwrite:true);
                    }

                }
            }
        }
    }
}
