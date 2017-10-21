using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1.src.CorrelationCalculatorTest
{
    public class LienNorminalTest
    {
        [Fact]
        public void TestLienNorminalBorneInferieure()
        {
            const string lienNorminalTest = " très forte à parfaite";

            string lienNorminal = CorrelationCalculator.getNorminalLink(0.888);

            Assert.Equal(lienNorminal, lienNorminalTest);
        }

        [Fact]
        public void TestLienNorminalBorneSuperieure()
        {
            const string lienNorminalTest = " moyenne à forte";

            string lienNorminal = CorrelationCalculator.getNorminalLink(0.5);

            Assert.Equal(lienNorminal, lienNorminalTest);
        }

        [Fact]
        public void TestLienNorminalBorneInvalide()
        {
            const string lienNorminalTest = "nulle";

            string lienNorminal = CorrelationCalculator.getNorminalLink(2);

            Assert.Equal(lienNorminal, lienNorminalTest);
        }
    }
}
