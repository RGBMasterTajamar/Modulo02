using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viernes2510App.Models
{
    public static class StringExtensions
    {
        public static bool IsDate(this String content) {
            DateTime date;
            bool result = DateTime.TryParse(content, out date);
            return result;
        }

        public static DateTime ToDate(this String content) { 
            DateTime date;
            bool result = DateTime.TryParse(content, out date);
            if (result)
            {
                return date;
            }else
            {
                date = DateTime.MinValue;
                return date;
            }        
        }
    }
}