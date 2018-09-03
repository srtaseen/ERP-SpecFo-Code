using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;

public class ReportFactory
{
    protected static int iMaxCount = 5;
    protected static Queue reportQueue = new Queue();

    protected static ReportDocument CreateReport(Type reportClass)
    {
        object obj2 = Activator.CreateInstance(reportClass);
        reportQueue.Enqueue(obj2);
        return (ReportDocument)obj2;
    }

    public static ReportDocument GetReport(Type reportClass)
    {
        if (reportQueue.Count > iMaxCount)
        {
            ((ReportDocument)reportQueue.Dequeue()).Close();
            ((ReportDocument)reportQueue.Dequeue()).Dispose();
            GC.Collect();
        }
        return CreateReport(reportClass);
    }
}