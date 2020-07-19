namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.botonMR = new System.Windows.Forms.Button();
            this.botonTangente = new System.Windows.Forms.Button();
            this.botonSeno = new System.Windows.Forms.Button();
            this.botonCoseno = new System.Windows.Forms.Button();
            this.encendido = new System.Windows.Forms.Button();
            this.botonresultado = new System.Windows.Forms.Button();
            this.boton1x = new System.Windows.Forms.Button();
            this.botonporcentaje = new System.Windows.Forms.Button();
            this.botonsumar = new System.Windows.Forms.Button();
            this.botonrestar = new System.Windows.Forms.Button();
            this.botonmultiplicar = new System.Windows.Forms.Button();
            this.botonmasmenos = new System.Windows.Forms.Button();
            this.botoncoma = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.botondividir = new System.Windows.Forms.Button();
            this.botonraiz = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.botonPI = new System.Windows.Forms.Button();
            this.botonX3 = new System.Windows.Forms.Button();
            this.botonCE = new System.Windows.Forms.Button();
            this.retroceso = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.archivoToolStripMenuItem.Text = "Edición";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "Copiar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 19);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.botonMR);
            this.panel1.Controls.Add(this.botonTangente);
            this.panel1.Controls.Add(this.botonSeno);
            this.panel1.Controls.Add(this.botonCoseno);
            this.panel1.Controls.Add(this.encendido);
            this.panel1.Controls.Add(this.botonresultado);
            this.panel1.Controls.Add(this.boton1x);
            this.panel1.Controls.Add(this.botonporcentaje);
            this.panel1.Controls.Add(this.botonsumar);
            this.panel1.Controls.Add(this.botonrestar);
            this.panel1.Controls.Add(this.botonmultiplicar);
            this.panel1.Controls.Add(this.botonmasmenos);
            this.panel1.Controls.Add(this.botoncoma);
            this.panel1.Controls.Add(this.boton0);
            this.panel1.Controls.Add(this.boton2);
            this.panel1.Controls.Add(this.boton3);
            this.panel1.Controls.Add(this.boton1);
            this.panel1.Controls.Add(this.boton5);
            this.panel1.Controls.Add(this.boton6);
            this.panel1.Controls.Add(this.boton4);
            this.panel1.Controls.Add(this.boton8);
            this.panel1.Controls.Add(this.boton9);
            this.panel1.Controls.Add(this.botondividir);
            this.panel1.Controls.Add(this.botonraiz);
            this.panel1.Controls.Add(this.boton7);
            this.panel1.Controls.Add(this.botonPI);
            this.panel1.Controls.Add(this.botonX3);
            this.panel1.Controls.Add(this.botonCE);
            this.panel1.Controls.Add(this.retroceso);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 223);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(278, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(39, 26);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // botonMR
            // 
            this.botonMR.Enabled = false;
            this.botonMR.ForeColor = System.Drawing.Color.Red;
            this.botonMR.Location = new System.Drawing.Point(52, 178);
            this.botonMR.Name = "botonMR";
            this.botonMR.Size = new System.Drawing.Size(40, 32);
            this.botonMR.TabIndex = 37;
            this.botonMR.Text = "MR";
            this.botonMR.UseVisualStyleBackColor = true;
            this.botonMR.Click += new System.EventHandler(this.botonMR_Click);
            // 
            // botonTangente
            // 
            this.botonTangente.Enabled = false;
            this.botonTangente.ForeColor = System.Drawing.Color.Fuchsia;
            this.botonTangente.Location = new System.Drawing.Point(6, 179);
            this.botonTangente.Name = "botonTangente";
            this.botonTangente.Size = new System.Drawing.Size(40, 32);
            this.botonTangente.TabIndex = 36;
            this.botonTangente.Text = "tan";
            this.botonTangente.UseVisualStyleBackColor = true;
            this.botonTangente.Click += new System.EventHandler(this.botonTangente_Click);
            // 
            // botonSeno
            // 
            this.botonSeno.Enabled = false;
            this.botonSeno.ForeColor = System.Drawing.Color.Fuchsia;
            this.botonSeno.Location = new System.Drawing.Point(6, 140);
            this.botonSeno.Name = "botonSeno";
            this.botonSeno.Size = new System.Drawing.Size(40, 32);
            this.botonSeno.TabIndex = 34;
            this.botonSeno.Text = "sin";
            this.botonSeno.UseVisualStyleBackColor = true;
            this.botonSeno.Click += new System.EventHandler(this.botonSeno_Click);
            // 
            // botonCoseno
            // 
            this.botonCoseno.Enabled = false;
            this.botonCoseno.ForeColor = System.Drawing.Color.Fuchsia;
            this.botonCoseno.Location = new System.Drawing.Point(52, 140);
            this.botonCoseno.Name = "botonCoseno";
            this.botonCoseno.Size = new System.Drawing.Size(40, 32);
            this.botonCoseno.TabIndex = 33;
            this.botonCoseno.Text = "cos";
            this.botonCoseno.UseVisualStyleBackColor = true;
            this.botonCoseno.Click += new System.EventHandler(this.botonCoseno_Click);
            // 
            // encendido
            // 
            this.encendido.BackColor = System.Drawing.Color.Red;
            this.encendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encendido.Location = new System.Drawing.Point(6, 65);
            this.encendido.Name = "encendido";
            this.encendido.Size = new System.Drawing.Size(86, 33);
            this.encendido.TabIndex = 30;
            this.encendido.Text = "OFF";
            this.encendido.UseVisualStyleBackColor = false;
            this.encendido.Click += new System.EventHandler(this.encendido_Click);
            // 
            // botonresultado
            // 
            this.botonresultado.Enabled = false;
            this.botonresultado.ForeColor = System.Drawing.Color.Red;
            this.botonresultado.Location = new System.Drawing.Point(278, 178);
            this.botonresultado.Name = "botonresultado";
            this.botonresultado.Size = new System.Drawing.Size(39, 32);
            this.botonresultado.TabIndex = 29;
            this.botonresultado.Text = "=";
            this.botonresultado.UseVisualStyleBackColor = true;
            this.botonresultado.Click += new System.EventHandler(this.botonresultado_Click);
            // 
            // boton1x
            // 
            this.boton1x.Enabled = false;
            this.boton1x.ForeColor = System.Drawing.Color.Fuchsia;
            this.boton1x.Location = new System.Drawing.Point(6, 102);
            this.boton1x.Name = "boton1x";
            this.boton1x.Size = new System.Drawing.Size(40, 32);
            this.boton1x.TabIndex = 28;
            this.boton1x.Text = "X^2";
            this.boton1x.UseVisualStyleBackColor = true;
            this.boton1x.Click += new System.EventHandler(this.boton1x_Click);
            // 
            // botonporcentaje
            // 
            this.botonporcentaje.Enabled = false;
            this.botonporcentaje.ForeColor = System.Drawing.Color.Blue;
            this.botonporcentaje.Location = new System.Drawing.Point(278, 103);
            this.botonporcentaje.Name = "botonporcentaje";
            this.botonporcentaje.Size = new System.Drawing.Size(39, 32);
            this.botonporcentaje.TabIndex = 27;
            this.botonporcentaje.Text = "%";
            this.botonporcentaje.UseVisualStyleBackColor = true;
            this.botonporcentaje.Click += new System.EventHandler(this.botonporcentaje_Click);
            // 
            // botonsumar
            // 
            this.botonsumar.Enabled = false;
            this.botonsumar.ForeColor = System.Drawing.Color.Red;
            this.botonsumar.Location = new System.Drawing.Point(233, 178);
            this.botonsumar.Name = "botonsumar";
            this.botonsumar.Size = new System.Drawing.Size(39, 32);
            this.botonsumar.TabIndex = 26;
            this.botonsumar.Text = "+";
            this.botonsumar.UseVisualStyleBackColor = true;
            this.botonsumar.Click += new System.EventHandler(this.botonsumar_Click);
            // 
            // botonrestar
            // 
            this.botonrestar.Enabled = false;
            this.botonrestar.ForeColor = System.Drawing.Color.Red;
            this.botonrestar.Location = new System.Drawing.Point(233, 141);
            this.botonrestar.Name = "botonrestar";
            this.botonrestar.Size = new System.Drawing.Size(39, 32);
            this.botonrestar.TabIndex = 25;
            this.botonrestar.Text = "-";
            this.botonrestar.UseVisualStyleBackColor = true;
            this.botonrestar.Click += new System.EventHandler(this.botonrestar_Click);
            // 
            // botonmultiplicar
            // 
            this.botonmultiplicar.Enabled = false;
            this.botonmultiplicar.ForeColor = System.Drawing.Color.Red;
            this.botonmultiplicar.Location = new System.Drawing.Point(233, 103);
            this.botonmultiplicar.Name = "botonmultiplicar";
            this.botonmultiplicar.Size = new System.Drawing.Size(39, 32);
            this.botonmultiplicar.TabIndex = 24;
            this.botonmultiplicar.Text = "*";
            this.botonmultiplicar.UseVisualStyleBackColor = true;
            this.botonmultiplicar.Click += new System.EventHandler(this.botonmultiplicar_Click);
            // 
            // botonmasmenos
            // 
            this.botonmasmenos.Enabled = false;
            this.botonmasmenos.ForeColor = System.Drawing.Color.Blue;
            this.botonmasmenos.Location = new System.Drawing.Point(143, 179);
            this.botonmasmenos.Name = "botonmasmenos";
            this.botonmasmenos.Size = new System.Drawing.Size(39, 32);
            this.botonmasmenos.TabIndex = 23;
            this.botonmasmenos.Text = "+/-";
            this.botonmasmenos.UseVisualStyleBackColor = true;
            this.botonmasmenos.Click += new System.EventHandler(this.botonmasmenos_Click);
            // 
            // botoncoma
            // 
            this.botoncoma.Enabled = false;
            this.botoncoma.ForeColor = System.Drawing.Color.Blue;
            this.botoncoma.Location = new System.Drawing.Point(188, 178);
            this.botoncoma.Name = "botoncoma";
            this.botoncoma.Size = new System.Drawing.Size(39, 32);
            this.botoncoma.TabIndex = 22;
            this.botoncoma.Text = ",";
            this.botoncoma.UseVisualStyleBackColor = true;
            this.botoncoma.Click += new System.EventHandler(this.botoncoma_Click);
            // 
            // boton0
            // 
            this.boton0.Enabled = false;
            this.boton0.ForeColor = System.Drawing.Color.Blue;
            this.boton0.Location = new System.Drawing.Point(98, 179);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(39, 32);
            this.boton0.TabIndex = 21;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // boton2
            // 
            this.boton2.Enabled = false;
            this.boton2.ForeColor = System.Drawing.Color.Blue;
            this.boton2.Location = new System.Drawing.Point(143, 142);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(39, 32);
            this.boton2.TabIndex = 20;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Enabled = false;
            this.boton3.ForeColor = System.Drawing.Color.Blue;
            this.boton3.Location = new System.Drawing.Point(188, 141);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(39, 32);
            this.boton3.TabIndex = 19;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton1
            // 
            this.boton1.Enabled = false;
            this.boton1.ForeColor = System.Drawing.Color.Blue;
            this.boton1.Location = new System.Drawing.Point(98, 142);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(39, 32);
            this.boton1.TabIndex = 18;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton5
            // 
            this.boton5.Enabled = false;
            this.boton5.ForeColor = System.Drawing.Color.Blue;
            this.boton5.Location = new System.Drawing.Point(143, 104);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(39, 32);
            this.boton5.TabIndex = 17;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.Enabled = false;
            this.boton6.ForeColor = System.Drawing.Color.Blue;
            this.boton6.Location = new System.Drawing.Point(188, 103);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(39, 32);
            this.boton6.TabIndex = 16;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton4
            // 
            this.boton4.Enabled = false;
            this.boton4.ForeColor = System.Drawing.Color.Blue;
            this.boton4.Location = new System.Drawing.Point(98, 104);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(39, 32);
            this.boton4.TabIndex = 15;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton8
            // 
            this.boton8.Enabled = false;
            this.boton8.ForeColor = System.Drawing.Color.Blue;
            this.boton8.Location = new System.Drawing.Point(143, 66);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(39, 32);
            this.boton8.TabIndex = 14;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Enabled = false;
            this.boton9.ForeColor = System.Drawing.Color.Blue;
            this.boton9.Location = new System.Drawing.Point(188, 65);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(39, 32);
            this.boton9.TabIndex = 13;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // botondividir
            // 
            this.botondividir.Enabled = false;
            this.botondividir.ForeColor = System.Drawing.Color.Red;
            this.botondividir.Location = new System.Drawing.Point(233, 65);
            this.botondividir.Name = "botondividir";
            this.botondividir.Size = new System.Drawing.Size(39, 32);
            this.botondividir.TabIndex = 12;
            this.botondividir.Text = "/";
            this.botondividir.UseVisualStyleBackColor = true;
            this.botondividir.Click += new System.EventHandler(this.botondividir_Click);
            // 
            // botonraiz
            // 
            this.botonraiz.Enabled = false;
            this.botonraiz.ForeColor = System.Drawing.Color.Blue;
            this.botonraiz.Location = new System.Drawing.Point(278, 65);
            this.botonraiz.Name = "botonraiz";
            this.botonraiz.Size = new System.Drawing.Size(39, 32);
            this.botonraiz.TabIndex = 11;
            this.botonraiz.Text = "Sqrt";
            this.botonraiz.UseVisualStyleBackColor = true;
            this.botonraiz.Click += new System.EventHandler(this.botonraiz_Click);
            // 
            // boton7
            // 
            this.boton7.Enabled = false;
            this.boton7.ForeColor = System.Drawing.Color.Blue;
            this.boton7.Location = new System.Drawing.Point(98, 66);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(39, 32);
            this.boton7.TabIndex = 10;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // botonPI
            // 
            this.botonPI.Enabled = false;
            this.botonPI.ForeColor = System.Drawing.Color.Blue;
            this.botonPI.Location = new System.Drawing.Point(278, 140);
            this.botonPI.Name = "botonPI";
            this.botonPI.Size = new System.Drawing.Size(39, 32);
            this.botonPI.TabIndex = 9;
            this.botonPI.Text = "pi";
            this.botonPI.UseVisualStyleBackColor = true;
            this.botonPI.Click += new System.EventHandler(this.botonPI_Click);
            // 
            // botonX3
            // 
            this.botonX3.Enabled = false;
            this.botonX3.ForeColor = System.Drawing.Color.Fuchsia;
            this.botonX3.Location = new System.Drawing.Point(52, 102);
            this.botonX3.Name = "botonX3";
            this.botonX3.Size = new System.Drawing.Size(40, 32);
            this.botonX3.TabIndex = 6;
            this.botonX3.Text = "X^3";
            this.botonX3.UseVisualStyleBackColor = true;
            this.botonX3.Click += new System.EventHandler(this.botonX3_Click);
            // 
            // botonCE
            // 
            this.botonCE.Enabled = false;
            this.botonCE.ForeColor = System.Drawing.Color.Red;
            this.botonCE.Location = new System.Drawing.Point(188, 34);
            this.botonCE.Name = "botonCE";
            this.botonCE.Size = new System.Drawing.Size(84, 25);
            this.botonCE.TabIndex = 3;
            this.botonCE.Text = "CE";
            this.botonCE.UseVisualStyleBackColor = true;
            this.botonCE.Click += new System.EventHandler(this.botonCE_Click);
            // 
            // retroceso
            // 
            this.retroceso.Enabled = false;
            this.retroceso.ForeColor = System.Drawing.Color.Red;
            this.retroceso.Location = new System.Drawing.Point(98, 34);
            this.retroceso.Name = "retroceso";
            this.retroceso.Size = new System.Drawing.Size(84, 26);
            this.retroceso.TabIndex = 2;
            this.retroceso.Text = "Retroceso";
            this.retroceso.UseVisualStyleBackColor = true;
            this.retroceso.Click += new System.EventHandler(this.retroceso_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(6, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(311, 25);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 246);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button botonX3;
        private System.Windows.Forms.Button botonCE;
        private System.Windows.Forms.Button retroceso;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button botondividir;
        private System.Windows.Forms.Button botonraiz;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button botonPI;
        private System.Windows.Forms.Button botonresultado;
        private System.Windows.Forms.Button boton1x;
        private System.Windows.Forms.Button botonporcentaje;
        private System.Windows.Forms.Button botonsumar;
        private System.Windows.Forms.Button botonrestar;
        private System.Windows.Forms.Button botonmultiplicar;
        private System.Windows.Forms.Button botonmasmenos;
        private System.Windows.Forms.Button botoncoma;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button encendido;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button botonTangente;
        private System.Windows.Forms.Button botonSeno;
        private System.Windows.Forms.Button botonCoseno;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.Button botonMR;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

