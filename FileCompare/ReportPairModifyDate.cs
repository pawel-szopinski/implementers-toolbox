using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace FileCompare
{
    public sealed class ReportPairModifyDate : ReportPair
    {
        private readonly string appInstanceFail = "Failed Opening Application Instance!";
        // Additional file read result
        private readonly string blank = "Modify Date Blank!";
        private readonly string notSupported = "Not Supported File Type!";

        public ReportPairModifyDate(string fullPathWIN, string fullPathOriginal) : base(fullPathWIN, fullPathOriginal)
        {
            if (FileExtension == ".pdf")
            {
                if (ReadResultWIN != notFound)
                {
                    ReadResultWIN = GetModifyDatePdf(fullPathWIN);
                }

                if (_readResultOriginal != notFound)
                {
                    _readResultOriginal = GetModifyDatePdf(fullPathOriginal);
                }
            }
            else if (FileExtension == ".xls" || FileExtension == ".xlsx"
                     || FileExtension == ".xlsm" || FileExtension == ".xlsb" || FileExtension == ".csv")
            {
                if (ReadResultWIN != notFound)
                {
                    ReadResultWIN = GetModifyDateExcel(fullPathWIN);
                }

                if (_readResultOriginal != notFound)
                {
                    _readResultOriginal = GetModifyDateExcel(fullPathOriginal);
                }
            }
            else
            {
                if (ReadResultWIN != notFound)
                {
                    ReadResultWIN = notSupported;
                }

                if (_readResultOriginal != notFound)
                {
                    _readResultOriginal = notSupported;
                }
            }

            _match = CheckMatch(ReadResultWIN, _readResultOriginal);
        }

        protected override string CheckMatch(string readResultWIN, string readResultOriginal)
        {
            if (readResultWIN != cannotOpen && readResultWIN != blank && readResultWIN != notFound
                && readResultWIN != appInstanceFail && readResultWIN != notSupported
                && readResultOriginal != cannotOpen && readResultOriginal != blank && readResultOriginal != notFound
                && readResultOriginal != appInstanceFail && readResultOriginal != notSupported)
            {
                // Determine if the same file was referenced two times.
                if (FullPathWIN == FullPathOriginal)
                    // Return true to indicate that the files are the same.
                    return yesSameFile;

                if (readResultWIN == readResultOriginal)
                    return yes;
                return no;
            }
            return issue;
        }

        private string GetModifyDateExcel(string fullPath)
        {
            // Require both wkbs and wkb
            // If these vars are not declared, Excel instances do not close properly
            Excel.Application xlApp;
            Excel.Workbooks xlWkbs = null;
            Excel.Workbook xlWkb = null;

            try
            {
                xlApp = new Excel.Application() { DisplayAlerts = false, Visible = false };
            }
            catch
            {
                return appInstanceFail;
            }

            try
            {
                xlWkbs = xlApp.Workbooks;
                xlWkb = xlWkbs.Open(fullPath, false, true);

                return xlWkb.BuiltinDocumentProperties("Last Save Time").Value.ToString() != "" ? xlWkb.BuiltinDocumentProperties("Last Save Time").Value.ToString() : blank;
            }
            catch
            {
                return cannotOpen;
            }
            finally
            {
                if (xlWkb != null)
                {
                    xlWkb.Close(false);
                    Marshal.ReleaseComObject(xlWkb);
                }
                if (xlWkbs != null)
                {
                    Marshal.ReleaseComObject(xlWkbs);
                }
                if (xlApp != null)
                {
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }
        }

        private string GetModifyDatePdf(string fullPath)
        {
            try
            {
                using (PdfReader reader = new PdfReader(fullPath))
                {
                    if (reader.Info.ContainsKey("ModDate"))
                    {
                        return PdfDate.Decode(reader.Info["ModDate"]).ToString();
                    }
                    return blank;
                }
            }
            catch
            {
                return cannotOpen;
            }
        }
    }
}