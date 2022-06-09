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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotelReservation
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initialise instance
        /// </summary>
        private Booking booking = Booking.Instance;
        /// <summary>
        /// List of test bedrooms, conference room and customers added
        /// </summary>
        public MainWindow()
        {
         
            InitializeComponent();

            booking.addCustomer("Haris", 1999, "Main Street", "Glasgow", "G72 9SR");
            booking.addCustomer("James", 1994, "south side", "Blantyre", "G74 2DL");
            booking.addBedroom(" 1 Person", "1 Single Bed", 0);
            booking.addBedroom(" 2 Person", "1 double Bed", 1);
            booking.addBedroom(" 2 Person", "2 Single Bed", 2);
            booking.addBedroom(" 4 Person", "4 Single Bed", 3);
            booking.addBedroom(" 4 Person", "2 double Bed", 4);
            booking.addBedroom(" 5 Person", "3 Single Bed and 1 double bed", 5);
            booking.addBedroom(" 6 Person", "2 double Bed and 2 single bed", 6);
            

            booking.addConferenceroom("Conference Room", 20 , 100);
        }
        /// <summary>
        /// To open windowAddCustomer to create a customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            WindowAddCustomer winAddCus = new WindowAddCustomer();
            winAddCus.Owner = this;
            winAddCus.Show();
            //to hide the current window
            this.Hide(); 
        }
        /// <summary>
        /// Lists all customers in the booking class method getCustomers
        /// and displays them in the output text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Clears the text box
            txtOutput.Clear();
            //get the customers from booking class
            txtOutput.Text = booking.getCustomers();
        }
        /// <summary>
        /// Opens the room booking window where you have two options book bedroom and conference room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomBooking_Click(object sender, RoutedEventArgs e)
        {
            roomBookingType winRoomBookType = new roomBookingType();
            winRoomBookType.Owner = this;
            winRoomBookType.Show();
            this.Hide();
        }
        /// <summary>
        /// Calls the getRooms method and displays the list in the output box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListBooking_Click(object sender, RoutedEventArgs e)
        {
            ///to clear the output text box
            txtOutput.Clear();
            //calls the get rooms method and display them in the output box
            txtOutput.Text = booking.getRooms();
        }
        /// <summary>
        /// to open the cancel booking window where you have option of cancelling
        /// both bedroom and conferenceroom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelBooking_Click(object sender, RoutedEventArgs e)
        {
            CancelRoomBooking returnRoom = new CancelRoomBooking();
            returnRoom.Owner = this;
            returnRoom.Show();
            this.Hide();
        }
    }
}
