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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void btRegistration_Click(object sender, EventArgs e) {
            try {
                using (var db = new BooksDbContext()) {
                    var author1 = db.Authors.Single(a => a.Name == tbAuthor.Text);
                    var book1 = new Book {
                        Title = tbTitle.Text,
                        PublishedYear = int.Parse(tbPublish.Text),
                        Author = author1,

                    };
                    db.Books.Add(book1);
                    db.SaveChanges();
                    MessageBox.Show("登録完了");
                    this.Close();
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
