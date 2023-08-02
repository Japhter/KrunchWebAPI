using KrunchWebAPI.KrunchService;
using System.Collections;

namespace KrunchUnitTests
{
    public class KrunchServiceTests
    {
        KrunchService _servive;
        [SetUp]
        public void Setup()
        {
            _servive = new KrunchService();
        }

        [Test]
        public void CrunchPhraseTest1()
        {
            string phrase = "NOW IS THE TIME FOR ALL GOOD MEN TO COME TO THE AID OF THEIR COUNTRY";

            var crunchedWord = _servive.CrunchPhrase(phrase);

            Assert.That(crunchedWord, Is.EqualTo("NW S TH M FR L GD C Y"));
        }

        [Test]
        public void CrunchPhraseTest2()
        {
            string phrase = "RAILROAD CROSSING";

            var crunchedWord = _servive.CrunchPhrase(phrase);

            Assert.That(crunchedWord, Is.EqualTo("RLD CSNG"));
        }
    }
}