using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;
using System.Windows.Forms;


namespace editortexto
{
    class pdf
    {
        public void crear(string texto,string tipoletra, float tamanio)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "PDF|*.pdf";
            dialogo.Title = "Seleccione donde guardar el pdf";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
            Document documento = new Document(PageSize.LETTER);
            FileStream fs = new FileStream(dialogo.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            PdfWriter escrito = PdfWriter.GetInstance(documento,fs);
                documento.Open();
                documento.SetMargins(2.2f,1.6f,2.54f,2.54f);
                if (tipoletra == "Predeterminada")
                {
                    Paragraph cuerpo_texto = new Paragraph(texto, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, tamanio));
                    documento.Add(cuerpo_texto);
                }
                else if (tipoletra == "Arial")
                {
                    Paragraph cuerpo_texto = new Paragraph(texto, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, tamanio));
                    documento.Add(cuerpo_texto);
                }
                else
                {
                    Paragraph cuerpo_texto = new Paragraph(texto, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, tamanio));
                    documento.Add(cuerpo_texto);
                }                   
                documento.Close();
            }
        }
    }
}
