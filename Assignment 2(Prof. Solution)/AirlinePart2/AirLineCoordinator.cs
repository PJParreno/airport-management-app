using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePart2
{
    class AirLineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookManager;

        public AirLineCoordinator(int custIdSeed, int maxCust, int maxFlights, int bookSeed, int maxBookings)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bookManager = new BookingManager(bookSeed, maxBookings);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public bool addBooking(int cNum,int flightNo)
        {
            Customer c =custManager.getCustomer(cNum);
            Flight f = flManager.getFlight(flightNo);
            if (c == null || f == null) return false;
            return bookManager.addBooking(c,f);
        }

        public string viewFlight(int fN)
        {
            string s = "Sorry there is no Flight with flight number " + fN;
            if (flManager.flightExists(fN))
            {
                s = flManager.getFlight(fN).toString();
            }
            return s;
        }

        public string flightList()
        {
            return flManager.getFlightList();
        }

        public string customerList()
        {
            return custManager.getCustomerList();
        }
        public string bookingList()
        {
            return bookManager.getBookingList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

    }
}
