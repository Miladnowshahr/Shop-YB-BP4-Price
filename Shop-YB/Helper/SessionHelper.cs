using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Helper
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
            
        }

        //public static List<Item> GetObjectFromJson<List<Item>>(this ISession session,string key)
        //{
        //    var value = session.GetString(key);

        //    if (value!=null)
        //    {
        //        var list = JsonConvert.DeserializeObject<List<Item>>(value);

        //    }


        //    return value == null ? default(List<Item>) : JsonConvert.DeserializeObject<List<Item>(value);
        //}

        public static List<Item> GetObjectFromJson(ISession session,string key)
        {
            var value = session.GetString(key);

            if (value != null)
            {
                var list = JsonConvert.DeserializeObject<List<Item>>(value);

            }


            return value == null ? default(List<Item>) : JsonConvert.DeserializeObject<List<Item>>(value);
        }
    }
}
