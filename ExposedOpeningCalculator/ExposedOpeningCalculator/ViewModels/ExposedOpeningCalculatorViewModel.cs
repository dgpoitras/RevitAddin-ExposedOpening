
using ExposedOpeningCalculator.Commands;
using ExposedOpeningCalculator.Models;
using System.Diagnostics;
using System.Windows.Input;

namespace ExposedOpeningCalculator.ViewModels
{
    public sealed class ExposedOpeningCalculatorViewModel : ObservableObject
    {
        private double _limitDist = 1.2;
        public double LimitDist {
            get => _limitDist;
            set => SetProperty(ref _limitDist, value);
        }

        private double _maxArea = 30.0;
        public double MaxArea {
            get => _maxArea;
            set => SetProperty(ref _maxArea, value);
        }

        // Not Needed? - Derek
        //private double[] _areaValues = null;
        //public double[] AreaValues { 
        //    get => _areaValues;  
        //    set => SetProperty(ref _areaValues, value);
        //}

        private double _result = 0;
        public double Result { 
            get => _result;
            set => SetProperty(ref _result, value);
        }

        private bool _residentail = true;
        public bool Residential
        {
            get => _residentail;
            set => SetProperty(ref _residentail, value);
        }

        public ICommand CalculateCommand { get; }

        public ExposedOpeningCalculatorViewModel() 
        {
            CalculateCommand = new RelayCommand(CalculateExec);
        }

        public void CalculateExec()
        {
            Debug.WriteLine("Starting Command");
            if (Residential)
            {
                IExposedOpeningData data = new ResidentialData();
                Result = Calculator.CalcPoint(LimitDist, Calculator.GetValues(MaxArea, data), data);
            }
            else
            {
                IExposedOpeningData data = new CommercialData();
                Result = Calculator.CalcPoint(LimitDist, Calculator.GetValues(MaxArea, data), data);
            }
            
            Debug.WriteLine($"result = {Result}");

        }
    }
}