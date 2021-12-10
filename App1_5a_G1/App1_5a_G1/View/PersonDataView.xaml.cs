using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App1_5a_G1.ViewModels;
using App1_5a_G1.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_5a_G1.View {
	public partial class PersonDataView : ContentPage {

		public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		private PersonDataViewModel data = new PersonDataViewModel();
		public PersonDataView() {
			logger.Info("Starting ...");
			InitializeComponent();
			logger.Debug("Binding Person with View");
			this.BindingContext = data;
		}
	}
}