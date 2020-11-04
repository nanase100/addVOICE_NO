using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace addVOICE_NO
{
    class takeData
    {
        public string serifText { set; get; } = "";
        public string voiceText { set; get; } = "";
        public int      hitCount { set; get; } = 0;

        public takeData( string voice, string serif)
        {
            serifText = serif;
            voiceText = voice;
            hitCount = 0;
        }
    }

    class takeCheck : GetEncodeClass
    {
     
        public Dictionary<string, List<takeData>> takeDataDic = new Dictionary<string, List<takeData>>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Load( string path )
        {
            string textData = "";
            string[] loadText;

            if (File.Exists(path))
            {
                var enc = this.GetEncoding(path);

                using (StreamReader sr = new StreamReader(path, enc))
                { 
                    string charName = System.IO.Path.GetFileNameWithoutExtension( path );

                    List< takeData > addList = new List<takeData>();

                    while (sr.EndOfStream == false )
                    { 
                        textData = sr.ReadLine();

                        loadText = textData.Split('\t');

                        addList.Add( new takeData(loadText[0], loadText[1]));
                    }

                    takeDataDic.Add( charName, addList);
                }

            }

        }
    }
}
