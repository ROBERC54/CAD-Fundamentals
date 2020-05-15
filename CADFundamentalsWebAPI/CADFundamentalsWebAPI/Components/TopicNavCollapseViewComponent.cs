using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CADFundamentalsWebAPI.Data;
using CADFundamentalsWebAPI.Models;

namespace CADFundamentalsWebAPI.Components
{
    public class TopicNavCollapseViewComponent : ViewComponent
    {
        private readonly CADFundamentalsWebAPIContext _context;
        public TopicNavCollapseViewComponent(CADFundamentalsWebAPIContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(UberCategory uberCategory)
        {

            return View(_context.Topic
                .Where(x => x.UberCategoryId == uberCategory.Id));

        }
    }
}
