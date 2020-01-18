using Kingfood.Models;
using Kingfood.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kingfood.View
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PedidoLayout());
        }
    }
}
