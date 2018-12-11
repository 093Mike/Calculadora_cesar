namespace WindowsFormsApp4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fondo1 = new System.Windows.Forms.Panel();
            this.etiqueta2 = new System.Windows.Forms.Label();
            this.etiqueta1 = new System.Windows.Forms.Label();
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.etiqueta3 = new System.Windows.Forms.Label();
            this.etiqueta5 = new System.Windows.Forms.Label();
            this.casilla1 = new System.Windows.Forms.CheckBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.etiqueta6 = new System.Windows.Forms.Label();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.fondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo1
            // 
            this.fondo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fondo1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fondo1.Controls.Add(this.etiqueta2);
            this.fondo1.Controls.Add(this.etiqueta1);
            this.fondo1.Controls.Add(this.foto1);
            this.fondo1.Location = new System.Drawing.Point(-4, 0);
            this.fondo1.Name = "fondo1";
            this.fondo1.Size = new System.Drawing.Size(485, 147);
            this.fondo1.TabIndex = 1;
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(20, 51);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(102, 18);
            this.etiqueta2.TabIndex = 1;
            this.etiqueta2.Text = "Versión 2.33";
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(16, 9);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etiqueta1.Size = new System.Drawing.Size(197, 42);
            this.etiqueta1.TabIndex = 0;
            this.etiqueta1.Text = "Calculadora";
            // 
            // foto1
            // 
            this.foto1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.foto1.Image = ((System.Drawing.Image)(resources.GetObject("foto1.Image")));
            this.foto1.Location = new System.Drawing.Point(343, 7);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(133, 133);
            this.foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto1.TabIndex = 2;
            this.foto1.TabStop = false;
            // 
            // etiqueta3
            // 
            this.etiqueta3.AutoSize = true;
            this.etiqueta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta3.Location = new System.Drawing.Point(16, 158);
            this.etiqueta3.Name = "etiqueta3";
            this.etiqueta3.Size = new System.Drawing.Size(183, 15);
            this.etiqueta3.TabIndex = 2;
            this.etiqueta3.Text = "Copyrigth © 2018 Omega Studio";
            // 
            // etiqueta5
            // 
            this.etiqueta5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etiqueta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta5.Location = new System.Drawing.Point(16, 173);
            this.etiqueta5.Name = "etiqueta5";
            this.etiqueta5.Size = new System.Drawing.Size(442, 46);
            this.etiqueta5.TabIndex = 3;
            this.etiqueta5.Text = "Aquesta calculadora, feta per la empresa OMEGA Studio, a sigut realitzat amb el p" +
    "rograma Visual Studio de Microsoft. ";
            // 
            // casilla1
            // 
            this.casilla1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.casilla1.AutoSize = true;
            this.casilla1.Location = new System.Drawing.Point(16, 413);
            this.casilla1.Name = "casilla1";
            this.casilla1.Size = new System.Drawing.Size(159, 17);
            this.casilla1.TabIndex = 5;
            this.casilla1.Text = "El programa esta actualitzat.";
            this.casilla1.UseVisualStyleBackColor = true;
            this.casilla1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // boton1
            // 
            this.boton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boton1.Location = new System.Drawing.Point(383, 413);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 25);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "Tancar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiqueta6
            // 
            this.etiqueta6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.etiqueta6.AutoSize = true;
            this.etiqueta6.Location = new System.Drawing.Point(13, 387);
            this.etiqueta6.Name = "etiqueta6";
            this.etiqueta6.Size = new System.Drawing.Size(148, 13);
            this.etiqueta6.TabIndex = 7;
            this.etiqueta6.Text = "Troba la lliçencia de privacitat";
            // 
            // link1
            // 
            this.link1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.link1.AutoSize = true;
            this.link1.Location = new System.Drawing.Point(165, 387);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(74, 13);
            this.link1.TabIndex = 8;
            this.link1.TabStop = true;
            this.link1.Text = "Fes click aquí";
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // texto1
            // 
            this.texto1.AllowDrop = true;
            this.texto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texto1.Location = new System.Drawing.Point(16, 222);
            this.texto1.Multiline = true;
            this.texto1.Name = "texto1";
            this.texto1.ReadOnly = true;
            this.texto1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texto1.Size = new System.Drawing.Size(443, 153);
            this.texto1.TabIndex = 9;
            this.texto1.Text = resources.GetString("texto1.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boton1;
            this.ClientSize = new System.Drawing.Size(471, 448);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.etiqueta6);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.casilla1);
            this.Controls.Add(this.etiqueta5);
            this.Controls.Add(this.etiqueta3);
            this.Controls.Add(this.fondo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 372);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A proposit de";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.fondo1.ResumeLayout(false);
            this.fondo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel fondo1;
        private System.Windows.Forms.Label etiqueta3;
        private System.Windows.Forms.Label etiqueta5;
        private System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.Label etiqueta2;
        private System.Windows.Forms.Label etiqueta1;
        private System.Windows.Forms.CheckBox casilla1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label etiqueta6;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.TextBox texto1;
    }
}