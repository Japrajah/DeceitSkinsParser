﻿using System;
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
            if (Skin_id >= 4097 && Skin_id <= 4162)
                return "PISTOL";
            if (Skin_id >= 5121 && Skin_id <= 5178)
                return "KNIFE";
            if (Skin_id >= 3073 && Skin_id <= 3124)  // ЧАСЫ
                return "WRISTBAND";
            if (Skin_id >= 8193 && Skin_id <= 8260)
                return "GRAFFITI";
            ///////////////ALEX
            if (Skin_id >= 5 && Skin_id <= 109)  //ALEX HEAD
                return "ALEX_HEAD";
            if (Skin_id >= 1025 && Skin_id <= 1051)  //ALEX MASK // 1051
                return "ALEX_MASK";
            if (Skin_id >= 2049 && Skin_id <= 2182)  //ALEX BODY   2049 18433 34817 51201 67585 83969
                return "ALEX_BODY";

            /////////////// CHANG
            if (Skin_id >= 16387 && Skin_id <= 16498)  //CHANG HEAD
                return "CHANG_HEAD";
            if (Skin_id >= 17411 && Skin_id <= 17432)  //CHANG MASK
                return "CHANG_MASK";
            if (Skin_id >= 18433 && Skin_id <= 18572)  //CHANG BODY
                return "CHANG_BODY";

            /////////////// LISA 
            if (Skin_id >= 32769 && Skin_id <= 32878)  //LISA HEAD
                return "LISA_HEAD";
            if (Skin_id >= 33794 && Skin_id <= 33817)  //LISA MASK
                return "LISA_MASK";
            if (Skin_id >= 34817 && Skin_id <= 34952)  //LISA BODY
                return "LISA_BODY";

            //////////// Rachel
            if (Skin_id >= 49159 && Skin_id <= 49263)  //RACHEL HEAD
                return "RACHEL_HEAD";
            if (Skin_id >= 50179 && Skin_id <= 50198)  //RACHEL MASK
                return "RACHEL_MASK";
            if (Skin_id >= 51201 && Skin_id <= 51337)  //RACHEL BODY
                return "RACHEL_BODY";

            //////////// Hans
            if (Skin_id >= 65547 && Skin_id <= 65649)  //Hans HEAD
                return "HANS_HEAD";
            if (Skin_id >= 66563 && Skin_id <= 66586)  //Hans MASK
                return "HANS_MASK";
            if (Skin_id >= 67585 && Skin_id <= 67723)  //Hans BODY
                return "HANS_BODY";

            //////////// Nina
            if (Skin_id >= 81924 && Skin_id <= 82032)  //Nina HEAD
                return "NINA_HEAD";
            if (Skin_id >= 82947 && Skin_id <= 82967)  //LISA MASK
                return "NINA_MASK";
            if (Skin_id >= 83969 && Skin_id <= 84106)  //LISA BODY
                return "NINA_BODY";


            return "UNKNOWN";
        }
        static public async Task GetListFromCvs()
        {
          

            Task t = Task.Run(() => {
                using (TextFieldParser parser = new TextFieldParser(@"c:\Japrajah\unlocks.csv"))
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
                            SkinList.skInfo.Add(parsInfo);



                    }
                    // while end
                    
                }



            });



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