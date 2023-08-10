using Xunit;

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
}