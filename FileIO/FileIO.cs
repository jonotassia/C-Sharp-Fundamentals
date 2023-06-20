const string filename = "TestFile.txt";

// Create a file
Console.WriteLine(File.Exists(filename));
if (File.Exists(filename))
{
    File.Delete(filename);
}
else
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file.");
    }
}
Console.WriteLine(File.Exists(filename));

// Writing
if (!File.Exists(filename))
{
    // Overwrites entire text file
    File.WriteAllText(filename, "This is a text file. ");
}

// Appending
File.AppendAllText(filename, "Hello, I am Monkey. ");

// Appending with a stream writer
using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("Wald is my best friend. ");
}

// Reading
string content = File.ReadAllText(filename);
Console.WriteLine(content);

// Get info about file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

Console.WriteLine(File.GetAttributes(filename));

// Get general information for a FileInfo
try
{
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"{fi.Length}");
    Console.WriteLine(fi.Directory);
    Console.WriteLine(fi.IsReadOnly);
}
catch (Exception e) {
    Console.WriteLine($"Exception: {e}");
}

// File information can also be manipulated
DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename));

// Creating a directory
const string dirname = "TestDir";
if (!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}

// Get path for current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {curpath} ");

// Getting directory metadata
DirectoryInfo di = new DirectoryInfo(curpath);
Console.WriteLine(di.Name);
Console.WriteLine(di.Parent);

// Enumerate files in the directory
List<string> filedirs = new List<string>(Directory.EnumerateFiles(curpath));
foreach (string dir in filedirs)
{
    Console.WriteLine(dir);
}

// Enumerate directories in the directory
List<string> dirdirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in dirdirs)
{
    Console.WriteLine(dir);
}

// Enumerate all contents in the directory
List<string> alldirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath));
foreach (string dir in alldirs)
{
    Console.WriteLine(dir);
}