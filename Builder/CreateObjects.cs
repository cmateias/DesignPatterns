﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CreateObjects
    {
        public static void Run()
        {
            
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            
            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
    }
}
