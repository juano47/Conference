using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    //Clase que permite la conexión y obtención de datos de la base de datos
    //Lo mejor sería tener una clase Repository que se encargue de las conexiones y guardar datos. Quedaría entre el modelo y la base de datos
    public class ConferenceContext : DbContext // la sintaxis : implementa la herencia
    {
        public DbSet<Session> Sessions { get; set; } //maneja la lista completa de sesiones guardada en la bd

        public DbSet<Speaker> Speakers { get; set; }
    }
}