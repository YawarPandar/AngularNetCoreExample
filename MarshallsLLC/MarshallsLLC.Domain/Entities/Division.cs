﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MarshallsLLC.Domain.Entities
{
    public class Division
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}
