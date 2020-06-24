using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public class Movie
    {
        // Declaring the variables of Movie

        private int _movieId;
        private string _movieName;
        private DateTime _showTimings;
        private string _location;
        private string _language;
        private int _screenNo;
        private int _availableTickets;

        // Parameterised Constructor of Movie

        public Movie( int movieId, string movieName, DateTime showTimings , string location, string language, int screenNo, int availableTickets)
        {
            _movieId = movieId;
            _movieName = movieName;
            _showTimings = showTimings;
            _location = location;
            _language = language;
            _screenNo = screenNo;
            _availableTickets = availableTickets;
        }

        // Property of Movie Variables

        public int MovieId
        {
            get { return this._movieId; }
            set { this._movieId = value; }
        }
        public string MovieName
        {
            get { return this._movieName; }
            set { this._movieName = value; }
        }
  
        public DateTime ShowTimings
        {
            get { return this._showTimings; }
            set { this._showTimings = value; }
        }
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }
        public int ScreenNo
        {
            get { return this._screenNo; }
            set { this._screenNo = value; }
        }
        public int AvailableTickets
        {
            get { return this._availableTickets; }
            set { this._availableTickets = value; }
        }

  
    }
}
    
