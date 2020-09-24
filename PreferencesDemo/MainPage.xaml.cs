using System.ComponentModel;
using PreferencesDemo.Storages;
using Xamarin.Forms;

namespace PreferencesDemo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            const string key = "app_timeout";
            var timeout = PreferencesStorage.Get(key, 0.0);
            if (timeout == 0.0)
                PreferencesStorage.Set(key, 30.0);
            timeout = PreferencesStorage.Get(key, 0.0);
        }
    }
}
