using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LINQTraining.Models
{
    [Table(Name = "student")]
    public partial class Student
    {
        [Column(Name = "std_id" , IsPrimaryKey = true, CanBeNull = false)]
        public string StudentId { get; set; } // varchar(16)
        [Column(Name = "std_name",CanBeNull = true)]
        public string Name { get; set; } // varchar(32)
        [Column(Name = "std_indate",CanBeNull =true)]
        public DateTime? Indate { get; set; } // datetime
        [Column(Name = "std_score",CanBeNull =true)]
        public long? Score { get; set; } // integer
    }
}