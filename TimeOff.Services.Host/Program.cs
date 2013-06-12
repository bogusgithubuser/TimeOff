using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace TimeOff.Services.Host
{
    class Program
    {
        static void Main()
        {
            using (var staffServiceHost = new ServiceHost(typeof(StaffService), new Uri("http://localhost:8080/StaffService")))
            using (var vacationServiceHost = new ServiceHost(typeof(VacationService), new Uri("http://localhost:8080/VacationService")))
            {
                staffServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
                vacationServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

                staffServiceHost.Open();
                vacationServiceHost.Open();

                Console.WriteLine("Press ENTER to stop services and exit.");
                Console.ReadLine();

                staffServiceHost.Close();
                vacationServiceHost.Close();
            }
        }
    }
}