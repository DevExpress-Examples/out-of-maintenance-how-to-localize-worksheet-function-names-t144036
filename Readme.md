<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613835/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T144036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/LocalizationSample/Form1.cs) (VB: [Form1.vb](./VB/LocalizationSample/Form1.vb))
<!-- default file list end -->
# How to localize worksheet function names


To localize worksheet function names, the culture-specific satellite assemblies are required. The DevExpress .NET Products Installer delivers satellite assemblies for German, Spanish, Japan and Russian languages. To obtain satellite assemblies localized for French culture, use the <a href="http://localization.devexpress.com/">DevExpress Localization Service</a>. <br />Once the French translation set is obtained, extract the DevExpress.Spreadsheet.vX.Y.Core.resources.dll assembly and add it to the <strong>fr </strong>folder<strong> </strong>created in your project. Specify "<strong>Copy to Output Directory</strong>" to "<strong>Copy Always</strong>" for that file.<br /><br />Add the code that sets the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetSpreadsheetBehaviorOptions_FunctionNameCulturetopic">FunctionNameCulture</a> to <strong>Local</strong> and specify the "<strong>fr-FR"</strong> culture using the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetDocumentOptions_Culturetopic">SpreadsheetControlOptions.Culture</a> property.<br />Run the project.<br />All function names in the worksheet and in the <strong>Formulas</strong> tab of the Ribbon UI are in French.

<br/>


