
namespace ExposedOpeningCalculator.Models
{
    public record CommercialData : IExposedOpeningData
    {
        public int[] ZAreaList { get => new int[] { 30, 40, 50, 100, 101 }; }

        public Dictionary<int, Func<double[]>> YSelection
        {
            get => new Dictionary<int, Func<double[]>>
        {
            {0, () => Y30 },
            {1, () => Y40 },
            {2, () => Y50 },
            {3, () => Y100 },
            {4, () => YOver100 }
        };
        }

        public double[] XLimitList
        {
            get => new double[]{
            0.0,
            1.2,
            1.5,
            2.0,
            4.0,
            6.0,
            8.0,
            10.0,
            12.0,
            16.0,
            20.0,
            25.0
        };
        }

        public double[] Y30
        {
            get => new double[]{
            0,
            4,
            4,
            6,
            20,
            44,
            80,
            100,
            100,
            100,
            100,
            100
        };
        }

        public double[] Y40
        {
            get => new double[]{
            0,
            4,
            4,
            6,
            16,
            34,
            61,
            97,
            100,
            100,
            100,
            100
        };
        }

        public double[] Y50
        {
            get => new double[]{
            0,
            4,
            4,
            5,
            14,
            29,
            50,
            79,
            100,
            100,
            100,
            100
        };
        }

        public double[] Y100
        {
            get => new double[]{
            0,
            4,
            4,
            4,
            9,
            17,
            28,
            42,
            60,
            100,
            100,
            100
        };
        }

        public double[] YOver100
        {
            get => new double[]{
            0,
            4,
            4,
            4,
            6,
            10,
            14,
            20,
            27,
            46,
            70,
            100
        };
        }
    }
}
