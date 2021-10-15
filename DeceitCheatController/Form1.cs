using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace DeceitCheatController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillCommandBoxs();
         
        }

        public void FillCommandBoxs()
        {
            string[] rare = { "Common", "Uncommon", "Rare", "Legendary", };
            for (int i = 0; i < SkinList.skInfo.Count; i++)
            {
                if (SkinList.skInfo[i].SkinType == "ALEX_HEAD")
                {
                    if (SkinList.skInfo[i].Rarity == rare[3])
                    {
              
                        alexHeadBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));

                    }
                    if (SkinList.skInfo[i].Rarity == rare[2])
                    {
                        alexHeadBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
          
                    }
                    if (SkinList.skInfo[i].Rarity == rare[1])
                    {

                        alexHeadBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
   
                    }
                    if (SkinList.skInfo[i].Rarity != rare[3] && SkinList.skInfo[i].Rarity != rare[2] && SkinList.skInfo[i].Rarity != rare[1])
                        alexHeadBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));





                }
                   
                if (SkinList.skInfo[i].SkinType == "ALEX_MASK")
                {
                    if (SkinList.skInfo[i].Rarity == rare[3])
                    {

                        alexMaskBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));

                    }
                    if (SkinList.skInfo[i].Rarity == rare[2])
                    {
                        alexMaskBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));

                    }
                    if (SkinList.skInfo[i].Rarity == rare[1])
                    {

                        alexMaskBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));

                    }
                    if (SkinList.skInfo[i].Rarity != rare[3] && SkinList.skInfo[i].Rarity != rare[2] && SkinList.skInfo[i].Rarity != rare[1])
                        alexMaskBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));







                }
             
                if (SkinList.skInfo[i].SkinType == "ALEX_BODY")
                { 
                if (SkinList.skInfo[i].Rarity == rare[3])
                    alexBodyBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                if (SkinList.skInfo[i].Rarity == rare[2])
                    alexBodyBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                if (SkinList.skInfo[i].Rarity == rare[1])
                    alexBodyBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                    if (SkinList.skInfo[i].Rarity != rare[3] && SkinList.skInfo[i].Rarity != rare[2]&& SkinList.skInfo[i].Rarity != rare[1])
                        alexBodyBox.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                }

                ////
                if (SkinList.skInfo[i].SkinType == "CHANG_HEAD")
                    changHead.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "CHANG_MASK")
                    changMask.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "CHANG_BODY")
                    changBody.Items.Add(SkinList.skInfo[i].SkinName);
                ////
                if (SkinList.skInfo[i].SkinType == "LISA_HEAD")
                    lisaHead.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "LISA_MASK")
                    lisaMask.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "LISA_BODY")
                    lisaBody.Items.Add(SkinList.skInfo[i].SkinName);
                ////
                if (SkinList.skInfo[i].SkinType == "RACHEL_HEAD")
                    RachelHead.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "RACHEL_MASK")
                    RachelMask.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "RACHEL_BODY")
                    RachelBody.Items.Add(SkinList.skInfo[i].SkinName);
                ////
                if (SkinList.skInfo[i].SkinType == "HANS_HEAD")
                    HansHead.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "HANS_MASK")
                    HansMask.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "HANS_BODY")
                    HansBody.Items.Add(SkinList.skInfo[i].SkinName);
                ////
                if (SkinList.skInfo[i].SkinType == "NINA_HEAD")
                    NinaHead.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "NINA_MASK")
                    NinaMask.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "NINA_BODY")
                {
                  

                    NinaBody.Items.Add(SkinList.skInfo[i].SkinName);
               
                  
                }
                   
///////////////////////////////////////////////////////////////////////////
                if (SkinList.skInfo[i].SkinType == "PISTOL")
                {
                    alexPistol.Items.Add(SkinList.skInfo[i].SkinName);
                    changPistol.Items.Add(SkinList.skInfo[i].SkinName);
                    lisaPistol.Items.Add(SkinList.skInfo[i].SkinName);
                    RachelPistol.Items.Add(SkinList.skInfo[i].SkinName);
                    HansPistol.Items.Add(SkinList.skInfo[i].SkinName);
                    NinaPistol.Items.Add(SkinList.skInfo[i].SkinName);
                }
/////////////////////////
            if (SkinList.skInfo[i].SkinType == "WRISTBAND")
                {  alexWristband.Items.Add(SkinList.skInfo[i].SkinName);
                    changWist.Items.Add(SkinList.skInfo[i].SkinName);
                    lisaWist.Items.Add(SkinList.skInfo[i].SkinName);
                    HansWist.Items.Add(SkinList.skInfo[i].SkinName);
                    RachelWist.Items.Add(SkinList.skInfo[i].SkinName);
                    NinaWist.Items.Add(SkinList.skInfo[i].SkinName);
                }
/////////////////////////
            if   (SkinList.skInfo[i].SkinType == "KNIFE")
                {

                    if (SkinList.skInfo[i].Rarity == rare[3])
                    {
                   
                        alexKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                        changKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                        LisaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                        RachelKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                        HansKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                        NinaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Orange));
                    }
                    if (SkinList.skInfo[i].Rarity == rare[2])
                    {
                        alexKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                        changKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                        LisaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                        RachelKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                        HansKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                        NinaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Magenta));
                    }
                    if (SkinList.skInfo[i].Rarity == rare[1])
                    {
                        
                        alexKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                        changKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                        LisaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                        RachelKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName,"0", Color.Cyan));
                        HansKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                        NinaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.Cyan));
                    }
                    if (SkinList.skInfo[i].Rarity != rare[3] && SkinList.skInfo[i].Rarity != rare[2] && SkinList.skInfo[i].Rarity != rare[1])
                    { 
                        alexKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                        changKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                        LisaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                        RachelKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                        HansKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                        NinaKnife.Items.Add(new ComboBoxItem(SkinList.skInfo[i].SkinName, "0", Color.White));
                    }


                }

               



   }
           







            Debug.WriteLine(SkinList.skInfo.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lodoutalex = { alexHeadBox.Text, alexMaskBox.Text, alexBodyBox.Text, alexWristband.Text, alexPistol.Text, alexKnife.Text };
            string[] lodoutchang = { changHead.Text, changMask.Text, changBody.Text, changWist.Text, changPistol.Text, changKnife.Text };
            string[] lodoutlisa = { lisaHead.Text, lisaMask.Text, lisaBody.Text, lisaWist.Text, lisaPistol.Text, LisaKnife.Text };
            string[] lodoutRACHEL = {RachelHead.Text, RachelMask.Text, RachelBody.Text, RachelWist.Text, RachelPistol.Text, RachelKnife.Text };
            string[] lodouthans = { HansHead.Text, HansMask.Text, HansBody.Text, HansWist.Text, HansPistol.Text, HansKnife.Text };
            string[] lodoutnina = {  NinaHead.Text, NinaMask.Text, NinaBody.Text, NinaWist.Text, NinaPistol.Text, NinaKnife.Text };

            string alex = Skinparser.ConvertToloadoutByName(lodoutalex, "ALEX");
            string chang = Skinparser.ConvertToloadoutByName(lodoutchang, "CHANG");
            string lisa = Skinparser.ConvertToloadoutByName(lodoutlisa, "LISA");
            string rachel= Skinparser.ConvertToloadoutByName(lodoutRACHEL, "RACHEL");
            string hans = Skinparser.ConvertToloadoutByName(lodouthans, "HANS");
            string nina = Skinparser.ConvertToloadoutByName(lodoutnina, "NINA");

            

            if (alex != "INVALID" && chang != "INVALID" && lisa != "INVALID" && rachel != "INVALID" && rachel != "INVALID" && hans != "INVALID" && nina != "INVALID")
            {

                label1s.Text = alex;
                label1s.Text += chang;
                label1s.Text += lisa;
                label1s.Text += rachel;
                label1s.Text += hans;
                label1s.Text += nina;
                label2.Text = "ALL OK!";
            }
            else
            {
                label2.Text = "ALEX "+ alex + "\nCHANG " + chang + "\nLISA " + lisa + "\nRACHEL " + rachel + "\nHANS " + hans + "\nNINA " + nina + "\n";
            }
        }

        private void checkboxShorted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShorted.Checked)
            {
               bool shot = shortmode.Shortedstate = true;
                {
                NinaBody.Sorted = shot;
                NinaHead.Sorted = shot;
                NinaMask.Sorted = shot;
                NinaWist.Sorted = shot;
                NinaPistol.Sorted = shot;
                NinaKnife.Sorted = shot;
                HansBody.Sorted = shot;
                HansHead.Sorted = shot;
                HansMask.Sorted = shot;
                HansWist.Sorted = shot;
                HansPistol.Sorted = shot;
                HansKnife.Sorted = shot;

                lisaBody.Sorted = shot;
                lisaHead.Sorted = shot;
                lisaMask.Sorted = shot;
                lisaWist.Sorted = shot;
                lisaPistol.Sorted = shot;
                LisaKnife.Sorted = shot;

                RachelBody.Sorted = shot;
                RachelHead.Sorted = shot;
                RachelMask.Sorted = shot;
                RachelWist.Sorted = shot;
                RachelPistol.Sorted = shot;
                RachelKnife.Sorted = shot;

                changBody.Sorted = shot;
                changHead.Sorted = shot;
                changMask.Sorted = shot;
                changWist.Sorted = shot;
                changPistol.Sorted = shot;
                changKnife.Sorted = shot;

                alexBodyBox.Sorted = shot;
                alexHeadBox.Sorted = shot;
                alexKnife.Sorted = shot;
                alexMaskBox.Sorted = shot;
                alexWristband.Sorted = shot;
                alexPistol.Sorted = shot;
                }

            }
            else
            {
                bool shot = shortmode.Shortedstate = false;
                {
                    NinaBody.Sorted = shot;
                    NinaHead.Sorted = shot;
                    NinaMask.Sorted = shot;
                    NinaWist.Sorted = shot;
                    NinaPistol.Sorted = shot;
                    NinaKnife.Sorted = shot;
                    HansBody.Sorted = shot;
                    HansHead.Sorted = shot;
                    HansMask.Sorted = shot;
                    HansWist.Sorted = shot;
                    HansPistol.Sorted = shot;
                    HansKnife.Sorted = shot;
                
                    lisaBody.Sorted = shot;
                    lisaHead.Sorted = shot;
                    lisaMask.Sorted = shot;
                    lisaWist.Sorted = shot;
                    lisaPistol.Sorted = shot;
                    LisaKnife.Sorted = shot;

                    RachelBody.Sorted = shot;
                    RachelHead.Sorted = shot;
                    RachelMask.Sorted = shot;
                    RachelWist.Sorted = shot;
                    RachelPistol.Sorted = shot;
                    RachelKnife.Sorted = shot;

                    changBody.Sorted = shot;
                    changHead.Sorted = shot;
                    changMask.Sorted = shot;
                    changWist.Sorted = shot;
                    changPistol.Sorted = shot;
                    changKnife.Sorted = shot;

                    alexBodyBox.Sorted = shot;
                    alexHeadBox.Sorted = shot;
                    alexKnife.Sorted = shot;
                    alexMaskBox.Sorted = shot;
                    alexWristband.Sorted = shot;
                    alexPistol.Sorted = shot;
                }

            }

        }
    }
}
