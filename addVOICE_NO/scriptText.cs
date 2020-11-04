using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace addVOICE_NO
{
    class scriptText :  GetEncodeClass
    {
        public string  filePath { set; get; } = "";
        public string   textData { set; get; } = "";
        public Encoding enc;

        public void Load(string path)
        {
            filePath = path;
            
            if (File.Exists(path))
            {
                enc = this.GetEncoding(path);

                using (StreamReader sr = new StreamReader(path, enc ))
                {
                    textData = sr.ReadToEnd();
                }
            }
        }

        public void Save( string dirPath = "" )
        {
            string outputPath = "";
            if(　dirPath == "" )
            {
                outputPath = this.filePath;
            }
            else
            {
                outputPath = Path.Combine( dirPath , System.IO.Path.GetFileName(this.filePath));
            }

            using (StreamWriter sw = new StreamWriter(outputPath, false, enc))
            {
                sw.Write(this.textData);
            }

        }


    }
}
