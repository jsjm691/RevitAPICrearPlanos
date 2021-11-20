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
        //MOSTRAR LA LISTA DE ELEMENTOS
        public formViewList(IList<Element> viewList)
        {
            InitializeComponent();

            selectViewList.DataSource = viewList;
            selectViewList.DisplayMember = "Name";

        }

        #region COLECCION DE ELEMENTOS SELECCIONADOS EL CHECKEDLISTBOX
        //ALMACENAR LOS ELEMENTOS SELECCIONADOS
        public static List<Autodesk.Revit.DB.ViewPlan> viewListSelected = new List<ViewPlan>();

        //RECORRER LA LISTA PARA COMPROBAR LOS ELEMENTOS SELECCIONADOS
        public void viewListFiltered()
        {
            foreach (Autodesk.Revit.DB.Element views in selectViewList.CheckedItems)
            {

                viewListSelected.Add(views as ViewPlan);
            }
        }
        #endregion


        #region BOTONES PARA SELECCIONAR Y DESELECCIONAR TODO
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectViewList.Items.Count; i++)
            {
                selectViewList.SetItemChecked(i, true);
            }
        }

        private void btnResetSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectViewList.Items.Count; i++)
            {
                selectViewList.SetItemChecked(i, false);
            }
        }
        #endregion


        #region BOTON PARA CREAR PLANOS
        public static bool createSheets; //ALMACENA EL VALOR DEL BOTON

        private void btnCreateSheets_Click(object sender, EventArgs e)
        {
            createSheets = true;
            viewListFiltered();
            Close();
        }
        #endregion


        #region BOTON PARA CANCELAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            createSheets = false;
            Close();
        }
        #endregion
    }

}
