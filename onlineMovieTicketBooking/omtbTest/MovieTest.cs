using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using onlineMovieTicketBooking;
using System.ComponentModel;

namespace omtbTest
{

    public class MovieTest
    {
        Movie m1 = new Movie(1, "abc", new DateTime(2020, 06, 10), "xyz", "abc", 1, 20);
        MovieList mlt = new MovieList();
       
            [TestCase(1)]
            public void TestMovieDetails (int id)
            {
            Movie mt = mlt.MovieDetails(id);
                Assert.AreNotEqual(m1, mt);
            }
        

    }
}
