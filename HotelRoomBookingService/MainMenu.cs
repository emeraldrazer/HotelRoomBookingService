using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: AssemblyTitle("HotelRoomBookingService")]

namespace HotelRoomBookingService
{
    public partial class MainMenu : Form
    {
        #region Lists And BindingSources

        static List<string> roomReservations = new List<string>();
        static List<string> tableReservations = new List<string>();
        static List<string> specialGuestList = new List<string>();


        BindingSource roomsBindingSource = new BindingSource();
        BindingSource tableBindingSource = new BindingSource();
        BindingSource specialBindingSource = new BindingSource();
        #endregion

        public MainMenu()
        {
            InitializeComponent();
            Timer.Start();
            curDate.Text = DateTime.Now.ToShortDateString();
            curTime.Text = DateTime.Now.ToLongTimeString();
            curDay.Text = DateTime.Today.DayOfWeek.ToString();

            MessageBox.Show(TableReservations.GetType().ToString());
        }

        // BINDING DATA TO LISTBOXES
        private void MainMenu_Load(object sender, EventArgs e) 
        {
            // ROOM RESERVATION
            roomsBindingSource.DataSource = roomReservations;
            RoomReservations.DataSource = roomsBindingSource;

            // TABLE RESERVATION
            tableBindingSource.DataSource = tableReservations;
            TableReservations.DataSource = tableBindingSource;

            // SPECIAL GUEST LIST
            specialBindingSource.DataSource = specialGuestList;
            SpecialGuestList.DataSource = specialBindingSource;

        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            roomsBindingSource.ResetBindings(false);
            tableBindingSource.ResetBindings(false);
            specialBindingSource.ResetBindings(false);
        }

        public void ReceiveData(string data, int option)
        {
            if(option == 1)
            {
                roomReservations.Add(data);
            }
            else if (option == 2)
            {
                tableReservations.Add(data);
            }
            else if (option == 3)
            {
                specialGuestList.Add(string.Concat($"{specialGuestList.Count + 1}. {data}"));
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Start();
            curDate.Text = DateTime.Now.ToShortDateString();
            curTime.Text = DateTime.Now.ToLongTimeString();
            curDay.Text = DateTime.Today.DayOfWeek.ToString();
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void clearAllLists_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all the lists? This cannot be undone.", "Hotel Booking/Reservations Service", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(roomReservations.Count == 0 && tableReservations.Count == 0 && specialGuestList.Count == 0)
                {
                    MessageBox.Show("Lists are already empty.", "Hotel Booking/Reservations Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    roomReservations.Clear();
                    roomsBindingSource.ResetBindings(false);

                    tableReservations.Clear();
                    tableBindingSource.ResetBindings(false);

                    specialGuestList.Clear();
                    specialBindingSource.ResetBindings(false);
                }
                
            }
        }

        #region RemoveAll Buttons

        private void removeall_RoomR_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear the list? This cannot be undone.", "Hotel Booking/Reservations Service", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(roomReservations.Count == 0)
                {
                    MessageBox.Show("List is already empty.", "Hotel Booking/Reservations Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    roomReservations.Clear();
                    roomsBindingSource.ResetBindings(false);
                }
                
            }
        }

        private void removeall_TableR_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear the list? This cannot be undone.", "Hotel Booking/Reservations Service", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(tableReservations.Count == 0)
                {
                    MessageBox.Show("List is already empty.", "Hotel Booking/Reservations Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tableReservations.Clear();
                    tableBindingSource.ResetBindings(false);
                }
            }
        }

        private void removeall_SpecialG_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear the list? This cannot be undone.", "Hotel Booking/Reservations Service", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(specialGuestList.Count == 0)
                {
                    MessageBox.Show("List is already empty.", "Hotel Booking/Reservations Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    specialGuestList.Clear();
                    specialBindingSource.ResetBindings(false);
                }
            }
        }
        #endregion

        #region Add Buttons

        private void add_RoomR_Click(object sender, EventArgs e)
        {
            AddRoomReservations add = new AddRoomReservations();
            add.ShowDialog();

        }

        private void add_TableR_Click(object sender, EventArgs e)
        {
            AddTableReservations add = new AddTableReservations();
            add.ShowDialog();
        }

        private void add_SpecialG_Click(object sender, EventArgs e)
        {
            AddSpecialGuests add = new AddSpecialGuests();
            add.ShowDialog();
        }

        #endregion

        #region Remove Button

        private void remove_RoomR_Click(object sender, EventArgs e)
        {
            int index = RoomReservations.SelectedIndex;

            if(index >= 0)
            {
                roomReservations.RemoveAt(index);
                roomsBindingSource.ResetBindings(false);
            }
        }

        private void remove_TableR_Click(object sender, EventArgs e)
        {
            int index = TableReservations.SelectedIndex;
            
            if(index >= 0)
            {
                tableReservations.RemoveAt(index);
                tableBindingSource.ResetBindings(false);
            }
        }

        private void remove_SpecialG_Click(object sender, EventArgs e)
        {
            int index = SpecialGuestList.SelectedIndex;

            if (index >= 0)
            {
                specialGuestList.RemoveAt(index);
                specialBindingSource.ResetBindings(false);
            }
        }
        #endregion
    }
}
