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
using System.IO;

namespace UDPcommunication
{
  
    public partial class Form1 : Form
    {
        string d = string.Empty;
        public Form1(string d)
        {
            InitializeComponent();
            this.d = d;
        }       
        private void btnGetTemp_Click(object sender, EventArgs e){

        }      
        private void brnShowTemp_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = d;
        }
    }
}
    
   





/*{
   string str = "Hello Data";
            int receiverPort = 20000;
            UdpClient receiver = new UdpClient(receiverPort);

            // Display some information
            //Console.WriteLine("Starting Upd receiving on port: " + receiverPort);
            //Console.WriteLine("Press any key to quit.");
            //Console.WriteLine("-------------------------------\n");

            // Start async receiving
            receiver.BeginReceive(DataReceived, receiver);

            // Send some test messages
            using (UdpClient sender1 = new UdpClient(19999))
                sender1.Send(Encoding.ASCII.GetBytes(str), 10, "localhost", receiverPort);
           using (UdpClient sender2 = new UdpClient(20001))
                sender2.Send(Encoding.ASCII.GetBytes("Hi!"), 3, "localhost", receiverPort);

            // Wait for any key to terminate application
            //Console.ReadKey();
}*/
/*private static void DataReceived(IAsyncResult ar)
{
    UdpClient c = (UdpClient)ar.AsyncState;
    IPEndPoint receivedIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
    Byte[] receivedBytes = c.EndReceive(ar, ref receivedIpEndPoint);

    // Convert data to ASCII and print in console
    string receivedText = ASCIIEncoding.ASCII.GetString(receivedBytes);
    //Console.Write(receivedIpEndPoint + ": " + receivedText + Environment.NewLine);

    // Restart listening for udp data packages
    c.BeginReceive(DataReceived, ar.AsyncState);
    textStr = receivedText;

}  */