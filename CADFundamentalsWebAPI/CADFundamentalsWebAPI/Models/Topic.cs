using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CADFundamentalsWebAPI.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime LatestReleaseDate { get; set; }
        public string UberCategory { get; set; }
        public int UberCategoryId { get; set; }
        public decimal Complexity { get; set; }
        public decimal Price { get; set; }
    }
}
