using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CADFundamentalsWebAPI.Models
{
    public class UberCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime LatestReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Complexity { get; set; }
        public decimal Price { get; set; }
    }
}
