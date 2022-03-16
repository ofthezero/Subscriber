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

namespace ANASTASIYABRAH
{
    public partial class Form1 : Form
    {

        MqttClient mqttClient;

        public Form1()
        {
            InitializeComponent();
            timer2.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //    timer1.Interval = 5000;
            //    try
            //    {
            //        timer1.Interval = 5000;
            //        Task.Run(() =>

            //        {
            //            mqttClient = new MqttClient(textBox2.Text);
            //            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            //            mqttClient.Subscribe(new string[] { textBox3.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            //            mqttClient.Connect(textBox3.Text);
            //        });
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Error");
            //    }


        }
        //private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        //{
        //    var message = Encoding.UTF8.GetString(e.Message);
        //    //listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));            
        //    label5.Invoke((MethodInvoker)delegate
        //    {
        //        label5.Text = message;
        //    });
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //timer1.Interval = 1000;           
        //    //Task.Run(() =>
        //    //{
        //    //    if (mqttClient != null && mqttClient.IsConnected)
        //    //    {
        //    mqttClient.Publish(textBox3.Text, Encoding.UTF8.GetBytes(textBox1.Text + "  " + label3.Text));
        //    //    }
        //    //});            
        //}

        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    button1.PerformClick();
        //    //label3.Text = DateTime.Now.ToString();
        //    button2.PerformClick();

        //}

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
            try { 
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

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked == true)
        //    {
        //        timer1.Start();
        //        timer1.Interval = 1000;
        //    }
        //    else
        //    {
        //        timer1.Stop();
        //    }
        //}

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
    }
}

//ANASTASIYABRAH