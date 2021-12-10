using App1_5a_G1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using App1_5a_G1.Models;
using Xamarin.Forms;
using System.Diagnostics;

namespace App1_5a_G1.ViewModels {
	class PersonDataViewModel : Models.Common.BindingBase {
		private int _personId = 0;
		private string _firstname = "";
		private string _lastname = "";
		private DateTime _birthdate = DateTime.Now;
		private Sex _sex = Sex.Unknown;
		private decimal _salary = 0.0m;

		private List<Sex> _sexes = Enum.GetValues(typeof(Sex)).Cast<Sex>().ToList();
		public List<Sex> Sexes => _sexes;
		
		
		public decimal Salary
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

		public ICommand CmdPrintPersonData => new Command(e => {
			Debug.WriteLine($"_personId = {_personId}\n" +
				$"_firstname = {_firstname}\n" +
				$"_lastname = {_lastname}\n" +
				$"_birthdate = {_birthdate}\n" +
				$"_sex = {_sex}\n" +
				$"_salary = {_salary}");
		});

		public ICommand CmdAbortPersonData => new Command(e => {
			// Reset all data to default
			Salary = 0.0m;
			PersonId = 0;
			Firstname = "";
			Lastname = "";
			Sex = Sex.Unknown;
			Birthdate = DateTime.Now;

			Debug.WriteLine("Resetted the persondata");
		});

		public ICommand CmdSavePersonData => new Command(SavePersonData);
		
		private void SavePersonData() {
			// Personendaten in der DB abspeichern
			Debug.WriteLine("Saving the persondata");
			return;
		}
	}
}
