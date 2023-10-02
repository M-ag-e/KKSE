using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Wacton.Unicolour;

namespace KoboldKareSaveEditor
{
    //  \/\/\ TODO LIST (IM TOO LAZY TO ADD IT ANYWHERE ELSE) /\/\/
    //  - Finish Writing the Export Function
    //  - Fix up the UI, it looks bad
    //  - Find a way to make everything dark mode
    //  - Actually impliment a Light Mode for psychos
    //  - 

    public partial class Form1 : Form
    {
        public bool autoUpdateUpDnBox = true;
        public string koboldSaveJSON = "";
        public List<string> koboldNameIDs = new List<string>();
        public List<int> koboldSaveLocation = new List<int>();
        public string SaveFileName = "";
        public Form1()
        {
            // Better way would be to put the names in an external file without the prefix '"name":' or suffix '"', but im lazy :p
            // this is because it would allow individuals to use the save editor with new mods that come out
            koboldNameIDs.Add("\"name\":\"Kobold\"");
            koboldNameIDs.Add("\"name\":\"Lilith\"");
            koboldNameIDs.Add("\"name\":\"Shark\"");
            koboldNameIDs.Add("\"name\":\"MuscleShark\"");
            koboldNameIDs.Add("\"name\":\"Lucario\"");
            koboldNameIDs.Add("\"name\":\"Goodra\"");
            koboldNameIDs.Add("\"name\":\"Renamon\"");
            koboldNameIDs.Add("\"name\":\"Tasque\"");
            koboldNameIDs.Add("\"name\":\"PorcupineNoSpines\"");
            koboldNameIDs.Add("\"name\":\"PorcupineColorNoSpines\"");
            koboldNameIDs.Add("\"name\":\"Porcupine\"");
            koboldNameIDs.Add("\"name\":\"PorcupineColor\"");
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
            // the glue that holds it all in place
            Application.Exit();
        }

        private void ResetOnLoad()
        {
            autoUpdateUpDnBox = false;
            koboldSaveLocation.Clear();
            koboldSaveJSON.DefaultIfEmpty();
            cbx_KoboldSelection.Items.Clear();
            updn_Bri.Value = 0;
            updn_Hue.Value = 0;
            updn_Sat.Value = 0;
            updn_KoboldMaxEnergy.Value = 0;
            updn_KoboldBaseSize.Value = 0;
            updn_KoboldFatSize.Value = 0;
            updn_KoboldBallSize.Value = 0;
            updn_KoboldDickSize.Value = 0;
            updn_KoboldBreastSize.Value = 0;
            updn_KoboldBellySize.Value = 0;
            updn_KoboldGrabCount.Value = 0;
            updn_KoboldMetabolizeCapacity.Value = 0;
            updn_KoboldDickEquip.Value = 0;
            updn_KoboldMoney.Value = 0;
            cbx_PlayerControlled.Checked= false;
            autoUpdateUpDnBox = true;
        }

        private void ms_OpenSave_Click(object sender, EventArgs e)
        {
            ResetOnLoad();
            cbx_KoboldSelection.Text = "Please Select A Kobold"; //only god above knows how this works \/
            OpenFileDialog.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\Naelstrof\\KoboldKare\\";
            OpenFileDialog.ShowDialog();
            string openedFileDir = OpenFileDialog.FileName;
            SaveFileName = OpenFileDialog.FileName.Substring(OpenFileDialog.FileName.LastIndexOf("saves\\")).Substring(6);
            koboldSaveJSON = File.ReadAllText(openedFileDir);
            int b = 0;
            int p = 0;
            // What this does is it searches for every instance of the koboldNameIDs that are within the koboldSaveJSON and adds
            // the index of where they all occurr within the koboldSaveJSON, within koboldSaveLocation.
            // Yes, my naming conventions are bad, i dont remember why i made them like this, i cant think of a better name, it all gets the job done anyway
            foreach (string i in koboldNameIDs)
            {
                b = 0;
                p = 0;
                while (p != -1)
                {

                    p = koboldSaveJSON.IndexOf(i, b);
                    if (p != -1) { koboldSaveLocation.Add(p); }
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
                cbx_KoboldSelection.Items.Add(koboldSaveJSON.Substring(p + 8, outputEnding - p - 8));
            }
        }
        // Kobold editing

        private void cbx_KoboldSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // A better way of doing this would be to put all of the variable names into a big list and iterate through it
            // asigning the variables as it goes, then just have a wall of code to output that to the GUI
            // or if there is someway of iterating through updownboxes, great!
            // (Also need data verification as the user could have a malformed save file, atm it just works with what is given to it)

            // Quick rundown of what is going on here,
            // it get the koboldSaveJSON, which is a plain text read of the .sav file
            // then it checks for the string 'hue":', but only after the Indexed point that the characters "name" is, that way
            // it gets the current character and not the one before/after.
            // Then it works out when the following ',' is, and stores that index
            // Then it generates a string that contains the specified data by taking the first initial string searched for
            // It generates it by taking the start point, '|hue":' the bar denotes where it searches from
            // It then adds the length of the string (hue": is 5 characters long) to offset the data being read
            // It then works out the end by using the indexs found earlier and then minusing the string length, as all the first one did 
            // was offset the search by that amount.
            // step 4) profit?
            autoUpdateUpDnBox = false;
            Console.WriteLine("Index Changed to " + cbx_KoboldSelection.SelectedIndex);
            int hueStart = koboldSaveJSON.IndexOf("hue\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int hueEnd = koboldSaveJSON.IndexOf(",", hueStart);
            string hString = koboldSaveJSON.Substring(hueStart + 5, (hueEnd - hueStart) - 5);
            updn_Hue.Value = Convert.ToDecimal(hString);

            int saturationStart = koboldSaveJSON.IndexOf("saturation\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int saturationEnd = koboldSaveJSON.IndexOf(",", saturationStart);
            string sString = koboldSaveJSON.Substring(saturationStart + 12, (saturationEnd - saturationStart) - 12);
            updn_Sat.Value = Convert.ToDecimal(sString);

            int brightnessStart = koboldSaveJSON.IndexOf("brightness\":", koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int brightnessEnd = koboldSaveJSON.IndexOf(",", brightnessStart);
            string bString = koboldSaveJSON.Substring(brightnessStart + 12, (brightnessEnd - brightnessStart) - 12);
            updn_Bri.Value = Convert.ToDecimal(bString);

            // why is HSB to RGB and vice versa so hard and mathy :(

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
            updn_KoboldBallSize.Value = Convert.ToDecimal(ballSizeString, CultureInfo.InvariantCulture);

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
            cbx_PlayerControlled.Checked = isPlayerControlled;
            autoUpdateUpDnBox = true;
        }

        // Spawns a newly made dialog box because for some reason Forms doesnt have a basic text entry dialog popup, like what year is this?
        // 2004? just add basic ass features you useless pile of **** (this annoyed me for some time)
        private void ms_RenameSave_Click(object sender, EventArgs e)
        {
            string value = "";
            if (RenameDialogResult("Enter Rename",ref value) == DialogResult.OK)
            {
                // some basic syntax checking for user input, i know i need to expand this to the whole illegal windows file name character set, its 5am
                if (value != "" && !value.Contains(" "))
                {
                    SaveFileName = value + ".sav";
                    Form.ActiveForm.Text = "KKSE - " + SaveFileName;
                }

            }
        }
        public static DialogResult RenameDialogResult(string title,ref string value)
        {
            //Totally not crtl+c / crtl+v'd from the internet ;) (https://www.makeuseof.com/winforms-input-dialog-box-create-display/)
            Form RenameDialog = new Form();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            RenameDialog.Text = title;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            textBox.SetBounds(25, 10, 150, 20);
            buttonOk.SetBounds(110, 40, 80, 30);
            buttonCancel.SetBounds(10, 40, 80, 30);
            RenameDialog.ClientSize = new Size(200, 100);
            RenameDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            RenameDialog.StartPosition = FormStartPosition.CenterParent;
            RenameDialog.MinimizeBox = false;
            RenameDialog.MaximizeBox = false;
            RenameDialog.Controls.AddRange(new Control[] {textBox, buttonOk, buttonCancel });
            RenameDialog.AcceptButton = buttonOk;
            RenameDialog.CancelButton = buttonCancel;
            DialogResult dialogResult = RenameDialog.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void ms_ExportSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\Naelstrof\\KoboldKare\\";
            SaveFileDialog.Title = "Save your Kobold Farm!";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) {
                if (SaveFileDialog.FileName != "")
                {
                    File.WriteAllText(SaveFileDialog.FileName, koboldSaveJSON);
                }
            }
        }
        //This is going to take alot of spaghetti code and willpower
        private void UpdateKoboldJSON(decimal value, string variable)
        {
            int UpdateJSONStart = koboldSaveJSON.IndexOf(variable, koboldSaveLocation[cbx_KoboldSelection.SelectedIndex]);
            int UpdateJSONEnd = koboldSaveJSON.IndexOf(",", UpdateJSONStart);
            var stringBuild = new StringBuilder(koboldSaveJSON);
            Console.WriteLine("Start: " + UpdateJSONStart +"| End: "+UpdateJSONEnd+"| Total Lines:"+(UpdateJSONEnd-UpdateJSONStart));
            stringBuild.Remove(UpdateJSONStart, UpdateJSONEnd - UpdateJSONStart);
            stringBuild.Insert(UpdateJSONStart, variable + value.ToString());
            koboldSaveJSON= stringBuild.ToString();
        }
        
        private void updn_Sat_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_Sat.Value, "saturation\":");
        }

        private void updn_KoboldBaseSize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
                UpdateKoboldJSON(updn_KoboldBaseSize.Value, "baseSize\":");
        }

        private void updn_KoboldFatSize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldFatSize.Value, "fatSize\":");
            
        }

        private void updn_KoboldBallSize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldBallSize.Value, "ballSize\":");
            
        }

        private void updn_KoboldDickSize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldDickSize.Value, "dickSize\":");
            
        }

        private void updn_KoboldBreastSize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldBreastSize.Value, "breastSize\":");
            
        }

        private void updn_KoboldBellySize_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldBellySize.Value, "bellySize\":");
            
        }

        private void updn_KoboldGrabCount_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldGrabCount.Value, "grabCount\":");
            
        }

        private void updn_KoboldMoney_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldMoney.Value, "money\":");
            
        }

        private void updn_KoboldDickEquip_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldDickEquip.Value, "dickEquip\":");
            
        }

        private void updn_KoboldMetabolizeCapacity_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldMetabolizeCapacity.Value, "metabolizeCapacitySize\":");
            
        }

        private void updn_Bri_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_Bri.Value, "brightness\":");
            
        }

        private void updn_KoboldMaxEnergy_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_KoboldMaxEnergy.Value, "maxEnergy\":");
            
        }

        private void updn_Hue_ValueChanged(object sender, EventArgs e)
        {
            if (!autoUpdateUpDnBox) { return; }
            UpdateKoboldJSON(updn_Hue.Value, "hue\":");
        }
    }
}