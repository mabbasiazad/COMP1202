class Program
{

public static void Main(string[] args)
{
    string directoryPath = @"C:\Animals";
    //string directoryPath = @"C:\Users\mabba\OneDrive - George Brown College\Winter2024\COMP1202\LabExercises\week12_online\Texts";
    //read this folder/directory and list all files inside it
    // dog.jpg ....
    // File or Directory class 
    // FileInfo DirectoryInfo class
    /*
    string[] files = Directory.GetFiles(directoryPath); 

    foreach (var file in files)
    {
        Console.WriteLine(file);
    }
    */

    // DirectoryInfo class  // FileInfo[]
    //display the name of the directory (obj.Name)
    //display the file names (obj.GetFiles())  -- file.Name)
    DirectoryInfo directoryObj = new DirectoryInfo(directoryPath); 

    Console.WriteLine("Directory Name" + directoryObj.Name);
    FileInfo[] files = directoryObj.GetFiles(); 

    foreach (var file in files)

    {
        string fileName = "File Name: " + file.Name;
        string fileSize = "Size: " + file.Length;
        DateTime creationTime = file.CreationTime;
        //showing the info in aligned format            
        Console.WriteLine(fileName.PadRight(30) + fileSize.PadRight(20) + creationTime);   
    }
}

    
}
