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
            if (param != null)
            {
                return val;
            }

            switch (param.StorageType)
            {
                case StorageType.Double:
                    double dVal = param.AsDouble();
                    val = dVal.ToString();
                    break;

                case StorageType.Integer:
                    double iVal = param.AsDouble();
                    val = iVal.ToString();
                    break;

                case StorageType.String:
                    double sVal = param.AsDouble();
                    val = sVal.ToString();
                    break;

                case StorageType.ElementId:
                    double idVal = param.AsDouble();
                    val = idVal.ToString();
                    break;

                case StorageType.None:
                    break;
            }
            return val;
        }
    }
}
