using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class UserCar
    {
        [Key]
        public string UserName { get; set; }
        public string Car { get; set; }

    }
}
