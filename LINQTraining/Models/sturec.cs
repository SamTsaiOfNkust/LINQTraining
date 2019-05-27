using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQTraining.Models
{
    [Table(Name = "sturec")]
    public class sturec
    {
        [Column(Name = "std_id", IsPrimaryKey = true, CanBeNull = false)]
        public string StudentId { get; set; } // varchar(16)
        [Column(Name = "unt_id")]
        public string UntId { get; set; }
    }
}