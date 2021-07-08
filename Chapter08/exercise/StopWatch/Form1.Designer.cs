
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
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.lap = new System.Windows.Forms.Button();
            this.timeDisp = new System.Windows.Forms.Label();
            this.lapDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.stop.Location = new System.Drawing.Point(294, 116);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(138, 49);
            this.stop.TabIndex = 0;
            this.stop.Text = "ストップ";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.start.Location = new System.Drawing.Point(150, 116);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(138, 49);
            this.start.TabIndex = 0;
            this.start.Text = "スタート";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.reset.Location = new System.Drawing.Point(150, 171);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(138, 49);
            this.reset.TabIndex = 0;
            this.reset.Text = "リセット";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // lap
            // 
            this.lap.AutoSize = true;
            this.lap.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lap.Location = new System.Drawing.Point(294, 171);
            this.lap.Name = "lap";
            this.lap.Size = new System.Drawing.Size(138, 49);
            this.lap.TabIndex = 0;
            this.lap.Text = "ラップ";
            this.lap.UseVisualStyleBackColor = true;
            this.lap.Click += new System.EventHandler(this.rap_Click);
            // 
            // timeDisp
            // 
            this.timeDisp.BackColor = System.Drawing.Color.White;
            this.timeDisp.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.timeDisp.Location = new System.Drawing.Point(150, 56);
            this.timeDisp.Name = "timeDisp";
            this.timeDisp.Size = new System.Drawing.Size(282, 57);
            this.timeDisp.TabIndex = 2;
            // 
            // lapDisp
            // 
            this.lapDisp.FormattingEnabled = true;
            this.lapDisp.ItemHeight = 12;
            this.lapDisp.Location = new System.Drawing.Point(457, 56);
            this.lapDisp.Name = "lapDisp";
            this.lapDisp.Size = new System.Drawing.Size(219, 256);
            this.lapDisp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 367);
            this.Controls.Add(this.lapDisp);
            this.Controls.Add(this.timeDisp);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.lap);
            this.Controls.Add(this.stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button lap;
        private System.Windows.Forms.Label timeDisp;
        private System.Windows.Forms.ListBox lapDisp;
    }
}

