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
using System.IO;

namespace DeceitCheatController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            FillCommandBoxs();
         
        }
        ComboBoxItem AddtolistByRare(SkinInfo skinf)
        {

            string[] rare = { "Common", "Uncommon", "Rare", "Legendary", };

            if (skinf.Rarity == rare[3])
            {
                return new ComboBoxItem(skinf.SkinName, "0", Color.Orange);
            }
            if (skinf.Rarity == rare[2])
            {

                return new ComboBoxItem(skinf.SkinName, "0", Color.Magenta);
            }
            if (skinf.Rarity == rare[1])
            {


                return new ComboBoxItem(skinf.SkinName, "0", Color.Cyan);
            }
            if (skinf.Rarity != rare[3] && skinf.Rarity != rare[2] && skinf.Rarity != rare[1])
            {
                return new ComboBoxItem(skinf.SkinName, "0", Color.White);

            }
            return new ComboBoxItem(skinf.SkinName, "0", Color.DarkGray); ;


        }

        public void FillCommandBoxs()
        {

            for (int i = 0; i < SkinList.skInfo.Count; i++)
            {
                if (SkinList.skInfo[i].SkinType == "ALEX_HEAD")
                 alexHeadBox.Items.Add(AddtolistByRare(SkinList.skInfo[i]));     
                if (SkinList.skInfo[i].SkinType == "ALEX_MASK")
                 alexMaskBox.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "ALEX_BODY")
                 alexBodyBox.Items.Add(AddtolistByRare(SkinList.skInfo[i]));

                ////
                if (SkinList.skInfo[i].SkinType == "CHANG_HEAD")
                    changHead.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "CHANG_MASK")
                    changMask.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "CHANG_BODY")
                    changBody.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                ////
                if (SkinList.skInfo[i].SkinType == "LISA_HEAD")
                    lisaHead.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "LISA_MASK")
                    lisaMask.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "LISA_BODY")
                    lisaBody.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                ////
                if (SkinList.skInfo[i].SkinType == "RACHEL_HEAD")
                    RachelHead.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "RACHEL_MASK")
                    RachelMask.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "RACHEL_BODY")
                    RachelBody.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                ////
                if (SkinList.skInfo[i].SkinType == "HANS_HEAD")
                    HansHead.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "HANS_MASK")
                    HansMask.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "HANS_BODY")
                    HansBody.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                ////
                if (SkinList.skInfo[i].SkinType == "NINA_HEAD")
                    NinaHead.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "NINA_MASK")
                    NinaMask.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                if (SkinList.skInfo[i].SkinType == "NINA_BODY")
                {
                  

                    NinaBody.Items.Add(AddtolistByRare(SkinList.skInfo[i]));


                }
                   
///////////////////////////////////////////////////////////////////////////
                if (SkinList.skInfo[i].SkinType == "PISTOL")
                {
                    alexPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    changPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    lisaPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    RachelPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    HansPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    NinaPistol.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                }
/////////////////////////
            if (SkinList.skInfo[i].SkinType == "WRISTBAND")
                {  alexWristband.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    changWist.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    lisaWist.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    HansWist.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    RachelWist.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                    NinaWist.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                }
/////////////////////////
            if   (SkinList.skInfo[i].SkinType == "KNIFE")
                {

  
                        alexKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                        changKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                        LisaKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                        RachelKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                        HansKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));
                        NinaKnife.Items.Add(AddtolistByRare(SkinList.skInfo[i]));



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

                label1.Text = alex;
                label1.Text += chang;
                label1.Text += lisa;
                label1.Text += rachel;
                label1.Text += hans;
                label1.Text += nina;

                try
                {
                    label2.Text = "ALL OK!";
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "freechanger.cfg|*.cfg";
                    saveFileDialog1.InitialDirectory = "C:\\Japrajah";
                    saveFileDialog1.RestoreDirectory = true;
                    saveFileDialog1.FileName = "freechanger.cfg";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, label1.Text);
                    }
                }
                catch
                {
                    label2.Text = "Failed to Open c\\Japrajah";

                }



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
