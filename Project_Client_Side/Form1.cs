using Project_Client_Side.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Client_Side
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceJson jsonService = new ServiceJson();
            List<Appointment> items = jsonService.GetAppointments();

            foreach (Appointment i in items)
            {
                listBox1.Items.Add("Client: " + i.Name_client + ", Phone number: " + i.Phone_number + ", Date: " + i.Appointment_date + ", services: " + i.AppointmentAsString);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
