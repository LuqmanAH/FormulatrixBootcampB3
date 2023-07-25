/*

* Taken from Exercism exercise: Need for speed
* Emphasize the use of private class' fields to enforce encapsulation
* Methods provided to access the private fields
source: exercism.org/tracks/csharp/exercises/need-for-speed

*/

class RemoteControlCar
{
    //* define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _battery;
    private int _batteryDrain;
    private int _distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
    }
    public bool BatteryDrained()
    {
        return _battery < _batteryDrain;
    }
    public int DistanceDriven()
    {
        return _distanceDriven;
    }
    public void Drive()
    {
        if (_battery != 0 && !BatteryDrained())
        {
            _distanceDriven += _speed;
            _battery -= _batteryDrain;
        }
    }
    public static RemoteControlCar Nitro()
    {
        RemoteControlCar rcCar = new(50, 4);
        return rcCar;
    }
}
class RaceTrack
{
    //* define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            
            car.Drive();
            
        }while(!car.BatteryDrained());

        return car.DistanceDriven() >= distance;
    }
}