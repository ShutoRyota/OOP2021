
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.tbLeap = new System.Windows.Forms.TextBox();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbOutput.Location = new System.Drawing.Point(96, 107);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(308, 29);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(329, 18);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(75, 23);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // tbLeap
            // 
            this.tbLeap.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbLeap.Location = new System.Drawing.Point(96, 142);
            this.tbLeap.Name = "tbLeap";
            this.tbLeap.Size = new System.Drawing.Size(308, 29);
            this.tbLeap.TabIndex = 0;
            // 
            // dTP1
            // 
            this.dTP1.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dTP1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dTP1.Location = new System.Drawing.Point(96, 14);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(200, 23);
            this.dTP1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dTP1);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbLeap);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.TextBox tbLeap;
        private System.Windows.Forms.DateTimePicker dTP1;
    }
}

