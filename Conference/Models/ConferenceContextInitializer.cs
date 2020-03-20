using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    //inicia la base de datos con datos de prueba
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "Super Conferencia!",
                    Abstract = "No te la pierdas",
                    Speaker = context.Speakers.Add(
                        new Speaker()
                        {
                            Name = "Pepe argento",
                            Email = "email@email.com"
                        })
                });
            context.SaveChanges();
        }
    }
}