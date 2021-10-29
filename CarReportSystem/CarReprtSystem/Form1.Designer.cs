
namespace CarReprtSystem {
    partial class fmMain {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.cbAutherName = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbSbar = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.infosys202126DataSet = new CarReprtSystem.infosys202126DataSet();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportTableAdapter = new CarReprtSystem.infosys202126DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReprtSystem.infosys202126DataSetTableAdapters.TableAdapterManager();
            this.carReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202126DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(85, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.Control;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(541, 67);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(290, 204);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 2;
            this.pbPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "日付：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(85, 162);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(425, 109);
            this.tbReport.TabIndex = 4;
            // 
            // cbAutherName
            // 
            this.cbAutherName.FormattingEnabled = true;
            this.cbAutherName.Location = new System.Drawing.Point(85, 67);
            this.cbAutherName.Name = "cbAutherName";
            this.cbAutherName.Size = new System.Drawing.Size(190, 20);
            this.cbAutherName.TabIndex = 5;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(85, 133);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(190, 20);
            this.cbCarName.TabIndex = 5;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbOthers);
            this.gbMaker.Controls.Add(this.rbImport);
            this.gbMaker.Controls.Add(this.rbSbar);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(85, 93);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(411, 37);
            this.gbMaker.TabIndex = 6;
            this.gbMaker.TabStop = false;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Checked = true;
            this.rbOthers.Location = new System.Drawing.Point(294, 15);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(54, 16);
            this.rbOthers.TabIndex = 0;
            this.rbOthers.TabStop = true;
            this.rbOthers.Tag = "5";
            this.rbOthers.Text = "その他";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(236, 15);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(59, 16);
            this.rbImport.TabIndex = 0;
            this.rbImport.TabStop = true;
            this.rbImport.Tag = "4";
            this.rbImport.Text = "外国車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSbar
            // 
            this.rbSbar.AutoSize = true;
            this.rbSbar.Location = new System.Drawing.Point(178, 15);
            this.rbSbar.Name = "rbSbar";
            this.rbSbar.Size = new System.Drawing.Size(52, 16);
            this.rbSbar.TabIndex = 0;
            this.rbSbar.TabStop = true;
            this.rbSbar.Tag = "3";
            this.rbSbar.Text = "スバル";
            this.rbSbar.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(125, 16);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 0;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(72, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 0;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(19, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(538, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "画像：";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(15, 341);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(55, 32);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(15, 304);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(55, 31);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(592, 32);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(55, 32);
            this.btPictureOpen.TabIndex = 7;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1200, -316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(653, 33);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(55, 31);
            this.btPictureDelete.TabIndex = 7;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(7, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "記事一覧：";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(15, 488);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(55, 32);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // infosys202126DataSet
            // 
            this.infosys202126DataSet.DataSetName = "infosys202126DataSet";
            this.infosys202126DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202126DataSet;
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReprtSystem.infosys202126DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carReportDataGridView
            // 
            this.carReportDataGridView.AllowUserToAddRows = false;
            this.carReportDataGridView.AutoGenerateColumns = false;
            this.carReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDataGridView.DataSource = this.carReportBindingSource;
            this.carReportDataGridView.Location = new System.Drawing.Point(85, 277);
            this.carReportDataGridView.Name = "carReportDataGridView";
            this.carReportDataGridView.RowTemplate.Height = 21;
            this.carReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDataGridView.Size = new System.Drawing.Size(746, 249);
            this.carReportDataGridView.TabIndex = 23;
            this.carReportDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDataGridView_DataError);
            this.carReportDataGridView.SelectionChanged += new System.EventHandler(this.carReportDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.carReportBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Enabled = false;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(859, 25);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 537);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.carReportDataGridView);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAutherName);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.dtpDate);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202126DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.ComboBox cbAutherName;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbSbar;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private infosys202126DataSet infosys202126DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202126DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202126DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

