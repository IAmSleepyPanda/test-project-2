namespace DLL.TempConverter;

public class TempConverter
{
    /// <summary>
    ///     
    /// </summary>
    /// <param name="temp"></param>
    /// <returns></returns>
    public double ConvertToKelvin(double temp) => temp + 273;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="temp"></param>
    /// <returns></returns>
    public double ConvertToFarenheight(double temp) => (temp * 1.6) + 32;
}