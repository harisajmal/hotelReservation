using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hotelReservation
{
    /// <summary>
    /// Interaction logic for WindowBookBedroom.xaml
    /// </summary>
    public partial class WindowBookBedroom : Window
    {
        private Booking booking = Booking.Instance;
        /// <summary>
        /// Sets the customers combobox to booking list customer and room combobox to the room list
        /// </summary>
        public WindowBookBedroom()
        {
            InitializeComponent();
            cmbBedroom.ItemsSource = booking.Rooming;
            cmbCustomers.ItemsSource = booking.Customers;
            cmbBedroom.SelectedIndex = 0;
            cmbCustomers.SelectedIndex = 0;

        }
        /// <summary>
        /// Book Bedroom Button
        /// Sends message to bedroom method in room class then
        /// checks if booked or not and sends a corrisponding message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bedroom br = (Bedroom)cmbBedroom.SelectedItem;
                br.Book((Customer)cmbCustomers.SelectedItem);
                if (cmbCustomers.SelectedItem != null && cmbBedroom.SelectedItem != null)
                {
                    MessageBox.Show("Room Booked");
                    this.Close();
                    App.Current.MainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Error, something went wrong or the is already booked");
                    this.Close();
                    App.Current.MainWindow.Show();
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Cancel Button
        /// To close current window and go back to the main window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.Current.MainWindow.Show();
        }
    }
}
