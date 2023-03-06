namespace HotelRoomBookingService
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.removeall_RoomR = new System.Windows.Forms.Button();
            this.removeall_TableR = new System.Windows.Forms.Button();
            this.remove_TableR = new System.Windows.Forms.Button();
            this.add_TableR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.removeall_SpecialG = new System.Windows.Forms.Button();
            this.remove_SpecialG = new System.Windows.Forms.Button();
            this.add_SpecialG = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.curDate = new System.Windows.Forms.Label();
            this.curTime = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.curDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearAllLists = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.add_RoomR = new System.Windows.Forms.Button();
            this.RoomReservations = new System.Windows.Forms.ListBox();
            this.TableReservations = new System.Windows.Forms.ListBox();
            this.SpecialGuestList = new System.Windows.Forms.ListBox();
            this.remove_RoomR = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(172, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Reservations";
            // 
            // removeall_RoomR
            // 
            this.removeall_RoomR.BackColor = System.Drawing.Color.Transparent;
            this.removeall_RoomR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removeall_RoomR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeall_RoomR.Location = new System.Drawing.Point(160, 333);
            this.removeall_RoomR.Name = "removeall_RoomR";
            this.removeall_RoomR.Size = new System.Drawing.Size(188, 23);
            this.removeall_RoomR.TabIndex = 4;
            this.removeall_RoomR.Text = "Remove All";
            this.removeall_RoomR.UseVisualStyleBackColor = false;
            this.removeall_RoomR.Click += new System.EventHandler(this.removeall_RoomR_Click);
            // 
            // removeall_TableR
            // 
            this.removeall_TableR.BackColor = System.Drawing.Color.Transparent;
            this.removeall_TableR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removeall_TableR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeall_TableR.Location = new System.Drawing.Point(384, 333);
            this.removeall_TableR.Name = "removeall_TableR";
            this.removeall_TableR.Size = new System.Drawing.Size(188, 23);
            this.removeall_TableR.TabIndex = 9;
            this.removeall_TableR.Text = "Remove All";
            this.removeall_TableR.UseVisualStyleBackColor = false;
            this.removeall_TableR.Click += new System.EventHandler(this.removeall_TableR_Click);
            // 
            // remove_TableR
            // 
            this.remove_TableR.BackColor = System.Drawing.Color.Transparent;
            this.remove_TableR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.remove_TableR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_TableR.Location = new System.Drawing.Point(485, 304);
            this.remove_TableR.Name = "remove_TableR";
            this.remove_TableR.Size = new System.Drawing.Size(87, 23);
            this.remove_TableR.TabIndex = 8;
            this.remove_TableR.Text = "Remove";
            this.remove_TableR.UseVisualStyleBackColor = false;
            this.remove_TableR.Click += new System.EventHandler(this.remove_TableR_Click);
            // 
            // add_TableR
            // 
            this.add_TableR.BackColor = System.Drawing.Color.Transparent;
            this.add_TableR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.add_TableR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_TableR.Location = new System.Drawing.Point(384, 304);
            this.add_TableR.Name = "add_TableR";
            this.add_TableR.Size = new System.Drawing.Size(80, 23);
            this.add_TableR.TabIndex = 6;
            this.add_TableR.Text = "Add";
            this.add_TableR.UseVisualStyleBackColor = false;
            this.add_TableR.Click += new System.EventHandler(this.add_TableR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(400, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hotel Table Reservations";
            // 
            // removeall_SpecialG
            // 
            this.removeall_SpecialG.BackColor = System.Drawing.Color.Transparent;
            this.removeall_SpecialG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removeall_SpecialG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeall_SpecialG.Location = new System.Drawing.Point(600, 333);
            this.removeall_SpecialG.Name = "removeall_SpecialG";
            this.removeall_SpecialG.Size = new System.Drawing.Size(188, 23);
            this.removeall_SpecialG.TabIndex = 14;
            this.removeall_SpecialG.Text = "Remove All";
            this.removeall_SpecialG.UseVisualStyleBackColor = false;
            this.removeall_SpecialG.Click += new System.EventHandler(this.removeall_SpecialG_Click);
            // 
            // remove_SpecialG
            // 
            this.remove_SpecialG.BackColor = System.Drawing.Color.Transparent;
            this.remove_SpecialG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.remove_SpecialG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_SpecialG.Location = new System.Drawing.Point(701, 304);
            this.remove_SpecialG.Name = "remove_SpecialG";
            this.remove_SpecialG.Size = new System.Drawing.Size(87, 23);
            this.remove_SpecialG.TabIndex = 13;
            this.remove_SpecialG.Text = "Remove";
            this.remove_SpecialG.UseVisualStyleBackColor = false;
            this.remove_SpecialG.Click += new System.EventHandler(this.remove_SpecialG_Click);
            // 
            // add_SpecialG
            // 
            this.add_SpecialG.BackColor = System.Drawing.Color.Transparent;
            this.add_SpecialG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.add_SpecialG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_SpecialG.Location = new System.Drawing.Point(600, 304);
            this.add_SpecialG.Name = "add_SpecialG";
            this.add_SpecialG.Size = new System.Drawing.Size(80, 23);
            this.add_SpecialG.TabIndex = 11;
            this.add_SpecialG.Text = "Add";
            this.add_SpecialG.UseVisualStyleBackColor = false;
            this.add_SpecialG.Click += new System.EventHandler(this.add_SpecialG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(635, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Special Guests List";
            // 
            // curDate
            // 
            this.curDate.AutoSize = true;
            this.curDate.BackColor = System.Drawing.Color.Transparent;
            this.curDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDate.ForeColor = System.Drawing.Color.White;
            this.curDate.Location = new System.Drawing.Point(201, 9);
            this.curDate.Name = "curDate";
            this.curDate.Size = new System.Drawing.Size(39, 17);
            this.curDate.TabIndex = 15;
            this.curDate.Text = "Date";
            // 
            // curTime
            // 
            this.curTime.AutoSize = true;
            this.curTime.BackColor = System.Drawing.Color.Transparent;
            this.curTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTime.ForeColor = System.Drawing.Color.White;
            this.curTime.Location = new System.Drawing.Point(433, 9);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(42, 17);
            this.curTime.TabIndex = 16;
            this.curTime.Text = "Time";
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundImage = global::HotelRoomBookingService.Properties.Resources.eXpresso;
            this.TopPanel.Controls.Add(this.HelpLabel);
            this.TopPanel.Controls.Add(this.curDay);
            this.TopPanel.Controls.Add(this.curDate);
            this.TopPanel.Controls.Add(this.curTime);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(809, 37);
            this.TopPanel.TabIndex = 17;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.HelpLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.ForeColor = System.Drawing.Color.White;
            this.HelpLabel.Location = new System.Drawing.Point(50, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(40, 17);
            this.HelpLabel.TabIndex = 18;
            this.HelpLabel.Text = "Help";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // curDay
            // 
            this.curDay.AutoSize = true;
            this.curDay.BackColor = System.Drawing.Color.Transparent;
            this.curDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDay.ForeColor = System.Drawing.Color.White;
            this.curDay.Location = new System.Drawing.Point(662, 9);
            this.curDay.Name = "curDay";
            this.curDay.Size = new System.Drawing.Size(33, 17);
            this.curDay.TabIndex = 17;
            this.curDay.Text = "Day";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HotelRoomBookingService.Properties.Resources.eXpresso;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.clearAllLists);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 334);
            this.panel2.TabIndex = 18;
            // 
            // clearAllLists
            // 
            this.clearAllLists.BackColor = System.Drawing.Color.Transparent;
            this.clearAllLists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearAllLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllLists.Location = new System.Drawing.Point(25, 296);
            this.clearAllLists.Name = "clearAllLists";
            this.clearAllLists.Size = new System.Drawing.Size(90, 23);
            this.clearAllLists.TabIndex = 20;
            this.clearAllLists.Text = "Clear All Lists";
            this.clearAllLists.UseVisualStyleBackColor = false;
            this.clearAllLists.Click += new System.EventHandler(this.clearAllLists_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // add_RoomR
            // 
            this.add_RoomR.BackColor = System.Drawing.Color.Transparent;
            this.add_RoomR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.add_RoomR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_RoomR.Location = new System.Drawing.Point(160, 304);
            this.add_RoomR.Name = "add_RoomR";
            this.add_RoomR.Size = new System.Drawing.Size(80, 23);
            this.add_RoomR.TabIndex = 19;
            this.add_RoomR.Text = "Add";
            this.add_RoomR.UseVisualStyleBackColor = false;
            this.add_RoomR.Click += new System.EventHandler(this.add_RoomR_Click);
            // 
            // RoomReservations
            // 
            this.RoomReservations.FormattingEnabled = true;
            this.RoomReservations.Location = new System.Drawing.Point(160, 79);
            this.RoomReservations.Name = "RoomReservations";
            this.RoomReservations.Size = new System.Drawing.Size(188, 212);
            this.RoomReservations.TabIndex = 20;
            // 
            // TableReservations
            // 
            this.TableReservations.FormattingEnabled = true;
            this.TableReservations.Location = new System.Drawing.Point(384, 79);
            this.TableReservations.Name = "TableReservations";
            this.TableReservations.Size = new System.Drawing.Size(188, 212);
            this.TableReservations.TabIndex = 21;
            // 
            // SpecialGuestList
            // 
            this.SpecialGuestList.FormattingEnabled = true;
            this.SpecialGuestList.Location = new System.Drawing.Point(600, 79);
            this.SpecialGuestList.Name = "SpecialGuestList";
            this.SpecialGuestList.Size = new System.Drawing.Size(188, 212);
            this.SpecialGuestList.TabIndex = 22;
            // 
            // remove_RoomR
            // 
            this.remove_RoomR.BackColor = System.Drawing.Color.Transparent;
            this.remove_RoomR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.remove_RoomR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_RoomR.Location = new System.Drawing.Point(261, 304);
            this.remove_RoomR.Name = "remove_RoomR";
            this.remove_RoomR.Size = new System.Drawing.Size(87, 23);
            this.remove_RoomR.TabIndex = 23;
            this.remove_RoomR.Text = "Remove";
            this.remove_RoomR.UseVisualStyleBackColor = false;
            this.remove_RoomR.Click += new System.EventHandler(this.remove_RoomR_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelRoomBookingService.Properties.Resources.Bighead;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 371);
            this.Controls.Add(this.remove_RoomR);
            this.Controls.Add(this.SpecialGuestList);
            this.Controls.Add(this.TableReservations);
            this.Controls.Add(this.RoomReservations);
            this.Controls.Add(this.add_RoomR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.removeall_SpecialG);
            this.Controls.Add(this.remove_SpecialG);
            this.Controls.Add(this.add_SpecialG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeall_TableR);
            this.Controls.Add(this.remove_TableR);
            this.Controls.Add(this.add_TableR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeall_RoomR);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Hotel Booking/Reservations Service";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeall_RoomR;
        private System.Windows.Forms.Button removeall_TableR;
        private System.Windows.Forms.Button remove_TableR;
        private System.Windows.Forms.Button add_TableR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeall_SpecialG;
        private System.Windows.Forms.Button remove_SpecialG;
        private System.Windows.Forms.Button add_SpecialG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label curDate;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label curDay;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button add_RoomR;
        private System.Windows.Forms.Button clearAllLists;
        private System.Windows.Forms.ListBox RoomReservations;
        private System.Windows.Forms.ListBox TableReservations;
        private System.Windows.Forms.ListBox SpecialGuestList;
        private System.Windows.Forms.Button remove_RoomR;
    }
}

