using System.ComponentModel;
using System.IO;

namespace FileCompare
{
    public abstract class ReportPair
    {
        private readonly string _fullPathWIN;
        private readonly string _fullPathOriginal;
        private readonly string _fileName;
        private readonly string _fileExtension;
        protected string _readResultWIN;
        protected string _readResultOriginal;
        protected string _match;

        [DisplayName("File Name")]
        public string FileName => _fileName;
        [DisplayName("Extension")]
        public string FileExtension => _fileExtension;
        [DisplayName("Full Path - WIN File")]
        public string FullPathWIN => _fullPathWIN;
        [DisplayName("Full Path - Original File")]
        public string FullPathOriginal => _fullPathOriginal;
        [DisplayName("Read Result - WIN File")]
        public string ReadResultWIN => _readResultWIN;
        [DisplayName("Read Result - Original File")]
        public string ReadResultOriginal => _readResultOriginal;
        [DisplayName("Match?")]
        public string Match => _match;

        // File read results - common issues
        protected string cannotOpen = "Unable to Open the File!";
        protected string notFound = "File Not Found!";

        // Compare results
        protected string yes = "True";
        protected string yesSameFile = "True (Same File)";
        protected string no = "False";
        protected string issue = "Issue(s) Found!";

        protected ReportPair(string fullPathWIN, string fullPathOriginal)
        {
            _fullPathWIN = fullPathWIN;
            _fullPathOriginal = fullPathOriginal;
            _fileName = Path.GetFileName(fullPathWIN);
            _fileExtension = Path.GetExtension(fullPathWIN).ToLower();

            if (!File.Exists(fullPathWIN))
            {
                _readResultWIN = notFound;
            }

            if (!File.Exists(fullPathOriginal))
            {
                _readResultOriginal = notFound;
            }
        }

        protected abstract string CheckMatch(string check1, string check2);
    }
}
