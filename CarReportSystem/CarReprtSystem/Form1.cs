using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarReprtSystem.CarReport;

namespace CarReprtSystem {
    public partial class fmMain : Form {

        public fmMain() {
            InitializeComponent();
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


        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked)
                    return (MakerGroup)Enum.Parse(typeof(MakerGroup), ((RadioButton)rb).Text);
            }
            return MakerGroup.その他;

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


        private void setMakerRb(CarReport.MakerGroup maker) {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Tag.ToString() == ((int)maker).ToString()) {
                    ((RadioButton)rb).Checked = true;
                    break;
                }
                rbOthers.Checked = true;
            }
        }
        
        //更新ボタン
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAutherName.Text;
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;
            

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202126DataSet);

        }

        //接続ボタン
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202126DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202126DataSet.CarReport);

            SetcbAuthorAndCar();
            bindingNavigator1.Enabled = true;
        }


        private void ClearScreen() {
            dtpDate.Value = DateTime.Now;
            cbAutherName.Text = string.Empty;
            rbOthers.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202126DataSet);

        }

        private void fmMain_Load(object sender, EventArgs e) {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].Visible = false;
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            ClearScreen();
            try {
                btConnect.Enabled = false;

                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cbAutherName.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRb((MakerGroup)Enum.Parse(typeof(MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image =  (Image)new ImageConverter().ConvertFrom(carReportDataGridView.CurrentRow.Cells[6].Value);
                //ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
                
            }
            catch (Exception ex) { }
            
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
        
        //コンボボックスに名前を設定
        private void SetcbAuthorAndCar() {
            foreach (var item in infosys202126DataSet.CarReport) {
                if (!string.IsNullOrWhiteSpace(item.Author)) 
                    SetCbAuther(item.Author);
                if(!string.IsNullOrWhiteSpace(item.CarName))
                    SetCbCarName(item.CarName);
            }
        }
    
    }


}
