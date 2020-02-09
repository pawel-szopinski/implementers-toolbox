using System.ComponentModel;
using System.IO;

namespace FileCompare
{
    public abstract class ReportPair
    {
        protected string _readResultOriginal;
        protected string _match;

        [DisplayName("File Name")]
        public string FileName { get; }

        [DisplayName("Extension")]
        public string FileExtension { get; }

        [DisplayName("Full Path - WIN File")]
        public string FullPathWIN { get; }

        [DisplayName("Full Path - Original File")]
        public string FullPathOriginal { get; }

        [DisplayName("Read Result - WIN File")]
        public string ReadResultWIN { get; protected set; }

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
            FullPathWIN = fullPathWIN;
            FullPathOriginal = fullPathOriginal;
            FileName = Path.GetFileName(fullPathWIN);
            FileExtension = Path.GetExtension(fullPathWIN).ToLower();

            if (!File.Exists(fullPathWIN))
            {
                ReadResultWIN = notFound;
            }

            if (!File.Exists(fullPathOriginal))
            {
                _readResultOriginal = notFound;
            }
        }

        protected abstract string CheckMatch(string check1, string check2);
    }
}