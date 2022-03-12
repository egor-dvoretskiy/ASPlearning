using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_site_1.Domain.Entities
{
    public class ServiceItem : EntityBase
    {

        [Required(ErrorMessage = "Enter service name.")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Short service description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full service description")]
        public override string Text { get; set; }
    }
}
