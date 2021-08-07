namespace ValidacionXMLyXSD
{
    partial class frmValidacionXml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidacionXml));
            this.label1 = new System.Windows.Forms.Label();
            this.txtReadXml = new System.Windows.Forms.RichTextBox();
            this.txtValidacionSms = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarXsd = new System.Windows.Forms.Button();
            this.txtArchivoXsd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcesarXml = new System.Windows.Forms.Button();
            this.btnBuscarXml = new System.Windows.Forms.Button();
            this.txtArchivoXml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARCHIVO XML";
            // 
            // txtReadXml
            // 
            this.txtReadXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReadXml.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtReadXml.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadXml.Location = new System.Drawing.Point(3, 35);
            this.txtReadXml.Name = "txtReadXml";
            this.txtReadXml.ReadOnly = true;
            this.txtReadXml.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtReadXml.Size = new System.Drawing.Size(556, 384);
            this.txtReadXml.TabIndex = 6;
            this.txtReadXml.Text = "";
            // 
            // txtValidacionSms
            // 
            this.txtValidacionSms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValidacionSms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValidacionSms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValidacionSms.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidacionSms.ForeColor = System.Drawing.Color.Red;
            this.txtValidacionSms.Location = new System.Drawing.Point(565, 35);
            this.txtValidacionSms.Name = "txtValidacionSms";
            this.txtValidacionSms.ReadOnly = true;
            this.txtValidacionSms.Size = new System.Drawing.Size(556, 384);
            this.txtValidacionSms.TabIndex = 7;
            this.txtValidacionSms.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "LISTADO ERRORES /NOVEDADES";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(938, 425);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(183, 45);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Tag = "3";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92679F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtReadXml, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtValidacionSms, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCerrar, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.788162F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.21184F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1124, 473);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscarXsd);
            this.groupBox1.Controls.Add(this.txtArchivoXsd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnProcesarXml);
            this.groupBox1.Controls.Add(this.btnBuscarXml);
            this.groupBox1.Controls.Add(this.txtArchivoXml);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 131);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(895, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(201, 45);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Tag = "3";
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarXsd
            // 
            this.btnBuscarXsd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarXsd.Enabled = false;
            this.btnBuscarXsd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarXsd.Image")));
            this.btnBuscarXsd.Location = new System.Drawing.Point(807, 72);
            this.btnBuscarXsd.Name = "btnBuscarXsd";
            this.btnBuscarXsd.Size = new System.Drawing.Size(82, 45);
            this.btnBuscarXsd.TabIndex = 28;
            this.btnBuscarXsd.UseVisualStyleBackColor = true;
            // 
            // txtArchivoXsd
            // 
            this.txtArchivoXsd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoXsd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArchivoXsd.Enabled = false;
            this.txtArchivoXsd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoXsd.ForeColor = System.Drawing.Color.Red;
            this.txtArchivoXsd.Location = new System.Drawing.Point(166, 72);
            this.txtArchivoXsd.Multiline = true;
            this.txtArchivoXsd.Name = "txtArchivoXsd";
            this.txtArchivoXsd.Size = new System.Drawing.Size(631, 45);
            this.txtArchivoXsd.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "ARCHIVO XSD:";
            // 
            // btnProcesarXml
            // 
            this.btnProcesarXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesarXml.BackColor = System.Drawing.Color.RosyBrown;
            this.btnProcesarXml.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarXml.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesarXml.Image")));
            this.btnProcesarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesarXml.Location = new System.Drawing.Point(895, 19);
            this.btnProcesarXml.Name = "btnProcesarXml";
            this.btnProcesarXml.Size = new System.Drawing.Size(201, 47);
            this.btnProcesarXml.TabIndex = 25;
            this.btnProcesarXml.Tag = "2";
            this.btnProcesarXml.Text = "PROCESAR";
            this.btnProcesarXml.UseVisualStyleBackColor = false;
            this.btnProcesarXml.Click += new System.EventHandler(this.btnProcesarXml_Click);
            // 
            // btnBuscarXml
            // 
            this.btnBuscarXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarXml.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarXml.Image")));
            this.btnBuscarXml.Location = new System.Drawing.Point(806, 18);
            this.btnBuscarXml.Name = "btnBuscarXml";
            this.btnBuscarXml.Size = new System.Drawing.Size(83, 47);
            this.btnBuscarXml.TabIndex = 24;
            this.btnBuscarXml.Tag = "1";
            this.btnBuscarXml.UseVisualStyleBackColor = true;
            this.btnBuscarXml.Click += new System.EventHandler(this.btnBuscarXml_Click);
            // 
            // txtArchivoXml
            // 
            this.txtArchivoXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArchivoXml.Enabled = false;
            this.txtArchivoXml.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoXml.Location = new System.Drawing.Point(166, 18);
            this.txtArchivoXml.Multiline = true;
            this.txtArchivoXml.Name = "txtArchivoXml";
            this.txtArchivoXml.ReadOnly = true;
            this.txtArchivoXml.Size = new System.Drawing.Size(629, 48);
            this.txtArchivoXml.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "ARCHIVO XML:";
            // 
            // frmValidacionXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1134, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmValidacionXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLORALTECH_VALIDATOR XML";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtReadXml;
        private System.Windows.Forms.RichTextBox txtValidacionSms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArchivoXsd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesarXml;
        private System.Windows.Forms.Button btnBuscarXml;
        private System.Windows.Forms.TextBox txtArchivoXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarXsd;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

