using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultados = Directory.GetDirectories(@"C:\Projetos\s3mHandlerRenameResults\netty\results\");
            StringBuilder output = new StringBuilder();

            foreach (string pastaResultado in resultados)
            {
                var arquivos = Directory.GetFiles(pastaResultado);

                string fileBase = "";
                string fileLeft = "";
                string fileRight = "";
                string fileMerge = "";


                foreach (string arquivo in arquivos)
                {
                    if (arquivo.Contains("base"))
                    {
                        fileBase = arquivo;
                    }
                    else if (arquivo.Contains("left"))
                    {
                        fileLeft = arquivo;
                    }
                    else if (arquivo.Contains("right"))
                    {
                        fileRight = arquivo;
                    }
                    else if (arquivo.Contains("merge"))
                    {
                        fileMerge = arquivo;
                    }
                }

                fileBase = fileBase.Replace(@"\", "/");
                fileLeft = fileLeft.Replace(@"\", "/");
                fileRight = fileRight.Replace(@"\", "/");
                fileMerge = fileMerge.Replace(@"\", "/");

                output.AppendLine("<tr>");
                output.AppendLine("<td>False Positive</td>");
                output.AppendLine("<td>Maintains both Constructors and Methds</td>");
                output.AppendLine("<td>");
                output.AppendLine("<ul>");
                output.AppendLine("<p>");
                output.AppendLine("Cometario qualquer...");
                output.AppendLine("</p>");

                output.AppendLine("<li>");
                output.AppendLine("s3m result: ");
                output.AppendLine("<a href='" + fileMerge + "'>");
                output.AppendLine(fileMerge);
                output.AppendLine("</a>");
                output.AppendLine("</li>");
                output.AppendLine("<br>");

                output.AppendLine("<li>");
                output.AppendLine("BASE:");
                output.AppendLine("<a href='" + fileBase + "'>");
                output.AppendLine(fileBase);
                output.AppendLine("<a/>");

                output.AppendLine("LEFT:");
                output.AppendLine("<a href='" + fileLeft + "'>");
                output.AppendLine(fileLeft);
                output.AppendLine("<a/>");

                output.AppendLine("RIGHT:");
                output.AppendLine("<a href='" + fileRight + "'>");
                output.AppendLine(fileRight);
                output.AppendLine("<a/>");
                output.AppendLine("</li>");
                output.AppendLine("</ul>");
                output.AppendLine("</td>");
                output.AppendLine("</tr>");

            }

            var final = output.ToString();


        }
    }
}
