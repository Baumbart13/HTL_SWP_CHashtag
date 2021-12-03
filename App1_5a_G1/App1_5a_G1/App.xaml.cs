using App1_5a_G1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_5a_G1 {
	public partial class App : Application {
		public App() {
			InitializeComponent();

			MainPage = new PersonDataView();
		}

		protected override void OnStart() {
		}

		protected override void OnSleep() {
		}

		protected override void OnResume() {
		}
	}
}
