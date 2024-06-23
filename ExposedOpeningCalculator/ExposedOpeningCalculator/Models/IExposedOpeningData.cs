namespace ExposedOpeningCalculator.Models
{
    public interface IExposedOpeningData
    {
        int[] ZAreaList { get; }
        Dictionary<int, Func<double[]>> YSelection { get; }
        double[] XLimitList { get; }
        double[] Y30{ get; }
        double[] Y40 { get; }
        double[] Y50 { get; }
        double[] Y100 { get; }
        double[] YOver100 { get; }
    }
}