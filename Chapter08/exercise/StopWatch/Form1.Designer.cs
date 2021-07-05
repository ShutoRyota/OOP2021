
namespace StopWatch {
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
            this.stop = new System.Windows.Forms.Button();
            this.timeDisp = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.rapDisp = new System.Windows.Forms.Label();
            this.rap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.stop.Location = new System.Drawing.Point(340, 116);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(92, 34);
            this.stop.TabIndex = 0;
            this.stop.Text = "ストップ";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timeDisp
            // 
            this.timeDisp.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.timeDisp.Location = new System.Drawing.Point(160, 46);
            this.timeDisp.Name = "timeDisp";
            this.timeDisp.Size = new System.Drawing.Size(272, 34);
            this.timeDisp.TabIndex = 1;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.start.Location = new System.Drawing.Point(160, 116);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 34);
            this.start.TabIndex = 0;
            this.start.Text = "スタート";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.reset.Location = new System.Drawing.Point(160, 170);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(92, 34);
            this.reset.TabIndex = 0;
            this.reset.Text = "リセット";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // rapDisp
            // 
            this.rapDisp.BackColor = System.Drawing.Color.White;
            this.rapDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rapDisp.Location = new System.Drawing.Point(488, 46);
            this.rapDisp.Name = "rapDisp";
            this.rapDisp.Size = new System.Drawing.Size(194, 292);
            this.rapDisp.TabIndex = 2;
            // 
            // rap
            // 
            this.rap.AutoSize = true;
            this.rap.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.rap.Location = new System.Drawing.Point(340, 170);
            this.rap.Name = "rap";
            this.rap.Size = new System.Drawing.Size(92, 34);
            this.rap.TabIndex = 0;
            this.rap.Text = "ラップ";
            this.rap.UseVisualStyleBackColor = true;
            this.rap.Click += new System.EventHandler(this.rap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rapDisp);
            this.Controls.Add(this.timeDisp);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rap);
            this.Controls.Add(this.stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox timeDisp;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label rapDisp;
        private System.Windows.Forms.Button rap;
    }
}

