class Program
{
    public static void Main(string[] args)
    {
        //exercise: list all the files of the folder/directory
        // dog.jpg ... 
        string path = @"C:\Animals";

        // Directory class
        // DirectoryInfo + FileInfo classes

        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Console.WriteLine("File Name: " + file);   
        }

        //DirectoryInfo class + FileInfo class- the methods are non-static
        // creat obj === obj.GetFiles()
        DirectoryInfo dirObj = new DirectoryInfo(path);
        FileInfo[] files_= dirObj.GetFiles();

        foreach (FileInfo file in files_)
        {
            string fileName = "File Name: " + file.Name;
            string fileSize = "Size: " + file.Length;
            DateTime creationTime = file.CreationTime;
            //showing the info in aligned format            
            Console.WriteLine(fileName.PadRight(30) + fileSize.PadRight(20) + creationTime);  
        }
    }
}
