using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//NameSpaces
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Events;
using X = Microsoft.Office.Interop.Excel;

namespace TFMCrearPlanosJS
{
    [Transaction(TransactionMode.ReadOnly)]
    class DataExportToExcel : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
                              ref string message,
                              ElementSet elements)
        {
            #region ACCEDIENDO AL DOCUMENTO
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;
            #endregion

            FilteredElementCollector colViewSheets = new FilteredElementCollector(doc).OfClass(typeof(ViewSheet));


            using (Transaction tran = new Transaction(doc, "Obtener datos de Planos"))
            {
                tran.Start();


                #region ALMACENANDO PARAMETROS A EXPORTAR
                List<Element> dataViewSheets = new List<Element>();

                foreach (var i in colViewSheets)
                {
                    Parameter shNum = i.get_Parameter(BuiltInParameter.SHEET_NUMBER);
                    Parameter shNam = i.get_Parameter(BuiltInParameter.SHEET_NAME);
                    Parameter shSca = i.get_Parameter(BuiltInParameter.SHEET_SCALE);

                    dataViewSheets.Add(i);//REVISAR ESTE LINEA ( DEBO ALMACENAR COMO STRING)
                }
                #endregion


                X.Application excel = new X.Application();
                excel.Visible = true;

                X.Workbook workbook = excel.Workbooks.Add(
                    Missing.Value);

                X.Worksheet worksheet;

               worksheet = excel.Worksheets.Add(
                   Missing.Value, Missing.Value,
                   Missing.Value, Missing.Value)
                   as X.Worksheet;

                int column = 3;

                foreach(string j in dataViewSheets)
                {
                    worksheet.Cells[1, column] = dataViewSheets;
                    ++column;
                }
                
                




                tran.Commit();
            }


            return Result.Succeeded;



        }

    }
}
