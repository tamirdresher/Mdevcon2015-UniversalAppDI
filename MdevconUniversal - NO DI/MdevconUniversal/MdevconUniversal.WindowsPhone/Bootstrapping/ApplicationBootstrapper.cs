using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Autofac;
using MdevconUniversal.Bootstapping;
using MdevconUniversal.Common.Managers;
using MdevconUniversal.Common.MdevconService;
using MdevconUniversal.Navigation;
using MdevconUniversal.ViewModels;

namespace MdevconUniversal.Bootstrapping
{
    class ApplicationBootstrapper:IApplicationBootstrapper
    {
        public IContainer  Start(Frame rootFrame)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<CommonClassesModule>();

            builder.RegisterInstance(new NavigationService(rootFrame)).As<INavigationService>();

            builder.RegisterAssemblyTypes(typeof(MainPageViewModel).GetTypeInfo().Assembly)
                .Where(t => t.Name.EndsWith("ViewModel"))
                .AsSelf();

            return builder.Build();
        }
    }
}
