using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimPark.Models
{
    public class Applications
    {
        public string applicationName { get; set; }
        public string image { get; set; }
        public string applicationController { get; set; }
        public string applicationAction { get; set; }

    }
}
