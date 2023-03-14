using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_api.Models
{
    public class unitList
    {
        public string unitItemId { get; set; }
        public string unitItemName { get; set; }
        [Key]
        public string unitId { get; set; }
        public string unitName { get; set; }
    }
}
