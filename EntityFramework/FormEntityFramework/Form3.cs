using FormEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEntityFramework {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public Form3(string name) {
            InitializeComponent();
            tbAutherName.Text = name;
        }

        private void touroku_Click(object sender, EventArgs e) {
            try {

                using (var db = new BooksDbContext()) {
                    var author1 = new Author {
                        Birthday = new DateTime(dtpBirth.Value.Year, dtpBirth.Value.Month, dtpBirth.Value.Day),
                        Gender = cbGender.Text,
                        Name = tbAutherName.Text
                    };
                    db.Authors.Add(author1);
                    db.SaveChanges();
                    MessageBox.Show("登録完了");
                    this.Close();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }

}