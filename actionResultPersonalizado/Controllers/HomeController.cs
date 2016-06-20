using actionResultPersonalizado.Custom;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace actionResultPersonalizado.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost,Route("/Download")]

        public ActionResult Download(string fileName, string text)
        {
            return new PdfFileResult(fileName,text);
        }

        [HttpPost, Route("/DownloadE")]

        public ActionResult DownloadE(string fileName, string text)
        {
            //http://www.variablenotfound.com/2013/03/generar-archivos-excel-como-un-senor.html
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet 1");
            worksheet.Cell(1, 1).Value = "Hello, world!";
            worksheet.Cell("A2").Value = "How are you?";

            //Establecer un valor en un rango
            worksheet.Range("B1:D5").Value = "Hi!";

            //Assignarle una lista
            worksheet.Cell("E1").Value = new[]
             {
                  new { Id=1, Name="John", Age = 42},
                  new { Id=2, Name="Peter", Age = 23},
                  new { Id=3, Name="Mary", Age = 32},
             };

            worksheet.Cell("I1").Value= new String[][]{ new String[] { "a", "s", "r" } , new String[] { "a2", "s2", "r" } , new String[] { "a3", "s3", "r" } };
            // Generate the workbook...


            // ... and return it to the client
            return new ExcelFileResult(workbook, fileName);
        }
    }
}