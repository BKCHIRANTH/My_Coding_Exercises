using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnderstandingFileAttributes
{
   public class FileAttributes
    {
        public bool setReadOnly(String file)
        {
            if (File.Exists(file))
            {
                File.SetAttributes(file, System.IO.FileAttributes.ReadOnly);
                Console.WriteLine("The File attributes have been set as ReadOnly successfully!");
                return true;
            }

            return false;
        }

        public bool toCompress(String file)
        {
            if (File.Exists(file))
            {
                File.SetAttributes(file, System.IO.FileAttributes.Compressed);
                Console.WriteLine("The File has been compressed successfully!");
                return true;
            }
            return false;
        }
        

        public bool toHide(String file)
        {
            if (File.Exists(file))
            {
                File.SetAttributes(file, System.IO.FileAttributes.Hidden);
                Console.WriteLine("Hided successfully!");
                return true;
            }
            return false;
        }

        public String getAttributes(String file)
        {
            if (File.Exists(file))
            {
                System.IO.FileAttributes attributes = File.GetAttributes(file);
                String attrReturn = attributes.ToString();
                Console.WriteLine(string.Format("File attribute: {0}", attributes));
                return attrReturn;
            }
            return null;
        }

    }
}
