string currentPath = Directory.GetCurrentDirectory();
string filesDirectory = currentPath + "/FileCollection";

// Results
int totalFiles = 0;
int excelFiles = 0; // .xlsx
int wordFiles = 0; // .docx
int ppFiles = 0; // .pptx
long totalSize = 0; // in bytes with commas
long excelSize = 0;
long wordSize = 0;
long ppSize = 0;

try
{
  DirectoryInfo di = new DirectoryInfo(currentPath);

  List<string> directoryContents = new List<string>(Directory.EnumerateFiles(filesDirectory));
  // foreach (FileInfo file in di.EnumerateFiles())
  foreach (string file in directoryContents)
  {
    FileInfo fi = new FileInfo(file);

    string extensionName = fi.Extension;
    if (extensionName == ".xlsx")
    {
      totalSize += fi.Length;
      totalFiles++;
      excelFiles++;
      excelSize += fi.Length;
    }
    else if (extensionName == ".docx")
    {
      totalSize += fi.Length;
      totalFiles++;
      wordFiles++;
      wordSize += fi.Length;
    }
    else if (extensionName == ".pptx")
    {
      totalSize += fi.Length;
      totalFiles++;
      ppFiles++;
      ppSize += fi.Length;
    }
  }
  if (File.Exists("results.txt"))
  {
    File.Delete("results.txt");
  }
  using (StreamWriter sw = File.CreateText("results.txt"))
  {
    sw.WriteLine("~~~ Results ~~~");
    sw.WriteLine($"Total Files: {totalFiles}");
    sw.WriteLine($"Excel Count: {excelFiles}");
    sw.WriteLine($"Word Count: {wordFiles}");
    sw.WriteLine($"PowerPoint Count: {ppFiles}");
    sw.WriteLine("---");
    sw.WriteLine($"Total Size: {totalSize:N0}");
    sw.WriteLine($"Excel Size: {excelSize:N0}");
    sw.WriteLine($"Word Size: {wordSize:N0}");
    sw.WriteLine($"PowerPoint Size: {ppSize:N0}");
  }

}
catch (Exception e)
{
  Console.WriteLine($"There was an exception: {e.Message}");
}