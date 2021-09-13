
namespace RssReader {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btWebDisp = new System.Windows.Forms.Button();
            this.tbUpdateDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdisc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbUrl.Location = new System.Drawing.Point(166, 18);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(604, 27);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(9, 60);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(256, 499);
            this.lbTitles.TabIndex = 3;
            this.lbTitles.Click += new System.EventHandler(this.lbTitles_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(808, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(110, 33);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btWebDisp
            // 
            this.btWebDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btWebDisp.Location = new System.Drawing.Point(855, 90);
            this.btWebDisp.Name = "btWebDisp";
            this.btWebDisp.Size = new System.Drawing.Size(141, 36);
            this.btWebDisp.TabIndex = 6;
            this.btWebDisp.Text = "ブラウザ表示";
            this.btWebDisp.UseVisualStyleBackColor = true;
            this.btWebDisp.Click += new System.EventHandler(this.btWebDisp_Click);
            // 
            // tbUpdateDate
            // 
            this.tbUpdateDate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbUpdateDate.Location = new System.Drawing.Point(406, 95);
            this.tbUpdateDate.Name = "tbUpdateDate";
            this.tbUpdateDate.Size = new System.Drawing.Size(434, 27);
            this.tbUpdateDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(282, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "最終更新日";
            // 
            // lbdisc
            // 
            this.lbdisc.BackColor = System.Drawing.Color.White;
            this.lbdisc.Location = new System.Drawing.Point(283, 131);
            this.lbdisc.Name = "lbdisc";
            this.lbdisc.Size = new System.Drawing.Size(713, 249);
            this.lbdisc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 565);
            this.Controls.Add(this.lbdisc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUpdateDate);
            this.Controls.Add(this.btWebDisp);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32005";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btWebDisp;
        private System.Windows.Forms.TextBox tbUpdateDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdisc;
    }
}

