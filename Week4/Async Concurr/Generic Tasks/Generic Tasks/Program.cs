// TODO: Generic tasks example

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string url1 = "https://www.example.com";
        string url2 = "https://www.example.co.id";

        Task<string> fetchUrl1 = FetchUrl(url1);
        Task<string> fetchUrl2 = FetchUrl(url2);

        Console.WriteLine("Fetching, please wait..");

        string content1 = await fetchUrl1;
        string content2 = await fetchUrl2;

        Console.WriteLine(content1);
        Console.WriteLine(content2);

    }

    static async Task<string> FetchUrl(string url)
    {
        await Task.Delay(3000);
        string content = $"The requested url is: {url}";

        return content;
    }
}