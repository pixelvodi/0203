using Xunit;
using CalculatorModule;

namespace Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            var calc = new Calculator();
            var result = calc.Add(2, 3);
            Assert.Equal(6, result); // ❌ Ошибка: 2+3=5, а не 6
        }
    }
}
