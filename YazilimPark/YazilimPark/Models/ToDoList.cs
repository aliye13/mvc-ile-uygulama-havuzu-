using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimPark.Models
{
    public class ToDoList
    {
        [Key]
        public int TDL_ID { get; set; }
        public DateTime addDate { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "2 Karekterden fazla olmalı")]
        [MaxLength(200, ErrorMessage = "200 Karekterden az olmalı")]
        public string toDoListItem { get; set; }
        public bool isDone { get; set; }


    }
}
