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
    [Transaction(TransactionMode.Manual)]
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

            FilteredElementCollector colSheets = new FilteredElementCollector(doc).OfClass(typeof(ViewSheet));

            using (Transaction tran = new Transaction(doc, "Obtener datos de Planos"))
            {
                tran.Start();


                #region ALMACENANDO DATOS A EXPORTAR

                string sheetNum = "";
                string sheetNam = "";
                string sheetSca = "";


                foreach (Element i in colSheets)

                {
                    sheetNum += Util.ParameterToString(i.LookupParameter("Sheet Number"));
                    sheetNam += Util.ParameterToString(i.LookupParameter("Sheet Name"));
                    sheetSca += Util.ParameterToString(i.LookupParameter("Scale"));
                }

                #endregion


                #region EXPORTACION DE DATOS A EXCEL
                //RUTA PARA ALMACENAR EL ARCHIVO
                string path = "C:\\Users\\Usuario\\Desktop\\Datos.xlsm";

                //INICIANDO EXCEL
                X.Application excel = new X.Application();
                excel.Visible = true;
                if (excel != null)
                {
                    X.Workbook myWorkbook = excel.Workbooks.Add();      //AGREGANDO LIBRO A EXCEL
                    X.Worksheet myWorksheet = (excel.Worksheets.Add()); //AGREGANDO HOJA  A LIBRO DE EXCEL

                    //INSERTANDO DATOS EN LAS CELDAS DE EXCEL, (PRIMER INDICE FILA, SEGUNDO COLUMNA)
                    myWorksheet.Cells[1, 1] = sheetNum;
                    myWorksheet.Cells[2, 1] = sheetNam;
                    myWorksheet.Cells[3, 1] = sheetSca;

                    //GUARDANDO ARCHIVO EXCEL
                    excel.ActiveWorkbook.SaveAs(path, X.XlFileFormat.xlWorkbookNormal);

                    //myWorkbook.Close(); //CERRAR ARCHIVO
                    //excel.Quit();       //SALIR DE APLICACION
                }
                #endregion



                tran.Commit();
            }


            return Result.Succeeded;



        }

    }
}
