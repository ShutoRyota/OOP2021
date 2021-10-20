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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e) {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(s=>s.Title==tbInputTitle.Text).ToList();

                foreach (var book in books) {
                    tbOutput.Text += $"{book.Title} {book.PublishedYear}年 {book.Author.Name}";
                }
            }
        }

        private void btForm2Open_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btForm3Open_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
