using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Session
    {
        public Int32 SessionID { get; set; } //MVC tiene una convención de nombres que permite que SessionID se convierta en primary key

        [Required]
        public String Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public String Abstract { get; set; } //Resumen

        public Int32 SpeakerID { get; set; } //supongo que tenemos una clave foranea acá

        public Speaker Speaker {get; set;}
    }
}