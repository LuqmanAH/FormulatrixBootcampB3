public class GameArgs : EventArgs
{
    public string GameMode {get; set;}
    public string ProcessedString {get; set;}
    public GameArgs(string gameMode, string processedString)
    {
        GameMode = gameMode;
        ProcessedString = processedString;
    }
}

public class Handler
{
    // public string name = "Game Handler";
    public event EventHandler<GameArgs> GameHandler;
    public void GameStart(string gameMode)
    {
        GameHandler?.Invoke(this,gameMode);
    }
}

public class Program
{
    public static void Main()
    {
        bool restart = true;

        while(restart)
        {
            StringModifier modifier = new();
            Handler sampleEvent = new();
            string choice;
            string word;
            string response;

            Console.WriteLine("Pilih Operasi yang hendak dilakukan: ");
            choice = Convert.ToString(Console.ReadLine()).ToLower();

            if(choice == "omitvowel")
            {
                sampleEvent.GameHandler += modifier.OmitVowel;
                
            }
            else if(choice == "reverseword")
            {
                sampleEvent = modifier.ReverseWord;
            }
            else
            {
                Console.WriteLine("Tidak ada method yang Anda maksud");
                break;
            }

            Console.WriteLine($"Program {choice}. Masukkan kata dengan huruf vokal: ");
            word = Convert.ToString(Console.ReadLine());

            var hasil = sampleEvent(in word);
            Console.WriteLine($"Hasil konversi:{hasil}");

            Console.WriteLine("konversi lagi? Y/N");
            response = Convert.ToString(Console.ReadLine()).ToUpper();

            if(response == "Y")
            {
                restart = true;
            }
            else
            {
                restart = false;
            }
        }
        Console.WriteLine("Feedback anda dari skala 1 sampai 5: ");
        var feedback = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sampaian feedback Anda: {(Feedback)feedback}. Terima kasih. termintating..");
    }
}
public enum Feedback
{
    sangatTidakPuas = 1,
    tidakPuas,
    biasa,
    puas,
    sangatPuas
}

public class StringModifier
{
    public string OmitVowel(object sender, string word)
    {
        var vowels = "aiueoAIUEO";
        var processedWord = "";
        for (int i = 0; i < word.Length; i++)
        {
            if(!vowels.Contains(word[i]))
            {
                processedWord += word[i];
            }   
        }
        return processedWord;
    }
    public string ReverseWord(in string word)
    {
        var processedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            processedWord += word[i];
        }
        return processedWord;
    }
}