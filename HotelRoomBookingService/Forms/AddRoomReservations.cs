using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomBookingService
{
    public partial class AddRoomReservations : Form
    {
        public AddRoomReservations()
        {
            InitializeComponent();
        }

        private void SendData(string data)
        {
            MainMenu mainMenu = new MainMenu();
            if (data == String.Empty)
            {
                MessageBox.Show("Textbox is empty, nothing was added", "Hotel Booking/Reservations Service", MessageBoxButtons.OK);
            }
            else
            {
                mainMenu.ReceiveData(data, 1);
                MessageBox.Show("Successfully added!", "Hotel Booking/Reservations Service", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void add_Button_Click_1(object sender, EventArgs e)
        {
            SendData(string.Format($"Name: {textBox1.Text} | Room: {textBox2.Text}"));
        }
    }
}
