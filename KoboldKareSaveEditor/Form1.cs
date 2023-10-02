using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Wacton.Unicolour;

namespace KoboldKareSaveEditor
{
    public partial class Form1 : Form
    {
        public string koboldSaveJSON = "";
        public List<string> koboldViewIDs = new List<string>();
        public List<int> koboldSaveLocation = new List<int>();
        public string SaveFileName = "";
        public Form1()
        {
            koboldViewIDs.Add("\"name\":\"Shark\"");
            koboldViewIDs.Add("\"name\":\"Kobold\"");
            InitializeComponent();
        }
        // Help Section \/
        private void ms_WhatToDo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string help_Message = "" +
                "Open a Kobold Kare save file, thease are usually located in \\AppData\\localLow\\Naelstrof\\KoboldKare\\<USERNUMBER>\\\n" +
                "When you are done, you can rename the file or overwrite the file you loaded, just be sure to make backups if overwriting\n" +
                "To Edit Data, [wrn_finishHelpDoc]";
            MessageBox.Show(help_Message, "Help", buttons);
        }

        private void ms_WhoMade_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string credits_Message =
                "KKSE Made By: Mage (I have too much time on my hands)\n" +
                "Kobold Kare Made By: Naelstrof";
            MessageBox.Show(credits_Message, "Credits", buttons);
        }
        // File Section
        private void ms_QuitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ms_OpenSave_Click(object sender, EventArgs e)
        {
            koboldSaveLocation.Clear();
            koboldSaveJSON.DefaultIfEmpty();
            cbx_KoboldSelection.Items.Clear();
            cbx_KoboldSelection.Text = "Please Select A Kobold";
            OpenFileDialog.InitialDirectory = "C:\\Users\\"+Environment.UserName+"\\AppData\\LocalLow\\Naelstrof\\KoboldKare\\";
            OpenFileDialog.ShowDialog();
            string openedFileDir = OpenFileDialog.FileName;
            SaveFileName = OpenFileDialog.FileName.Substring(OpenFileDialog.FileName.LastIndexOf("saves\\"));
            koboldSaveJSON = File.ReadAllText(openedFileDir);
            int b = 0;
            int p = 0;
            foreach (string i in koboldViewIDs)
            {
                b = 0;
                p = 0;
                while (p != -1)
                {
                    
                    p = koboldSaveJSON.IndexOf(i, b);
                    if (p != -1) { koboldSaveLocation.Add(p); }
                    //Console.Write(p + " ");
                    b = p + 1;
                }
            }

            SetDropDownBox();
            Form.ActiveForm.Text = "KKSE - " + SaveFileName;
            
        }

        private void SetDropDownBox()
        {
            foreach (int p in koboldSaveLocation)
            {
                int outputEnding = koboldSaveJSON.IndexOf(("\""), p + 8);
                //Console.WriteLine(p +" : "+ outputEnding);
                cbx_KoboldSelection.Items.Add(koboldSaveJSON.Substring(p +8, outputEnding - p -8));
            }
        }
        // Kobold editing

        private void cbx_KoboldSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Index Changed to " +cbx_KoboldSelection.SelectedIndex);
            int hueStart = koboldSaveJSON.IndexOf("hue\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int hueEnd = koboldSaveJSON.IndexOf(",", hueStart);
            string hString = koboldSaveJSON.Substring(hueStart+5, (hueEnd - hueStart)-5);
            updn_Hue.Value = Convert.ToInt32(hString);

            int saturationStart = koboldSaveJSON.IndexOf("saturation\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int saturationEnd = koboldSaveJSON.IndexOf(",", saturationStart);
            string sString = koboldSaveJSON.Substring(saturationStart + 12, (saturationEnd - saturationStart) - 12);
            updn_Sat.Value = Convert.ToInt32(sString);

            int brightnessStart = koboldSaveJSON.IndexOf("brightness\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int brightnessEnd = koboldSaveJSON.IndexOf(",", brightnessStart);
            string bString = koboldSaveJSON.Substring(brightnessStart + 12, (brightnessEnd - brightnessStart) - 12);
            updn_Bri.Value = Convert.ToInt32(bString);

            // COLOUR IS FUCKED, WORLD IS A SHIT, ASSWIPE, 1994 JOE BIDEN

            int energyStart = koboldSaveJSON.IndexOf("Energy\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int energyEnd = koboldSaveJSON.IndexOf(",", energyStart);
            string energyString = koboldSaveJSON.Substring(energyStart + 8, (energyEnd - energyStart) - 8);
            updn_KoboldMaxEnergy.Value = Convert.ToDecimal(energyString, CultureInfo.InvariantCulture);

            int baseSizeStart = koboldSaveJSON.IndexOf("baseSize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int baseSizeEnd = koboldSaveJSON.IndexOf(",", baseSizeStart);
            string baseSizeString = koboldSaveJSON.Substring(baseSizeStart + 10, (baseSizeEnd - baseSizeStart) - 10);
            updn_KoboldBaseSize.Value = Convert.ToDecimal(baseSizeString, CultureInfo.InvariantCulture);

            int fatSizeStart = koboldSaveJSON.IndexOf("fatSize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int fatSizeEnd = koboldSaveJSON.IndexOf(",", fatSizeStart);
            string fatSizeString = koboldSaveJSON.Substring(fatSizeStart + 9, (fatSizeEnd - fatSizeStart) - 9);
            updn_KoboldFatSize.Value = Convert.ToDecimal(fatSizeString, CultureInfo.InvariantCulture);

            int ballSizeStart = koboldSaveJSON.IndexOf("ballSize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int ballSizeEnd = koboldSaveJSON.IndexOf(",", ballSizeStart);
            string ballSizeString = koboldSaveJSON.Substring(ballSizeStart + 10, (ballSizeEnd - ballSizeStart) - 10);
            updn_KoboldBallSize.Value = Convert.ToDecimal(ballSizeString,CultureInfo.InvariantCulture);

            int dickSizeStart = koboldSaveJSON.IndexOf("dickSize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int dickSizeEnd = koboldSaveJSON.IndexOf(",", dickSizeStart);
            string dickSizeString = koboldSaveJSON.Substring(dickSizeStart + 10, (dickSizeEnd - dickSizeStart) - 10);
            updn_KoboldDickSize.Value = Convert.ToDecimal(dickSizeString, CultureInfo.InvariantCulture);
            
            int breastSizeStart = koboldSaveJSON.IndexOf("breastSize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int breastSizeEnd = koboldSaveJSON.IndexOf(",", breastSizeStart);
            string breastSizeString = koboldSaveJSON.Substring(breastSizeStart + 12, (breastSizeEnd - breastSizeStart) - 12);
            updn_KoboldBreastSize.Value = Convert.ToDecimal(breastSizeString, CultureInfo.InvariantCulture);
            
            int bellySizeStart = koboldSaveJSON.IndexOf("bellySize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int bellySizeEnd = koboldSaveJSON.IndexOf(",", bellySizeStart);
            string bellySizeString = koboldSaveJSON.Substring(bellySizeStart + 11, (bellySizeEnd - bellySizeStart) - 11);
            updn_KoboldBellySize.Value = Convert.ToDecimal(bellySizeString, CultureInfo.InvariantCulture);
            
            int grabCountStart = koboldSaveJSON.IndexOf("grabCount\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int grabCountEnd = koboldSaveJSON.IndexOf(",", grabCountStart);
            string grabCountString = koboldSaveJSON.Substring(grabCountStart + 11, (grabCountEnd - grabCountStart) - 11);
            updn_KoboldGrabCount.Value = Convert.ToDecimal(grabCountString, CultureInfo.InvariantCulture);

            int metabolizeCapacitySizeStart = koboldSaveJSON.IndexOf("metabolizeCapacitySize\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int metabolizeCapacitySizeEnd = koboldSaveJSON.IndexOf(",", metabolizeCapacitySizeStart);
            string metabolizeCapacitySizeString = koboldSaveJSON.Substring(metabolizeCapacitySizeStart + 24, (metabolizeCapacitySizeEnd - metabolizeCapacitySizeStart) - 24);
            updn_KoboldMetabolizeCapacity.Value = Convert.ToDecimal(metabolizeCapacitySizeString, CultureInfo.InvariantCulture);

            int dickEquipStart = koboldSaveJSON.IndexOf("dickEquip\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int dickEquipEnd = koboldSaveJSON.IndexOf(",", dickEquipStart);
            string dickEquipString = koboldSaveJSON.Substring(dickEquipStart + 11, (dickEquipEnd - dickEquipStart) - 11);
            updn_KoboldDickEquip.Value = Convert.ToDecimal(dickEquipString, CultureInfo.InvariantCulture);

            int moneyStart = koboldSaveJSON.IndexOf("money\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int moneyEnd = koboldSaveJSON.IndexOf(",", moneyStart);
            string moneyString = koboldSaveJSON.Substring(moneyStart + 7, (moneyEnd - moneyStart) - 7);
            updn_KoboldMoney.Value = Convert.ToDecimal(moneyString, CultureInfo.InvariantCulture);

            int isPlayerControlledStart = koboldSaveJSON.IndexOf("isPlayerControlled\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int isPlayerControlledEnd = koboldSaveJSON.IndexOf(",", isPlayerControlledStart);
            string isPlayerControlledString = koboldSaveJSON.Substring(isPlayerControlledStart + 20, (isPlayerControlledEnd - isPlayerControlledStart) - 20);
            bool isPlayerControlled = Convert.ToBoolean(isPlayerControlledString, CultureInfo.InvariantCulture);
            cbx_PlayerControlled.Checked= isPlayerControlled;
        }
    }
}