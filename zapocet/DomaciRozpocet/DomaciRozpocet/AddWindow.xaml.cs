using System;
using System.Windows;

namespace DomaciRozpocet {
	/// <summary>
	/// Interaction logic for AddWindow.xaml
	/// </summary>
	public partial class AddWindow : Window {
		public AddWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Returns information from a 'Person' field
		/// </summary>
		public string PersonText {
			get { return (tbPerson.Text).Trim(); }
		}

		/// <summary>
		/// Returns information from a 'Date' field
		/// </summary>
		public Nullable<DateTime> Date {
			get { return dpDate.SelectedDate; }
		}

		/// <summary>
		/// Returns information from a 'Reason' field
		/// </summary>
		public string ReasonText {
			get { return (tbReason.Text).Trim(); }
		}

		/// <summary>
		/// Returns information from a 'Amount' field
		/// </summary>
		public Nullable<decimal> Amount {
			get {
				try {
					decimal amount = decimal.Parse(tbAmount.Text);
					if (amount <= 0)
						throw new Exception("The amount is zero or lower");
					if ((bool)radioIncome.IsChecked)
						return amount;
					else
						return amount * (-1);
				}
				catch {
					return null;
				}
			}
		}

		/// <summary>
		/// Clicking this button will check if all the fields are entered in a correct way, if yes, it will send a "true" as its result, otherwise it will open
		/// a MessageBox prompting the user to enter the right information
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, RoutedEventArgs e) {
			if ((PersonText == "") || (ReasonText == "") || Date == null || (Amount == null))
				MessageBox.Show(Application.Current.MainWindow, "Prosím vyplňte správně všechny pole");
			else {
				this.DialogResult = true;
				this.Close();
			}
		}
	}
}
