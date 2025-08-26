using LexiconConsole;

namespace Tester
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            float expected = 10f;
            float value = Calculator.DoAddition(5f, 5f);
            Assert.Equal(expected, value);
        }
        [Fact]
        public void TestSubtraction()
        {
            float expected = 0f;
            float value = Calculator.DoSubtraction(5f, 5f);
            Assert.Equal(expected, value);
        }
        [Fact]
        public void TestMultiplication()
        {
            float expected = 10f;
            float value = Calculator.DoMultiplication(5f, 2f);
            Assert.Equal(expected, value);
        }
        [Fact]
        public void TestDivision()
        {
            float expected = 10f;
            float value = Calculator.DoDivision(100f, 10f);
            Assert.Equal(expected, value);
        }
        [Fact]
        public void TestPower()
        {
            float expected = 256f;
            float value = Calculator.DoPower(2f, 8f);
            Assert.Equal(expected, value);
        }
        [Fact]
        public void TestRoot()
        {
            string expected = "8";
            string value = Calculator.DoRoot(2f, 64f);
            Assert.Equal(expected, value);
            expected = "imaginary";
            value = Calculator.DoRoot(3f, -1);
            Assert.Equal(expected, value);
        }
    }
}
