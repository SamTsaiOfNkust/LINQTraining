using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQTraining.Models
{
    [Table(Name = "unit")]
    public class unit
    {
        [Column(Name = "unt_id", IsPrimaryKey = true, CanBeNull = false)]
        public string UntId { get; set; } // varchar(16)
        [Column(Name = "unt_name")]
        public string UntName { get; set; }
    }
}