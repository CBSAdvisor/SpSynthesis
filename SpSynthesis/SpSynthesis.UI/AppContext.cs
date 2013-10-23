using SpSynthesis.Core;
using SpSynthesis.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpSynthesis.UI
{
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            AppConfig.Run();
            MainForm = AppConfig.CreateForm<MainForm>();
            Logger = ServiceLocator.Resolve<ILogger>();

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            Logger.Info("Application start: {0} {1}", new object[] { Application.ProductName, Application.ProductVersion });
        }

        public ILogger Logger { get; private set; }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            Logger.Info("Application exit: {0} {1}", new object[] { Application.ProductName, Application.ProductVersion });
        }
    }
}
