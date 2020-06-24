using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ombtwebapi.Models
{
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }
        public string Movie_Name { get; set; }

        public string Movie_language { get; set; }

        public string Movie_location { get; set; }

        public string Movie_gener { get; set; }

        public DateTime Movie_time { get; set; }

        [DisplayName("UploadImage")]
        public string Movie_Imagepath { get; set; }

        [DisplayName("Availabel Ticket")]
        public int Atickets { get; set; }

        public string Movie_Description { get; set; }

    }
}
