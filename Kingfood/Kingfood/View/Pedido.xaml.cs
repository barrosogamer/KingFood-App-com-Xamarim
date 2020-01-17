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

        public Pedido()
        {
            InitializeComponent();
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
        public double qtdEsfirra;

        public double QtdEsfirra
        {
            get { return qtdEsfirra; }
            set
            {
                qtdEsfirra = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(QtdEsfirra));
            }
        }
        public double qtdBolinho;

        public double QtdBolinho
        {
            get { return qtdBolinho; }
            set
            {
                qtdBolinho = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(QtdBolinho));
            }
        }
        public double qtdKibe;

        public double QtdKibe
        {
            get { return qtdKibe; }
            set
            {
                qtdKibe = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(QtdKibe));
            }
        }

        private double total;

        
        public double Total
        {
            get { return total; }
            set { total=value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(Total));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            QtdCoxinha = value;
            Total = QtdBolinho+QtdCoxinha+QtdEsfirra+QtdKibe;
        }
        

        private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            QtdEsfirra = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }

        private void Stepper_ValueChanged_2(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            QtdBolinho = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }

        private void Stepper_ValueChanged_3(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            QtdKibe = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }
    }
}