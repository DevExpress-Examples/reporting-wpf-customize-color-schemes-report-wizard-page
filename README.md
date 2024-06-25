<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180375835/18.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830427)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to customize the Choose a Report Color Scheme wizard page in WPF
This example demonstrates how to customize the [Choose a Report Color Scheme](https://docs.devexpress.com/XtraReports/400459/create-end-user-reporting-applications/wpf-reporting/end-user-report-designer/gui/report-wizard/table-report/choose-a-report-color-scheme) wizard page in WPF applications.

Below are the main steps to change the color scheme set on the Report Wizard page:

1. Implement the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage">IColorSchemeStorage</a> interface to create a storage for the wizard's custom color schemes.
2. Use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage.AddColorScheme(DevExpress.XtraReports.Wizards.ColorSchemes.ColorScheme)">AddColorScheme</a> method to add custom color schemes to the created storage.
3. Add a custom service that implements the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService">IWizardCustomizationService</a> interface. 
4. Register the custom color scheme storage in the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService.CustomizeReportWizard(IWizardCustomization-XtraReportModel-)">CustomizeReportWizard</a> method.
5. Register the wizard customization service in XAML.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-customize-color-schemes-report-wizard-page&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-customize-color-schemes-report-wizard-page&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
