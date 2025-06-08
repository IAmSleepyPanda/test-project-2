namespace DLL.TempConverter;

public class TempConverter
{
    private readonly Dictionary<TempType, Func<double, double>> tempConversion = new()
    {
        [TempType.Celsius] = d => d * 1
    };
    
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <param name="temp"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public double Convert(TempType type, double temp) => 
        tempConversion.TryGetValue(type, out var val) ? val(temp) : throw new Exception();
}