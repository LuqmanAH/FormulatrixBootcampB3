namespace SquareMatrix;


public class SquareIdenticalMatrix
{
    private int _rows;
    private int _columns;
    private double[][] _data;

    public SquareIdenticalMatrix(int rows)// row -98
    {
        try
        {

            // if (rows < 1)
            // {
            //     throw new ArgumentException("Matrix dimension minimum value is 1");
            // }
            _rows = rows;
            _columns = rows;
            _data = new double[_rows][];
            for (int i = 0; i < _rows; i++)
            {
                _data[i] = new double[_columns];
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("MAAF MATRIKS NGGA BISA NEGATIF DIMENSINYA OM");
            Console.WriteLine(ex.Message);
        }

    }
    public override string ToString()
    {
        string output = "";
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                output += _data[i][j] + " ";
            }
            output += "\n";
        }

        return output;
    }
    public void Fill(double value)
    {
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                _data[i][j] = value;
            }
        }
    }
}