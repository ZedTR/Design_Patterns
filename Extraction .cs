using System;
using System.IO;
using System.Linq;


namespace CST276_Assign_3
{
    class Extraction : ReadMorgFile
    {
        private StreamReader srReader;

        public Extraction(string filename)
        {
            srReader = File.OpenText(filename);
            
            if (srReader == null)
                throw new Exception("OpenRead() failed for file " + filename);
        }
        public override string GetState()
        {

            string line = srReader.ReadToEnd();

            return line;
        }

        public override void Close()
        {
            srReader.Close();
        }
    }
}
