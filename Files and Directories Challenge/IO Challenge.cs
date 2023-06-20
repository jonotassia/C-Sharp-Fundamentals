string filedir = Directory.GetCurrentDirectory() + "/FileCollection";

int TotalFiles = 0;
int ExcelFiles = 0;
int WordFiles = 0;
int PPFiles = 0;

long TotalSize = 0;
long ExcelSize = 0;
long WordSize = 0;
long PPSize = 0;

foreach (string file in  Directory.GetFiles(filedir))
{
    FileInfo fi = new FileInfo(file);

    switch (fi.Extension)
    {
        case ".xlsx":
            ExcelFiles += 1;
            ExcelSize += fi.Length;
            break;
        case ".docx":
            WordFiles += 1;
            WordSize += fi.Length;
            break;
        case ".pptx":
            PPFiles += 1;
            PPSize += fi.Length;
            break;
        default:
            break;
    }
}

TotalFiles = ExcelFiles + WordFiles + PPFiles;
TotalSize = ExcelSize + WordSize + PPSize;

Console.WriteLine("~~~~ Results ~~~~");
Console.WriteLine($"Total Files: {TotalFiles}");
Console.WriteLine($"Excel Files: {ExcelFiles}");
Console.WriteLine($"Word Files: {WordFiles}");
Console.WriteLine($"PowerPoint Files: {PPFiles}");

Console.WriteLine("---");
Console.WriteLine($"Total Size: {TotalSize:N0}");
Console.WriteLine($"Excel Size: {ExcelSize:N0}");
Console.WriteLine($"Word Size: {WordSize:N0}");
Console.WriteLine($"PowerPoint Size: {PPSize:N0}");