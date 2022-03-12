using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_site_1.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name (title)")]
        public override string Title { get; set; } = "Info page";

        [Display(Name = "Content page")]
        public override string Text { get; set; } = "Content filling by admin.";
    }
}
