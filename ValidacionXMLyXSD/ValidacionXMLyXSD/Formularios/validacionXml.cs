using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
//
using System.IO;
using ValidacionXMLyXSD.UTILITARIOS;
using ValidacionXMLyXSD.Excepciones;

namespace ValidacionXMLyXSD
{
    public partial class frmValidacionXml : Form
    {
                                
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
       
        public frmValidacionXml()
        {
            InitializeComponent();
            //muestra la ruta del archivo validador XSD            
            verPathXsd();
             

        }

        //------------- BOTONES -------------//
        //------------------------------------//
        #region Controles Formulario

        private void btnBuscarXml_Click(object sender, EventArgs e)
        {
            validarBusqueda();
        }

        private void btnProcesarXml_Click(object sender, EventArgs e)
        {

             validacionXmlyXsd() ;
            actualizarLecturaXml();           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrarAplicacion();
        }

        #endregion


        //--------------- MÉTODOS -------------//
        //------------------------------------//
        #region Métodos


    //VALIDACION XML
    private void validacionXmlyXsd() 
        {
           
            
            //Path archivo XSD-Validador 
            string xsdPath = (@"" + retrocedeFicheroBuscaArchivoXsd(appPath) + @"Plantilla\floraltech.xsd");
            try
            {
                if (this.txtArchivoXml.Text == "")
                {
                    MessageBox.Show("Debe elegir un archivo XML!", "ARCHIVO XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Definición de archivo XSD y Validación                                                                           
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.Schemas.Add(null, xsdPath);
                    settings.ValidationType = ValidationType.Schema;                                                     
                    settings.ValidationEventHandler += new ValidationEventHandler(this.ValidationEventHandler);

                    //ejecuta la variable hasta que termina la instruccion y cierra.
                    using (XmlReader reader = XmlReader.Create(txtArchivoXml.Text, settings))
                    {
                      
                        while (reader.Read()) { }                                                                                                        
                        txtValidacionSms.Text = "VALIDACIÓN EXITOSA...!";
                        reader.Close();
                    }

                }


            }
            catch (Exception ex)
            {

                txtValidacionSms.Text = "ERROR DE VALIDACIÓN: " + ex.Message;
                   
             }
                                                       
        }

      

        private void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            txtValidacionSms.Text = args.Message;
            throw new Exception( args.Message);
        }
    
       
        
        //BUSCAR ARCHIVO XML
        private void buscarXml()
        {
           try
            {

                OpenFileDialog archivo = new OpenFileDialog();

                archivo.Filter = "Archivos xml(*.xml)| *.xml";
                archivo.Title = "Archivos XML";           

                if (archivo.ShowDialog() == DialogResult.OK)
                {                
                    txtArchivoXml.Text = archivo.FileName;
                }
                else
                {
                    return; 
                }

                archivo.Dispose();
            }catch (Exception e)
            
                {
                     throw new ErrorBuscarArchivoXmlException(e.Message + e.StackTrace, e);                        
                }
        }

        //LEER DOCUMENTO XML
        private void leerArchivo()
        {
            try{
                if (txtArchivoXml.Text == "" )
                {
                    return;
                }                 
                       // ejecuta la variable hasta que termina la instruccion y cierra
                   using( XmlTextReader xmlTextReader = new XmlTextReader(txtArchivoXml.Text))
                    {
                       string etiquetafinal = "";
                        while (xmlTextReader.Read())
                        {
                            if (xmlTextReader.NodeType == XmlNodeType.Element)
                            {
                                txtReadXml.Text += (new string(' ', xmlTextReader.Depth*3) + "<" + xmlTextReader.Name + ">");
                                etiquetafinal = xmlTextReader.Name;                                       
                                continue;
                            }

                            if (xmlTextReader.NodeType == XmlNodeType.Text)
                            {
                                txtReadXml.Text += xmlTextReader.ReadContentAsString() + "</" + etiquetafinal + ">";                    
                            }                                  
                                            
                            else
                                txtReadXml.Text += "\r";                        
                        }
                        xmlTextReader.Close();                   
                    }
                     
                
            }catch(Exception ex)
            
                {
                    throw new ErrorLeerXmlExcepcion(ex.Message + ex.StackTrace, ex);
                }
           
        }
            
        //VALIDAR BÚSQUEDA
        private void validarBusqueda()
        {
            try{
                    if (txtReadXml.Text == "" && txtArchivoXml.Text=="")
                    {
                        buscarXml();
                        leerArchivo();
                    }
               }catch(Exception ex)
                    {
                     //throw new ErrorValidarBusquedaException(ex.Message + ex.StackTrace, ex);
                     txtValidacionSms.Text = ex.Message;
                    }
        }

        //LIMPIAR TEXTBOX
        private void limpiar()
        {

            txtReadXml.Clear();
            txtValidacionSms.Clear();
            txtArchivoXml.Clear();          

        }

        //SALIR DE APLICACION
        private void cerrarAplicacion()
        {
            this.Close();
        }

        //UBICACIÒN: PLANTILA XSD UNA CARPETA ANTES DE LA ACTUAL
        public string retrocedeFicheroBuscaArchivoXsd(String path)
        {

            int i;
            int j;
            int k;
            String ubicacion;

            j = 0;
            k = 0;
            ubicacion = "";

            if ((path.Length) > 0)
            {
                for (i = 0; i < (path.Length); i++)
                {
                    if ((path.Substring(i, 1).Equals("\\")))
                    {
                        j = j + 1;
                        k = 0;
                    }
                    else
                    {
                        k = k + 1;
                    }
                }

                ubicacion = ubicacion + (path.Substring(0, (((path.Length) - k))));

            }

            return ubicacion;

        }

        //PATH XSD Validador 
        private void verPathXsd()
        {
            string xsdPath = (@"" + retrocedeFicheroBuscaArchivoXsd(appPath) + @"Plantilla\floraltech.xsd");
            txtArchivoXsd.Text = xsdPath; 
        }


        //Visualizar los cambios realizados al archivo XML
        private void actualizarLecturaXml()
        {
            if(txtReadXml.Text != null)
                {
                    txtReadXml.Clear();
                    leerArchivo();
                }
        }
        #endregion


    }
}
