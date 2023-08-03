# File class and FileStream class

- Class designed for file handling

## File Class

- Write, Read, Append, Copy, Delete, Move Functionality
- Memory heavy when loading
- Faster R/W when loaded
- Implements IDisposable

## FileStream Class

- Write, Read, Append Functionality
- More memory efficient
- Might be laggy when append operation is exhaustive
- Loads by chunks defined by the user
- Implements IDisposable

### File Operation Mode Enum

Defines how the instance of File class _opens_ the file. Usually depends on the **status of the file**, whether the file has already been created, yet to be created,

1. CreateNew => `the file must yet to exist`
2. Create => `if the file exists, overwrite it`
3. Open => `the file should already be created`
4. OpenOrCreate => `read if exists, creates it if not`
5. Truncate => `file already created, set to zero (reset)`
6. Append => `file already created, appends new item`

### Higher level writer / reader class

Eliminates the requirement to convert readable data to bytes just like how FileStream works

- **StreamWriter**
- **StreamReader**

example use of **FileStream**

```cs
public class FileManager : IDisposable
{
    private bool _disposedValue = false;
    private FileStream? _fileStream;

    public string ReadFileContent(string filePath)
    {
        if(_disposedValue)
        {
            throw new ObjectDisposedException("FileManager", "Object has been closed");
        }

        using (_fileStream = new FileStream(filePath, FileMode.Open))
        {
            byte[] buffer = new byte[_fileStream.Length];
            _fileStream.Read(buffer, 0, buffer.Length);
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
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
        FileManager fileManager = new FileManager();

        Console.WriteLine(fileManager.ReadFileContent(filePath));

        Console.Read();
    }
}
```

## Path Handling

- Absolute path explicitly declares the root of the specified file address
  
  `C:\Users\Batch 3\_BootcampJourney_B3\Week4\File and FileStream\README.md`

- Relative path points address to other file from current file address

  `Week4\File and FileStream\README.md` assuming current address is `C:\Users\Batch 3\_BootcampJourney_B3\`
