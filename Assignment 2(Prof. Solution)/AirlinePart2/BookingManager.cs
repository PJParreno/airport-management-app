using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePart2
{
    class BookingManager
    {
        private static int currentBookNumber;
        private int maxBookings;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int seed,int maxBook)
        {
            currentBookNumber = seed;
            maxBookings = maxBook;
            numBookings = 0;
            bookingList = new Booking[maxBook];
        }

        public bool addBooking(Customer c, Flight f)
        {
            if (!f.isFull())
            {
                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                f.addPassenger(c);
                Booking b = new Booking(date, c, f, currentBookNumber);
                currentBookNumber++;
                bookingList[numBookings] = b;
                numBookings++;
                return true;
            }
            return false;
        }

        public string getBookingList()
        {
            string s = "";
            for (int x = 0; x < numBookings; x++)
            {
                s = s + bookingList[x].toString()+"\n__________________________";
            }
            return s;

        }

    }
}
