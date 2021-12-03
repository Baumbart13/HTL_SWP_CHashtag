using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1_5a_G1.Models.Common {
	class BindingBase : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(params string[] propertyNames) {
            foreach (string propertyName in propertyNames) {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
