using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionEmpresa.Core.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString ToJson(this HtmlHelper helper, Object obj)
        {
            //Convertimos el modelo en un string
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None);

            //Remplazamos los caracteres que dañan el json https://www.json.org/
            var fix = json.Replace("\\", "\\\\")
                          .Replace("\\t", "     ")
                          .Replace("\\f", "")
                          .Replace("\\b", "")
                          .Replace("\\f", "")
                          .Replace("\\r", "<br>")
                          .Replace("\\n", "<br>")
                          .Replace("\\r\\n", "<br>")
                          .Replace("`", "");

            //Retornamos la cadena con la correción
            return helper.Raw(fix);
        }

        public static string GetUrl(this HtmlHelper helper, HttpRequestBase Request)
        {
            string scheme = Request.Url.Scheme.ToString();
            string host = Request.Url.Host.ToString().Replace("/", String.Empty);
            string port = Request.Url.Port.ToString();
            string appPath = Request.ApplicationPath.ToString().Replace("/", String.Empty);
            string url = scheme + "://" + host + (string.IsNullOrEmpty(port) ? string.Empty : (":" + port)) + "/" + (string.IsNullOrEmpty(appPath) ? string.Empty : (appPath + "/"));

            return url;
        }

        public static string GetArea(this HtmlHelper helper, HttpRequestBase Request)
        {
            var area = Request.RequestContext.RouteData.Values["area"];

            return (area != null) ? area.ToString() : null;
        }

        public static string GetController(this HtmlHelper helper, HttpRequestBase Request)
        {
            return Request.RequestContext.RouteData.Values["controller"].ToString();
        }

        public static string GetAction(this HtmlHelper helper, HttpRequestBase Request)
        {
            return Request.RequestContext.RouteData.Values["action"].ToString();
        }

        public static bool IsAjax(this HtmlHelper helper, HttpRequestBase Request)
        {
            return Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
    }
}