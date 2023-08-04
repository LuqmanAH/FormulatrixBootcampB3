using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

[DataContract]
class MyObject
{
    public MyObject(Guid _id, int jumlahBakso, ReferenceObject referenceObject)
    {
        ID = _id;
        this.jumlahBakso = jumlahBakso;
        this.referenceObject = referenceObject;
    }
    
    [DataMember(Name = "ID")]
    private Guid ID;

    [DataMember(Name = "jumlahBakso")]
    private int jumlahBakso;

    [DataMember(Name = "referenceObject")]
    private ReferenceObject referenceObject;

    public int GetJumlahBakso()
    {
        return jumlahBakso;
    }

    public ReferenceObject GetReferenceObject()
    {
        return referenceObject;
    }
}

[DataContract]
class ReferenceObject
{
    [DataMember(Name = "_x")]
    private int _x;

    [DataMember(Name = "_y")]
    private int _y;

    public ReferenceObject(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public int GetX()
    {
        return _x;
    }

    public int GetY()
    {
        return _y;
    }

}

class Program
{
    static void Main(string[] args)
    {
        var jsonSer = new DataContractJsonSerializer(typeof(MyObject));

        MyObject myObject = new MyObject(Guid.NewGuid(), 89, new ReferenceObject(6,5));

        using (FileStream fs = new FileStream("myObject.json", FileMode.OpenOrCreate))
        {
            jsonSer.WriteObject(fs, myObject);
        }

        MyObject importedObject;
        using (FileStream fs2 = new FileStream("myObject.json", FileMode.OpenOrCreate))
        {
            importedObject = (MyObject)jsonSer.ReadObject(fs2);
        }

        Console.WriteLine(importedObject.GetJumlahBakso());
        Console.WriteLine(importedObject.GetReferenceObject().GetX());
        Console.WriteLine(importedObject.GetReferenceObject().GetY());

    }
}