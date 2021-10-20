
namespace FormEntityFramework {
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
            this.btSearch = new System.Windows.Forms.Button();
            this.tbInputTitle = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btForm2Open = new System.Windows.Forms.Button();
            this.btForm3Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(315, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "検索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbInputTitle
            // 
            this.tbInputTitle.Location = new System.Drawing.Point(12, 12);
            this.tbInputTitle.Name = "tbInputTitle";
            this.tbInputTitle.Size = new System.Drawing.Size(274, 19);
            this.tbInputTitle.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 53);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(378, 267);
            this.tbOutput.TabIndex = 2;
            // 
            // btForm2Open
            // 
            this.btForm2Open.Location = new System.Drawing.Point(422, 297);
            this.btForm2Open.Name = "btForm2Open";
            this.btForm2Open.Size = new System.Drawing.Size(75, 23);
            this.btForm2Open.TabIndex = 3;
            this.btForm2Open.Text = "書籍登録";
            this.btForm2Open.UseVisualStyleBackColor = true;
            this.btForm2Open.Click += new System.EventHandler(this.btForm2Open_Click);
            // 
            // btForm3Open
            // 
            this.btForm3Open.Location = new System.Drawing.Point(422, 247);
            this.btForm3Open.Name = "btForm3Open";
            this.btForm3Open.Size = new System.Drawing.Size(75, 23);
            this.btForm3Open.TabIndex = 4;
            this.btForm3Open.Text = "作家登録";
            this.btForm3Open.UseVisualStyleBackColor = true;
            this.btForm3Open.Click += new System.EventHandler(this.btForm3Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.btForm3Open);
            this.Controls.Add(this.btForm2Open);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInputTitle);
            this.Controls.Add(this.btSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbInputTitle;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btForm2Open;
        private System.Windows.Forms.Button btForm3Open;
    }
}

