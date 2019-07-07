using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIDInterface;


namespace TargetDeviceView
{
    public partial class Form1 : Form
    {
        const UInt16 KTC_VID = 0x0951;
        const UInt16 DART_PID1 = 0x16E2;    //wired mode PID
        const UInt16 DART_PID2 = 0x16E1;    //wireless mode PID
        const UInt16 ALPHAS_PID = 0x16ED;
        UInt16 CONFIG_VID;
        UInt16 CONFIG_PID;
        string CONFIG_MANUFACTURER;
        string CONFIG_PRODUCT;
        string CONFIG_REVISION;
        UInt16 TARGET_VID;
        UInt16 TARGET_PID;
        System.Windows.Forms.Timer Test_Timer;

        public Form1()
        {
            InitializeComponent();

            Test_Timer = new System.Windows.Forms.Timer();
            Test_Timer.Tick += new EventHandler(timer_Ticktock1);

            if (read_config_file())
            {
                TARGET_VID = CONFIG_VID;
                TARGET_PID = CONFIG_PID;                
            }
            else
            {
                TARGET_VID = KTC_VID;   //Kingston
                TARGET_PID = ALPHAS_PID;    //Alpha S
            }

            //auto-run
            Test_Timer.Interval = 1000; //unit is sec
            Test_Timer.Enabled = true;
            Test_Timer.Start();
        }
        
        private void button_detect_Click(object sender, EventArgs e)
        {
            FindDev();

            if (button_detect.Text == "START")
            {
                Test_Timer.Interval = 1000; //unit is sec
                Test_Timer.Enabled = true;
                Test_Timer.Start();
                button_detect.Text = "STOP";
                label_status.Text = "Auto-detecting...";
            }
            else if(button_detect.Text == "STOP")
            {
                Test_Timer.Enabled = false;
                Test_Timer.Stop();

                empty_fields();
                label_status.Text = "";
                button_detect.Text = "START";

            }

        }
        
        public bool FindDev()
        {
            bool result = false;
            bool foundtarget = false;
            HIDDevice.interfaceDetails[] devices = HIDDevice.getConnectedDevices();
            List<HIDDevice.interfaceDetails> KingstonDevs = new List<HIDDevice.interfaceDetails>();
            for (int i = 0; i < devices.Length; i++)
            {

                // Alpha S 
                if (devices[i].VID == TARGET_VID && devices[i].PID == TARGET_PID) //if (devices[i].VID == KTC_VID && devices[i].PID == ALPHAS_PID)
                {
                    label_vid.Text = devices[i].VID.ToString("X4"); //KTC_VID.ToString("X4");
                    label_pid.Text = devices[i].PID.ToString("X4");//DART_PID1.ToString("X4");
                    //textBox_device.AppendText("\r\nProduct : " + devices[i].product.ToString());
                    //textBox_device.AppendText("\r\nRevision : " + "0x" + devices[i].versionNumber.ToString("X"));
                    label_manufacturer.Text = devices[i].manufacturer.ToString();
                    label_product.Text = devices[i].product.ToString();
                    label_revision.Text = devices[i].versionNumber.ToString("X");

                    label_status.Text = "Detected";

                    CheckDev();

                    foundtarget = true;

                    break;
                }

                if (!foundtarget)
                {
                    empty_fields();

                    if (button_detect.Text == "STOP")
                        label_status.Text = "Detecting...";
                    if (button_detect.Text == "START")
                        label_status.Text = "";

                }
                foundtarget = false;
            }

            return result;

        }

        void empty_fields()
        {

            var Color_Default = SystemColors.Control;

            string path = "C:\\Users\\PaulTsai\\Documents\\Visual Studio 2017\\Projects\\TargetDeviceView\\TargetDeviceView\\image";
            var Image_Default = Image.FromFile(Path.Combine(path, "uncheck.png"));

            label_vid.Text = "";
            label_pid.Text = "";
            label_manufacturer.Text = "";
            label_product.Text = "";
            label_revision.Text = "";

            label_vid.BackColor = Color_Default;
            label_pid.BackColor = Color_Default;
            label_manufacturer.BackColor = Color_Default;
            label_product.BackColor = Color_Default;
            label_revision.BackColor = Color_Default;

            button1.BackgroundImage = Image_Default;
            button2.BackgroundImage = Image_Default;
            button3.BackgroundImage = Image_Default;
            button4.BackgroundImage = Image_Default;
            button5.BackgroundImage = Image_Default;
        }

        void timer_Ticktock1(object sender, EventArgs e)
        {
            FindDev();
        }

        bool read_config_file()
        {
            string path1;
            string[] words;

            path1 = System.IO.Directory.GetCurrentDirectory();
            // var path2 = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "\\text.cfg");
            if (!File.Exists(path1 + "\\config.txt")){
                return false;
            }

            string[] lines = System.IO.File.ReadAllLines(path1 + "\\config.txt");
            for (int i = 0; i < 5; i++)
            {
                words = lines[i].Split('=');
                if (words[0] == "VID")
                {
                    CONFIG_VID = UInt16.Parse(words[1], System.Globalization.NumberStyles.HexNumber);
                }
                if (words[0] == "PID")
                {
                    CONFIG_PID = UInt16.Parse(words[1], System.Globalization.NumberStyles.HexNumber);
                }
                if (words[0] == "MANUFACTURER")
                {
                    CONFIG_MANUFACTURER = words[1];
                }
                if (words[0] == "PRODUCT")
                {
                    CONFIG_PRODUCT = words[1];
                }
                if (words[0] == "REVISION")
                {
                    CONFIG_REVISION = words[1];
                }
            }

            
            return true;
        }

        void CheckDev()
        {
            var Color_Pass = Color.GreenYellow;
            var Color_Fail = Color.OrangeRed;
            

            string path = "C:\\Users\\PaulTsai\\Documents\\Visual Studio 2017\\Projects\\TargetDeviceView\\TargetDeviceView\\image";
            var Image_Pass = Image.FromFile(Path.Combine(path, "pass.png"));
            var Image_Fail = Image.FromFile(Path.Combine(path, "fail.png"));

            if (label_vid.Text == CONFIG_VID.ToString("X4"))
            {
                label_vid.BackColor = Color_Pass;
                button1.BackgroundImage = Image_Pass;
            }
            else
            {
                label_vid.BackColor = Color_Fail;
                button1.BackgroundImage = Image_Fail;
            }


            if (label_pid.Text == CONFIG_PID.ToString("X4"))
            {
                label_pid.BackColor = Color_Pass;
                button2.BackgroundImage = Image_Pass;
            }
            else
            {
                label_pid.BackColor = Color_Fail;
                button2.BackgroundImage = Image_Fail;
            }

            if (label_manufacturer.Text == CONFIG_MANUFACTURER)
            {
                label_manufacturer.BackColor = Color_Pass;
                button3.BackgroundImage = Image_Pass;
            }
            else
            { 
                label_manufacturer.BackColor = Color_Fail;
                button3.BackgroundImage = Image_Fail;
            }

            if (label_product.Text == CONFIG_PRODUCT)
            {
                label_product.BackColor = Color_Pass;
                button4.BackgroundImage = Image_Pass;
            }
            else
            {
                label_product.BackColor = Color_Fail;
                button4.BackgroundImage = Image_Fail;
            }

            if (label_revision.Text == CONFIG_REVISION)
            {
                label_revision.BackColor = Color_Pass;
                button5.BackgroundImage = Image_Pass;
            }
            else
            {
                label_revision.BackColor = Color_Fail;
                button5.BackgroundImage = Image_Fail;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Version Check Tool Ver. 0.1.1.0");

            /*
            Form1 testDialog = new Form2();
            
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                
            }
            else
            {
                
            }
            testDialog.Dispose();
            */
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
        }


        private void autorunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autorunToolStripMenuItem.Checked == false)
            {
                autorunToolStripMenuItem.Checked = true;
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("Universal Version Check Tool", @"C:\Users\PaulTsai\Documents\Visual Studio 2017\Projects\TargetDeviceView\TargetDeviceView\bin\Debug\Universal Version Check Tool.exe");
            }
            else if (autorunToolStripMenuItem.Checked == true)
            {
                autorunToolStripMenuItem.Checked = false;
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("Universal Version Check Tool");
            }
        }

        private void powerCyclingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (powerCyclingTestToolStripMenuItem.Checked == false)
            {
                this.Size = new Size(390, 250);
                this.MinimumSize = new Size(390,250);
                this.MaximumSize = new Size(390,250);
            }
            else if (powerCyclingTestToolStripMenuItem.Checked == true)
            {
                this.Size = new Size(390, 450);
                this.MinimumSize = new Size(390,370);
                this.MaximumSize = new Size(390,370);
            }
        }
    }
}
