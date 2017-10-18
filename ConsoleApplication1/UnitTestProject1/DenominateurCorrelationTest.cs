using ConsoleApplication1;
using System.IO;
using Xunit;

namespace UnitTestProject
{
    public class DenominateurCorrelationTest
    {
        [Fact]
        public void TestDenominateurCorrelationInferieure()
        {
            const double denominateurTest = 144;

            double sommeExposantX = 68;
            double sommePowX = 100;

            double sommeExposantY = 34;
            double sommePowY = 64;

            int nbrPairDonnees = 2;

            double denominateur = CorrelationCalculator.calculDenominateurCorrelation(sommeExposantX, sommeExposantY, sommePowX, sommePowY, nbrPairDonnees);

            Assert.Equal(denominateur, denominateurTest);
        }

        [Fact]
        public void TestDenominateurCorrelationSuperieure()
        {
            const double denominateurTest = 195.64;

            double sommeExposantX = 34.83;
            double sommePowX = 64.3;

            double sommeExposantY = 68.7;
            double sommePowY = 100.9;

            int nbrPairDonnees = 2;

            double denominateur = CorrelationCalculator.calculDenominateurCorrelation(sommeExposantX, sommeExposantY, sommePowX, sommePowY, nbrPairDonnees);

            Assert.Equal(denominateur, denominateurTest);
        }

        [Fact]
        public void TestDenominateurCorrelationInvalide()
        {
            const double denominateurTest = 0;

            double sommeExposantX = 64;
            double sommePowX = 64;

            double sommeExposantY = 64;
            double sommePowY = 64;

            int nbrPairDonnees = 1;

            double denominateur = CorrelationCalculator.calculDenominateurCorrelation(sommeExposantX, sommeExposantY, sommePowX, sommePowY, nbrPairDonnees);

            Assert.Equal(denominateur, denominateurTest);
        }
    }
}
