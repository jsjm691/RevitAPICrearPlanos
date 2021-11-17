using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Reflection;
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
            const string tabName = "TFM_SHEETS_tab";
            const string panelName = "SHEETS_JS";

            //creamos la pestaña
            a.CreateRibbonTab(tabName);

            //creamos el panel
            var newPanel = a.CreateRibbonPanel(tabName, panelName);

            //creamos los botones
            const string NAME = "Crear" + "\nPlanos";
            const string TEXT = "Crear" + "\nPlanos";
            const string COMMAND = "TFMCrearPlanosJS.Command";

            var pbd = new PushButtonData(NAME, TEXT, Assembly.GetExecutingAssembly().Location, COMMAND);
            pbd.ToolTip = "Seleccione las vistas que desee insertar en las nuevas laminas";
            pbd.LongDescription = "Al seleccionar las vistas deseadas estas se insertaran automaticamente en una nueva lamina por cada vista";

            //creamos los botones apilados
            const string name2 = "button2";
            const string text2 = "Button2";
            const string command2 = "TFMCrearPlanosJS.Command";

            var button2 = new PushButtonData(name2, text2, Assembly.GetExecutingAssembly().Location, command2);
            pbd.ToolTip = "This is a tooltip";
            pbd.LongDescription = "This is a long description";

            const string name3 = "button3";
            const string text3 = "Button3";
            const string command3 = "TFMCrearPlanosJS.Command";

            var button3 = new PushButtonData(name3, text3, Assembly.GetExecutingAssembly().Location, command3);
            pbd.ToolTip = "This is a tooltip";
            pbd.LongDescription = "This is a long description";

            //agregamos los botones al panel
            var btp1 = newPanel.AddItem(pbd) as PushButton;
            newPanel.AddStackedItems(button2, button3);




            return Result.Succeeded;
        }
    }
}
