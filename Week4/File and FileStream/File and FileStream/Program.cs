using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "puisi.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Pemikiran gua ya! Lu punya duit, lu punya kuasa.");
                writer.WriteLine("Tapi buat gue enggak nyet. Gue gak punya. Ibaratnya gue gak bermateri, lawan orang yang bermateri.");
                writer.WriteLine("Bisa jadi gue menang soal pemikiran. Udah tenang lu, gak usah mikirin cuan ama gue, tai");
            }

            Console.WriteLine("Write successfull");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error has occurred: " + ex.Message);
        }
    }
}