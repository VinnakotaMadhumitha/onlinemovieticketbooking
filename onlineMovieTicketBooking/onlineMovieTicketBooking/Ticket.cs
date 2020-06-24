using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
    public class Ticket
    {
        // Declaring the variables of Ticket

        private int _ticketId;
        private string _movieName;
        private DateTime _showtime;
        private int _customerId;
        private int _nOT;
        private double _amount;
        private int _seatNumber;

        // Parameterised Constructor of Ticket 

        public Ticket (int ticketId , string movieName, DateTime showtime, int customerId ,int nOT, double amount, int seatNumber)
        {
            _ticketId = ticketId;
            _movieName = movieName;
            _showtime = showtime;
            _customerId = customerId;
            _nOT = nOT;
            _amount = amount;
            _seatNumber = seatNumber;

        }

        //property of Ticket

        public int TicketId 
        {
          get { return this._ticketId; }
            set { this._ticketId = value; }
        }
        public string MovieName
        {
            get { return this._movieName; }
            set { this._movieName = value; }
        }
        public DateTime Showtime
        {
            get { return this._showtime; }
            set { this._showtime = value; }
        }
        public int CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        public int Not
        {
            get { return this._nOT; }
            set { this._nOT = value; }
        }
        public double Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }
        public int SeatNumber
        {
            get { return this._seatNumber; }
            set { this._seatNumber = value; }
        }
       
    }
}
