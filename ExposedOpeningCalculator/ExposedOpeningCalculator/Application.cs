using ExposedOpeningCalculator.Commands;
using Nice3point.Revit.Toolkit.External;

namespace ExposedOpeningCalculator
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "ExposedOpeningCalculator");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/ExposedOpeningCalculator;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/ExposedOpeningCalculator;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}