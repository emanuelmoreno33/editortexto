using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using word = Microsoft.Office.Interop.Word;



namespace editortexto
{
    public partial class Form1 : Form
    {
        pdf pdfarchivo = new pdf();
        private Font fuentepr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuentepr = ctEditor.Font;
        }
        //acciones
        //salir
        public void salir()
        {
            Close();
        }
        //cortar
        public void cortar()
        {
            ctEditor.Cut();
        }
        //copiar
        public void copiar()
        {
            ctEditor.Copy();
        }
        //pegar
        public void pegar()
        {
            ctEditor.Paste();
        }
        public void deshacer()
        {
            if (ctEditor.CanUndo) ctEditor.Undo();
        }
        //guardar txt
        public void guardar()
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Archivo TXT|*.txt";
            dialogo.Title = "Guardar archivo TXT";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (Stream ruta = File.Open(dialogo.FileName, FileMode.OpenOrCreate))
                using (StreamWriter escritor = new StreamWriter(ruta))
                {
                    escritor.Write(ctEditor.Text);
                }
                status.Text = "TXT Guardado";
            }
        }
        //abrir txt
        public void abrir()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos TXT|*.txt";
            dialogo.Title = "Abrir un archivo txt";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                ctEditor.Clear();
                StreamReader leido = File.OpenText(dialogo.FileName);
                string contenido = null;
                contenido = leido.ReadToEnd();
                ctEditor.Text = contenido;
                leido.Close();
                status.Text = "TXT Abierto";

            }
        }
        //guardar word
        public void guardarword()
        {
            object objmiss = System.Reflection.Missing.Value;
            word.Application wordobj = new word.Application();
            word.Document objdoc = wordobj.Documents.Add(ref objmiss, ref objmiss, ref objmiss, ref objmiss);
            objdoc.Activate();
            wordobj.Selection.Font.Name = menuFuente.SelectedItem.ToString();
            if (menuTamanio.SelectedItem.ToString() == "Predeterminada")
            {
                wordobj.Selection.Font.Size = fuentepr.Size;
            }
            else
            {
                wordobj.Selection.Font.Size = float.Parse(menuTamanio.SelectedItem.ToString());
            }
            wordobj.Selection.TypeText(ctEditor.Text);
            wordobj.Application.Visible = true;
            status.Text = "Documento de Word Guardado";
        }
        //guardar pdf
        public void guardarpdf()
        { 
            string tamanio = menuTamanio.SelectedItem.ToString();
            float tam;
            if (tamanio == "16" || tamanio == "24")
            {
                tam = float.Parse(tamanio);
            }
            else
            {
                tam = fuentepr.Size;
            }
            pdfarchivo.crear(ctEditor.Text,menuFuente.SelectedItem.ToString(),tam);
            status.Text = "PDF Guardado";
        }

        //fuente
        public void fuente()
        {
          ctEditor.Font = new Font(menuFuente.SelectedItem.ToString(),ctEditor.Font.Size,ctEditor.Font.Style);
        }
        public void fuente_CourierNew()
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font("Courier New", f.Size, f.Style);
            OpFuArial.Checked = false;
            OpFuCouriernew.Checked = true;
            OpFuPredeterminada.Checked = false;
        }
        public void fuente_Arial()
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font("Arial", f.Size, f.Style);
            OpFuArial.Checked = true;
            OpFuCouriernew.Checked = false;
            OpFuPredeterminada.Checked = false;
        }
        public void fuente_predeterminada()
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(fuentepr.SystemFontName, f.Size, f.Style);
            OpFuArial.Checked = false;
            OpFuCouriernew.Checked = false;
            OpFuPredeterminada.Checked = true;
        }
        
        //tamaño
        public void tamanio(float tam)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(f.SystemFontName, tam, f.Style);

        }
        public void tamanio_pred()
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(f.SystemFontName, fuentepr.Size, f.Style);
        }

        //archivo
        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        //edicion
        private void EdicionCortar_Click(object sender, EventArgs e)
        {
            cortar();
        }
        private void EdicionPegar_Click(object sender, EventArgs e)
        {
            pegar();
        }
        private void EdicionCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }
        //opciones
        //fuente
        private void OpFuCouriernew_Click(object sender, EventArgs e)
        {
            fuente_CourierNew();
        }
        private void OpFuArial_Click(object sender, EventArgs e)
        {
            fuente_Arial();
        }
        private void OpFuPredeterminada_Click(object sender, EventArgs e)
        {
            fuente_predeterminada();
        }
        //tamaño
        private void Optam16_Click(object sender, EventArgs e)
        {
            tamanio(16.0f);
            Optam16.Checked = true;
            OpTam24.Checked = false;
            OpTamPredeterminado.Checked = false;
        }
        private void OpTam24_Click(object sender, EventArgs e)
        {
            tamanio(24.0f);
            Optam16.Checked = false;
            OpTam24.Checked = true;
            OpTamPredeterminado.Checked = false;
        }
        private void OpTamPredeterminado_Click(object sender, EventArgs e)
        {
            tamanio_pred();
            Optam16.Checked = false;
            OpTam24.Checked = false;
            OpTamPredeterminado.Checked = true;
        }
        //activar pegar y cortar
        //edicion
        private void menuEdicion_DropDownOpened(object sender, EventArgs e)
        {
            bool textoseleccionado = (ctEditor.SelectedText.Length != 0);
            EdicionCopiar.Enabled = textoseleccionado;
            EdicionCortar.Enabled = textoseleccionado;
            btnbarCopiar.Enabled = textoseleccionado;
            btnbarCortar.Enabled = textoseleccionado;
        }
        //barra
        private void ctEditor_MouseMove(object sender, MouseEventArgs e)
        {
            bool textoseleccionado = (ctEditor.SelectedText.Length != 0);
            btnbarCopiar.Enabled = textoseleccionado;
            btnbarCortar.Enabled = textoseleccionado;
        }
        //deshacer
        private void btnbarDeshacer_Click(object sender, EventArgs e)
        {
            deshacer();   
        }
        //combobox fuente y tamaño
        private void menuFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuente();
        }
        private void menuTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tam = menuTamanio.SelectedItem.ToString();
            if (tam == "Predeterminada")
            {
                //ctEditor.Font = new Font(ctEditor.Font.SystemFontName,fuentepr.Size, ctEditor.Font.Style);
                tamanio_pred();
            }
            else if (tam == "16" || tam == "24")
            {
                ctEditor.Font = new Font(ctEditor.Font.SystemFontName, float.Parse(menuTamanio.SelectedItem.ToString()), ctEditor.Font.Style);
            }
            else
            {
                MessageBox.Show("Seleccione valores validos");
            }
           
        }
        //archivo
        //guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }
        //abrir - barra
        private void btnbarAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }
        //pegar - barra
        private void btnbarPegar_Click(object sender, EventArgs e)
        {
            pegar();
        }
        //copiar - barra
        private void btnbarCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }
        //cortar - barra
        private void btnbarCortar_Click(object sender, EventArgs e)
        {
            cortar();
        }
        //guardar - barra
        private void btnbarGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        //guardar pdf
        private void btnbarGuardarpdf_Click(object sender, EventArgs e)
        {
            guardarpdf();
        }
        //guardar word
        private void btnbarGuardarword_Click(object sender, EventArgs e)
        {
            guardarword();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarpdf();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarword();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deshacer();
        }
    }
}
