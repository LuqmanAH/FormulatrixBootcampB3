using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        List<string> listOfNames = new List<string>()
        {
            "Sule",
            "Sugiyono",
            "Juminten",
            "Richard"
        };

        string jsonString = JsonSerializer.Serialize(listOfNames);

        //* Serialize
        using (StreamWriter writer = new StreamWriter("names.json"))
        {
            writer.WriteLine(jsonString);
        }

        //*deserialize
        string deserializedName;

        using (StreamReader reader = new StreamReader("names.json"))
        {
            if (reader == null)
            {
                throw new NullReferenceException("No such json file!");
            }
            deserializedName = reader.ReadToEnd();
        }

        Console.WriteLine(deserializedName);

    }
}