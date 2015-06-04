using System;
using System.Windows.Forms;

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
            tabPage2.Width = this.Width + 2;
            tabPage2.Height = this.Height + 2;
        }
        
        // connect with HomeWizard
        private void BtnConHW_Click(object sender, EventArgs e)
        { // Author Sieger
            Discover authOffline = Discover.discover();
            
                
                //Create Object for authOnline
                AuthOnline authOnline = AuthOnline.authOnline(textBox1.Text, textBox2.Text);
                
                //Set SessionID for use in URL 
                Sensors.Session = authOnline.session;
                
                //Set Serialnumbr for use in URL
                foreach (Response detail in authOnline.response)
                {
                    Sensors.Serial = detail.serial;
                }

            // Create Object for Sensors
            Sensors sensor = Sensors.sensorlist();

            //Retrive data to adjust the settings of the labals (HUE/Switches)
            foreach (var detail in sensor.response.switches)
            {
                if (detail.hue_id != null)
                {
                    // 1st Hue Lamp
                    LblHue1.Text = detail.name;
                    LblHue1.Name = detail.id.ToString();
                    Console.WriteLine(LblHue1.Name);
                }
                else if (detail.id == 0)
                {
                    // 1st switch
                    LblSch1.Text = detail.name;
                    LblSch1.Name = detail.id.ToString();
                }
                else if (detail.id == 1)
                {
                    // 2nd switch
                    LblSch2.Text = detail.name;
                    LblSch2.Name = detail.id.ToString();
                }
            }
            ////Retrive data to adjust the settings of the labals (Thermometers)
            foreach (var detail in sensor.response.thermometers)
            {   //1ts Thermometer
                LblCurTemp.Text = "Temp: " + detail.te + "C";
                LblCurHum.Text = "Hum: " + detail.hu + "%";
               // label3.Text = "Max Temp: " + detail.teMax + " at " + detail.teMaxTime;

            }

        }

        private void BtnHueOn1_Click(object sender, EventArgs e)
        {   // Author Sieger
            //switch methode for turnung on and changing colors of HUE1
            switch (CmbHue1.SelectedIndex)
            {
                case 0:     //RED
                    Control.controlHue(LblHue1.Name, "on", 0, 100, 100);
                    break;
                case 1:     //ORANGE
                    Control.controlHue(LblHue1.Name, "on", 50, 100, 100);
                    break;
                case 2:     //MAGNETA
                    Control.controlHue(LblHue1.Name, "on", 290, 100, 100);
                    break;
                case 3:     //GREEN
                    Control.controlHue(LblHue1.Name, "on", 110, 100, 100);
                    break;
                case 4:     //CYAN
                    Control.controlHue(LblHue1.Name, "on", 170, 100, 100);
                    break;
                case 5:     //BLUE
                    Control.controlHue(LblHue1.Name, "on", 235, 100, 100);
                    break;
                case 6:     //PINK
                    Control.controlHue(LblHue1.Name, "on", 330, 100,100);
                    break;
                default:    //WHITE
                    Control.controlHue(LblHue1.Name, "on", 0, 0, 100);
                    break;
            }
        }

        private void BtnHueOff1_Click(object sender, EventArgs e)
        {   // Author Sieger
            //Turn HUE1 OFF
            Control.controlHue(LblHue1.Name, "off", 0, 0, 0);
        }

        private void BtnSchon1_Click(object sender, EventArgs e)
        {   // Author Sieger
            //Turn ON Switch1
            Control.controlSchakelaar(LblSch1.Name, "on");
        }

        private void BtnSchOff1_Click(object sender, EventArgs e)
        {   // Author Sieger
            //Turn OFF Switch1
            Control.controlSchakelaar(LblSch1.Name, "off");
        }

        private void BtnSchOn2_Click(object sender, EventArgs e)
        {   // Author Sieger
            //Turn ON Switch2
            Control.controlSchakelaar(LblSch2.Name, "on");
        }

        private void BtnSchOff2_Click(object sender, EventArgs e)
        {   // Author Sieger
            //Turn OFF Switch2
            Control.controlSchakelaar(LblSch2.Name, "off");
        }
        /// <summary>
        /// Sets the size of the tabcontrol to match the form size on resize
        /// Martin Beekhuizen
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.Width + 1;
            tabControl1.Height = this.Height + 1;
        }
    }
}
