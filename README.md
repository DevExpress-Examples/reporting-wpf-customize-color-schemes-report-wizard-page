<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180375835/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830427)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WPF - Customize the Choose a Report Color Scheme Wizard Page

This example shows how to customize the [Choose a Report Color Scheme](https://docs.devexpress.com/XtraReports/400459/create-end-user-reporting-applications/wpf-reporting/end-user-report-designer/gui/report-wizard/table-report/choose-a-report-color-scheme) wizard page in a WPF application.

The main steps to change the color scheme set on the Report Wizard page are as follows:

1. Implement the [IColorSchemeStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage) interface. This is a storage for the custom color schemes.
2. Use the [AddColorScheme](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage.AddColorScheme(DevExpress.XtraReports.Wizards.ColorSchemes.ColorScheme)) method to add custom color schemes to the storage.
3. Add a custom service that implements the [IWizardCustomizationService](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService)  interface. 
4. Register the custom color scheme storage in the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService.CustomizeReportWizard(IWizardCustomization-XtraReportModel-)">CustomizeReportWizard</a> method.
5. Register the wizard customization service in XAML.


![Reporting for WPF - Customize the `Choose a Report Color Scheme` Wizard Page](Images/screenshot.png)

## Files to Review

- [MainWindow.xaml](CS/MainWindow.xaml) (VB: [MainWindow.xaml](VB/MainWindow.xaml))
- [CustomColorSchemeStorage.cs](CS/CustomColorSchemeStorage.cs) (VB: [CustomColorSchemeStorage.vb](VB/CustomColorSchemeStorage.vb))
## Documentation

- [Wizard Customization Overview](https://docs.devexpress.com/XtraReports/118019/wpf-reporting/end-user-report-designer-for-wpf/api-and-customization/wizard-customization-overview)

## More Examples

- [WPF Report Designer - How to register a custom page in the Report Wizard](https://github.com/DevExpress-Examples/Reporting_wpf-report-designer-how-to-register-a-custom-page-in-the-report-wizard-t600080)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-customize-color-schemes-report-wizard-page&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-customize-color-schemes-report-wizard-page&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
