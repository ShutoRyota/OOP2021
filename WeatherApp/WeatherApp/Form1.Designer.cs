
namespace WeatherApp {
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
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cbArea.Items.AddRange(new object[] {
            "東京都",
            "神奈川県",
            "埼玉県",
            "千葉県",
            "茨城県",
            "栃木県",
            "群馬県",
            "山梨県"});
            this.cbArea.Location = new System.Drawing.Point(159, 26);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 28);
            this.cbArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "地域を選択";
            // 
            // btView
            // 
            this.btView.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btView.Location = new System.Drawing.Point(322, 19);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(129, 41);
            this.btView.TabIndex = 2;
            this.btView.Text = "天気を表示";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(22, 73);
            this.tbresult.Multiline = true;
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(766, 379);
            this.tbresult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.TextBox tbresult;
    }
}

