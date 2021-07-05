using Project_Client_Side.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json; // also add Framework reference 'System.Runtime.Serialization'
using System.Runtime.Serialization;
using System.IO;
using System.Net;

namespace Project_Client_Side
{
    public class ServiceJson
    {
        string uri = "https://localhost:44366/api/Appointment";                  
        public List<Appointment> GetAppointments()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = "GET";
                var response = request.GetResponse();

                Stream stream = response.GetResponseStream();
                int ok = 0;
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Appointment>));
                List<Appointment> objResponse = (List<Appointment>)dataContractJsonSerializer.ReadObject(stream);
                if (objResponse != null)
                {
                    ok = 1;
                    return objResponse;
                }
                else
                {
                    return new List<Appointment>();
                }

            }
            catch (Exception e)
            {
                return new List<Appointment>();
            }
        }

        public void deleteAppointment(int id)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = "DELETE";
                var response = request.GetResponse();
                int ok = 0;
                if (response != null)
                {
                    ok = 1;
                }

            }
            catch (Exception e)
            {
                return ;
            }
        }

    }
}
