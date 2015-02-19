using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace MdevconUniversal.Navigation
{
    public class NavigationService:INavigationService
    {
        private readonly Frame _rootFrame;

        public NavigationService(Frame rootFrame)
        {
            _rootFrame = rootFrame;
 #if WINDOWS_PHONE_APP
                Windows.Phone.UI.Input.HardwareButtons.BackPressed +=(s,e)=>
                {

                    e.Handled = true;
                    if (_rootFrame.CanGoBack) _rootFrame.GoBack();
                };
#endif
        }

        public void Navigate<TPage>(object parameter)
        {
            _rootFrame.Navigate(typeof (TPage), parameter);
        }

        public void Navigate<TPage>()
        {
            _rootFrame.Navigate(typeof(TPage));
        }
    }
}
