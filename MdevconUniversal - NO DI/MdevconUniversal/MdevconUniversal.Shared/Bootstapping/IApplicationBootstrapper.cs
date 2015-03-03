using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;
using Autofac;

namespace MdevconUniversal.Bootstapping
{
    public interface IApplicationBootstrapper
    {
        IContainer Start(Frame rootFrame);
    }
}
