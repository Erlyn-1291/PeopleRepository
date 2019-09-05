using System;
using System.Collections.Generic;
using System.Text; 
using SQLite;

namespace People.Models
{
    [Table("T_People")]

    public class Person
    {
        
        //Miembro Propietes
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
