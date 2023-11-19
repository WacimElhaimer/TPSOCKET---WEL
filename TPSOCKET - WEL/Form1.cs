using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace TPSocket.Properties
{
    public partial class Communication : Form
    {
        public Communication()
        {
            InitializeComponent();
        }

        private void buttonCreer_click(object sender, EventArgs e)
        {
            try
            {
                //creer object socket
                SSocketUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                //set timeout
                SSocketUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);

                try
                {
                    Destination = new IPEndPoint(IPAddress.Parse(this.ipDest.Text), int.Parse(this.portRec.Text));
                    Reception = new IPEndPoint(IPAddress.Parse(this.ipRec.Text), int.Parse(this.portDest.Text));
                    SSocketUDP.Bind(Reception);


                }
                catch(Exception ex)
                {
                    string str = ex.ToString();
                    MessageBox.Show(str);
                }

            }

            catch(SocketException ex)
            {
                string str = ex.ToString();
                MessageBox.Show(str);
            }
        }

        private void buttonFerme_click(object sender, EventArgs e)
        {
            try
            {
                SSocketUDP.Close();
            }
            catch (SocketException ex)
            {
                string str = ex.ToString();
                MessageBox.Show(str);
            }
        }

        private void buttonSend_click(object sender, EventArgs e)
        {
            try
            {
                var msg = Encoding.ASCII.GetBytes(this.textLineSend.Text);
                SSocketUDP.SendTo(msg, Destination);
            }
            catch (SocketException ex)
            {
                string str = ex.ToString();
                MessageBox.Show(str);
            }
        }

        private void buttonRecThread_click(object sender, EventArgs e)
        {
            Task.Run(() => CheckUp());

        }

        private bool recTimer()
        {
            try
            {
                var buffer = new byte[1024];
                SSocketUDP.ReceiveFrom(buffer, ref Reception);
                this.textLineRec.Text = Encoding.ASCII.GetString(buffer);
                return SSocketUDP.Available == 0;
            }
            catch (SocketException ex)
            {
                string str = ex.ToString();
                MessageBox.Show(str);
            }
            return false;


        }

        private void CheckUp()
        {
            Timer.Start();
            while (Timer.ElapsedMilliseconds < 1500) ;
            Timer.Stop();

            if (!recTimer())
            {
                CheckUp();
            }
        }

    }


}