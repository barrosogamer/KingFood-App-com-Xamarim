using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kingfood.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pedido : INotifyPropertyChanged
	{
        
        public Pedido ()
		{
			InitializeComponent ();
            this.BindingContext = this;
		}
       public double qtdCoxinha;

      
       public double QtdCoxinha
        {
            get { return qtdCoxinha; }
            set {
                qtdCoxinha = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(QtdCoxinha));
            }
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            QtdCoxinha = value;

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name="")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
    }
}