namespace Enumerator_Op_Overload;

public class Complex
    {
        private int _real;
        private int _imag;
        public Complex(int real = 0, int imag = 0)
        {
            _real = real;
            _imag = imag;
        }
        public static Complex operator +(Complex x, Complex y) // Complex Class Addition by operator overloading
        {
            Complex temp = new()
            {
                _real = x._real + y._real,
                _imag = x._imag + y._imag
            };
            return temp;
        }
        public static int AddPart (Complex x, Complex y, string part = "imag") // Addition by part, return sesuai yang diminta
        {
           Complex temp = new()
            {
                _real = x._real + y._real,
                _imag = x._imag + y._imag
            };
            if(part == "imag")
            {
                return temp._imag;
            }
            return temp._real;
        }
        public static Complex AddComplex (Complex x, Complex y) // Complex Class Addition by method
        {
            Complex temp = new()
            {
                _real = x._real + y._real,
                _imag = x._imag + y._imag
            };
            return temp;
        }
        public void Display() // Complex displayer
        {
            if (_imag < 0){
                Console.WriteLine($"{_real} - i{Math.Abs(_imag)}");// real + i(-imag)
            }
            else
            {
                Console.WriteLine($"{_real} + i{_imag}");
            }
        }
    }