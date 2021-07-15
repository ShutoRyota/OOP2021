using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReprtSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }


        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void btPictureOpen_Click(object sender, EventArgs e) {
            
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);

            }
        }


        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }


        private void btDataAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(cbAutherName.Text) || string.IsNullOrEmpty(cbCarName.Text)) {
                MessageBox.Show("全ての項目を入力してください");
                return;
            }
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAutherName.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };

            listCarReport.Add(carReport);
            //記録
            SetCbAuther(cbAutherName.Text);
            SetCbCarName(cbCarName.Text);

            ClearScreen();
        }


        private CarReport.MakerGroup selectedGroup() {

            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked)
                    return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
            }
            return CarReport.MakerGroup.その他;

        }


        //記録者セット
        private void SetCbAuther(string name) {
            if (!cbAutherName.Items.Contains(name)) {
                cbAutherName.Items.Add(name);
            }
        }

        //車名セット
        private void SetCbCarName(string name) {
            if (!cbCarName.Items.Contains(name)) {
                cbCarName.Items.Add(name);
            }
        }


        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex < 0)  return;

            CarReport selected = listCarReport[e.RowIndex];
            dtpDate.Value = selected.Date;
            cbAutherName.Text = selected.Auther;
            setMakerRb(selected.Maker);
            cbCarName.Text = selected.CarName;
            tbReport.Text = selected.Report;
            pbPicture.Image = selected.Picture;
            
        }


        private void setMakerRb(CarReport.MakerGroup maker) {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Tag.ToString() == ((int)maker).ToString()) {
                    ((RadioButton)rb).Checked = true;
                    break;
                }
                rbOthers.Checked = true;
            }
        }


        private void btDataDelete_Click(object sender, EventArgs e) {
            if (listCarReport.Count<1) return;

            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
            
            ClearScreen();
        }


        private void btDataCorrect_Click(object sender, EventArgs e) {
            if (dgvRegistData.CurrentRow == null) return;

            listCarReport[dgvRegistData.CurrentRow.Index].Update(
                                        dtpDate.Value, cbAutherName.Text,selectedGroup(),
                                        cbCarName.Text,tbReport.Text, pbPicture.Image);

            
            dgvRegistData.Refresh();
        }
        
        
        private void btSave_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                //バイナリ形式でシリアル化
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(sfdFileSave.FileName,FileMode.Create)) {
                    bf.Serialize(fs, listCarReport);
                }
            }
        }


        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                //バイナリ形式で逆シリアル化
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                    //逆シリアル化して読み込む
                    listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                    dgvRegistData.DataSource = null;
                    dgvRegistData.DataSource = listCarReport;
                }

            }
        }


        private void ClearScreen() {
            cbAutherName.Text = string.Empty;
            rbOthers.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
        }
    }
}
