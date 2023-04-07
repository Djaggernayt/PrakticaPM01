using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Xps.Packaging;
using System.Windows.Xps;
using System.Windows.Xps.Serialization;
using DotLiquid;
using sample;
using dotTemplate = DotLiquid.Template;
using System.Xml;
using System.Windows.Markup;

namespace Administration
{
    /// <summary>
    /// Окно предназначено для вывода на печать
    /// </summary>
    public partial class Print : Window
    {
        //05.04.2023 Калинин Арсений Олегович Описание: инициальзация шаблона печати
        public Print()
        {
            InitializeComponent();
            using (var stream = new FileStream("Templates\\report1.lqd", FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    var templateString = reader.ReadToEnd();
                    var template = dotTemplate.Parse(templateString);
                    Hash docContext;
                    if (datamine.isComplaint)
                        docContext = SampleDoc.CreateDocumentContext(datamine.nd, datamine.dr, datamine.fi, datamine.ao, datamine.kc, datamine.cor, datamine.ex, datamine.pe);
                    else
                        docContext = SampleDoc.CreateDocumentContext(datamine.nd, datamine.dr, datamine.kc, datamine.cor, datamine.ex, datamine.pe);
                    var docString = template.Render(docContext);
                    DocViewer.Document = (FlowDocument)XamlReader.Parse(docString);
                }
            }
        }
        //06.04.2023 Калинин Арсений Олегович Описание: сохранение и вывод на печать
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            using (var stream = new MemoryStream())
            {
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (var xpsDoc = new XpsDocument(package, CompressionOption.Maximum))
                    {
                        var rsm = new XpsSerializationManager(new XpsPackagingPolicy(xpsDoc), false);
                        var paginator = ((IDocumentPaginatorSource)DocViewer.Document).DocumentPaginator;
                        rsm.SaveAsXaml(paginator);
                        rsm.Commit();
                    }
                }
                stream.Position = 0;

                var pdfXpsDoc = PdfSharp.Xps.XpsModel.XpsDocument.Open(stream);
                PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc, "doc.pdf", 0);
                System.Diagnostics.Process.Start("doc.pdf");
                
            }
            this.DialogResult = true;

        }

    }
}
