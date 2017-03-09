using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ImplementersToolbox.Utilities.ExportData
{
    public static class ExportDataGridView
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        public static void ToExcel(DataGridView dataGridView, string filePath, IProgress<byte> progress)
        {
            Process proc = null;
            Excel.Application xlApp = null;
            Workbooks xlWkbs = null;
            Workbook xlWkb = null;
            Sheets xlWkss = null;
            Worksheet xlWks = null;
            Range xlRng = null;

            try
            {
                progress.Report(1);

                xlApp = new Excel.Application() { DisplayAlerts = false, Visible = false };
                xlWkbs = xlApp.Workbooks;
                xlWkb = xlWkbs.Add();
                xlWkss = xlWkb.Sheets;
                xlWks = xlWkb.ActiveSheet;
                xlWks.Name = "Results";
                List<int> removeColumns = new List<int>();

                int pid;
                GetWindowThreadProcessId(xlApp.Hwnd, out pid);
                proc = Process.GetProcessById(pid);

                // store header part in Excel
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    if (dataGridView.Columns[i - 1].Visible)
                    {
                        xlWks.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                        xlWks.Cells[1, i].Font.Bold = true;
                    }
                    else
                        removeColumns.Add(i);
                }

                progress.Report(2);

                // store each row and column value to excel sheet
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (!dataGridView.Columns[j].Visible) continue;

                        if (dataGridView.Rows[i].Cells[j].Value != null)
                            xlWks.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();

                        xlWks.Cells[i + 2, j + 1].Font.Color =
                            ColorTranslator.ToOle(dataGridView.Rows[i].DefaultCellStyle.ForeColor);
                    }
                }

                // remove blank columns
                if (removeColumns.Count > 0)
                {
                    removeColumns.Reverse();

                    foreach (int column in removeColumns)
                        xlWks.Columns[column].Delete();
                }

                // remove other worksheets
                xlApp.DisplayAlerts = false;

                foreach (Worksheet ws in xlWkss)
                {
                    if (ws.Name != xlWks.Name)
                        ws.Delete();
                }

                // add autofilter
                xlRng = xlWks.Range["A1", xlWks.Cells[xlWks.UsedRange.Rows.Count, xlWks.UsedRange.Columns.Count]];
                xlRng.AutoFilter(1, Type.Missing, XlAutoFilterOperator.xlAnd, Type.Missing, true);

                xlRng.EntireColumn.AutoFit();

                xlWkb.SaveAs(filePath);

                xlApp.DisplayAlerts = true;

                xlWkb.Close();
                xlApp.Quit();

                progress.Report(3);
            }
            finally
            {
                if (xlRng != null) Marshal.ReleaseComObject(xlRng);
                if (xlWks != null) Marshal.ReleaseComObject(xlWks);
                if (xlWkss != null) Marshal.ReleaseComObject(xlWkss);
                if (xlWkb != null) Marshal.ReleaseComObject(xlWkb);
                if (xlWkbs != null) Marshal.ReleaseComObject(xlWkbs);
                if (xlApp != null) Marshal.ReleaseComObject(xlApp);

                // if still not closed - kill it!
                if (proc != null && !proc.HasExited)
                    proc.Kill();
            }
        }
    }
}