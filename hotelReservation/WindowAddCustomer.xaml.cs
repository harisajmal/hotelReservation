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
    /// Interaction logic for WindowAddCustomer.xaml
    /// </summary>
    public partial class WindowAddCustomer : Window
    {
        private Booking booking = Booking.Instance;
        public WindowAddCustomer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To Create a Customer
        /// to add to the list once validates everything has correct parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Check if all the fields have been filled
            if (String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtYear.Text) && 
                String.IsNullOrEmpty(txtStreet.Text) && String.IsNullOrEmpty(txtTown.Text) && String.IsNullOrEmpty(txtPostcode.Text))
            { MessageBox.Show("Enter data into the fields"); }
            else
            {
                //Validate Name
                if (txtName.Text.Length < 1 || String.IsNullOrEmpty(txtName.Text))
                { MessageBox.Show("Please enter a valid name"); }
                else
                {
                    //Year
                    if (String.IsNullOrEmpty(txtYear.Text))
                    {
                        MessageBox.Show("Error message must have year of birth");
                    }
                    else
                    {
                        try
                        {
                            int year = Convert.ToInt32(txtYear.Text);
                            if (year < 1900 || year > 2015)
                            {
                                if (year < 1900)
                                { MessageBox.Show("Error year must be after 1900."); }
                                else
                                { MessageBox.Show("Error year must be before 2015."); }
                            }
                            else
                            {
                                //Street
                                if (txtStreet.Text.Length < 1 || String.IsNullOrEmpty(txtStreet.Text))
                                { MessageBox.Show("please enter valid street name"); }
                                else
                                {
                                    //Town
                                    if (txtTown.Text.Length < 1 || String.IsNullOrEmpty(txtTown.Text))
                                    { MessageBox.Show("please enter valid town name"); }
                                    else
                                    {
                                        //Postcode
                                        if (txtPostcode.Text.Length < 6 || txtPostcode.Text.Length > 8 || String.IsNullOrEmpty(txtPostcode.Text))
                                        {
                                            if (txtPostcode.Text.Length < 6)
                                            { MessageBox.Show("Postcode must be 6 character"); }
                                            else if (txtPostcode.Text.Length > 8)
                                            {
                                                MessageBox.Show("Postcode cannot be longer than 8 characters");
                                            }
                                            else
                                            { MessageBox.Show("Please enter a Postcode"); }
                                        }
                                        else
                                        {//adds customer to list!!!!
                                            booking.addCustomer(txtName.Text, Convert.ToInt32(txtYear.Text), txtStreet.Text, txtTown.Text, txtPostcode.Text);
                                            this.Close();
                                            App.Current.MainWindow.Show();
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Year of Birth must be a numeric value and in 1900s");
                        }
                        MessageBox.Show("Added");

                    }

                }
            }
            
        }
        /// <summary>
        /// To go back to the main window
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
