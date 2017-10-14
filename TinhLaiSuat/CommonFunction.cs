using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLaiSuat
{
    public static class CommonFunction
    {
        public static double LamTronSo(this double value)
        {
            return Math.Round(value, 3);
        }

        public static double LamTronSo(this float value)
        {
            return Math.Round(value, 3);
        }

        public static double ParseDouble(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;
            double dob = 0;
            value = value.Replace(",", "").Replace(" ", "");
            value = value.Trim();
            try
            {
                dob = double.Parse(value, CultureInfo.InvariantCulture);
                dob = dob.LamTronSo();
            }
            catch { }
            return dob;
        }

        public static int ParseInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;
            int dob = 0;
            value = value.Replace(",", "").Replace(" ", "");
            value = value.Trim();
            try
            {
                dob = int.Parse(value, CultureInfo.InvariantCulture);
            }
            catch { }
            return dob;
        }

        public static float ParseFloat(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;
            float f = 0;
            float.TryParse(value, out f);
            return f;
        }

        public static float ParseFloat(this double dob)
        {
            return Convert.ToSingle(dob);
        }

        public static string AddSeparator(this double num)
        {
            num = num.LamTronSo();
            var str = num.ToString();
            var sub = "";
            var sdecimal = "";
            if (str.Contains("-"))
            {
                sub = "-";
                str = str.Substring(1);
            }
            if (str.Contains("."))
            {
                sdecimal = str.Substring(str.IndexOf('.'));
                str = str.Substring(0, str.IndexOf('.'));
            }
            str = string.Join("", str.Replace(",", "").Reverse());
            var output = "";
            for (var i = 0; i <= str.Length - 1; i++)
            {
                output = str[i] + output;
                if ((i + 1) % 3 == 0 && (str.Length - 1) != i)
                    output = ',' + output;
            }
            output = sub + output + sdecimal;
            return output;
        }

        public static string AddSeparator(this int num)
        {
            var str = num.ToString();
            var sub = "";
            var sdecimal = "";
            if (str.Contains("-"))
            {
                sub = "-";
                str = str.Substring(1);
            }
            if (str.Contains("."))
            {
                sdecimal = str.Substring(str.IndexOf('.'));
                str = str.Substring(0, str.IndexOf('.'));
            }
            str = string.Join("", str.Replace(",", "").Reverse());
            var output = "";
            for (var i = 0; i <= str.Length - 1; i++)
            {
                output = str[i] + output;
                if ((i + 1) % 3 == 0 && (str.Length - 1) != i)
                    output = ',' + output;
            }
            output = sub + output + sdecimal;
            return output;
        }

        public static string AddSeparator(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            str = str.Trim();
            var num = str.ParseDouble().LamTronSo();
            if (num == 0)
                return "0";
            var sub = "";
            var sdecimal = "";
            if (str.Contains("-"))
            {
                sub = "-";
                str = str.Substring(1);
            }
            if (str.Contains("."))
            {
                sdecimal = str.Substring(str.IndexOf('.'));
                str = str.Substring(0, str.IndexOf('.'));
            }
            str = string.Join("", str.Replace(",", "").Reverse());
            var output = "";
            for (var i = 0; i <= str.Length - 1; i++)
            {
                output = str[i] + output;
                if ((i + 1) % 3 == 0 && (str.Length - 1) != i)
                    output = ',' + output;
            }
            output = sub + output + sdecimal;
            return output;
        }

        public static DateTime ParseDatetime(this string str)
        {
            var list = str.Split(' ')[0].Trim().Split('/');
            return new DateTime(list[2].ParseInt(), list[1].ParseInt(), list[0].ParseInt());
        }
    }
}
