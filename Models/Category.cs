using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]

        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        [DisplayName("Display Order")]
        public int? DisplayOrder { get; set; }
    }
}
