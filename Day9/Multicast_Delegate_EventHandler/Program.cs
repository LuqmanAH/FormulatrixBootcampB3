namespace Multicast_Delegate_EventHandler;

public delegate string ProcessDelegate(string word);

public class Program
{
    public static void Main()
    {
        RestartHandler restartHandler = new();
        restartHandler.SetRestart(true);
        bool restart =  restartHandler.restart;
  
        while(restart)
        {
            int? choice;
            string? word;
            string? response;

            Console.WriteLine("Pilih Operasi yang hendak dilakukan: (1-2)");
            
            try
            {
                Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Must Input integer value!");
                break;
            }

            choice = Convert.ToInt32(Console.ReadLine());
            IProcess? chosenProcess = ProcessFactory.CreateProcess(choice);

            if(chosenProcess is not null)
            {
                ProcessDelegate processDelegate = chosenProcess.Process;

                Console.WriteLine($"Program {(ProcessName) choice}. Masukkan kata dengan huruf vokal: ");
                word = Convert.ToString(Console.ReadLine());

                string? processedWord = processDelegate(word);
                Console.WriteLine($"Hasil konversi:{processedWord}");
            }
            else
            {
                Console.WriteLine("ERROR:PROCESS UNAVAILABLE");
                break;
            }

            Console.WriteLine(restartHandler.message);
            response = Convert.ToString(Console.ReadLine());
            restart = restartHandler.ShouldRestart(out restart, ref response);
        }
        Console.ReadLine();
    }
}