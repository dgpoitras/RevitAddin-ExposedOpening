
using ExposedOpeningCalculator.Models;

namespace ExposedOpeningCalculator.Commands
{
    public class Calculator
    {
        public static double[] GetValues(double exposedFace, IExposedOpeningData data)
        {
            int face = data.ZAreaList[0];
            foreach (int v in data.ZAreaList)
            {
                if (v <= exposedFace) face = v;
            }

            var faceIndex = Array.IndexOf(data.ZAreaList, face);

            if (exposedFace != face) return CalcNewValues(exposedFace, faceIndex, data);

            return data.YSelection[faceIndex]();
        }

        private static double[] CalcNewValues(double faceValue, int zIndex, IExposedOpeningData data)
        {
            var minZ = data.ZAreaList[zIndex];
            var maxZ = data.ZAreaList[zIndex + 1];

            var zMargin = maxZ - minZ;
            var fix = faceValue - minZ;
            var realMargin = fix/zMargin;

            var newY = faceValue;
            var minY = data.YSelection[zIndex]();
            var maxY = data.YSelection[zIndex + 1]();

            List<double> newXList = new List<double>();

            for (int i = 0; i < data.XLimitList.Length; i++)
            {
                var minX = minY[i];
                var maxX = maxY[i];
                var xMargin = minX - maxX;
                var newX = minX - xMargin * realMargin;
                newXList.Add(newX);
            }

            double[] result = newXList.ToArray();
            return result;
        }

        public static double CalcPoint(double distLimit, double[] area, IExposedOpeningData data)
        {
            if (distLimit < data.XLimitList[1]) return 0.00;
            if (distLimit > data.XLimitList.Max()) return 100;
            var x = data.XLimitList;
            var y = area;
            return new LinearInterpolate().Interp(distLimit, x, y);
        }


    }
}
