using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using People;

namespace hotelReservation
{
    /// <summary>
    /// Customer encapsulates booking customers
    /// /// customer : person inheritance
    /// /// extends People.Person class
    /// </summary>
    public class Customer : Person
    {
        
        private int id; //id
        private string strst; //street
        private string strtwn; //town
        private string strpc; //postcode

        /// <summary>
        /// Customer constructor calling base constructor
        /// setting base id to 0
        /// </summary>
        public Customer() :base()
        {
            id = 0;
        }
        /// <summary>
        /// constructor calling base constructor!
        /// strn, yr, strt, strtwn, strpc correspond to name, year, street, town and postcode
        /// </summary>
        /// <param name="strn"></param>
        /// <param name="yr"></param>
        /// <param name="strst"></param>
        /// <param name="strtwn"></param>
        /// <param name="strpc"></param>
        /// <param name="id"></param>
        public Customer(string strn, int yr, string strst, string strtwn, string strpc, int id) : base(strn, yr)
        {
            this.id = id;
            this.strst = strst;
            this.strtwn = strtwn;
            this.strpc = strpc;
        }

        public Customer(String strn, string strst, string strtwn, string strpc, int yr, int mid) : base(strn, strst, strtwn, strpc, yr)
        {
            id = mid;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                ID = value;
            }
        }

        /// <summary>
        /// returns string
        /// </summary>
        /// <returns>name Haris</returns>
        public override string ToString()
        {
            string strout = ID + ": " + Name;
            return strout;
        }
    }



}
