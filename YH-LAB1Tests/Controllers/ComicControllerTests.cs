using YH_LAB1.Controllers;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YH_LAB1.Services.XKCD;
using YH_LAB1.Controllers.Fakes;

namespace YH_LAB1.Controllers.Tests
{
    [TestClass()]
    public class ComicControllerTests
    {

        [TestMethod()]
        public void Get_Should_Map_Title_And_Transcript()
        {

            // Arrange:
            IXKCDService xkcdService = new XKCDServiceFake();
            var systemUnderTest = new ComicController(xkcdService);

            //Act
            var comic = systemUnderTest.Get(1);

            //Assert
            Assert.AreEqual("Detta är ett test", comic.Value.Title);
            Assert.AreEqual("Lorum Ipsum...", comic.Value.Transcript);
        }
    }
}