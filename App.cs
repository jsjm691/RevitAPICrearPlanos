using System.Windows.Media.Imaging;
using System.Reflection;
using System.IO;
using Autodesk.Revit.UI;
using System.Windows.Media;
using System;

namespace TFMCrearPlanosJS
{
    class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


        public Result OnStartup(UIControlledApplication a)
        {

            const string tabName = "Sheets Tools";
            const string panelName = "Sheets";

            //CREANDO LA PESTAÑA
            a.CreateRibbonTab(tabName);

            //CREANDO EL PANEL
            var newPanel = a.CreateRibbonPanel(tabName, panelName);

            //CREANDO EL BOTON PRINCIPAL
            const string NAME_C = "Set Views on Sheets";
            const string TEXT_C = "Set Views on Sheets";
            const string COMMAND_C = "TFMCrearPlanosJS.Command";

            var pbCommand = new PushButtonData(NAME_C, TEXT_C, Assembly.GetExecutingAssembly().Location, COMMAND_C);
            pbCommand.ToolTip = "Inserta en nuevos planos las vistas seleccionadas";


            const string NAME_D = "Data to Excel";
            const string TEXT_D = "Data to Excel";
            const string COMMAND_D = "TFMCrearPlanosJS.DataExportToExcel";

            var pbDataExportToExcel = new PushButtonData(NAME_D, TEXT_D, Assembly.GetExecutingAssembly().Location, COMMAND_D);
            pbDataExportToExcel.ToolTip = "Exporta datos de los planos a Excel";



            //pbCommand.LargeImage = NewBitmapImage(Assembly.GetExecutingAssembly(),
            //    "TFMCrearPlanosJs.iCommand.png");

            //pbDataExportToExcel.LargeImage = NewBitmapImage(Assembly.GetExecutingAssembly(),
            //  "TFMCrearPlanosJS.iCExportToData.png");



            //AGREGANDO BOTONES AL PANEL
            SplitButtonData split_buttonData
                  = new SplitButtonData(
                    "SetViewsonSheets", "DataExportToExcel");

            SplitButton split_button = newPanel.AddItem(split_buttonData) as SplitButton;

            split_button.AddPushButton(pbCommand);
            split_button.AddPushButton(pbDataExportToExcel);

            return Result.Succeeded;
        }

        //private ImageSource NewBitmapImage(Assembly assembly, string v)
        //{
        //    Stream s = assembly.GetManifestResourceStream(v);
        //    BitmapImage img = new BitmapImage();
        //    img.BeginInit();
        //    img.StreamSource = s;
        //    img.EndInit();
        //    return img;
        //}


    }
}
