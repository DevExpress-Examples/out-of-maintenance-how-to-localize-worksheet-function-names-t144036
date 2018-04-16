Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace LocalizationSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

'            #Region "#frlocalize"
            spreadsheetControl1.Options.Behavior.FunctionNameCulture = DevExpress.XtraSpreadsheet.FunctionNameCulture.Local
            spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("fr-FR")
'            #End Region ' #frlocalize
        End Sub
    End Class
End Namespace
