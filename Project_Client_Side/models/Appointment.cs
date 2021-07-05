using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace Project_Client_Side.models
{

        [DataContract]
        public class Appointment
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }

            [DataMember(Name = "name_client")]
            public String Name_client { get; set; }


            [DataMember(Name = "phone_number")]
            public String Phone_number { get; set; }

            //[DataType(DataType.Date)]
            [DataMember(Name = "appointment_date")]
            public DateTime Appointment_date { get; set; }

            [DataMember(Name = "total")]
            public double Total { get; set; }

            [DataMember(Name = "services")]
            public List<Service> Services { get; set; }

            [DataMember(Name = "appointmentAsString")]
            public string AppointmentAsString { get; set; }

    }
}
