namespace Multicast_Delegate_EventHandler;

public delegate string ProcessDelegate(string word);

public class Program
{
    public static void Main()
    {
        RestartHandler restartHandler = new();
        restartHandler.SetRestart(true);
        bool restart =  restartHandler.restart;
        var availableProcess = Enum.GetValues(typeof(ProcessName)).Cast<ProcessName>().Max();
        while(restart)
        {
            int choice;
            string word;
            string response;

            Console.WriteLine("Pilih Operasi yang hendak dilakukan: (1-2)");
            choice = Convert.ToInt32(Console.ReadLine());

            IProcess process = ProcessFactory.CreateProcess(choice);
            ProcessDelegate processDelegate = process.Process;
            // try
            // {
            // }
            // catch (NullReferenceException ex)
            // {
            //     Console.WriteLine("No such ");
            // }

            Console.WriteLine($"Program {(ProcessName) choice}. Masukkan kata dengan huruf vokal: ");
            word = Convert.ToString(Console.ReadLine());

            string processedWord = processDelegate(word);
            Console.WriteLine($"Hasil konversi:{processedWord}");

            Console.WriteLine(restartHandler.message);
            response = Convert.ToString(Console.ReadLine());
            restart = restartHandler.ShouldRestart(out restart, ref response);
        }
        Console.ReadLine();
    }
}