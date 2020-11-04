using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace addVOICE_NO
{



    class DataManager
    {
         
        public enum EngineType
        {
            EngineType_CS2   = 0,
            EngineType_yuris = 1,
        }


        private EngineType          procType = EngineType.EngineType_CS2;
        private takeCheck           takeCheckData = new takeCheck();
        private List<scriptText>    textFileList = new List<scriptText>();
        private List<takeData> list;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool Proc(string scenarioPath, string takecheckPath, EngineType type )
        {
            this.procType = type;

            ScriptDataLoad(scenarioPath);

            TakeDataLoad(takecheckPath);

            for( int i = 0; i < this.textFileList.Count; i++ )
            {
                Do( i );
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int ScriptDataLoad( string path )
        {
            textFileList.Clear();

            int ret = -1;

            if( Directory.Exists( path ) )
            {
                string[] textPath = Directory.GetFiles(path);

               foreach( var tmp in textPath )
               {
                    var data = new scriptText();
                    data.Load(tmp);
                    textFileList.Add( data );
               }
            }

            return ret;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int TakeDataLoad(string path)
        {
            this.takeCheckData.takeDataDic.Clear();

            int ret = -1;

            if (Directory.Exists(path))
            {
                string[] textPath = Directory.GetFiles(path);

                foreach (var tmp in textPath)
                {
                    var data = new scriptText();
                    data.Load(tmp);

                    this.takeCheckData.Load(tmp);
                }
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Do( int no)
        {
            MatchCollection results;
            Regex regex;

            if(this.procType == EngineType.EngineType_CS2)
            {
                regex = new Regex(@"^([^\x01-\x7E]+)(\r\n\t)(.+)\r", RegexOptions.Multiline);
            }
            else
            //if (this.procType == EngineType.EngineType_yuris)
            {
                regex = new Regex(@"(.*)\r\n【(.*)】(.+)\r", RegexOptions.Multiline);
            }

            string newStr,serifText,voiceName,destText,charName;
            results = regex.Matches(this.textFileList[no].textData);
            foreach ( Match tmp in results)
            {
                string tmpStr = tmp.Groups[1].ToString();
                if (this.procType == EngineType.EngineType_yuris && tmpStr.IndexOf("\\VO") != -1 ) continue;       //名前の前に\voがあるならスルー。
                if (this.procType == EngineType.EngineType_CS2 && tmpStr.IndexOf(" pcm") != -1) continue;       //名前の前にpcmがあるならスルー。

                if (this.procType == EngineType.EngineType_CS2)
                {
                    serifText = tmp.Groups[3].ToString();
                    destText = tmp.Groups[1].ToString() + tmp.Groups[2].ToString() + tmp.Groups[3].ToString();
                    serifText = serifText.Replace( "\\@","");
                }
                else
                //if (this.procType == EngineType.EngineType_yuris)
                {
                    serifText = tmp.Groups[3].ToString();
                    destText = "【"+tmp.Groups[2].ToString() + "】"+ tmp.Groups[3].ToString(); 
                }

                charName    = (this.procType == EngineType.EngineType_CS2 ?  tmp.Groups[1].ToString() : tmp.Groups[2].ToString() );
                voiceName   = this.VoiceNameGet(serifText, charName);
                if (this.procType == EngineType.EngineType_CS2)
                {
                    newStr = "\t" + @"pcm " + voiceName + Environment.NewLine + tmp.Groups[1].ToString() + tmp.Groups[2].ToString() + tmp.Groups[3].ToString();
                }
                else
                {                    
                    newStr = @"\VO(" + voiceName + ")" + Environment.NewLine + "【" + tmp.Groups[2].ToString() + "】"+ tmp.Groups[3].ToString();
                }

                //実際にボイスなしセリフにボイスを追加置換。   
                if( voiceName != "" ) this.textFileList[no].textData = this.textFileList[no].textData.Replace( destText, newStr );
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public string VoiceNameGet( string searchText, string charName )
        {
            string ret ="";

            if( takeCheckData.takeDataDic.TryGetValue(charName, out list) == false ) return ret;
            
            foreach ( var tmp in list)
            {
                if( tmp.serifText.IndexOf( searchText ) != -1 && tmp.hitCount == 0 )
                {
                    tmp.hitCount++;
                    ret = tmp.voiceText;
                    break;
                }
            }
            return ret;
        }

        public void OutputText( string dirPath )
        {
            foreach( var tmp in textFileList )
            {
                tmp.Save(dirPath);
            }
        }
    }
}
