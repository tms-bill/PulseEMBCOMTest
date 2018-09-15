using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pulse;


namespace PulseEMBCOMBill
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplication PulseID = new Pulse.Application();
  
            IEmbDesign Design = PulseID.OpenDesign("C:\\Temp\\Emoji.PXF", FileTypes.ftAuto, OpenTypes.otOutlines, "Tajima");
            IElements TemplateElements = Design.Elements;
          
            foreach (IElement Element in TemplateElements) 
            {
                //Go through each element in a template

                Console.WriteLine ("Element Name: {0:G}",Element.Name);
                for (int i = 0; i < Element.NumText; i++)
                {
                    // Go through each text element and print the default text

                    Console.WriteLine("Default Text: {0:G}", Element.Texts.GetValue(i));
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
