using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ombtwebapi.Models;

namespace ombtwebapi.Controllers
{
    public class MovieController : ApiController
    {
        OmbtContext Oc = new OmbtContext();

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return Oc.Movies.ToList();
        }
        [HttpGet]
        public Movie GetMovie(int id)
        {
            return Oc.Movies.Find(id);
        }
        [HttpPost]
        public bool AddMovie(Movie m)
        {
            bool successflag = false;
            Oc.Movies.Add(m);
            Oc.SaveChanges();
            successflag = true;
            return successflag;
        }
        [HttpPut]
        public bool UpdateCustomer(Movie m)
        {
            bool successflag = false;
            var movieindb = Oc.Movies.SingleOrDefault(x => x.Movie_Id == m.Movie_Id);
            if (movieindb != null)
            {
                movieindb.Atickets = m.Atickets;
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            bool successflag = false;
            var movieindb = Oc.Movies.SingleOrDefault(x => x.Movie_Id == id);
            if (movieindb != null)
            {
                Oc.Movies.Remove(movieindb);
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }

    }
}

