﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using DemoApp.Entities;

namespace DemoApp.Web
{
    public static class Converter
    {
        public static decimal? StringToDecimal(string s)
        {
            try
            {
                decimal a = decimal.Parse(s);
                s = a.ToString(CultureInfo.InvariantCulture);
                if (s == null)
                {
                    return null;
                }
                return decimal.Parse(s, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
        public static int? StringToInt(string s)
        {
            try
            {

                return int.Parse(s, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Chuyen một chuỗi DMY sang DateTime
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? DMYStringToDateTime(string s, string format = "d/M/yyyy")
        {
            try
            {
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? YMDStringToDateTime(string s, string format = "yyyy-MM-dd")
        {
            try
            {
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cookie"></param>
        /// <returns></returns>
        public static TaiKhoan CookieToUserAccount(string cookie)
        {
            // Json -> obj
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TaiKhoan>(cookie);
        }

        //public 
    }
}