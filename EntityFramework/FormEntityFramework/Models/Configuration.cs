using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEntityFramework.Models {
    public class Configuration : DbMigrationsConfiguration<BooksDbContext>{
        //自動マイグレーション
        public Configuration() {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFramework.Models.BooksDbContext";
        }
    }
}
