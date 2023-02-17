using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
namespace DeceitCheatController
{
    class SkinList
    {
        public static List<SkinInfo> skInfo;
    }

class SkinInfo
{
    public int Global_Id { get; set; }
    public string SkinType { get; set; }
    public string SkinName { get; set; }
    public string Rarity { get; set; }
    public string isDefault { get; set; }
    public string BaseReward { get; set; }
    public string Exclusive { get; set; }
    public string Event { get; set; }
    public string Year { get; set; }


    }

    class Skinparser 
    {

        static private string TryDefineSKIN(int Skin_id)
        {
            int newskins = 300;
            if (Skin_id >= 4097 && Skin_id <= 4162 + newskins)
                return "PISTOL";
            if (Skin_id >= 5121 && Skin_id <= 5178 + newskins)
                return "KNIFE";
            if (Skin_id >= 3073 && Skin_id <= 3124 + newskins)  // ЧАСЫ
                return "WRISTBAND";
            if (Skin_id >= 8193 && Skin_id <= 8260 + newskins)
                return "GRAFFITI";
            ///////////////ALEX
            if (Skin_id >= 5 && Skin_id <= 109 + newskins)  //ALEX HEAD
                return "ALEX_HEAD";
            if (Skin_id >= 1025 && Skin_id <= 1051 + newskins)  //ALEX MASK // 1051
                return "ALEX_MASK";
            if (Skin_id >= 2049 && Skin_id <= 2182 + newskins)  //ALEX BODY   2049 18433 34817 51201 67585 83969
                return "ALEX_BODY";

            /////////////// CHANG
            if (Skin_id >= 16387 && Skin_id <= 16498 + newskins)  //CHANG HEAD
                return "CHANG_HEAD";
            if (Skin_id >= 17411 && Skin_id <= 17432 + newskins)  //CHANG MASK
                return "CHANG_MASK";
            if (Skin_id >= 18433 && Skin_id <= 18572 + newskins)  //CHANG BODY
                return "CHANG_BODY";

            /////////////// LISA 
            if (Skin_id >= 32769 && Skin_id <= 32878 + newskins)  //LISA HEAD
                return "LISA_HEAD";
            if (Skin_id >= 33794 && Skin_id <= 33817 + newskins)  //LISA MASK
                return "LISA_MASK";
            if (Skin_id >= 34817 && Skin_id <= 34952 + newskins)  //LISA BODY
                return "LISA_BODY";

            //////////// Rachel
            if (Skin_id >= 49159 && Skin_id <= 49263 + newskins)  //RACHEL HEAD
                return "RACHEL_HEAD";
            if (Skin_id >= 50179 && Skin_id <= 50198 + newskins)  //RACHEL MASK
                return "RACHEL_MASK";
            if (Skin_id >= 51201 && Skin_id <= 51337 + newskins)  //RACHEL BODY
                return "RACHEL_BODY";

            //////////// Hans
            if (Skin_id >= 65547 && Skin_id <= 65649 + newskins)  //Hans HEAD
                return "HANS_HEAD";
            if (Skin_id >= 66563 && Skin_id <= 66586 + newskins)  //Hans MASK
                return "HANS_MASK";
            if (Skin_id >= 67585 && Skin_id <= 67723 + newskins)  //Hans BODY
                return "HANS_BODY";

            //////////// Nina
            if (Skin_id >= 81924 && Skin_id <= 82032 + newskins)  //Nina HEAD
                return "NINA_HEAD";
            if (Skin_id >= 82947 && Skin_id <= 82967 + newskins)  //LISA MASK
                return "NINA_MASK";
            if (Skin_id >= 83969 && Skin_id <= 84106 + newskins)  //LISA BODY
                return "NINA_BODY";


            return "UNKNOWN";
        }
        static public async Task GetListFromCvs()
        {
          

            Task t = Task.Run(() => {
                using (TextFieldParser parser = new TextFieldParser("unlocks.csv"))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    //  
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        SkinInfo parsInfo = new SkinInfo();
                        foreach (string field in fields)
                        {
                            if ("Global ID" == fields[0])
                                continue;

                            parsInfo.Global_Id = Convert.ToInt32(fields[0]);
                            parsInfo.SkinType = Skinparser.TryDefineSKIN(parsInfo.Global_Id);
                            parsInfo.SkinName = fields[1];

                            parsInfo.Rarity = fields[2];
                            parsInfo.isDefault = fields[3];
                            parsInfo.BaseReward = fields[4];
                            parsInfo.Exclusive = fields[5];
                            parsInfo.Event = fields[6];


                            parsInfo.Year = fields[7];
                        }
                        if (parsInfo.Global_Id != 0)
                        {
                  
                            SkinList.skInfo.Add(parsInfo);

                        
                        
                        }
                        //if (parsInfo.Event == "Halloween" && parsInfo.Year == "2021")
                        //{
                        //    Debug.WriteLine("[" + parsInfo.SkinType + "] " + parsInfo.Global_Id + " " + parsInfo.SkinName);

            //}

        }
                    // while end
                    
                }



            });



        }

        static public string ConvertToloadoutByName(string[] Skin, string charachter)
        {
            string loadout = "";
            for (int i = 0; i < Skin.Length; i++)
            {
                if (Skin[i] == "")
                    return "INVALID";
            }
     
                for (int i = 0; i < 3; i++)
                {
                    for (int z = 0; z < SkinList.skInfo.Count; z++)
                    {
                        if (SkinList.skInfo[z].SkinType == charachter + "_HEAD" || SkinList.skInfo[z].SkinType == charachter + "_BODY" || SkinList.skInfo[z].SkinType == charachter + "_MASK")
                        {
                            if (SkinList.skInfo[z].SkinName == Skin[i])
                            {
                                loadout += SkinList.skInfo[z].Global_Id + ",";
                                break;
                            }
                        }
                    }
                }
                for (int z = 0; z < SkinList.skInfo.Count; z++)
                {
                    if (SkinList.skInfo[z].SkinType == "WRISTBAND")
                    {
                        if (SkinList.skInfo[z].SkinName == Skin[3])
                        {
                            loadout += SkinList.skInfo[z].Global_Id + ",";
                            break;
                        }
                    }
                }
                for (int z = 0; z < SkinList.skInfo.Count; z++)
                {
                    if (SkinList.skInfo[z].SkinType == "PISTOL")
                    {
                        if (SkinList.skInfo[z].SkinName == Skin[4])
                        {
                            loadout += SkinList.skInfo[z].Global_Id + ",";
                            break;
                        }
                    }
                }
                for (int z = 0; z < SkinList.skInfo.Count; z++)
                {
                    if (SkinList.skInfo[z].SkinType == "KNIFE")
                    {
                        if (SkinList.skInfo[z].SkinName == Skin[5])
                        {
                            loadout += SkinList.skInfo[z].Global_Id + ",";
                            break;
                        }
                    }
                }
            if (charachter == "ALEX")
                return loadout + "6178,7215,8225,";
             if (charachter == "CHANG")
                return loadout + "22579,23596,8225,";
             if (charachter == "LISA")
                return loadout + "38922,39940,8225,";
             if (charachter == "RACHEL")
                return loadout + "55299,56334,8225,";
             if (charachter == "HANS")
                return loadout + "71695,72720,8225,";
             if (charachter == "NINA")
                return loadout + "88073,89134,8225";

            return "INVALID";
        }

        
    }





}
/// <summary>
/// EXTERNAL GET ASYNC KEY
///    while (true)
///    {
///        Thread.Sleep(1);
///        if (Convert.ToBoolean(Input.GetAsyncKeyState(Keys.P)))
///        {
///            Debug.WriteLine("KeyPressed! P " + Pcount);
///
///            string path = @"C:\Japrajah\TESTINPUT.txt";
///
///            // Open the stream and write to it.
///            try
///            {
///                using (FileStream fs = File.OpenWrite(path))
///                {
///                    if (Pcount == 0)
///                   {
///                       Pcount--;
///                        Byte[] info =
///                            new UTF8Encoding(true).GetBytes("WH=0\nNOKNOCK=0");
///                        fs.Write(info, 0, info.Length);
///                        fs.Close();
///                    }
///                    else
///                    {
///                        Byte[] info =
///                        new UTF8Encoding(true).GetBytes("WH=1\nNOKNOCK=1");
///                        Pcount++;
///                        fs.Write(info, 0, info.Length);
///                        fs.Close();
///                    }
///                }
///           }
///            catch
///            {
///            }
///            Thread.Sleep(300);
///        }
///    }
/// </summary>
