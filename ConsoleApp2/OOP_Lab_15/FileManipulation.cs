using System;
using System.IO;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    internal class FileManipulation : IFile
    {
        public string FileName { get; set; }
        public FileManipulation()
        {
            FileName = "Defout.txt";

            File.Create(FileName);
        }
        public FileManipulation(string name)
        {
            if (name.Contains(".txt"))
            {
                FileName = name;
            }
            else
            {
                FileName = name + ".txt";
            }

            File.Create(FileName);
        }

        void FileWrite()
        {

        }
        void FileRename(string name)
        {
            if (!(name.Contains(".txt")))
            {
                name = name + ".txt";
                File.Copy(FileName, name, true);
            }   
        }
        void FileRead(string name)
        {

        }
    }
}
