using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnConHW_Click(object sender, EventArgs e)
        { // Author Sieger
            Discover authOffline = Discover.discover();

            if (authOffline.ip != String.Empty)
            {
                Discover.Local = true;
            }
            else
            {
                Discover.Local = false;
            }
           
            Discover.Local = false;
            
            if (Discover.Local == false)
            {
                AuthOnline.Email = textBox1.Text;
                AuthOnline.Pass = textBox2.Text;

                AuthOnline authOnline = AuthOnline.authOnline();

                AuthOnline.Session = authOnline.session;

                foreach (Response detail in authOnline.response)
                {
                    AuthOnline.Serial = detail.serial;
                }
            }
            else
            {
                AuthOffline.Pass = textBox2.Text;
                AuthOffline.IP = authOffline.ip;
            }

            Sensors.Serial = AuthOnline.Serial;
            Sensors.Session = AuthOnline.Session;

            Sensors sensor = Sensors.sensorlist();

            foreach (var detail in sensor.response.switches)
            {
                if (detail.hue_id != null)
                {

                    LblHue1.Text = detail.name;
                    LblHue1.Name = detail.id.ToString();
                    Console.WriteLine(LblHue1.Name);
                }
                else if (detail.id == 0)
                {
                    LblSch1.Text = detail.name;
                    LblSch1.Name = detail.id.ToString();
                };
    
            }
            foreach (var detail in sensor.response.thermometers)
            {
                label3.Text = detail.te.ToString();
                label4.Text = detail.hu.ToString();
            }
             
        }

        private void BtnHueOn1_Click(object sender, EventArgs e)
        {   // Author Sieger
            switch (CmbHue1.SelectedIndex)
            {
                case 0:
                    Control.controlHue(LblHue1.Name, "on", 0, 100, 100);
                    break;
                case 1: 
                    Control.controlHue(LblHue1.Name, "on", 50, 100, 100);
                    break;
                case 2:
                    Control.controlHue(LblHue1.Name, "on", 65, 100, 100);
                    break;
                case 3:
                    Control.controlHue(LblHue1.Name, "on", 110, 100, 100);
                    break;
                case 4: 
                    Control.controlHue(LblHue1.Name, "on", 170, 100, 100);
                    break;
                case 5:
                    Control.controlHue(LblHue1.Name, "on", 235, 100, 100);
                    break;
                default:
                    Control.controlHue(LblHue1.Name, "on", 0, 0, 100);
                    break;
            }
        }

        private void BtnHueOff1_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlHue(LblHue1.Name, "off", 0, 0, 0);
        }

        private void BtnSchon1_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlSchakelaar(LblSch1.Name, "on");
        }

        private void BtnSchOff1_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlSchakelaar(LblSch1.Name, "off");
        }

        private void BtnSchOn2_Click(object sender, EventArgs e)
        {
            Control.controlSchakelaar(LblSch2.Name, "on");
        }

        private void BtnSchOff2_Click(object sender, EventArgs e)
        {
            Control.controlSchakelaar(LblSch2.Name, "off");
        }
    }
}
