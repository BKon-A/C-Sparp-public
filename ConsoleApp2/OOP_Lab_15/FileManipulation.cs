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
        public string Path { get; set; }
        public FileManipulation()
        {
            Path = "Defout.txt";

            File.Create(Path).Close();
        }
        public FileManipulation(string path)
        {
            if (path.Contains(".txt"))
            {
                Path = path;
                File.Create(Path).Close();
            }
            else
            {
                Path = path + ".txt";
                File.Create(Path).Close();
            }
        }

        public void FileWrite(string path, List<string> values)
        {
            try
            {
                if (File.Exists(path))
                {
                    if (!path.Contains(".txt"))
                    {
                        path = path + ".txt";
                        StreamWriter streamWrite = new StreamWriter(path, true);
                        foreach(var i in values)
                        {
                            streamWrite.Write(" " + i);
                        }
                        streamWrite.Close();
                    }
                    else
                    {
                        StreamWriter streamWrite = new StreamWriter(path, true);
                        foreach (var i in values)
                        {
                            streamWrite.Write(" " + i);
                        }
                        streamWrite.Close();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void FileRename(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                if(!path.Contains(".txt"))
                {
                    path = path + ".txt";
                }

                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(Path, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string FileRead(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    if (!path.Contains(".txt"))
                    {
                        path = path + ".txt";
                        StreamReader streamReader = new StreamReader(path);
                        return streamReader.ReadToEnd();
                    }
                    else
                    {
                        StreamReader streamReader = new StreamReader(path);

                        return streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "";
        }
    }
}
