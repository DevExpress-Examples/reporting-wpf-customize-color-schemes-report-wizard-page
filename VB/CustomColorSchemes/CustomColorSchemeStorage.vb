Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.Xpf.DataAccess.DataSourceWizard
Imports DevExpress.Xpf.Reports.UserDesigner.ReportWizard
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Wizards
Imports DevExpress.XtraReports.Wizards.ColorSchemes
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomColorSchemes
    Public Class WizardCustomization
        Implements IWizardCustomizationService

        Private Sub IDataSourceWizardCustomizationService_CustomizeDataSourceWizard(ByVal customization As DataSourceWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IDataSourceWizardCustomizationService.CustomizeDataSourceWizard
        End Sub
        Private Function IDataSourceWizardCustomizationService_TryCreateDataSource(ByVal model As IDataSourceModel, ByRef dataSource As Object, ByRef dataMember As String) As Boolean Implements IDataSourceWizardCustomizationService.TryCreateDataSource
            dataSource = Nothing
            dataMember = Nothing
            Return False
        End Function
        Private Function IWizardCustomizationService_TryCreateReport(ByVal model As XtraReportModel, ByRef report As XtraReport) As Boolean Implements IWizardCustomizationService.TryCreateReport
            report = Nothing
            Return False
        End Function

        ' Register the custom color scheme storage.
        Private Sub IWizardCustomizationService_CustomizeReportWizard(ByVal customization As ReportWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IWizardCustomizationService.CustomizeReportWizard
            container.RegisterType(Of IColorSchemeStorage, CustomColorSchemeStorage)()
        End Sub
    End Class

    Friend Class CustomColorSchemeStorage
        Implements IColorSchemeStorage

        Private ReadOnly colorSchemes As New List(Of ColorScheme)()

        Public Sub New()

            'Add custom color schemes to the storage.
            AddColorScheme(New ColorScheme("Independence", System.Drawing.Color.FromArgb(80, 75, 102)))
            AddColorScheme(New ColorScheme("Denim", System.Drawing.Color.FromArgb(8, 38, 74)))
            AddColorScheme(New ColorScheme("Cerulean", System.Drawing.Color.FromArgb(0, 109, 167), System.Drawing.Color.FromArgb(0, 48, 65), System.Drawing.Color.FromArgb(0, 151, 167), System.Drawing.Color.FromArgb(205, 232, 242), System.Drawing.Color.FromArgb(255, 243, 245, 248), System.Drawing.Color.FromArgb(255, 109, 117, 129), System.Drawing.Color.FromArgb(255, 182, 186, 192)))
            AddColorScheme(New ColorScheme("JungleGreen", "Jungle Green", System.Drawing.Color.FromArgb(63, 102, 43), System.Drawing.Color.FromArgb(74, 120, 49), System.Drawing.Color.FromArgb(85, 138, 57), System.Drawing.Color.FromArgb(198, 216, 189), System.Drawing.Color.FromArgb(255, 64, 70, 80), System.Drawing.Color.FromArgb(255, 109, 117, 129), System.Drawing.Color.FromArgb(255, 182, 186, 192)))
        End Sub

        'Add a custom color scheme to the storage.
        Public Function AddColorScheme(ByVal colorScheme As ColorScheme) As Boolean
            If colorSchemes.Where(Function(x) x.Name = colorScheme.Name).Any() Then
                Return False
            End If
            colorSchemes.Add(colorScheme)
            Return True
        End Function

        'Remove a custom color scheme from the storage.
        Public Function RemoveColorScheme(ByVal colorSchemeName As String) As Boolean
            Dim colorScheme As ColorScheme = colorSchemes.Where(Function(x) x.Name = colorSchemeName).First()
            If colorScheme IsNot Nothing Then
                colorSchemes.Remove(colorScheme)
                Return True
            End If
            Return False
        End Function

        'Retrieves the collection of color schemes from the storage.
        Private Function IColorSchemeStorage_GetColorSchemes() As IEnumerable(Of ColorScheme) Implements IColorSchemeStorage.GetColorSchemes
            Return colorSchemes
        End Function
    End Class
End Namespace
