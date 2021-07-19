
namespace Exercise1 {
    partial class Form1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btRAL = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.btLR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(25, 77);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(608, 361);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(25, 13);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(88, 44);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btRAL
            // 
            this.btRAL.Location = new System.Drawing.Point(267, 17);
            this.btRAL.Name = "btRAL";
            this.btRAL.Size = new System.Drawing.Size(118, 37);
            this.btRAL.TabIndex = 2;
            this.btRAL.Text = "ReadAllLines";
            this.btRAL.UseVisualStyleBackColor = true;
            this.btRAL.Click += new System.EventHandler(this.btRAL_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(119, 26);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(120, 19);
            this.tbKeyWord.TabIndex = 3;
            // 
            // btLR
            // 
            this.btLR.Location = new System.Drawing.Point(419, 17);
            this.btLR.Name = "btLR";
            this.btLR.Size = new System.Drawing.Size(122, 37);
            this.btLR.TabIndex = 4;
            this.btLR.Text = "ReadLines";
            this.btLR.UseVisualStyleBackColor = true;
            this.btLR.Click += new System.EventHandler(this.btLR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 457);
            this.Controls.Add(this.btLR);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btRAL);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btRAL;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Button btLR;
    }
}

