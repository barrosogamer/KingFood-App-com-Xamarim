using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kingfood.ViewModel
{
    public class PedidoViewModel: BaseViewModel
    {
        
        public double qtdCoxinha=1000;

        public double QtdCoxinha
        {
            get { return qtdCoxinha;
                
            }
            set
            {
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


        private string totalFormat = "Total:0";

        public string TotalFormat
        {
            get { return totalFormat; }
            set
            {
                totalFormat = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalFormat));

            }
        }
        private double total;
        public double Total
        {
            get { return total; }
            set
            {
                total = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(Total));
                TotalFormatado();
            }
        }
       

        public string TotalFormatado()
        {
            return TotalFormat = String.Format("Total:{0}", total);
        }
        
        public void SomaTotalCoxinha(double value)
        {

            QtdCoxinha = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }
        public void SomaTotalEsfirra(double value)
        {
            QtdEsfirra = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }
        public void SomaTotalBolinho(double value)
        {
            QtdBolinho = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }
        public void SomaTotalKibe(double value)
        {
            QtdKibe = value;
            Total = QtdBolinho + QtdCoxinha + QtdEsfirra + QtdKibe;
        }
    }
}
