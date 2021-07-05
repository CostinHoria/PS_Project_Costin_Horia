using System;
using Xunit;
using Tema2_NoLogin.Services;
using Tema2_NoLogin.DTO;
using Tema2_NoLogin.DAL;
using Microsoft.EntityFrameworkCore;
using Tema2_NoLogin.Models;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalonContext>();
            optionsBuilder.UseSqlServer("DESKTOP-MR6F4FF");
            var context = new SalonContext(optionsBuilder.Options);

            AppointmentService appointmentService = new AppointmentService(context);
            Appointment appointment = new Appointment();
            Service service1= new Service();
            service1.Name = "Vopsit";
            service1.Price = 55;

            Service service2 = new Service();
            service2.Name = "Manichiura";
            service2.Price = 45;

            appointment.Services.Add(service1);
            appointment.Services.Add(service2);
            appointmentService.calculateTotal(appointment);
            Assert.Equal(100.00, appointment.Total);
        }
    }
}
