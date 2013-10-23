using SpSynthesis.Core.Infrastructure;
using SpSynthesis.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpSynthesis.UI
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = Resources.strAppTitle + String.Format(Resources.strVersionFormat, Application.ProductVersion);
            Logger.Info("Load form: {0}", new object[] { GetType().Name });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Info("Closed form: {0}", new object[] { GetType().Name });
        }
    }
}
