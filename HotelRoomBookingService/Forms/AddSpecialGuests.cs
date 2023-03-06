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
    public partial class AddSpecialGuests : Form
    {
        public AddSpecialGuests()
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
                mainMenu.ReceiveData(data, 3);
                MessageBox.Show("Successfully added!", "Hotel Booking/Reservations Service", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            SendData(textBox1.Text);
        }
    }
}
