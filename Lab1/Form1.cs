using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private float scrollPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAdaptersInfo();
            ThreadFunc();
        }

        public async void ThreadFunc()
        {
            while (true)
            {
                await Task.Delay(1000);

                cloclLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }

        public void PingTest(IPAddress address)
        {
            Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int anyPort = 0;
            EndPoint localWifiEP = new IPEndPoint(address, anyPort);

            clientSock.Bind(localWifiEP);

            EndPoint webApiServiceEP = new DnsEndPoint("www.google.com", port: 80);
            clientSock.Connect(webApiServiceEP);

            clientSock.Close();
        }

        /// <summary>
        /// Updates all adapters info
        /// </summary>
        public void UpdateAdaptersInfo()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            string outputText = "";

            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();

                outputText += "Name: " + adapter.Name + "\r\n";
                outputText += "Description " + adapter.Description + "\r\n";
                outputText += "GUID: " + adapter.Id + "\r\n";
                outputText += "Ipv6: " + properties.UnicastAddresses[0].Address.ToString() + "\r\n";

                if (properties.UnicastAddresses.Count > 1)
                {
                    outputText += "Ipv4: " + properties.UnicastAddresses[1].Address.ToString() + "\r\n";

                    outputText += "Mask: " + properties.UnicastAddresses[1].IPv4Mask.ToString() + "\r\n";

                    bool internetAccess = false;

                    try
                    {
                        PingTest(properties.UnicastAddresses[1].Address);

                        internetAccess = true;
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("Error connection: " + e);
                    }

                    outputText += "Internet access: " + internetAccess + "\r\n";

                }

                outputText += "Traffic: \r\n " + "mb received:" + (adapter.GetIPStatistics().BytesReceived * 1.0 / (1024 * 1024)).ToString("0.00") + "\r\n " + "mb sent" +
                              (adapter.GetIPStatistics().BytesSent * 1.0 / (1024 * 1024)).ToString("0.00") + "\r\n";
                outputText += "Status: " + (adapter.OperationalStatus.ToString() /*? "On" : "Off"*/) + "\r\n";
                outputText += "\r\n\r\n";

            }

            textBoxOutput.Text = outputText;

        }


        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }


        static void EnableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        static void DisableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            EnableAdapter(textBoxAdapterName.Text);
        }

        private void buttonDisableAdapter_Click(object sender, EventArgs e)
        {
            DisableAdapter(textBoxAdapterName.Text);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateAdaptersInfo();
        }
    }
}