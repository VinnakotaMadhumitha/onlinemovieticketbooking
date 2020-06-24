using ombtmvc1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ombtmvc1.Controllers
{
    public class MovieController : Controller
    {
        
        OmbtContext mc = new OmbtContext();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddNewMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewMovie(Movie movie, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imagepath = Path.Combine(Server.MapPath("~/Images/"), filename);
                file.SaveAs(imagepath);
                movie.Movie_Imagepath = "~/Images/" + file.FileName;
            }
            else
            {
                movie.Movie_Imagepath = "~/Images/default";
            }
            mc.Movies.Add(movie);
            mc.SaveChanges();
            ViewData["Message"] = movie.Movie_Name + "is added sucessfully";
            return RedirectToAction("Index");
        }
        public ActionResult MovieList()
        {

            List<Movie> ml = mc.Movies.ToList();
            return View(ml);
        }
        [HttpGet]
        public ActionResult ViewMovies(int id)
        {
            Movie mobj = new Movie();
            mobj = mc.Movies.Where(x => x.Movie_Id == id).FirstOrDefault();
            return View(mobj);
        }
        public ActionResult MovieListAdmin()
        {
            List<Movie> ml = mc.Movies.ToList();
            return View(ml);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie mdel = mc.Movies.Find(id);
            if (mdel == null)
            {
                return HttpNotFound();
            }
            return View(mdel);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Movie mdel = mc.Movies.Find(id);
            mc.Movies.Remove(mdel);
            mc.SaveChanges();
            return RedirectToAction("CartDetails");

        }
        public ActionResult Edit(int id)
        {
            
            Movie medit = mc.Movies.SingleOrDefault(movie => movie.Movie_Id == id);
            return View(medit);


        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie me,HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        string filename = Path.GetFileName(file.FileName);
                        string imagepath = Path.Combine(Server.MapPath("~/Images/"), filename);
                        file.SaveAs(imagepath);
                        me.Movie_Imagepath = "~/Images/" + file.FileName;
                    }
                    else
                    {
                        me.Movie_Imagepath = "~/Images/default";
                    }
                    mc.Movies.AddOrUpdate(me);
                    mc.SaveChanges();
                    return RedirectToAction("MovieListAdmin");
                }
                return View();



            }
            catch
            {
                return View();
            }
        }
        public ActionResult ViewMoviesA(int id)
        {
            Movie mobj = new Movie();
            mobj = mc.Movies.Where(x => x.Movie_Id == id).FirstOrDefault();
            return View(mobj);
        }


    }
}