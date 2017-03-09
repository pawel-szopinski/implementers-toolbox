using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCompare
{
    public static class FolderPairReader
    {
        public static string[,] GetFiles(string pathWIN, string pathOriginal, bool ignoreSystem)
        {
            pathWIN = pathWIN.Trim();
            pathOriginal = pathOriginal.Trim();

            if (!Directory.Exists(pathWIN) && !Directory.Exists(pathOriginal))
            {
                MessageBox.Show("Neither of the selected paths exist!",
                    "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (!Directory.Exists(pathWIN) && Directory.Exists(pathOriginal))
            {
                MessageBox.Show("The path to reports downloaded from WIN does not exist!",
                    "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (Directory.Exists(pathWIN) && !Directory.Exists(pathOriginal))
            {
                MessageBox.Show("The path to original reports does not exist!",
                    "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            try
            {
                FileInfo[] filesWIN = null;

                if (ignoreSystem)
                {
                    filesWIN = new DirectoryInfo(pathWIN)
                                        .GetFiles()
                                        .Where(x => (x.Attributes & FileAttributes.System) == 0)
                                        .ToArray();
                }
                else
                {
                    filesWIN = new DirectoryInfo(pathWIN)
                                        .GetFiles()
                                        .ToArray();
                }

                string[,] filesBoth = new string[filesWIN.Length, 2];

                for (int i = 0; i < filesWIN.Length; i++)
                {
                    filesBoth[i, 0] = filesWIN[i].FullName;

                    if (pathOriginal.EndsWith(@"\"))
                        filesBoth[i, 1] = pathOriginal + Path.GetFileName(filesWIN[i].Name);
                    else
                        filesBoth[i, 1] = pathOriginal + @"\" + Path.GetFileName(filesWIN[i].Name);
                }

                return filesBoth;
            }
            finally
            {
            }
        }
    }
}