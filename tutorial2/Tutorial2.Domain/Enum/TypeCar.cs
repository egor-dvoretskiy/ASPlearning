using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Sedan")]
        Sedan = 0,

        [Display(Name = "Hatchback")]
        Hatchback,

        [Display(Name = "Liftback")]
        Liftback,
        
        [Display(Name = "Minivan")]
        Minivan,

        [Display(Name = "SUV")]
        SUV,

        [Display(Name = "Sportcar")]
        Sportcar
    }
}
