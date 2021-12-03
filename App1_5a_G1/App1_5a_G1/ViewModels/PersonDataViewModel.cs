using App1_5a_G1.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1_5a_G1.Models;
using Xamarin.Forms;

namespace App1_5a_G1.ViewModels {
	class PersonDataViewModel : Models.Common.BindingBase {
		private int _personId = 0;
		private string _firstname = "";
		private string _lastname = "";
		private DateTime _birthdate = DateTime.Now;
		private Sex _sex = Sex.Unknown;
		private decimal _salary = 0.0m;

		public decimal Salaray
		{
			get { return _salary; }
			set
			{
				_salary = value;
				RaisePropertyChanged(nameof(_salary));
			}
		}

		public int PersonId
		{
			get { return this._personId; }
			set
			{
				this._personId = value;
				this.RaisePropertyChanged(nameof(PersonId));
			}
		}

		public string Firstname {
			get { return this._firstname; }
			set {
				this._firstname = value;
				this.RaisePropertyChanged(nameof(Firstname));
			}
		}

		public string Lastname
		{
			get { return _lastname; }
			set
			{
				_lastname = value;
				RaisePropertyChanged(nameof(_lastname));
			}
		}
		
		public Sex Sex
		{
			get { return _sex; }
			set
			{
				_sex = value;
				RaisePropertyChanged(nameof(_sex));
			}
		}

		public DateTime Birthdate {
			get { return this._birthdate; }
			set {
				this._birthdate = value;
				this.RaisePropertyChanged(nameof(Birthdate));
			}
		}

		public ICommand CmdSavePersonData => new Command(SavePersonData, CanSavePersonData);
		
		private void SavePersonData() {
			// Personendaten in der DB abspeichern

			return;
		}

		private bool CanSavePersonData() {
			return true;
		}
	}
}
