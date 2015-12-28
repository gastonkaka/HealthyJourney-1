using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Data;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;

namespace HealthyJourney.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthyJourneyContext ctx = null;
            ctx = new HealthyJourneyContext();

            // Admin c = new Admin { UserName = "thaer", Password = "thaer", ConfirmPAssword = "thaer", Email = "thaer.saidi@esprit.tn", IsApproved = false };
            //ISpecialityServices service = new SpecialityServices();
            //Speciality s = new Speciality { Label = "Diagnostic Imaging", Description = "nice Diagnostic Imaging description", ImgPath="eye", Special=false };
            //service.AddSpeciality(s);

            //Infos i = new Infos { UserId = "1", Adress = new Adress(), FirstName = "thaer" };



            //IUserServices service = new UserServices();
            //List<Infos> users = service.GetAllInfos() as List<Infos>;
            //foreach (var s in users)
            //{
            //    System.Diagnostics.Debug.Write("Id " + s.UserId);

            //    //System.Diagnostics.Debug.Write("Name " + s.FirstName);
            //}


            IForumServices f = new ForumServices();
            IUserServices isx = new UserServices();
            User i = isx.GetAllUsers().ElementAt(0);

            try
            {
                Forum forum = new Forum { Content = "test", Files = "expert-1.png", DateCreation = new DateTime(), Title = "test", User = i };

            }
            catch (Exception)
            {

                throw;
            }

            System.Diagnostics.Debug.Write("OK");
        }
    }
}
