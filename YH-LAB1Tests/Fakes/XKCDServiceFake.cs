using System;
using YH_LAB1.Services.XKCD;
using YH_LAB1.Services.XKCD.Models;

namespace YH_LAB1.Controllers.Fakes
{
    public class XKCDServiceFake : IXKCDService
    {
        public int GetComicCalled { get; private set; }

        public Comic GetComic(int id)
        {
            GetComicCalled++;

            return new Comic()
            {
                Title = "Detta är ett test",
                Transcript = "Lorum Ipsum..."

            };
        }
    }
}