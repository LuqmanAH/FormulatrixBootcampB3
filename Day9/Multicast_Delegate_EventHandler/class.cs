namespace Multicast_Delegate_EventHandler;

public class OmitVowel : IProcess
{
    public string Process(string word)
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
}

public class ReverseWord : IProcess
{
    public string Process(string word)
    {
        var processedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            processedWord += word[i];
        }
        return processedWord;
    }
}

public class InvalidProcessType : IProcess
{
    public string Process(string word)
    {
        return "Invalid Process Type!";
    }
}

// TODO introduce processtype enum so user can input indexes rather than the process name
public class ProcessFactory
{
    public static IProcess? CreateProcess(int processtype)
    {
        try
        {
            ProcessName processName = (ProcessName) processtype;
            if (processName.ToString() == "omitvowel")
            {
                return new OmitVowel();
            }
            else if (processtype.ToString() == "reverseword")
            {
                return new ReverseWord();
            }
            Console.WriteLine("CreateProcess");
            return null;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}

enum ProcessName
{
    omitvowel = 1,
    reverseword
}