namespace Multicast_Delegate_EventHandler;

public class RestartHandler
{
    public string message = "konversi lagi? Y/N";
    public string? response;
    public bool restart;

    public void SetResponse(string response)
    {
        this.response = response.ToLower();
    }
    public void SetRestart(bool restart)
    {
        this.restart = restart;
    }

    public bool ShouldRestart(out bool restart, ref string? response)
    {
        if(response == "y")
        {
            restart = true;
            return restart;
        }
        restart = false;
        return restart;
    }
}