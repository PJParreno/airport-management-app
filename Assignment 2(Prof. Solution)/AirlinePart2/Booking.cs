using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePart2
{
    class Booking
    {
        private string bookingDate;
        private Customer customer;
        private Flight flight;
        private int bookingNumber;

        public Booking(string bdate,Customer c,Flight f,int bn)
        {
            bookingDate = bdate;
            customer = c;
            flight = f;
            bookingNumber = bn;
        }

        public int getBookingNumber() { return bookingNumber; }
        public string getBookingDate() { return bookingDate; }
        public Flight getFlight() { return flight; }
        public Customer getCustomer() { return customer; }
        

        public string toString()
        {
            string s = "Booking Number: " + bookingNumber;
            s = s + "\nOrigin: " + flight.getOrigin();
            s = s + "\nDestination:" + flight.getDestination();
            s = s + "\nPassenger:" + customer.getFirstName()+" "+customer.getLastName();
            s = s + "\nBooking date:" + bookingDate;
            return s;

        }
    }
}
