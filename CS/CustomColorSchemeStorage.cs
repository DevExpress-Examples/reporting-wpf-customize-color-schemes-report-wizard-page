using DevExpress.DataAccess.Wizard.Model;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraReports.Wizards.ColorSchemes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomColorSchemes
{
    public class WizardCustomization : IWizardCustomizationService
    {
        void IDataSourceWizardCustomizationService.CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) { }
        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }
        bool IWizardCustomizationService.TryCreateReport(XtraReportModel model, out XtraReport report) {
            report = null;
            return false;
        }

        // Register the custom color scheme storage.
        void IWizardCustomizationService.CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            container.RegisterType<IColorSchemeStorage, CustomColorSchemeStorage>();
        }
    }

    class CustomColorSchemeStorage : IColorSchemeStorage {
        readonly List<ColorScheme> colorSchemes = new List<ColorScheme>();

        public CustomColorSchemeStorage() {
            
            //Add custom color schemes to the storage.
            AddColorScheme(new ColorScheme("Independence", System.Drawing.Color.FromArgb(80, 75, 102)));
            AddColorScheme(new ColorScheme("Denim", System.Drawing.Color.FromArgb(8, 38, 74)));
            AddColorScheme(new ColorScheme("Cerulean",
                System.Drawing.Color.FromArgb(0, 109, 167),
                System.Drawing.Color.FromArgb(0, 48, 65),
                System.Drawing.Color.FromArgb(0, 151, 167),
                System.Drawing.Color.FromArgb(205, 232, 242),
                System.Drawing.Color.FromArgb(255, 243, 245, 248),
                System.Drawing.Color.FromArgb(255, 109, 117, 129),
                System.Drawing.Color.FromArgb(255, 182, 186, 192)));
            AddColorScheme(new ColorScheme("JungleGreen", "Jungle Green",
                System.Drawing.Color.FromArgb(63, 102, 43),
                System.Drawing.Color.FromArgb(74, 120, 49),
                System.Drawing.Color.FromArgb(85, 138, 57),
                System.Drawing.Color.FromArgb(198, 216, 189),
                System.Drawing.Color.FromArgb(255, 64, 70, 80),
                System.Drawing.Color.FromArgb(255, 109, 117, 129),
                System.Drawing.Color.FromArgb(255, 182, 186, 192)));
        }

        //Add a custom color scheme to the storage.
        public bool AddColorScheme(ColorScheme colorScheme) {
            if (colorSchemes.Where(x => x.Name == colorScheme.Name).Any())
                return false;
            colorSchemes.Add(colorScheme);
            return true;
        }
        
        //Remove a custom color scheme from the storage.
        public bool RemoveColorScheme(string colorSchemeName) {
            ColorScheme colorScheme = colorSchemes.Where(x => x.Name == colorSchemeName).First();
            if (colorScheme != null)
            {
                colorSchemes.Remove(colorScheme);
                return true;
            }
            return false;
        }

        //Retrieves the collection of color schemes from the storage.
        IEnumerable<ColorScheme> IColorSchemeStorage.GetColorSchemes() {
            return colorSchemes;
        }
    }
}
