﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Client
{
    public partial class lobby : Form
    {
        public RoomControl prev_select;
        public lobby() 
        {
            InitializeComponent();
           
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            showplayer();
            showroom();
        }

        public void showplayer()
        {
            player[] playerlist = new player[20];
            for (int i = 0; i < playerlist.Length; i++)
            {
                playerlist[i] = new player();
                playerlist[i].playername = "PlayerName";
                flowLayoutPanel1.Controls.Add(playerlist[i]);
         
                //if (flowLayoutPanel1.Controls.Count>0)
                //{
                //flowLayoutPanel1.Controls.Clear();
                //}
                //else

            }
        }


        public void showroom()
        {
            RoomControl[] roomlist = new RoomControl[10];
            for (int i = 0; i < roomlist.Length; i++)
            {
                roomlist[i] = new RoomControl();
                roomlist[i].roomname = "Room Name"+i;
                flowLayoutPanel2.Controls.Add(roomlist[i]);


                //if (flowLayoutPanel1.Controls.Count>0)
                //{
                //flowLayoutPanel1.Controls.Clear();
                //}
                //else

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(217,83,79);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(51, 178, 73);
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;

        }
        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(87, 131, 219);

        }




        //drag the borderless form 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Lobby_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // end code of dragable form
    }
}
