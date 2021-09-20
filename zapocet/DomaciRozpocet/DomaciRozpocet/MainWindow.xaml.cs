using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace DomaciRozpocet {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Records allRecords = new Records();
		ICollectionView defaultView;
		Predicate<object> dvFilter = item => true;
		public MainWindow() {
			InitializeComponent();
			Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("cs-CZ");
			allRecords.LoadFromCSV();
			defaultView = CollectionViewSource.GetDefaultView(allRecords);
			DGRecords.ItemsSource = defaultView;
			SetTotalLabel(allRecords.TotalAmount(dvFilter));
		}

		/// <summary>
		/// When this button is pressed, a selected record or multiple records get deleted
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, RoutedEventArgs e) {
			if (DGRecords.SelectedItems.Count != 0) {
				if (MessageBox.Show("Opravdu chcete vymazat vybrané záznamy?", "Smazat", MessageBoxButton.YesNo) == MessageBoxResult.Yes) {
					foreach (Record item in DGRecords.SelectedItems)
						allRecords.Remove((Record)item);
					if (!allRecords.SaveToCSV())
						MessageBox.Show("Chyba při zápisu do souboru");
					defaultView.Refresh();
					SetTotalLabel(allRecords.TotalAmount(dvFilter));
				}
			}
		}

		/// <summary>
		/// When this button is pressed, it opens a new dialog window where the user can enter the info about a new record
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, RoutedEventArgs e) {
			var addWindow = new AddWindow();
			addWindow.Owner = this;
			if ((bool)addWindow.ShowDialog()) {
				allRecords.Add(new Record(addWindow.PersonText, (DateTime)addWindow.Date, addWindow.ReasonText, (decimal)addWindow.Amount));
				if (!allRecords.AppendLastToCSV())
					MessageBox.Show("Chyba při zápisu do souboru");
				defaultView.Refresh();
				SetTotalLabel(allRecords.TotalAmount(dvFilter));
			}
		}

		/// <summary>
		/// Deselecting records after click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DGRecords_MouseDown(object sender, MouseButtonEventArgs e) {
			(sender as DataGrid).SelectedItem = null;
		}

		/// <summary>
		/// Clicking this button opens a new dialog window where the user can set the properties for filtering
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFilter_Click(object sender, RoutedEventArgs e) {
			var filterWindow = new FilterWindow();
			filterWindow.Owner = this;
			if ((bool)filterWindow.ShowDialog()) {
				//Combining predicates to allow for multiple filters
				Predicate<object> pred = defaultView.Filter;
				if (pred == null) {
					dvFilter = item => filterWindow.FilterPredicate(item);
				}
				else {
					dvFilter = item => pred(item) && filterWindow.FilterPredicate(item);
				}
				defaultView.Filter = dvFilter;
				defaultView.Refresh();
				SetTotalLabel(allRecords.TotalAmount(dvFilter));
			}
		}

		/// <summary>
		/// Clicking removes all filters
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRemoveFilter_Click(object sender, RoutedEventArgs e) {
			dvFilter = item => true;
			defaultView.Filter = null;
			defaultView.Refresh();
			SetTotalLabel(allRecords.TotalAmount(dvFilter));
		}

		/// <summary>
		/// Clicking exports filtered datagrid into Exported.csv file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExport_Click(object sender, RoutedEventArgs e) {
			if (allRecords.SaveToCSV(dvFilter, "Exported.csv"))
				MessageBox.Show("Úspěšně exportováno");
			else
				MessageBox.Show("Při ukládání souboru došlo k chybě");
		}

		/// <summary>
		/// Setting the value and colour of the 'Celkem' (lblTotal) label
		/// </summary>
		/// <param name="amount"></param>
		private void SetTotalLabel(decimal amount) {
			lblTotal.Content = amount.ToString("C", CultureInfo.CurrentCulture);
			//green for total amount > 0
			if (amount > 0) {
				lblTotal.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00b026"));
			}
			//red for total < 0
			else if (amount < 0) {
				lblTotal.Foreground = Brushes.Red;
			}
			//black for amount == 0
			else
				lblTotal.Foreground = Brushes.Black;
		}
	}
}

