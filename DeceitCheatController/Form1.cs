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
            for (int i = 0; i < SkinList.skInfo.Count; i++)
            {
                if (SkinList.skInfo[i].SkinType == "ALEX_HEAD")
                   alexHeadBox.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "ALEX_MASK")
                    alexMaskBox.Items.Add(SkinList.skInfo[i].SkinName);
                if (SkinList.skInfo[i].SkinType == "ALEX_BODY")
                    alexBodyBox.Items.Add(SkinList.skInfo[i].SkinName);
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
                    NinaBody.Items.Add(SkinList.skInfo[i].SkinName);
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
                    alexKnife.Items.Add(SkinList.skInfo[i].SkinName);
                    changKnife.Items.Add(SkinList.skInfo[i].SkinName);
                    LisaKnife.Items.Add(SkinList.skInfo[i].SkinName);
                    RachelKnife.Items.Add(SkinList.skInfo[i].SkinName);
                    HansKnife.Items.Add(SkinList.skInfo[i].SkinName);
                    NinaKnife.Items.Add(SkinList.skInfo[i].SkinName);
                }

            }








            Debug.WriteLine(SkinList.skInfo.Count);
        }










    }
}
