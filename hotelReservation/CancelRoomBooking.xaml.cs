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
    /// Interaction logic for CancelRoomBooking.xaml
    /// </summary>
    public partial class CancelRoomBooking : Window
    {
        private Booking booking = Booking.Instance;
        /// <summary>
        /// Cancel Room Booking Window
        /// sets the combobox to list from rooms & customers
        /// </summary>
        public CancelRoomBooking()
        {
            InitializeComponent();
            cmbRoom.ItemsSource = booking.Rooming;
            cmbRoom.SelectedIndex = 0;
            cmbCustomer.ItemsSource = booking.Customers;
            cmbCustomer.SelectedIndex = 0;
        }
        /// <summary>
        /// Cancel the booking and then sends a message for validation on return or error message 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelRoom_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Room str = (Room)cmbRoom.SelectedItem;
                str.cancelRoom();
                if (cmbRoom.SelectedItem != null)
                {
                    MessageBox.Show("Item Returned.");
                    this.Close();
                    App.Current.MainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Error, something went wrong or the current room has already been returned");
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
        /// Button to go back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.Current.MainWindow.Show();
        }
    }
}
