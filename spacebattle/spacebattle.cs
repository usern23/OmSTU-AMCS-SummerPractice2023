namespace spacebattle;
public class Spacebattle
{
    public static double[] FindPosition(double[] position, double[] speed, bool can_move)
    {
        var result = new double[2];
        if(can_move)
        {
            try
            {
                result[0] = position[0] + speed[0];
                result[1] = position[1] + speed[1];
            }   
            catch
            {
                throw new System.Exception();
            }
        }
        else throw new System.Exception();
        return result; 
    }
    public static double Fuel(double fuel_volume, double fuel_consumption)
    {
        if((fuel_volume - fuel_consumption) > 0)
        {
            return (fuel_volume - fuel_consumption);
        }
        else
        {
            throw new System.Exception();
        }
    }
    public static double? Angle(double? ox, double? angular_velocity)
    {
        if (ox is not null & angular_velocity is not null )
            {
                return ox + angular_velocity;
            }

            else{
                throw new Exception("Enter angle or angle speed");}
    }
}