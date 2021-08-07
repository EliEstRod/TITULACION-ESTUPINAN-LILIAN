using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
//
using System.IO;
using ValidacionXMLyXSD.UTILITARIOS;
namespace ValidacionXMLyXSD
{
    public partial class Form1 : Form
    {
        //Path archivo XSD-Validador
        public string xsdFile = (@"Z:\Pasantias\PROGRAMACIÓN\XML-XSD-VS\prueba.xsd");
      
        public Form1()
        {
            InitializeComponent();
            //muestra la ruta del archivo validador XSD
            txtArchivoXsd.Text = xsdFile;          
        }
             
        
        //-------------- BUTTONS -------------- //
        private void bXmlvsXSD_Click(object sender, EventArgs e)
        {
            validacionXmlyXsd();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnBuscarXml_Click(object sender, EventArgs e)
        {

            validaBusqueda();
        }

        //--------------- MÉTODOS -------------//
        private void validacionXmlyXsd() {              
            try
         {             
            //string xmlFile= (@"Z:\Pasantias\PROGRAMACIÓN\XML-XSD-VS\prueba.xml");
            
            if (this.txtArchivoXml.Text== ""){
                MessageBox.Show("Suba/Escoja un ARCHIVO XML para Validar!", "ARCHIVO XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.txtArchivoXml.Text != ""){
                 //Definición de archivo XSD
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(null, xsdFile);
            settings.ValidationType = ValidationType.Schema;

                //Defino que obtenga la ruta del archivo XML escogido
            XmlReader reader = XmlReader.Create(txtArchivoXml.Text, settings);
            XmlDocument document = new XmlDocument();
            document.Load(reader);           
           
                //Validación
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);  
            MessageBox.Show("Archivos Validados correctamente!","XML VS XSD",MessageBoxButtons.OK, MessageBoxIcon.Information);          
            document.Validate(eventHandler);
            }                      
        
        } catch (Exception ex)
            {
                MessageBox.Show("Archivos NO validados, corrija los ERRORES!", ex.Message);
                //capturar el error en un txt
                txtValidacionSMS.Text = ex.Message;
                                          
           }
        }


        static void ValidationEventHandler(object sender, ValidationEventArgs e)
            {
            switch (e.Severity)             
                {
                 case XmlSeverityType.Error:
                        Console.WriteLine("XML {0}: {1} (Line {2})", 
                                            e.Severity,
                                            e.Message,                                       
                                            e.Exception.LineNumber);
                                break;
                 case XmlSeverityType.Warning:
                        Console.WriteLine("Warning {0}: {1} (Line {2})",
                                            e.Severity,
                                            e.Message,
                                            e.Exception.LineNumber);
                                break;
                }
            }

            //SALIR DE APLICACION
        private void cerrar(){

            if (MessageBox.Show("Está seguro de salir del Programa?", "SISTEMA DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            } return;
        }

            //BUSCAR ARCHIVO XML
        private void buscarXml(){

            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos xml(*.xml)| *.xml";
            archivo.Title = "Archivos XML";           
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                
                txtArchivoXml.Text = archivo.FileName;
            }
            if (archivo.ShowDialog() != DialogResult.OK)
            {
                return; 
            }
            archivo.Dispose();
          
        }

            //LEER DOCUMENTO XML
        private void leerArchivo(){
            if (txtArchivoXml.Text == "" )
            {
              validaBusqueda();
            }
            
            XmlTextReader xmlTextReader = new XmlTextReader(txtArchivoXml.Text);  
            string etiquetafinal = "";
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType == XmlNodeType.Element)
                {
                    txtReadXml.Text += (new string(' ', xmlTextReader.Depth*3) + "<" + xmlTextReader.Name + ">");
                    etiquetafinal = xmlTextReader.Name;                   
                    //Console.Write("{0} {1},{2}  ", xmlTextReader.Depth, xmlTextReader.LineNumber, xmlTextReader.LinePosition);
                    //Console.WriteLine("<{0}>", xmlTextReader.Name);
                    continue;
                }

                if (xmlTextReader.NodeType == XmlNodeType.Text)
                {
                    txtReadXml.Text += xmlTextReader.ReadContentAsString() + "</" + etiquetafinal + ">";
                    //Console.Write("{0} {1},{2}  ", xmlTextReader.Depth, xmlTextReader.LineNumber, xmlTextReader.LinePosition);
                    //Console.WriteLine("  {0}", xmlTextReader.Value);
                }
                else
                    txtReadXml.Text += "\r";                                              
            }
          
            
        }
            
            //VALIDAR BÚSQUEDA
        private void validaBusqueda(){

            if (txtReadXml.Text == "" && txtArchivoXml.Text=="")
            {
                buscarXml();
                leerArchivo();
            }else{
                txtReadXml.Clear();
                txtValidacionSMS.Clear();
                txtArchivoXml.Clear();
            }
            
        }
                                                                                 
    }
}
