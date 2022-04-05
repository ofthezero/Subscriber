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
using MaterialSkin.Controls;

namespace ANASTASIYABRAH
{
    public partial class Form1 : Form
    {

        MqttClient mqttClient;
        MqttClient mqttClient1;
        MqttClient mqttClient2;
        MqttClient mqttClient3;
        MqttClient mqttClient4;
        MqttClient mqttClient5;
        MqttClient mqttClient6;
        MqttClient mqttClient7;
        MqttClient mqttClient8;
        MqttClient mqttClient9;
        MqttClient mqttClient10;
        MqttClient mqttClient11;
        MqttClient mqttClient12;
        MqttClient mqttClient13;
        MqttClient mqttClient14;
        MqttClient mqttClient15;
        

        public Form1()
        {
            InitializeComponent();
            timer2.Start();
            
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
            button3.PerformClick();

        }
        
        private void MqttClient_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {
                var message = Encoding.UTF8.GetString(a.Message); //1-1
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label4.Invoke((MethodInvoker)delegate
                {
                    label4.Text = message;
                });



            }
            catch { }
        }
        private void MqttClient1_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message1 = Encoding.UTF8.GetString(a.Message); //1-2
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label10.Invoke((MethodInvoker)delegate
                {
                    label10.Text = message1;
                });


            }
            catch { }
        }
        private void MqttClient2_MqttMsgPublishReceived21(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message2 = Encoding.UTF8.GetString(a.Message); //1-3
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label13.Invoke((MethodInvoker)delegate
                {
                    label13.Text = message2;
                });


            }
            catch { }
        }

        private void MqttClient3_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message3 = Encoding.UTF8.GetString(a.Message); //1-4
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label14.Invoke((MethodInvoker)delegate
                {
                    label14.Text = message3;
                });

            }
            catch { }

        }

        private void MqttClient4_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message4 = Encoding.UTF8.GetString(a.Message); //2-1
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label11.Invoke((MethodInvoker)delegate
                {
                    label11.Text = message4;
                });

            }
            catch { }
        }

        private void MqttClient5_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message5 = Encoding.UTF8.GetString(a.Message); //2-2
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label12.Invoke((MethodInvoker)delegate
                {
                    label12.Text = message5;
                });

            }
            catch { }
        }

        private void MqttClient6_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message6 = Encoding.UTF8.GetString(a.Message); //2-3
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label15.Invoke((MethodInvoker)delegate
                {
                    label15.Text = message6;
                });

            }
            catch { }
        }

        private void MqttClient7_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message7 = Encoding.UTF8.GetString(a.Message); //2-4
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label16.Invoke((MethodInvoker)delegate
                {
                    label16.Text = message7;
                });
            }
            catch { }
        }

        private void MqttClient8_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message8 = Encoding.UTF8.GetString(a.Message); //3-1
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label18.Invoke((MethodInvoker)delegate
                {
                    label18.Text = message8;
                });

            }
            catch { }
        }

        private void MqttClient9_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message9 = Encoding.UTF8.GetString(a.Message);//3-2
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label19.Invoke((MethodInvoker)delegate
                {
                    label19.Text = message9;
                });

            }
            catch { }
        }

        private void MqttClient10_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message10 = Encoding.UTF8.GetString(a.Message); //3-3
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label21.Invoke((MethodInvoker)delegate
                {
                    label21.Text = message10;
                });


            }
            catch { }
        }

        private void MqttClient11_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message11 = Encoding.UTF8.GetString(a.Message); //3-4
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label22.Invoke((MethodInvoker)delegate
                {
                    label22.Text = message11;
                });

            }
            catch { }
        }


        private void MqttClient12_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message12 = Encoding.UTF8.GetString(a.Message); //4-1
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label20.Invoke((MethodInvoker)delegate
                {
                    label20.Text = message12;
                });

            }
            catch { }
        }

        private void MqttClient13_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message13 = Encoding.UTF8.GetString(a.Message); //4-2               
                label25.Invoke((MethodInvoker)delegate
                {
                    label25.Text = message13;
                });

            }
            catch { }
        }

        private void MqttClient14_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {
                var message14 = Encoding.UTF8.GetString(a.Message); //4-3
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label26.Invoke((MethodInvoker)delegate
                {
                    label26.Text = message14;
                });

            }
            catch { }
        }
        private void MqttClient15_MqttMsgPublishReceived1(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs a)
        {
            try
            {

                var message15 = Encoding.UTF8.GetString(a.Message); //4-4
                //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
                label27.Invoke((MethodInvoker)delegate
                {
                    label27.Text = message15;
                });

            }
            catch { }
        }








        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(textBox2.Text, 1000);
                //MessageBox.Show(reply.Status.ToString());
                timer1.Interval = 1000;
                try
                {
                    if (textBox3.Text != "" & textBox1.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "" & textBox11.Text != "" & textBox12.Text != "" & textBox13.Text != "" & textBox14.Text != "" & textBox15.Text != "" & textBox16.Text != "" & textBox17.Text != "")
                    {
                        timer1.Interval = 1000;
                        Task.Run(() =>
                        {


                            mqttClient = new MqttClient(textBox2.Text);
                            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived1;
                            mqttClient.Subscribe(new string[] { textBox3.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient.Connect("510");



                            mqttClient1 = new MqttClient(textBox2.Text);
                            mqttClient1.MqttMsgPublishReceived += MqttClient1_MqttMsgPublishReceived1;
                            mqttClient1.Subscribe(new string[] { textBox1.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient1.Connect("5101");

                            mqttClient2 = new MqttClient(textBox2.Text);
                            mqttClient2.MqttMsgPublishReceived += MqttClient2_MqttMsgPublishReceived21;
                            mqttClient2.Subscribe(new string[] { textBox4.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient2.Connect("5102");


                            mqttClient3 = new MqttClient(textBox2.Text);
                            mqttClient3.MqttMsgPublishReceived += MqttClient3_MqttMsgPublishReceived1;
                            mqttClient3.Subscribe(new string[] { textBox5.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient3.Connect("5103");



                            mqttClient4 = new MqttClient(textBox2.Text);
                            mqttClient4.MqttMsgPublishReceived += MqttClient4_MqttMsgPublishReceived1;
                            mqttClient4.Subscribe(new string[] { textBox6.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient4.Connect("511");

                            mqttClient5 = new MqttClient(textBox2.Text);
                            mqttClient5.MqttMsgPublishReceived += MqttClient5_MqttMsgPublishReceived1;
                            mqttClient5.Subscribe(new string[] { textBox7.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient5.Connect("5111");

                            mqttClient6 = new MqttClient(textBox2.Text);
                            mqttClient6.MqttMsgPublishReceived += MqttClient6_MqttMsgPublishReceived1;
                            mqttClient6.Subscribe(new string[] { textBox8.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient6.Connect("5112");

                            mqttClient7 = new MqttClient(textBox2.Text);
                            mqttClient7.MqttMsgPublishReceived += MqttClient7_MqttMsgPublishReceived1;
                            mqttClient7.Subscribe(new string[] { textBox9.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient7.Connect("5113");


                            mqttClient8 = new MqttClient(textBox2.Text);
                            mqttClient8.MqttMsgPublishReceived += MqttClient8_MqttMsgPublishReceived1;
                            mqttClient8.Subscribe(new string[] { textBox10.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient8.Connect("513");

                            mqttClient9 = new MqttClient(textBox2.Text);
                            mqttClient9.MqttMsgPublishReceived += MqttClient9_MqttMsgPublishReceived1;
                            mqttClient9.Subscribe(new string[] { textBox11.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient9.Connect("5131");

                            mqttClient10 = new MqttClient(textBox2.Text);
                            mqttClient10.MqttMsgPublishReceived += MqttClient10_MqttMsgPublishReceived1;
                            mqttClient10.Subscribe(new string[] { textBox12.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient10.Connect("5132");

                            mqttClient11 = new MqttClient(textBox2.Text);
                            mqttClient11.MqttMsgPublishReceived += MqttClient11_MqttMsgPublishReceived1;
                            mqttClient11.Subscribe(new string[] { textBox13.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient11.Connect("5133");


                            mqttClient12 = new MqttClient(textBox2.Text);
                            mqttClient12.MqttMsgPublishReceived += MqttClient12_MqttMsgPublishReceived1;
                            mqttClient12.Subscribe(new string[] { textBox14.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient12.Connect("514");

                            mqttClient13 = new MqttClient(textBox2.Text);
                            mqttClient13.MqttMsgPublishReceived += MqttClient13_MqttMsgPublishReceived1;
                            mqttClient13.Subscribe(new string[] { textBox15.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient13.Connect("5141");

                            mqttClient14 = new MqttClient(textBox2.Text);
                            mqttClient14.MqttMsgPublishReceived += MqttClient14_MqttMsgPublishReceived1;
                            mqttClient14.Subscribe(new string[] { textBox16.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient14.Connect("5142");

                            mqttClient15 = new MqttClient(textBox2.Text);
                            mqttClient15.MqttMsgPublishReceived += MqttClient15_MqttMsgPublishReceived1;
                            mqttClient15.Subscribe(new string[] { textBox17.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                            mqttClient15.Connect("5143");
                        });
                    }
                    else
                    {

                    }
                }
                catch
                {
                    //MessageBox.Show("Error");
                }
            }
            catch
            {
                //MessageBox.Show("Error");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
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

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {

                                    label4.BackColor = Color.Yellow;
                                    label17.BackColor = Color.Red;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label4.BackColor = Color.SpringGreen;
                                    label17.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        if (label11.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label11.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label11.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label11.BackColor = Color.Yellow;
                                    label23.BackColor = Color.Red;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label11.BackColor = Color.SpringGreen;
                                    label23.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                         if (label18.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label18.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label18.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label18.BackColor = Color.Yellow;
                                    label24.BackColor = Color.Red;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label18.BackColor = Color.SpringGreen;
                                    label24.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label20.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label20.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label20.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label20.BackColor = Color.Yellow;
                                    label28.BackColor = Color.Red;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label20.BackColor = Color.SpringGreen;
                                    label28.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label10.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label10.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label10.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label10.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label10.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label12.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label12.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label12.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label12.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label12.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label19.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label19.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label19.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label19.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label19.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label25.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label25.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label25.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label25.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label25.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label13.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label13.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label13.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label13.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    // label2.Text = Convert.ToString(diff1.Seconds);
                                    label13.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label15.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label15.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label15.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label15.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label15.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                        if (label21.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label21.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label21.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label21.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label21.BackColor = Color.SpringGreen;
                                });
                            }
                        }

                         if (label26.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label26.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label26.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label26.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label26.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        if (label14.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label14.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label14.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label14.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label14.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        if (label16.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label16.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label16.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label16.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label16.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        if (label22.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label22.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label22.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label22.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label22.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        if (label27.Text != "")
                        {
                            DateTime ukDateFormat;
                            string ukFormat = "HH:mm:ss";
                            DateTime.TryParseExact(label27.Text, ukFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ukDateFormat);
                            DateTime test = ukDateFormat;
                            string ampm = ukDateFormat.ToString("htt");
                            string datecom = DateTime.Now.ToString();


                            TimeSpan diff1 = Convert.ToDateTime(datecom).Subtract(Convert.ToDateTime(label27.Text));

                            int one = 10;


                            if (Convert.ToInt32(diff1.TotalSeconds) > one)
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.TotalSeconds);
                                    label27.BackColor = Color.Yellow;
                                });

                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    //label2.Text = Convert.ToString(diff1.Seconds);
                                    label27.BackColor = Color.SpringGreen;
                                });
                            }
                        }
                        else
                        {
                            //MessageBox.Show("ОШИБКА");
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