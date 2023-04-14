namespace OOP_Lab_15
{
    internal interface ICube
    {
        double RibLength { get; set; }
        double CubeVolume { get; set; }
        double CubeLateralSurfaceSquare { get; set;}
    }
    internal interface IFile
    {
        string Path { get; set; }

        void FileRename(string path);
        void FileWrite(string path, List<string> values);
        string FileRead(string path);
    }
}
