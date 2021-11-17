using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NameSpaces
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Events;

namespace TFMCrearPlanosJS
{
    [Transaction(TransactionMode.Manual)]
    class Command : IExternalCommand
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

            #region COLECTORES DE PLANOS(TitleBlocks), VISTAS(Views) y VENTANAS GRAFICAS(ViewPort)
            FilteredElementCollector colTitleBlocks = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).OfCategory(BuiltInCategory.OST_TitleBlocks);
            FilteredElementCollector colViews = new FilteredElementCollector(doc).OfClass(typeof(View));
            FilteredElementCollector colViewPorts = new FilteredElementCollector(doc).OfClass(typeof(FamilySymbol)).OfCategory(BuiltInCategory.OST_Viewports);
            #endregion

            //TRANSACCION
            using (Transaction tran = new Transaction(doc, "Vistas asignadas a nuevas laminas"))
            {
                tran.Start();

                #region SELECCION DE VISTAS PRESENTES EN EL PROYECTO
                IList<Element> viewList = new List<Element>();
                foreach (View v in colViews)
                {
                    ViewType vType = v.ViewType;
                    if (vType == ViewType.Legend || vType == ViewType.Schedule ||
                        v.IsTemplate || vType == ViewType.DraftingView ||
                        v.Name == "System Browser" || v.Name == "Project View")
                    { }
                    else { viewList.Add(v); }
                }
                #endregion


                //TRANSFIRIENDO INFORMACION A WINFORM
                formViewList frm = new formViewList(viewList);
                frm.ShowDialog();


                //CONVIRTIENDO LISTA DE ELEMENTOS EN VISTAS
                List<ViewPlan> viewPlanList = formViewList.viewListSelected;


                //CREANDO PLANOS (TitleBlocks) E INSERTANDO VISTAS
                FamilySymbol titleBlock = colTitleBlocks.FirstElement() as FamilySymbol;

                if (formViewList.createSheets == true)
                {
                    foreach (var item in viewPlanList)
                    {
                        ViewSheet newSheets = ViewSheet.Create(doc, titleBlock.Id);
                        if (newSheets == null)
                        {
                            throw new Exception("No se pudo crear una nueva lamina");
                        }

                        BoundingBoxUV uv = newSheets.Outline;
                        double xx = (uv.Max.U - uv.Min.U) / 2;
                        double yy = (uv.Max.U - uv.Min.U) / 2;
                        XYZ pnt = new XYZ(xx, yy, 0);


                        if (Viewport.CanAddViewToSheet(doc, newSheets.Id, item.Id))
                        {
                            Viewport.Create(doc, newSheets.Id, item.Id, pnt);
                        }


                    }


                }

                tran.Commit();


                
            }

            return Result.Succeeded;
        }

        


    }
}