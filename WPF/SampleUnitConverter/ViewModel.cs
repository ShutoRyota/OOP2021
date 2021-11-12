using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleUnitConverter {
    public class ViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyNmae = null) {
            //if (this.PropertyChanged != null)
            //   this.PropertyChanged(this, new PropertyChangedEventArgs(propertyNmae));

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyNmae));
        }
    }
}
