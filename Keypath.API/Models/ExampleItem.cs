using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Keypath.API.Models
{
    public class ExampleItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required] 
        [MaxLength(100)]
        public string Word { get; set; }
        public int SortOrder { get; set; }
        
    }
}
