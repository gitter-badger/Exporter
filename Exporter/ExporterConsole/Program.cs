﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExporterObjects;
using ExportImplementation;

namespace ExporterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "andrei", WebSite = "http://msprogrammer.serviciipeweb.ro/" , CV = "http://serviciipeweb.ro/iafblog/content/binary/cv.doc" };

            Export<Person> export = new ExportHtml<Person>();
            var data = export.ExportResult(new List<Person>() { p });            
            File.WriteAllBytes("a.html",data);
            Process.Start("a.html");

            export=new ExportExcel2007<Person>();
            data = export.ExportResult(new List<Person>() { p });
            File.WriteAllBytes("a.xlsx", data);
            Process.Start("a.xlsx");


            export = new ExportWord2007<Person>();
            data = export.ExportResult(new List<Person>() { p });
            File.WriteAllBytes("a.docx", data);
            Process.Start("a.docx");


            export = new ExportPdfiTextSharp4<Person>();
            data = export.ExportResult(new List<Person>() { p });
            File.WriteAllBytes("a.pdf", data);
            Process.Start("a.pdf");


            //or you can use the factory
            data = ExportFactory.ExportData(new List<Person>() {p}, ExportToFormat.Excel2007);
            File.WriteAllBytes("b.xlsx", data);
            Process.Start("b.xlsx");

            //export from JSON
            string dataJson = @"[
    { 'Name':'Andrei Ignat', 
        'WebSite':'http://msprogrammer.serviciipeweb.ro/',
        'CV':'http://serviciipeweb.ro/iafblog/content/binary/cv.doc'        
    },
{ 'Name':'Andrei Ignat', 
        'WebSite':'http://msprogrammer.serviciipeweb.ro/',
        'CV':'http://serviciipeweb.ro/iafblog/content/binary/cv.doc'        
    }
]";

            data= ExportFactory.ExportDataJson(dataJson, ExportToFormat.Excel2007);
            File.WriteAllBytes("bJson.xlsx", data);
            Process.Start("bJson.xlsx");


            //or from CSV
            var dataCSV = new List<string>();
            dataCSV.Add("Name,WebSite,CV");
            dataCSV.Add("Andrei Ignat,http://msprogrammer.serviciipeweb.ro/,http://serviciipeweb.ro/iafblog/content/binary/cv.doc");
            dataCSV.Add("Andrei Ignat,http://msprogrammer.serviciipeweb.ro/,http://serviciipeweb.ro/iafblog/content/binary/cv.doc");

            data= ExportFactory.ExportDataCsv(dataCSV.ToArray(), ExportToFormat.Excel2007);
            File.WriteAllBytes("bCSV.xlsx", data);
            Process.Start("bCSV.xlsx");


        }
    }
}
