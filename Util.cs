using Autodesk.Revit.DB;

namespace TFMCrearPlanosJS
{
    public static class Util
    {
        /// transform one parameter to string
        /// <param name = "param" > Parameter to convert</param>
        /// <returns></returns>
        public static string ParameterToString(Parameter param)
        {
            string val = "none";
            if (param == null)
            {
                return val;
            }

            switch (param.StorageType)
            {
                case StorageType.Double:
                    double dval = param.AsDouble();
                    val = dval.ToString();
                    break;

                case StorageType.Integer:
                    int iVal = param.AsInteger();
                    val = iVal.ToString();
                    break;

                case StorageType.String:
                    string sVal = param.AsString();
                    val = sVal;
                    break;

                case StorageType.ElementId:
                    ElementId idVal = param.AsElementId();
                    val = idVal.IntegerValue.ToString();
                    break;

                case StorageType.None:
                    break;

                default:
                    break;
            }
            return val;
        }
    }
}
