using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace ANASTASIYABRAH
{
    public partial class Form1 : Form
    {

        MqttClient mqttClient;


        public Form1()
        {
            InitializeComponent();
            timer2.Start();
            RefreshData();
        }

        private void RefreshData()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
            button3.PerformClick();

        }
        private void button2_Click(object sender, EventArgs a)
        {

        }
        private void MqttClient_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {
                var message = Encoding.UTF8.GetString(a.Message);
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label4.Invoke((MethodInvoker)delegate
                {
                    label4.Text = message;
                });
            }
            catch { }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(textBox2.Text, 1000);
                MessageBox.Show(reply.Status.ToString());
                timer1.Interval = 1000;
                try
                {
                    timer1.Interval = 1000;
                    Task.Run(() =>
                    {
                        mqttClient = new MqttClient(textBox2.Text);
                        mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived1;
                        mqttClient.Subscribe(new string[] { textBox3.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                        mqttClient.Connect("324");
                    });
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.CountryId = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }

       



        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                timer3.Start();
                timer3.Interval = 1000;

                {
                    timer3.Interval = 1000;
                    Task.Run(() =>
                    {
                        if (label4.Text != "")
                        {
                            DateTime ukDateFormat;
                        string ukFormat = "HH:mm:ss";
                        DateTime.TryParseExact(label4.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                        DateTime test = ukDateFormat;
                        string ampm = ukDateFormat.ToString("htt");
                        string datecom = DateTime.Now.ToString();

                        
                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label4.Text));

                            int one = 3;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    label2.Text = Convert.ToString(diff1.TotalSeconds);
                                });
                                //textBox1.Text = "МАКС НЕ СПИ";
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    label2.Text = Convert.ToString(diff1.Seconds);
                                });
                            }
                        }
                        else
                        {
                          
                        }

                    });
                }
            }
            catch
            {

            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
             try
            {
                button1.PerformClick();
                //label3.Text = DateTime.Now.ToString();
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}

//ANASTASIYABRAH