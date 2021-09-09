
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
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(913, 543);
            this.wbBrowser.TabIndex = 0;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wbBrowser;
    }
}