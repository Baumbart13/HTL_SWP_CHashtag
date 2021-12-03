using App1_5a_G1.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1_5a_G1.ViewModels {
	class PersonDataViewModel : Models.Common.BindingBase{
		private int _personId;
		private string _firstname;
		private DateTime _birthdate;

		public int PersonId {
			get { return this._personId; }
			set {
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
