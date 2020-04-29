using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required,MaxLength(60)]
        public string Name { get; set; }
        [Required, Range(0,1000)]
        [DisplayFormat(DataFormatString =("{0:C}"))]
        public int Price { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Required, Range(0, 1000)]
        public int Count { get; set; }

        public string Description { get; set; }
    }
}
