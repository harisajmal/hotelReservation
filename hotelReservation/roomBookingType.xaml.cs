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
    /// Interaction logic for roomBookingType.xaml
    /// </summary>
    public partial class roomBookingType : Window
    {
        /// <summary>
        /// initialising instance
        /// </summary>
        public roomBookingType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button Book Bedroom will open window book bedroom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookBedroom_Click(object sender, RoutedEventArgs e)
        {
            WindowBookBedroom winBookBedroom = new WindowBookBedroom();
            winBookBedroom.Owner = this;
            winBookBedroom.Show();
            this.Hide();
        }
        /// <summary>
        /// Button Book Conference room will open window book conference room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookConferenceRoom_Click(object sender, RoutedEventArgs e)
        {
            bookConferenceRoom BookCRoom = new bookConferenceRoom();
            BookCRoom.Owner = this;
            BookCRoom.Show();
            this.Hide();
        }
    }
}
