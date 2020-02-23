using System;
using YH_LAB1.Services.XKCD;
using YH_LAB1.Services.XKCD.Models;

namespace YH_LAB1.Controllers.Fakes
{
    public class XKCDServiceFake : IXKCDService
    {
        public Comic GetComic(int id)
        {
            return new Comic()
            {
                Title = "Detta är ett test",
                Transcript = "Lorum Ipsum..."

            };
        }
    }
}