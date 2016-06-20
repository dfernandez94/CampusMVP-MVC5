using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace actionResultPersonalizado.Custom
{
    public class ExcelFileResult: ActionResult
    {
        private readonly XLWorkbook workbook;
        private readonly string fileName;

        public ExcelFileResult(XLWorkbook workbook, string fileName)
        {
            this.workbook = workbook;
            this.fileName = fileName;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.Clear();
            response.ContentType = "application/vnd.openxmlformats-officedocument."
                                 + "spreadsheetml.sheet";
            response.AddHeader("content-disposition",
                               "attachment;filename=\"" + fileName + ".xlsx\"");

            using (var memoryStream = new MemoryStream())
            {
                workbook.SaveAs(memoryStream);
                memoryStream.WriteTo(response.OutputStream);
            }
            response.End();
        }
    }
}