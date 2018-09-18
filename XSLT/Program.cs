using System.IO;
using System.Xml.Xsl;

namespace XSLT
{
    internal static class Program
    {
        private const string SourceFile = @"salle.xml";
        private const string Stylesheet = @"salle.xslt";
        private const string OutputFile = @"salle.html";

        private static void Main()
        {
            // Enable XSLT debugging.
            XslCompiledTransform xslt = new XslCompiledTransform(true);

            // Compile the style sheet.
            xslt.Load(Stylesheet);

            // Execute the XSLT transform.
            FileStream outputStream = new FileStream(OutputFile, FileMode.Create);
            xslt.Transform(SourceFile, null, outputStream);
        }
    }
}

