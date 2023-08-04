using System.Xml.Serialization;

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

        XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

        //* Serialize
        using (StreamWriter writer = new StreamWriter("names.xml"))
        {
            serializer.Serialize(writer, listOfNames);
        }

        //*deserialize
        List<string> deserializedName;
        using (StreamReader reader = new StreamReader("names.xml"))
        {
            if (reader == null)
            {
                throw new NullReferenceException("No such xml file!");
            }
            deserializedName = (List<string>)serializer.Deserialize(reader);
        }

        foreach (var name in deserializedName)
        {
            Console.WriteLine($"{name} is in xml");
        }

    }
}