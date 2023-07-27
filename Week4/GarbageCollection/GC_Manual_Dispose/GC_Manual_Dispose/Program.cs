public class FileManager : IDisposable
{
    private bool _disposedValue = false;
    private FileStream _fileStream;

    public FileManager(string filePath)
    {
        _fileStream  = new FileStream(filePath, FileMode.Open);
    }

    public string ReadFileContent()
    {
        if(_disposedValue)
        {
            throw new ObjectDisposedException("FileManager", "Object has been closed");
        }

        byte[] buffer = new byte[_fileStream.Length];
        _fileStream.Read(buffer, 0, buffer.Length);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _fileStream.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposedValue = true;
        }
    }
    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~FileManager()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

public class Program
{
    public static void Main()
    {
        string filePath = "Text.txt";

        FileManager fileManager = new FileManager(filePath);

        try
        {
            string content = fileManager.ReadFileContent();
            Console.WriteLine(content);
            fileManager.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            fileManager.Dispose();
        }
    }
}