using CalculationConsole;

namespace CalculationConsoleTest;

public class OperationTest
{
    [Fact]
    public void MakeSumArrayIntSuccess()
    {
        int[] test = { 1, 2, 3 };
        
        var result = Operation.SumArrayInt(test);
        
        Assert.Equal(6, result);
    }
    [Theory]
    [InlineData(1,-2)]
    [InlineData(1,-3)]
    [InlineData(-1,-2)]
    [InlineData(-1,2)]
    public void MakeSumArrayIntWithNegativeNums(int val1, int val2)
    {
        int[] test = { val1, val2 };
        
        var ex = Assert.Throws<InvalidOperationException>(() => Operation.SumArrayInt(test));
        
        Assert.Contains("O valor não pode ser menor que zero", ex.Message);
    }
}