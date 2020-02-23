using YH_LAB1.Services.XKCD.Models;

namespace YH_LAB1.Services.XKCD
{
    public interface IXKCDService
    {
        Comic GetComic(int id);
    }
}