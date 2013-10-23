using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SpSynthesis.Core.Infrastructure;
using SpSynthesis.Infrastructure;
using SpSynthesis.Core;
using IServiceProvider = SpSynthesis.Core.IServiceProvider;
using System.Windows.Forms;
using SpSynthesis.Infrastructure.Registration;
using SpSynthesis.Data;

namespace SpSynthesis.UI
{
    public static class AppConfig
    {
        private static bool _isRunned = false;
        public static IContainer Container { get; private set; }

        public static void Run()
        {
            if (_isRunned)
            {
                return;
            }

            SetupContainer();
        }

        private static void SetupContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<Logger>().As<ILogger>();

            #region Modules

            //builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterModule<DataAccessRegistrationModule>();
            builder.RegisterModule<ServicesRegistrationModule>();

            #endregion

            builder.RegisterType<AutofacServiceProvider>()
                .As<SpSynthesis.Core.IServiceProvider>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AssignableTo<BaseForm>()
                .SingleInstance()
                .OnActivated(e => ((BaseForm)e.Instance).Logger = e.Context.Resolve<ILogger>());

            Container = builder.Build();

            ServiceLocator.Initialize(() =>
            {
                return Container.Resolve<IServiceProvider>();
            });

            IEFUnitOfWork osf = ServiceLocator.Resolve<IEFUnitOfWork>();
        }

        public static TForm CreateForm<TForm>() where TForm : Form
        {
            var formScope = Container.BeginLifetimeScope("SpSynthesis.Form.Scope");
            var form = formScope.Resolve<TForm>();
            form.Closed += (s, e) => formScope.Dispose();
            return form;
        }
    }
}
