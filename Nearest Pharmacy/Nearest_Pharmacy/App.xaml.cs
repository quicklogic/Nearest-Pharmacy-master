using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;

using Xamarin.Forms;
using Nearest_Pharmacy.PageModels;
using Nearest_Pharmacy.Models;

namespace Nearest_Pharmacy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<IPharmacyService, PharmacyService>();
            var masterDetailNav = new FreshMasterDetailNavigationContainer();
            masterDetailNav.Init("Меню");
            masterDetailNav.AddPage<ProductListPageModel>("Главная страница", null);
            masterDetailNav.AddPage<LoginPageModel>("Войти", null);
            masterDetailNav.AddPage<RegisterPageModel>("Регистрация", null);
            MainPage = masterDetailNav;

        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
