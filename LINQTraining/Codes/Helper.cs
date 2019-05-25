using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace LINQTraining.Codes
{
    public class Helper
    {
        public static void CheckDB(string dbPath)
        {
            var cnStr = "data source=" + dbPath;
            if (System.IO.File.Exists(dbPath)) return;
            using (var cn = new SQLiteConnection(cnStr))
            {
                cn.Open();
                var Cmd = cn.CreateCommand();
                Cmd.CommandText = @"
CREATE TABLE student (
    std_id VARCHAR(10),
    std_name NVARCHAR(40),
    std_indate DATETIME,
    std_score INTEGER,
    CONSTRAINT student_PK PRIMARY KEY (std_id)
)";
                Cmd.ExecuteNonQuery();
            }

        }
    }
}