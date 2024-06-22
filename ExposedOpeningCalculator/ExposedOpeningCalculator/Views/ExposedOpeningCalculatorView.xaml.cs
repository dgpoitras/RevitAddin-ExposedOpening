using ExposedOpeningCalculator.ViewModels;

namespace ExposedOpeningCalculator.Views
{
    public sealed partial class ExposedOpeningCalculatorView
    {
        public ExposedOpeningCalculatorView(ExposedOpeningCalculatorViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}