using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_LampshadeQuery.Contracts.Slide;
using SopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _context;

        public SlideQuery(ShopContext context)
        {
            _context = context;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _context.Slides.Where(x => x.IsRemoved == false)
                .Select(x => new SlideQueryModel()
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Heading = x.Heading,
                    Title = x.Title,
                    Text = x.Text,
                    Link = x.Link,
                    BtnText = x.BtnText
                })
                .ToList();
        }
    }
}
