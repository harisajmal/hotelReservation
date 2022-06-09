using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace hotelReservation
{
    public class Booking
    {
        /// <summary>
        /// Singleton object
        /// </summary>
        private static Booking booking;
        /// <summary>
        /// Instance property returns the singleton instance
        /// </summary>
        public static Booking Instance
        {
            get
            {
                if (booking == null)
                    booking = new Booking();
                return booking;
            }
        }

        /// <summary>
        /// Instance variables
        /// </summary>
        private List<Customer> customers;
        private List<Room> rooms;
        /// <summary>
        /// Booking constructor 
        /// Instance variables customer and room
        /// room and customer set to a new list of room
        /// </summary>
        public Booking()
        {
            customers = new List<Customer>();
            rooms = new List<Room>();
        }

        /// <summary>
        /// read property for customer
        /// </summary>
        public List<Customer> Customers
        {
            get { return customers; }
        }
        /// <summary>
        /// read property for room
        /// </summary>
        public List<Room> Rooming
        {
            get { return rooms; }
        }
        /// <summary>
        /// method to add new customer
        /// adds customers based on parameters
        /// </summary>
        /// <param name="strn">name</param>
        /// <param name="yr">year of birth</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        public void addCustomer(String strn, int yr, String strst, string strtwn, string strpc)
        {
            ////member id setting to one more than the current size
            int id = customers.Count + 1;
            customers.Add(new Customer(strn, yr, strst, strtwn, strpc, id));
        }
        /// <summary>
        /// get customers method
        /// to return a string showing each member on a new line.
        /// </summary>
        /// <returns>string representation of customers</returns>
        public string getCustomers()
        {
            string strout = "Customers" + "\n";


            foreach (Customer cus in Customers)
            {
                strout = strout + cus + " \n";
                
            }
            
            return strout;
        }
        /// <summary>
        /// get rooms method 
        /// </summary>
        /// <returns>string representation of rooms</returns>
        public string getRooms()
        {
            string strStock = "";


            foreach (Room stk in rooms)
            {
                strStock = strStock + stk.ToString() + "\n";
            }
            return strStock;
        }
        /// <summary>
        /// add bedroom method
        /// setting room id to more than one more than the number of rooms
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="numOfBedrooms">Number of bedroom</param>
        public void addBedroom(string t, string a, int numOfBedrooms)
        {
            //stock id setting to one more than the current number of stock object
            int id = rooms.Count + 1;
            id = numOfBedrooms++;
            rooms.Add(new Bedroom(t, a, numOfBedrooms));
        }
        /// <summary>
        /// get bedroom method
        /// </summary>
        /// <returns>string representation of bedroom</returns>
        public string getBedroom()
        {
            string strbedroom = "";
            foreach (Room r in rooms)
            {
                Room room = r as Room;
                if (room != null)                
                {
                    strbedroom= strbedroom + r.ToString() + "\n";
                }
            }
            return strbedroom;
        }
        /// <summary>
        /// add conferenceroom method
        /// setting room id to more than one more than the number of rooms
        /// </summary>
        /// <param name="t"></param>
        /// <param name="v"></param>
        /// <param name="numOfRooms">num of rooms</param>
        public void addConferenceroom(string t, int v, int numOfRooms)
        {
            int id = rooms.Count + 1;
            id = numOfRooms++;
            rooms.Add(new Conferenceroom(v, t, numOfRooms));
        }
        /// <summary>
        /// get conference room method
        /// </summary>
        /// <returns>string representation of conferenceroom</returns>
        public string getConferenceroom()
        {
            string strJournal = "";
            foreach (Room j in rooms)
            {
                Conferenceroom conferenceroom = j as Conferenceroom;
                if (conferenceroom != null)
                {
                    strJournal = strJournal + j.ToString() + "\n";
                }
            }
            return strJournal;
        }
    }
}
