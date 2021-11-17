using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace TFMCrearPlanosJS
{
    public partial class formViewList : System.Windows.Forms.Form
    {
        //MOSTRANDO LA LISTA DE ELEMENTOS
        public formViewList(IList<Element> viewList)
        {
            InitializeComponent();

            selectViewList.DataSource = viewList;
            selectViewList.DisplayMember = "Name";

        }


        //ALMACENANDO LOS ELEMENTOS SELECCIONADOS
        public static List<Autodesk.Revit.DB.ViewPlan> viewListSelected = new List<ViewPlan>();


        //RECORRIENDO LA LISTA PARA COMPROBAR LOS ELEMENTOS SELECCIONADOS
        public void viewListFiltered()
        {
            foreach (Autodesk.Revit.DB.Element views in selectViewList.CheckedItems)
            {
                viewListSelected.Add(views as ViewPlan);
            }
        }

        
        //ALMACENANDO EL VALOR DEL BOTON
        public static bool createSheets;

        //CLICK SOBRE EL BOTON ES "TRUE"
        private void btnCreateSheets_Click(object sender, EventArgs e)
        {
            
            createSheets = true;
            viewListFiltered();
            Close();
        }
    }

}
