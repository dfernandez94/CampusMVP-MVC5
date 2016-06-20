using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace actionResultPersonalizado.Custom
{
    public class PdfFileResult : ActionResult
    {
        string filename;
        string text;
        public PdfFileResult(string fileName, string text)
        {
            this.filename = fileName;
            this.text = text;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "application/pdf";
            response.AddHeader("content-disposition", "attachment; filename="+filename+".pdf");
            generatePdf(response.OutputStream, text);
            
            
        }

        private void generatePdf(Stream stream, string text)
        {
            var document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.Open();

            document.Add(new Paragraph(text, FontFactory.GetFont("Arial", 28, BaseColor.BLACK)));
            document.Add(new Paragraph(DateTime.Now.ToLongDateString()));

            document.Close();
            writer.Flush();
            writer.Close();
        }
    }
}