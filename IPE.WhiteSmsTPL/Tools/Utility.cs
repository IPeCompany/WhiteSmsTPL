using IPE.WhiteSmsTPL.Responses;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace IPE.WhiteSmsTPL
{
    public static class Utility
    {
        public static string ToJson(this object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public static T ToObject<T> (this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }

        internal static void TokenValidation(this string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("توکن را وارد کنید");
        }

        public static T GetContent<T>(this IRestResponse response) where T: BaseResponse
        {
            var content = response.Content.ToObject<T>();
            if (!content.IsSuccessful)
                throw new ArgumentException(content.Message);

            return content;
        }
    }
}
