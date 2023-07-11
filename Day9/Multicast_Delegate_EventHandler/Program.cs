namespace Multicast_Delegate_EventHandler;

public class Program
{
    public static void Main()
    {
        RestartHandler restartHandler = new();
        restartHandler.SetRestart(true);
        bool restart =  restartHandler.restart;
        while(restart)
        {
            string choice;
            string word;
            string response;

            Console.WriteLine("Pilih Operasi yang hendak dilakukan: ");
            choice = Convert.ToString(Console.ReadLine());

            IProcess process = ProcessFactory.CreateProcess(choice);

            Console.WriteLine($"Program {choice}. Masukkan kata dengan huruf vokal: ");
            word = Convert.ToString(Console.ReadLine());

            string processedWord = process.Process(word);
            Console.WriteLine($"Hasil konversi:{processedWord}");

            Console.WriteLine(restartHandler.message);
            response = Convert.ToString(Console.ReadLine());
            restart = restartHandler.ShouldRestart(out restart, ref response);
        }
        Console.ReadLine();
    }
}