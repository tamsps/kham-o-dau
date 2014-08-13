using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Ultilities
{
    public class Helper
    {
        #region Format Numeric
        public static int ToInt(object obj)
        {
            int iValue = 0;
            try
            {
                int.TryParse(obj.ToString(), out iValue);
                return iValue;
            }
            catch
            {
                return -1;
            }
        }

        public static decimal ToDecimal(object obj)
        {
            decimal iValue = 0;
            try
            {
                decimal.TryParse(obj.ToString().Trim(), out iValue);
                return iValue;
            }
            catch
            {
                return 0;
            }
        }

        public static double ToDouble(object obj)
        {
            double iValue = 0;
            try
            {
                double.TryParse(obj.ToString().Trim(), out iValue);
                return iValue;
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime ToDateTime(object obj)
        {
            DateTime dt = DateTime.Now;
            try
            {
                dt = Convert.ToDateTime(obj);
            }
            catch { }
            return dt;
        }

        public static DateTime ToDateTimeFromString(object obj)
        {
            var dResult = DateTime.Now;
            var temp = obj.ToString();
            try
            {
                if (temp.Length == 8)
                {
                    int year = ToInt(temp.Substring(0, 4));
                    var month = ToInt(temp.Substring(4, 2));
                    var day = ToInt(temp.Substring(6, 2));
                    dResult = new DateTime(year, month, day);
                }
            }
            catch (Exception exception)
            {
                Logger.FrameworkLogger.Error("Convert to Date Time Error: ToDateTimeFromString ", exception);
            }
            return dResult;
        }

        public static string FormatNumeric(object obj, int places)
        {
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();
            try
            {
                string dec = "0:0.";
                string dec2 = "0.";

                for (int i = 0; i < places; i++)
                {
                    dec += "0";
                    dec2 += "0";
                }
                result = String.Format("{" + dec + "}", obj);
                result = Convert.ToDouble(result).ToString("###,###,##" + dec2);
            }
            catch
            {
                result = "-1";
            }
            return result;
        }
        #endregion
    }
}
