namespace dsd603Vm2025StudentVersion.Services
{


    /// <summary>
    /// Provides operations for working with text files in the web application's environment.
    /// </summary>
    /// <remarks>This class is designed to handle text file operations, such as loading content from specific
    /// files located in the web application's root directory. It relies on the <see cref="IWebHostEnvironment">  to
    /// determine the root path of the web application.</remarks>
    public class TextFileOperations : ITextFileOperations
    {

        private IWebHostEnvironment _webHostEnvironment { get; }
        public TextFileOperations(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public TextFileOperations()
        {
        }




        /// <summary>
        /// Loads the conditions for acceptance text from a predefined file.
        /// </summary>
        /// <remarks>This method reads the contents of a file named "ConditionsForAcceptance.txt" located
        /// in the web root directory and returns each line as a string in an enumerable collection. Ensure that the
        /// file exists and is accessible in the specified location.</remarks>
        /// <returns>An <see cref="IEnumerable{T}"/> of strings, where each string represents a line from the
        /// "ConditionsForAcceptance.txt" file.</returns>
        public IEnumerable<string> LoadConditionsForAcceptanceText()
        {
            string rootPath = _webHostEnvironment.WebRootPath;

            FileInfo filePath = new FileInfo(Path.Combine(rootPath, "ConditionsForAcceptance.txt"));
            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            return lines.ToList();
        }


    }
}
