
namespace RssReader {
    partial class Browser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btBack = new System.Windows.Forms.Button();
            this.btForword = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Enabled = false;
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btBack.Location = new System.Drawing.Point(3, 3);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(88, 32);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "←戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btForword
            // 
            this.btForword.Enabled = false;
            this.btForword.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btForword.Location = new System.Drawing.Point(97, 3);
            this.btForword.Name = "btForword";
            this.btForword.Size = new System.Drawing.Size(84, 32);
            this.btForword.TabIndex = 1;
            this.btForword.Text = "進む→";
            this.btForword.UseVisualStyleBackColor = true;
            this.btForword.Click += new System.EventHandler(this.btForword_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(3, 41);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(909, 502);
            this.wbBrowser.TabIndex = 2;
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btForword);
            this.Controls.Add(this.btBack);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForword;
        public System.Windows.Forms.WebBrowser wbBrowser;
    }
}