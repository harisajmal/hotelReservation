using hotelReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelReservation
{
    [Serializable]
    public abstract class Room
    {
        public abstract void Book(Customer m);
        protected int roomNum;
        protected string roomTitle;
        protected Customer customer;
        protected DateTime returnDate;

        /// <summary>
        /// Room constructor
        /// setting customer to null
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strtitle"></param>
        public Room(int id, string strtitle)
        {
            roomNum = id;
            roomTitle = strtitle;
            returnDate = DateTime.Now;
            customer = null;
        }

        /// <summary>
        /// returns the room that was booked
        /// </summary>
        public void cancelRoom()
        {
            if (customer == null)
            {
                throw new Exception("not booked");
            }
            else
            {
                customer = null;
            }
        }


        /// <summary>
        /// displays/returns the booking bedroom number and the title of the bedroom
        /// </summary>
        /// <returns>strout</returns>
        public override string ToString()
        {
            if (customer == null)
            {
                string strout = "";
                strout = strout + "\n" + roomNum + ": " + roomTitle + "\n";
                return strout;
            }
            else
            {
                string strout = "";
                strout = strout + "\n" + roomNum + ": " + roomTitle + " Room is booked by " + customer + " Return date is: " + returnDate + "\n";
                return strout;
            }
        }


    }
    //bedroom and room inheritance
    class Bedroom : Room
    {
        private string owner;
        /// <summary>
        /// Bedroom constructor
        /// </summary>
        /// <param name="strtitle">title</param>
        /// <param name="strowner">owner</param>
        /// <param name="intid">id</param>
        public Bedroom(string strtitle, string strowner, int intid) : base(intid, strtitle)
        {
            owner = strowner;
        }
        /// <summary>
        /// if a room object is booked (customer set) then the method should also
        /// display the customer booked and the return date
        /// </summary>
        /// <returns>string representation of bedroom</returns>
        public override string ToString()
        {
            if (customer == null)
            {
                string strout = "";
                strout = strout + roomNum + ") " + owner + " for" + roomTitle;
                return strout;
            }
            else
            {
                string strout = "";
                strout = strout  + owner + " for " + roomTitle + " is booked by " +customer + " return date : " + returnDate;
                return strout;
            }
        }
        /// <summary>
        /// abstract class Book
        /// return date set to 30 days
        /// throws exception if already Booked
        /// </summary>
        /// <param name="m"></param>
        public override void Book(Customer c)
        {
            if (customer == null)
            {
                customer = c;
                returnDate = returnDate.AddDays(30);
            }
            else
            {
                throw new Exception("Already booked");
            }
        }
    }
    //Conferenceroom and room inheritance
    class Conferenceroom : Room
    {
        private int guest;
        /// <summary>
        /// Conference room Constructor
        /// </summary>
        /// <param name="num"></param>
        /// <param name="strtitle"></param>
        /// <param name="id"></param>
        public Conferenceroom(int num, string strtitle, int id) : base(id, strtitle)
        {
            guest = num;
        }

        /// <summary>
        /// displays the customer booked if room object is booked
        /// </summary>
        /// <returns>string representation of conferenceroom</returns>
        public override string ToString()
        {
            if (customer == null)
            {
                string strout = "";
                strout = strout + roomNum + ": " + roomTitle + " guest " + guest;
                return strout;
            }
            else
            {
                string strout = "";
                strout = strout + roomNum + ": " + roomTitle  + " is booked " + guest + "is booked" + customer + " return date is: " + returnDate;
                return strout;
            }
        }
        /// <summary>
        /// return date set to 30 days
        /// throws exception if already booked
        /// </summary>
        /// <param name="m">customer</param>
        public override void Book(Customer c)
        {
            if (customer == null)
            {
                customer = c;
                returnDate = returnDate.AddDays(3);
            }
            else
            {
                throw new Exception("Already booked");
            }
        }
    }
}
