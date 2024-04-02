class Program
{
    public static void Main(string[] args)
    {
        //I want to show all the files inside the folder Animals
        string directoryPath = @"C:\Animals";

        // dog.jpg elephant.jpg monkey.jpg
        // (1)File (2)Directory 
        //FileInfo and DirectoryInfo

        //Approach 1: Using Directory class with static method GetFiles
        string[] files = Directory.GetFiles(directoryPath); 

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        //Approach 2: Using DirectoryInfo class
        DirectoryInfo directory = new DirectoryInfo(directoryPath);
        
        FileInfo[] files_ = directory.GetFiles();

        // file.Length ==> size   file.CreationTime ===> Time the file created
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
