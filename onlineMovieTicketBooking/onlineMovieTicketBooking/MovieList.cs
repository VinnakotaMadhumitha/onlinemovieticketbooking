using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public class MovieList
    {
        List<Movie> movielist = new List<Movie>();

       // Program ps = new Program();
        public void MovieView ( )
        {
            foreach (Movie s in movielist)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Id = {0}, Name = {1}, Timings = {2}, Location = {3}, Language = {4}, ScreenNo = {5}, AvailableTickets {6}", s.MovieId, s.MovieName, s.ShowTimings, s.Location, s.Language, s.ScreenNo, s.AvailableTickets);
                Console.ResetColor();

            }
        }
        public void MovieUpdate (Movie m)
        {
            movielist.Add(m);
        }

        public Movie MovieDetails (int mid)
        {
            Movie m1 = movielist.Find(a => a.MovieId == mid);
            return m1;
        }
    }
}
