using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{numero}",
                defaults: new { numero = RouteParameter.Optional }
            );

            //virer le formatter XML (pour framework 6.0)
            var monFormatterXML =
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(celui =>
                    celui.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(monFormatterXML);
        }
    }
}
