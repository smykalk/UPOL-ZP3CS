using System;
using System.Windows;
using System.Windows.Controls;

namespace DomaciRozpocet {
	/// <summary>
	/// Interaction logic for FilterWindow.xaml
	/// </summary>
	public partial class FilterWindow : Window {
		public FilterWindow() {
			InitializeComponent();
		}
		/// <summary>
		/// Returns a predicate according to the chosen and entered values
		/// The predicate is used to filter records in ICollectionView
		/// </summary>
		public Predicate<object> FilterPredicate {
			get {
				switch (cbFilterSelection.SelectedIndex) {
					case 0:
						return item => ((Record)item).Amount > 0;
					case 1:
						return item => ((Record)item).Amount < 0;
					case 2:
						return item => ((Record)item).Person.ToLower() == this.Value.ToLower();
					case 3:
						return item => ((Record)item).Reason.ToLower() == this.Value.ToLower();
					case 4:
						if (DateFrom == null)
							return item => ((Record)item).Date <= DateTo;
						else if (DateTo == null)
							return item => ((Record)item).Date >= DateFrom;
						else
							return item => ((Record)item).Date >= DateFrom && ((Record)item).Date <= DateTo;
					case 5:
						return item => ((Record)item).Amount >= this.Amount || ((Record)item).Amount <= (-1 * this.Amount);
					case 6:
						return item => ((Record)item).Amount <= this.Amount && ((Record)item).Amount >= (-1 * this.Amount);
				}
				return item => true;
			}
		}

		/// <summary>
		/// Returns date from the 'from' DatePicker 
		/// </summary>
		private Nullable<DateTime> DateFrom {
			get {
				return dpFrom.SelectedDate;
			}
		}

		/// <summary>
		/// Returns date from the 'to' DatePicker 
		/// </summary>
		private Nullable<DateTime> DateTo {
			get {
				return dpTo.SelectedDate;
			}
		}

		/// <summary>
		/// Returns a decimal amount from the tbValue textbox
		/// </summary>
		private Nullable<decimal> Amount {
			get {
				try {
					return Decimal.Parse(tbValue.Text);
				}
				catch {
					return null;
				}
			}
		}

		/// <summary>
		/// Returns a string from the tbValue textbox
		/// </summary>
		private string Value {
			get {
				return (tbValue.Text).Trim();
			}
		}

		/// <summary>
		/// Displays different UI elements based on the filter selection
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbFilterSelection_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			var selectedIndex = cbFilterSelection.SelectedIndex;
			if (selectedIndex == 2 || selectedIndex == 3 || selectedIndex == 5 || selectedIndex == 6) {
				tbValue.Visibility = Visibility.Visible;
				lblFrom.Visibility = Visibility.Hidden;
				lblTo.Visibility = Visibility.Hidden;
				dpFrom.Visibility = Visibility.Hidden;
				dpTo.Visibility = Visibility.Hidden;
				btnFilter.IsEnabled = true;
			}
			else if (selectedIndex == 4) {
				tbValue.Visibility = Visibility.Hidden;
				lblFrom.Visibility = Visibility.Visible;
				lblTo.Visibility = Visibility.Visible;
				dpFrom.Visibility = Visibility.Visible;
				dpTo.Visibility = Visibility.Visible;
				btnFilter.IsEnabled = true;
			}
			else {
				tbValue.Visibility = Visibility.Hidden;
				lblFrom.Visibility = Visibility.Hidden;
				lblTo.Visibility = Visibility.Hidden;
				dpFrom.Visibility = Visibility.Hidden;
				dpTo.Visibility = Visibility.Hidden;
				btnFilter.IsEnabled = true;
			}
		}
		/// <summary>
		/// Checks if the fields aren't empty, if not, closes the window
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFilter_Click(object sender, RoutedEventArgs e) {
			bool success = false;
			if (cbFilterSelection.SelectedIndex == 2 || cbFilterSelection.SelectedIndex == 3) {
				if (Value == "")
					MessageBox.Show(this, "Prosím vyplňte pole");
				else
					success = true;
			}
			else if (cbFilterSelection.SelectedIndex == 5 || cbFilterSelection.SelectedIndex == 6) {
				if (Amount == null)
					MessageBox.Show(this, "Prosím vyplňte pole");
				else
					success = true;
			}
			else if (cbFilterSelection.SelectedIndex == 4) {
				if (DateFrom == null && DateTo == null)
					MessageBox.Show(this, "Prosím zadejte alespoň jedno datum");
				else
					success = true;
			}
			else
				success = true;
			if (success) {
				this.DialogResult = true;
				this.Close();
			}
		}
	}
}
