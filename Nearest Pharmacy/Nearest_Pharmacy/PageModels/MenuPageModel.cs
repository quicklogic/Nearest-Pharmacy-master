using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;
using System.Windows.Input;
using Nearest_Pharmacy.Models;

namespace Nearest_Pharmacy.PageModels
{
    [ImplementPropertyChanged]
    class MenuPageModel : FreshBasePageModel
    {
        public MenuPageModel()
        {

        }


        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public ICommand goMain => new Command(async (value) =>
        {
            //await CoreMethods.PushPageModel<ProductListPageModel>();
            FreshPageModelResolver.ResolvePageModel < ProductListPageModel>();
        });
        public ICommand goToUserProfile => new Command(async (value) =>
        {
            await CoreMethods.PushPageModel<ProductListPageModel>();
        });
        public ICommand goOrders => new Command(async (value) =>
        {
            await CoreMethods.PushPageModel<ProductListPageModel>();
        });
        public ICommand goInfo => new Command(async (value) =>
        {
            await CoreMethods.PushPageModel<ProductListPageModel>();
        });

        public ICommand goLogin => new Command(async =>
        {
            CoreMethods.PushPageModel<LoginPageModel>();
        });

        public ICommand goRegister => new Command(async =>
        {
            CoreMethods.PushPageModel<RegisterPageModel>();
        });
    }
}
