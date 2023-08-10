namespace Complex_Xunit_Test;

public class UnitTest1
{
    [Fact]
    public void ComplexOperatorTest()
    {
        Complex complex1 = new(4, 3);
        Complex complex2 = new(4, 3);

        Complex complexAdd = complex1 + complex2;
        Complex expected = new Complex(8, 6);

        Assert.Equal(expected._imag, complexAdd._imag);
        Assert.Equal(expected._real, complexAdd._real);
    }

    [Theory]
    [InlineData(3, 3, 3, 3, 6, 6)]
    public void ComplexAddOperatorBatchTest(int realA, int imagA, int realB, int imagB, int realExpected, int imagExpected)
    {
        Complex complex1 = new(realA, imagA);
        Complex complex2 = new(realB, imagB);
        Complex result = complex1 + complex2;

        Assert.Equal(result._real, realExpected);
        Assert.Equal(result._imag, imagExpected);
    }

}