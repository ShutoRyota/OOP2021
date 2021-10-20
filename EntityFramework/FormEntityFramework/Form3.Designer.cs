
namespace FormEntityFramework {
    partial class Form3 {
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
            this.touroku = new System.Windows.Forms.Button();
            this.tbAutherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // touroku
            // 
            this.touroku.Location = new System.Drawing.Point(342, 207);
            this.touroku.Name = "touroku";
            this.touroku.Size = new System.Drawing.Size(54, 29);
            this.touroku.TabIndex = 0;
            this.touroku.Text = "登録";
            this.touroku.UseCompatibleTextRendering = true;
            this.touroku.UseVisualStyleBackColor = true;
            this.touroku.Click += new System.EventHandler(this.touroku_Click);
            // 
            // tbAutherName
            // 
            this.tbAutherName.Location = new System.Drawing.Point(131, 75);
            this.tbAutherName.Name = "tbAutherName";
            this.tbAutherName.Size = new System.Drawing.Size(280, 19);
            this.tbAutherName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "生年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(131, 131);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 19);
            this.dtpBirth.TabIndex = 3;
            this.dtpBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGender.Location = new System.Drawing.Point(131, 207);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(39, 20);
            this.cbGender.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 276);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAutherName);
            this.Controls.Add(this.touroku);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button touroku;
        private System.Windows.Forms.TextBox tbAutherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cbGender;
    }
}