namespace WindowsFormsApp4
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.numero1 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPropositDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalla = new System.Windows.Forms.Panel();
            this.valor2 = new System.Windows.Forms.Label();
            this.operante = new System.Windows.Forms.Label();
            this.etiqueta1 = new System.Windows.Forms.Label();
            this.igual = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.numero0 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.numero8 = new System.Windows.Forms.Button();
            this.numero9 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.numero7 = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.expotencial = new System.Windows.Forms.Button();
            this.Mitad = new System.Windows.Forms.Button();
            this.porcent = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.posneg = new System.Windows.Forms.Button();
            this.Borratodo = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pantalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.AllowDrop = true;
            resources.ApplyResources(this.numero1, "numero1");
            this.numero1.Name = "numero1";
            this.numero1.UseVisualStyleBackColor = true;
            this.numero1.Click += new System.EventHandler(this.Numero1_Click);
            // 
            // numero2
            // 
            this.numero2.AllowDrop = true;
            resources.ApplyResources(this.numero2, "numero2");
            this.numero2.Name = "numero2";
            this.numero2.UseVisualStyleBackColor = true;
            this.numero2.Click += new System.EventHandler(this.Numero2_Click_1);
            // 
            // numero3
            // 
            this.numero3.AllowDrop = true;
            resources.ApplyResources(this.numero3, "numero3");
            this.numero3.Name = "numero3";
            this.numero3.UseVisualStyleBackColor = true;
            this.numero3.Click += new System.EventHandler(this.Numero3_Click);
            // 
            // sumar
            // 
            this.sumar.AllowDrop = true;
            resources.ApplyResources(this.sumar, "sumar");
            this.sumar.Name = "sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionsToolStripMenuItem,
            this.einesToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // accionsToolStripMenuItem
            // 
            this.accionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.apagatToolStripMenuItem});
            this.accionsToolStripMenuItem.Name = "accionsToolStripMenuItem";
            resources.ApplyResources(this.accionsToolStripMenuItem, "accionsToolStripMenuItem");
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // apagatToolStripMenuItem
            // 
            resources.ApplyResources(this.apagatToolStripMenuItem, "apagatToolStripMenuItem");
            this.apagatToolStripMenuItem.Name = "apagatToolStripMenuItem";
            this.apagatToolStripMenuItem.Click += new System.EventHandler(this.apagatToolStripMenuItem_Click);
            // 
            // einesToolStripMenuItem
            // 
            this.einesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracioToolStripMenuItem,
            this.aPropositDeToolStripMenuItem});
            this.einesToolStripMenuItem.Name = "einesToolStripMenuItem";
            resources.ApplyResources(this.einesToolStripMenuItem, "einesToolStripMenuItem");
            // 
            // configuracioToolStripMenuItem
            // 
            resources.ApplyResources(this.configuracioToolStripMenuItem, "configuracioToolStripMenuItem");
            this.configuracioToolStripMenuItem.Name = "configuracioToolStripMenuItem";
            this.configuracioToolStripMenuItem.Click += new System.EventHandler(this.ConfiguracioToolStripMenuItem_Click);
            // 
            // aPropositDeToolStripMenuItem
            // 
            resources.ApplyResources(this.aPropositDeToolStripMenuItem, "aPropositDeToolStripMenuItem");
            this.aPropositDeToolStripMenuItem.Name = "aPropositDeToolStripMenuItem";
            this.aPropositDeToolStripMenuItem.Click += new System.EventHandler(this.APropositDeToolStripMenuItem_Click);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.pantalla.Controls.Add(this.valor2);
            this.pantalla.Controls.Add(this.operante);
            this.pantalla.Controls.Add(this.etiqueta1);
            resources.ApplyResources(this.pantalla, "pantalla");
            this.pantalla.Name = "pantalla";
            // 
            // valor2
            // 
            resources.ApplyResources(this.valor2, "valor2");
            this.valor2.Name = "valor2";
            // 
            // operante
            // 
            resources.ApplyResources(this.operante, "operante");
            this.operante.Name = "operante";
            // 
            // etiqueta1
            // 
            resources.ApplyResources(this.etiqueta1, "etiqueta1");
            this.etiqueta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(142)))));
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.UseMnemonic = false;
            // 
            // igual
            // 
            this.igual.AllowDrop = true;
            resources.ApplyResources(this.igual, "igual");
            this.igual.Name = "igual";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.Igual_Click);
            this.igual.Enter += new System.EventHandler(this.Igual_Enter);
            // 
            // coma
            // 
            this.coma.AllowDrop = true;
            resources.ApplyResources(this.coma, "coma");
            this.coma.Name = "coma";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.Coma_Click);
            // 
            // numero0
            // 
            this.numero0.AllowDrop = true;
            resources.ApplyResources(this.numero0, "numero0");
            this.numero0.Name = "numero0";
            this.numero0.UseVisualStyleBackColor = true;
            this.numero0.Click += new System.EventHandler(this.Numero0_Click);
            // 
            // numero4
            // 
            this.numero4.AllowDrop = true;
            resources.ApplyResources(this.numero4, "numero4");
            this.numero4.Name = "numero4";
            this.numero4.UseVisualStyleBackColor = true;
            this.numero4.Click += new System.EventHandler(this.Numero4_Click);
            // 
            // numero5
            // 
            this.numero5.AllowDrop = true;
            resources.ApplyResources(this.numero5, "numero5");
            this.numero5.Name = "numero5";
            this.numero5.UseVisualStyleBackColor = true;
            this.numero5.Click += new System.EventHandler(this.Numero5_Click);
            // 
            // numero6
            // 
            this.numero6.AllowDrop = true;
            resources.ApplyResources(this.numero6, "numero6");
            this.numero6.Name = "numero6";
            this.numero6.UseVisualStyleBackColor = true;
            this.numero6.Click += new System.EventHandler(this.Numero6_Click);
            // 
            // resta
            // 
            this.resta.AllowDrop = true;
            resources.ApplyResources(this.resta, "resta");
            this.resta.Name = "resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // numero8
            // 
            this.numero8.AllowDrop = true;
            resources.ApplyResources(this.numero8, "numero8");
            this.numero8.Name = "numero8";
            this.numero8.UseVisualStyleBackColor = true;
            this.numero8.Click += new System.EventHandler(this.Numero8_Click);
            // 
            // numero9
            // 
            this.numero9.AllowDrop = true;
            resources.ApplyResources(this.numero9, "numero9");
            this.numero9.Name = "numero9";
            this.numero9.UseVisualStyleBackColor = true;
            this.numero9.Click += new System.EventHandler(this.Numero9_Click);
            // 
            // multi
            // 
            this.multi.AllowDrop = true;
            resources.ApplyResources(this.multi, "multi");
            this.multi.Name = "multi";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // numero7
            // 
            this.numero7.AllowDrop = true;
            resources.ApplyResources(this.numero7, "numero7");
            this.numero7.Name = "numero7";
            this.numero7.UseVisualStyleBackColor = true;
            this.numero7.Click += new System.EventHandler(this.Numero7_Click);
            // 
            // raiz
            // 
            this.raiz.AllowDrop = true;
            resources.ApplyResources(this.raiz, "raiz");
            this.raiz.Name = "raiz";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // expotencial
            // 
            this.expotencial.AllowDrop = true;
            resources.ApplyResources(this.expotencial, "expotencial");
            this.expotencial.Name = "expotencial";
            this.expotencial.UseVisualStyleBackColor = true;
            this.expotencial.Click += new System.EventHandler(this.Expotencial_Click);
            // 
            // Mitad
            // 
            this.Mitad.AllowDrop = true;
            resources.ApplyResources(this.Mitad, "Mitad");
            this.Mitad.Name = "Mitad";
            this.Mitad.UseVisualStyleBackColor = true;
            this.Mitad.Click += new System.EventHandler(this.Mitad_Click);
            // 
            // porcent
            // 
            this.porcent.AllowDrop = true;
            resources.ApplyResources(this.porcent, "porcent");
            this.porcent.Name = "porcent";
            this.porcent.UseVisualStyleBackColor = true;
            this.porcent.Click += new System.EventHandler(this.porcent_Click);
            // 
            // Borrar
            // 
            this.Borrar.AllowDrop = true;
            resources.ApplyResources(this.Borrar, "Borrar");
            this.Borrar.Name = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // posneg
            // 
            this.posneg.AllowDrop = true;
            resources.ApplyResources(this.posneg, "posneg");
            this.posneg.Name = "posneg";
            this.posneg.UseVisualStyleBackColor = true;
            this.posneg.Click += new System.EventHandler(this.posneg_Click);
            // 
            // Borratodo
            // 
            this.Borratodo.AllowDrop = true;
            resources.ApplyResources(this.Borratodo, "Borratodo");
            this.Borratodo.Name = "Borratodo";
            this.Borratodo.UseVisualStyleBackColor = true;
            this.Borratodo.Click += new System.EventHandler(this.Borratodo_Click);
            // 
            // dividir
            // 
            this.dividir.AllowDrop = true;
            resources.ApplyResources(this.dividir, "dividir");
            this.dividir.Name = "dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Calculadora
            // 
            this.AcceptButton = this.igual;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.coma);
            this.Controls.Add(this.Borratodo);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.posneg);
            this.Controls.Add(this.Mitad);
            this.Controls.Add(this.porcent);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.expotencial);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.numero9);
            this.Controls.Add(this.numero8);
            this.Controls.Add(this.numero7);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Calculadora_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pantalla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button numero1;
        private System.Windows.Forms.Button numero2;
        private System.Windows.Forms.Button numero3;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einesToolStripMenuItem;
        private System.Windows.Forms.Panel pantalla;
        private System.Windows.Forms.Label etiqueta1;
        private System.Windows.Forms.ToolStripMenuItem configuracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPropositDeToolStripMenuItem;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button numero0;
        private System.Windows.Forms.Button numero4;
        private System.Windows.Forms.Button numero5;
        private System.Windows.Forms.Button numero6;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button numero8;
        private System.Windows.Forms.Button numero9;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button numero7;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button expotencial;
        private System.Windows.Forms.Button Mitad;
        private System.Windows.Forms.Button porcent;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button posneg;
        private System.Windows.Forms.Button Borratodo;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Label valor2;
        private System.Windows.Forms.Label operante;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagatToolStripMenuItem;
    }
}

