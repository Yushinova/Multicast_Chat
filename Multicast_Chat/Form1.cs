using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Multicast_Chat
{
    public partial class Form1 : Form
    {
        public List<int> ports = new List<int>//порты для рассылки
        {
           5555, 5556, 5557, 5558, 5559
        };
        public IPAddress brodcastAddress = IPAddress.Parse("224.0.0.0");// хост для отправки данных 
        public UdpClient client;
        public string name;
        int port;
        public Form1()
        {
            InitializeComponent();           
        }

        private void PortButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameText.Text))
            {
                name = NameText.Text;
            }
            else
            {
                MessageBox.Show("Имя не может быть пустым!");
            }
           
            if (int.TryParse(PortText.Text, out port))
            {
                port = int.Parse(PortText.Text);
            }
            try
            {
                client = new UdpClient(port);
                client.JoinMulticastGroup(brodcastAddress, 1);//присоединяемся к прослушиванию группы
                PortPanel.Visible = false;
                ChatPanel.Visible = true;
                Task.Run(RecieveMessage);//запускаем прослушивание
            }
            catch
            {
                MessageBox.Show("Порт занят!");
            }

        }

        private void SendButton_Click(object sender, EventArgs e)
        {           
            Task.Run(SendMessageAsync);
        }

       private async Task SendMessageAsync()
        {
            string message = MessageText.Text; // сообщение для отправки
                                               
            if (!string.IsNullOrWhiteSpace(message))
            {
                // иначе добавляем к сообщению имя пользователя
                message = $"[{name}]: {message}";
                byte[] data = Encoding.UTF8.GetBytes(message);
                // и отправляем в группу
                foreach (var item in ports)
                {
                    await client.SendAsync(data, data.Length, new IPEndPoint(brodcastAddress, item));
                }                           
            }
        }
        private async Task RecieveMessage()
        {
            while (true)
            {
                var result = await client.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);
                Invoke(new Action(()=> MessagesList.Items.Add(message)));//добавляем в чат наши сообщения
            }
        }
    }
}
