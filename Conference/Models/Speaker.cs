using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public Int32 speakerID { get; set; }

        [Required(ErrorMessage = "Todos tenemos un nombre acá. Dinos el tuyo")] //forma de cambiar los mensajes de validaciones por defecto
        [Display(Name = "Speakercista")] //por defecto se muestra como Titulo del campo a completar el nombre de la variable (Name)
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)] //crea una validación de email válido
        [Display(Name = "Email")]
        public String Email {get; set;}

        //public virtual List<Session> Sessions { get; set; } //el atributo virtual define una carga liviana/lazy desde la base de datos

    }
}
