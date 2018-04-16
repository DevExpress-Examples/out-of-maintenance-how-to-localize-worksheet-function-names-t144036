using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizationSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region #frlocalize
            spreadsheetControl1.Options.Behavior.FunctionNameCulture = DevExpress.XtraSpreadsheet.FunctionNameCulture.Local;
            spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("fr-FR");
            #endregion #frlocalize
        }
    }
}
