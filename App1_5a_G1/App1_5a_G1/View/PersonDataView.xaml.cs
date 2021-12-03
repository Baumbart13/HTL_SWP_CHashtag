using App1_5a_G1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_5a_G1.View {
	public partial class PersonDataView : ContentPage {

		private PersonDataViewModel data = new PersonDataViewModel();
		public PersonDataView() {
			InitializeComponent();
			this.BindingContext = data;
		}
	}
}