using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public class CarsCreateVMcs
    {
        [Required(ErrorMessage = "Please enter a valid value.")]
        [Display(Name = "Make")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please enter a valid value.")]
        [Range(3,5,ErrorMessage ="Please enter a value between 3 and 5")]
        public int Doors { get; set; }

        [Required(ErrorMessage ="Please enter a valid value.")]
        [Range(1,300,ErrorMessage ="This value cannot be greater than 300")]
        public int TopSpeed { get; set; }
    }
}
