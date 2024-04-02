class Program
{
    public static void Main(string[] args)
    {
        // Working with File and Direcotry classes 
        // Note: (It is better to use FileInfo and DirectoryInfo classes for more functionalities)
        //===============================================
        //1.Showing the current direcotry 
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());

        //2. Showing the file information
        string filePath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Animals\dog.jpg";
        //File Attributes: Compressed, Device, Directory, Encrypted, Hidden, Normal, ReadOnly, and System.
        Console.WriteLine("File Attribute: " + File.GetAttributes(filePath));
        Console.WriteLine("File Creation Time: " + File.GetCreationTime(filePath));       
        
        
        
        // Working with FileInfo and DirecotryInfo classes
        //===============================================
        //1. Get the path of Animal folder
        string pathDirectory = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Animals";
        DirectoryInfo directory = new DirectoryInfo(pathDirectory);
        Console.WriteLine("Directory Name: " + directory.Name);

        //2. get the files in the directory and print the name
        FileInfo[] files = directory.GetFiles();
        foreach (FileInfo file in files)
        {
            Console.WriteLine("File Name: " + file.Name);
        }

        //3. get the files in the directory and print the name, size and creation time
        foreach (FileInfo file in files)
        {
            string fileName = "File Name: " + file.Name;
            string fileSize = "Size: " + file.Length;
            DateTime creationTime = file.CreationTime;
            //showing the info in aligned format            
            Console.WriteLine(fileName.PadRight(30) + fileSize.PadRight(20) + creationTime);
        }     
    }   
}
        