using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimPark.Models
{
    public class RandomQuotations
    {
        [Key]
        public int RQ_ID { get; set; }
        public string Quotation { get; set; }
    }
}
