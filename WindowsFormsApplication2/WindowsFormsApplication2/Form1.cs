﻿using System;
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

            int schBtnOnTop = 15;
            int schBtnOnLeft = 120;
            int schLblTop = 20;
            int schLblLeft = 10;
            foreach (var detail in sensor.response)
            {
                if (detail.hue_id != null)
                {

                    LblHue1.Text = detail.name;
                    LblHue1.Name = detail.id.ToString();
                    Console.WriteLine(LblHue1.Name);
                }
                else if (detail.id == 0)
                {
                    Label label = new Label
                    {
                        Top = schLblTop,
                        Left = schLblLeft,
                        Text = detail.name,
                        Name = detail.id.ToString()
                    };
                    Console.WriteLine(label.Name);

                    Button button = new Button
                    {
                        Top = schBtnOnTop,
                        Left = schBtnOnLeft
                    };
                    this.Controls.Add(button);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
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
        private void button4_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlHue(LblHue1.Name, "off", 0, 0, 0);
        }
        private void Btn_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlSchakelaar(LblSch1.Name, "on");
        }
        private void BtnSchOff1_Click(object sender, EventArgs e)
        {   // Author Sieger
            Control.controlSchakelaar(LblSch1.Name, "off");
        }
    }
}
