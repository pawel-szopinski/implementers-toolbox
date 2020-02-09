using System.IO;

namespace FileCompare
{
    public sealed class ReportPairBinary : ReportPair
    {
        public ReportPairBinary(string fullPathWIN, string fullPathOriginal) : base(fullPathWIN, fullPathOriginal)
        {
            _match = CheckMatch(fullPathWIN, fullPathOriginal);
        }

        // This method accepts two strings the represent two files to 
        // compare. A return value of "True" indicates that the contents of the files
        // are the same. A return value of any other value indicates that the 
        // files are not the same.
        protected override string CheckMatch(string fullPathWIN, string fullPathOriginal)
        {
            int file1Byte;
            int file2Byte;
            long byteCounter = -1;
            FileStream fs1 = null;
            FileStream fs2 = null;

            // If any of the files does not exist return "issue"
            if (ReadResultWIN == notFound || _readResultOriginal == notFound)
                return issue;

            // Determine if the same file was referenced two times.
            if (fullPathWIN == fullPathOriginal)
                // Indicate that the files are the same.
                return yesSameFile;

            // Open the two files.
            try
            {
                fs1 = new FileStream(fullPathWIN, FileMode.Open);
            }
            catch
            {
                ReadResultWIN = cannotOpen;
            }

            try
            {
                fs2 = new FileStream(fullPathOriginal, FileMode.Open);
            }
            catch
            {
                _readResultOriginal = cannotOpen;
            }

            // If any of the files cannot be open return "issue"
            if (ReadResultWIN == cannotOpen || _readResultOriginal == cannotOpen)
                return issue;

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Save results
                ReadResultWIN = $"Different File Size (Bytes): {fs1.Length}";
                _readResultOriginal = $"Different File Size (Bytes): {fs2.Length}";

                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return no;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1Byte = fs1.ReadByte();
                file2Byte = fs2.ReadByte();

                // Icrease byte counter.
                byteCounter++;
            } while ((file1Byte == file2Byte) && (file1Byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the result of the comparison. If "file1byte" is 
            // equal to "file2byte" then the result is "True".
            // Otherwise, it is "False".
            if (file1Byte - file2Byte == 0)
            {
                ReadResultWIN = $"All Bytes Identical ({byteCounter})";
                _readResultOriginal = $"All Bytes Identical ({byteCounter})";
                return yes;
            }
            ReadResultWIN = $"Found Difference in (Byte): {byteCounter}";
            _readResultOriginal = $"Found Difference in (Byte): {byteCounter}";
            return no;
        }
    }
}