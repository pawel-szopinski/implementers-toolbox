using System;
using System.Collections.Generic;

namespace FileCompare
{
    public enum CompareMethod
    {
        Binary,
        ModifyDate
    }

    public static class ReadResultsList
    {
        public static List<ReportPair> Generate(string[,] fileList, CompareMethod compareMethod, IProgress<int> progress)
        {
            List<ReportPair> rl = new List<ReportPair>();

            int upperBound = fileList.GetUpperBound(0);

            for (int i = 0; i <= upperBound; i++)
            {
                progress.Report(i + 1);

                if (compareMethod == CompareMethod.Binary)
                    rl.Add(new ReportPairBinary(fileList[i, 0], fileList[i, 1]));
                else if (compareMethod == CompareMethod.ModifyDate)
                    rl.Add(new ReportPairModifyDate(fileList[i, 0], fileList[i, 1]));
            }

            return rl;
        }
    }
}