using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace lab3_trang.ViewModels
{
    public class VaildTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            bool isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                 CultureInfo.CurrentCulture,
                 DateTimeStyles.None,
                out dateTime);
            return isValid;
        }
    }
}