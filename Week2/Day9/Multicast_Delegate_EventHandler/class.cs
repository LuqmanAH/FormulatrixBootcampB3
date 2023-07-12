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

public class ProcessFactory
{
    public static IProcess? CreateProcess(int? processtype)
    {
        ProcessName? processName = (ProcessName?) processtype;
        if (processName.ToString() == "omitvowel")
        {
            return new OmitVowel();
        }
        else if (processName.ToString() == "reverseword")
        {
            return new ReverseWord();
        }
        return null;
    }
}

enum ProcessName
{
    omitvowel = 1,
    reverseword
}