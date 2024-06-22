using Autodesk.Revit.Attributes;
using ExposedOpeningCalculator.ViewModels;
using ExposedOpeningCalculator.Views;
using Nice3point.Revit.Toolkit.External;

namespace ExposedOpeningCalculator.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var viewModel = new ExposedOpeningCalculatorViewModel();
            var view = new ExposedOpeningCalculatorView(viewModel);
            view.ShowDialog();
        }
    }
}