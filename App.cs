using System.Reflection;
using System.IO;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Autodesk.Revit.UI;


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

            const string tabName = "SheetsTools";
            const string panelName = "Sheets";

            //CREANDO PESTAÑA
            a.CreateRibbonTab(tabName);


            //CREANDO PANEL
            var newPanel = a.CreateRibbonPanel(tabName, panelName);


            //INSERTANDO ICONOS
            BitmapImage btOne = new BitmapImage(new Uri("pack://application:,,,/TFMCrearPlanosJS;component/Resources/iCommand.png"));
            BitmapImage btTwo = new BitmapImage(new Uri("pack://application:,,,/TFMCrearPlanosJS;component/Resources/iCExportToData.png"));


            #region CREANDO BOTONES

            const string NAME_COM = "Set Views on Sheets";
            const string TEXT_COM = "Set Views on Sheets";
            const string COMMAND_COM = "TFMCrearPlanosJS.Command";

            var pbCommand = new PushButtonData(NAME_COM, TEXT_COM, Assembly.GetExecutingAssembly().Location, COMMAND_COM);
            pbCommand.ToolTip = "Inserta en nuevos planos las vistas seleccionadas";
            pbCommand.LargeImage = btOne;

            const string NAME_DAT = "Data to Excel";
            const string TEXT_DAT = "Data to Excel";
            const string COMMAND_DAT = "TFMCrearPlanosJS.DataExportToExcel";

            var pbDataExportToExcel = new PushButtonData(NAME_DAT, TEXT_DAT, Assembly.GetExecutingAssembly().Location, COMMAND_DAT);
            pbDataExportToExcel.ToolTip = "Exporta datos de los planos a Excel";
            pbDataExportToExcel.LargeImage = btTwo;

            #endregion


            //AGREGANDO BOTONES AL PANEL
            SplitButtonData split_buttonData
                                            = new SplitButtonData(
                                            "SetViewsonSheets", "DataExportToExcel");

            SplitButton split_button = newPanel.AddItem(split_buttonData) as SplitButton;

            split_button.AddPushButton(pbCommand);
            split_button.AddPushButton(pbDataExportToExcel);

            return Result.Succeeded;
        }
    }
}
