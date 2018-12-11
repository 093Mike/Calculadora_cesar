using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Calculadora : Form {
        //Variables para redimesionar del Form1.
        private float ampladaOriginal, alturaOriginal;
        Control[] listControls;
        float[] ampladasOriginales;
        float[] alturasOriginales;
        int[] posx;
        int[] posy;

        //Variables para la calculadora.
        String recordarOperante;
        Boolean mostrarResultado;
        Boolean cambioDeOperante;
        Boolean esCero;
        Boolean hayComa;
        Boolean operadoConUn;
        Boolean error;

        //Variables para el Form3 (Configuracion)
        Configuracio adios;
        RadioButton[] listRadios;
        ComboBox[] listCombos;
        //Para opciones SI/NO
        static Boolean[] radios;
        //Para con multiples opciones
        static int[] combo;
        //Para los Strings (TextBox)
        static String[] textsBoxs;
        //Para los campos numericos
        static int[] limites;

        public Calculadora() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
             adios = new Configuracio();
            // Variables del Resize PARA LOS BOTONES del Form y la fuente de ellas
            //Empieza por el Resize
            ampladaOriginal = ClientSize.Width;
            alturaOriginal = ClientSize.Height;
            listControls = new Control[] {pantalla,numero0, numero1, numero2, numero3, numero4, numero5, numero6,
            numero7, numero8, numero9, sumar,resta,dividir,multi,igual,Mitad,raiz,Borrar,Borratodo,coma,
            expotencial, porcent,posneg,etiqueta1,valor2,operante};

            ampladasOriginales = new float[listControls.Length];
            alturasOriginales = new float[listControls.Length];
            posx = new int[listControls.Length];
            posy = new int[listControls.Length];

            for (int i = 0; i < listControls.Length; i++) {
                // RESIZE
                ampladasOriginales[i] = listControls[i].Width;
                alturasOriginales[i] = listControls[i].Height;
                posx[i] = listControls[i].Location.X;
                posy[i] = listControls[i].Location.Y;
                // FONT
                if (i < 24){listControls[i].Font = new Font("Ubuntu Titling 2 Rg", 12, FontStyle.Regular);}
                else { listControls[i].Font = new Font("White Rabbit", 12, FontStyle.Regular); }
            }

            //Variables para la calculadora.
            cambioDeOperante = false;
            recordarOperante = "";
            esCero = true;
            hayComa = false;
            mostrarResultado = false;
            error = false;

            //Variables para Form 3
            radios = new Boolean[18];
            listRadios = new RadioButton[] { adios.radio1, adios.radio2, adios.radio3, adios.radio4, adios.radio5, adios.radio6,
            adios.radio7, adios.radio8, adios.radio1_9, adios.radio1_10, adios.radio11,adios.radio12,adios.radio13,adios.radio14,
            adios.radio15,adios.radio16,adios.radio17,adios.radio18};
            combo = new int[7];
            listCombos = new ComboBox[] { adios.Combo1_1,adios.Combo1_2,adios.Combo1_3,adios.Combo2_1,
            adios.comboBox3,adios.comboBox4, adios.comboBox5};

            textsBoxs = new string[2];
            limites = new int[3];

            for (int i = 0; i < radios.Length; i++) { radios[i] = true; }
            for (int i = 0; i < combo.Length; i++){ combo[i] = 0; }
            //Metodos
            CuandoEsCero_Error();

        }

        //Metodo para cada vez que se modifique la mida del formulario.
        private void Form1_Resize(object sender, EventArgs e) {
            for (int i = 0; i < listControls.Length; i++){
                Control control = listControls[i];
                float x = ClientSize.Width / ampladaOriginal * posx[i];
                float y = ClientSize.Height / alturaOriginal * posy[i];
                float am = ClientSize.Width / ampladaOriginal * ampladasOriginales[i];
                float ah = ClientSize.Height / alturaOriginal * alturasOriginales[i];
                control.Location = new Point((int)x, (int)y);
                control.Size = new Size((int)am, (int)ah);
            } 
        }

        //CALCULADORA - METODO GENERAL.
        //En este metodo pasan todos los parametros, sea un numero o operación.
        private void MetodoCalc(String parametro, Boolean borrartodo) {
            //Antes de ejecutar lo de dentro del metodo, controlaremos un error.
            if (error==true) {
                if (parametro.Equals("0")){esCero = true;}
                else{ esCero = false;}
                error = false;
                CuandoEsCero_Error();
            }
            //Variable unica para el metodo.
            //Para el resultado total.
            double resultat = 0;

            //Se empiezan por las operaciones.
            //Operaciones que necesitan dos numeros para calcular:
            if (parametro.Equals("+") || parametro.Equals("-") || parametro.Equals("*") || parametro.Equals("÷") || parametro.Equals("^") || parametro.Equals("%"))
            {
                //Si no se recuerda ninguna operacion anterior, hacemos una operacion.
                if (mostrarResultado == false){
                    OperacionsAmbDosNumeros(parametro,resultat);
                    etiqueta1.Text = valor2.Text;
                }
                //Si se muestra un resultado, pero no pulsa un numero y cambia de operante.
                else if (mostrarResultado == true && !operante.Text.Equals(" ")){
                    recordarOperante = parametro;
                    operante.Text = parametro;
                }
                //Ninguna de las condiciones anteriores son ciertas.
                else {
                    etiqueta1.Text = "0";
                    esCero = true;
                }
                coma.Enabled = true;
                hayComa = false;
                mostrarResultado = true;
            }

            // Operaciones que se calculan un valor
            else if (parametro.Equals("1/") || parametro.Equals("v")){
                //Se va operar la operacion con solo un valor.
                //No importa que se este operando algo o no; se controlara dentro del
                //metodo o mas adelante.
                if (esCero == false){
                    if (mostrarResultado == false || operadoConUn == false){
                        OperacionsAmbUnNumero(parametro, resultat);
                    }
                    coma.Enabled = true;
                    hayComa = false;
                    esCero = false;
                }
                //Controlamos errores:
                //En caso de que se este operando algo y no hay una operación pendiente.
                else {
                    etiqueta1.Text = this.valor2.Text;
                    valor2.Text = " ";
                    operante.Text = " ";
                    OperacionsAmbUnNumero(parametro, resultat);
                    esCero = false;
                }
            }
            //Si el parametro es +/-, lo cambia al negativo.
            else if (parametro.Equals("+/-")) {
                if (mostrarResultado == true) {
                    etiqueta1.Text = "0";
                    esCero = true;
                    mostrarResultado = false;
                }
                double valor = double.Parse(etiqueta1.Text);
                if (valor!=0) { resultat = valor * -1; }
                etiqueta1.Text = resultat.ToString();
            }

            //Asignar y meter numeros para operar
            else AfegirNumeros(parametro, borrartodo);
            //Control de Cero y de Errores
            CuandoEsCero_Error();
            parametro = "";
        }
        //Metodo de para las operaciones con dos valores
        private void OperacionsAmbDosNumeros(String parametro, double resultat) {
            //Cogemos el numero de la "Etiqueta1"
            double valor2 = double.Parse(etiqueta1.Text);
            //Si es la primera vez que hacemos una operacion, recordaremos la operacion 
            //que quiere hacer.
            if (operante.Text.Equals(" ")) { recordarOperante = parametro; }
            //Mostramos la operacion en pantalla.
            operante.Text = parametro;

            //Label 3 si esta vacio.
            if (this.valor2.Text.Equals(" "))
            {
                this.valor2.Text = etiqueta1.Text;
                etiqueta1.Text = "0";
                esCero = true;
            }
            //Si label 3 esta rellenado con un numero.
            else
            {
                double valor1 = double.Parse(this.valor2.Text);
                //Si tenemos una operacion pendiente por hacer, realizaremos la operacion 
                //antes de hacer una nueva, pero debemos de comprobar si es cero o no.
                if (esCero == false) {
                    resultat = Operar(recordarOperante, valor2, valor1, resultat);
                    cambioDeOperante = true;
                }
                //Cambiaremos lo que hemos recordado antes con la operacion actual.
                recordarOperante = parametro;
                //Si hemos hecho un cambio de operante, es decir, teniamos una operacion
                //pendiente por hacer y cambia de una + por una -, no realizaremos ninguna
                //operacion, ya que haria una innecesaria operacion de 
                //[resultado] - 0, o a las malas, [valor1] - [valor2].
                //Controlaremos un cambio en la operante.
                if (cambioDeOperante == false){
                    resultat = Operar(parametro, valor2, valor1, resultat);
                }
                if (error == false)
                {
                    recordarOperante = parametro;
                    this.valor2.Text = resultat.ToString();
                }
                esCero = true;
                cambioDeOperante = false;
            }
        }
        //Metodo para operaciones con solo un valor.
        private void OperacionsAmbUnNumero(String parametro, Double resultat) { 
            if (esCero == false){
                double valor = double.Parse(etiqueta1.Text);
                //Hay que comprobar si hay una operacion
                //que se esta realizado actualmente. Llamamos al metodo 
                //"OperacionsDosNumeros", comprobando si hay un numero en "VALOR2"
                if (!valor2.Text.Equals(" ")){
                    OperacionsAmbDosNumeros(null, resultat);
                    esCero = false;
                    etiqueta1.Text = valor2.Text;
                    valor = double.Parse(valor2.Text);
                    valor2.Text = " ";
                    operante.Text = " ";
                }
                //Una vez controlado lo anterior, hacermos las operaciones.
                if (parametro.Equals("1/")) { resultat = 1 / valor; }
                if (parametro.Equals("v")) { resultat = Math.Sqrt(valor); }

                if (error == false){
                    etiqueta1.Text = resultat.ToString();
                }
            }
            else {
                    error = true;
                    etiqueta1.Text = "ERROR MATEMATIC";
            }
            operadoConUn = true;

        }

        private void OperarCalc(String parametro){
            if (mostrarResultado == true) { etiqueta1.Text = "0"; }
            //En caso de que el usuario le de al boton "=", los calculos se hacen aqui.
            if (!etiqueta1.Equals("0") && !valor2.Equals(" ") && esCero == false)
            {
                double resultat = 0;
                double valor1 = double.Parse(this.valor2.Text);
                double valor2 = double.Parse(etiqueta1.Text);
                resultat = Operar(parametro, valor2, valor1, resultat);

                if (error == false){etiqueta1.Text = resultat.ToString();}
                else { CuandoEsCero_Error(); }
                this.valor2.Text = " ";
                operante.Text = " ";
                esCero = true;
            }
        }
        private double Operar(String parametro, double valor2,double valor1, double resultat) {
            switch (parametro){
                case "+":
                    resultat = valor1 + valor2;
                    break;
                case "-":
                    resultat = valor1 - valor2;
                    break;
                case "*":
                    resultat = valor1 * valor2;
                    break;
                case "÷":
                    if (valor2 != 0){
                        resultat = valor1 / valor2;
                    }
                    else{
                        etiqueta1.Text = "ERROR MATEMATIC";
                        esCero = true;
                    }
                    break;
                case "^":
                    resultat = Math.Pow(valor2, valor1);
                    break;
                case "%":
                    if (valor2 != 0) { resultat = (valor1 * valor2) / 100; }
                    else{
                        etiqueta1.Text = "ERROR MATEMATIC";
                        esCero = true;
                        error = true;
                    }
                    break;
            }
            return resultat;
        }

        private void AfegirNumeros(String parametro , Boolean borrartodo) {
            //Metodo Borrar Numeros
            if (borrartodo == true) { MetodoBorrar(parametro); }
            else {
                //En el caso de que se este recordando un resultado que solo 
                //hizo falta un valor.
                if (operadoConUn == true){
                    mostrarResultado = true;
                    operadoConUn = false;
                }

                //Metodo de añadir numeros
                if (mostrarResultado == false) {
                    if (esCero == true && borrartodo == false && !parametro.Equals("0")) {
                        //Para las comas.
                        if (parametro.Equals(",")) {
                            if (esCero == true) {
                                etiqueta1.Text = "0";
                                esCero = false;
                                etiqueta1.Text += parametro;

                            }
                            else etiqueta1.Text += parametro;

                        }
                        //Cuando es 0, cambiamos el numero.
                        else {
                            etiqueta1.Text = parametro;
                            esCero = false;
                            mostrarResultado = false;
                        }

                    }
                    // Cuando tenemos mas numeros
                    else {
                        if (parametro.Equals("0") && esCero == true){
                            esCero = true;
                            etiqueta1.Text = parametro;
                        }
                        else{
                            etiqueta1.Text += parametro;
                            esCero = false;
                        }

                    }
                }
                //Cuando estamos recordando algo.
                else{
                    //Si añadimos una coma.
                    if (parametro.Equals(",")) {
                        etiqueta1.Text = "0,";
                        hayComa = true;
                        coma.Enabled = false;

                    }
                    //Cuando añadimos un nuevo valor
                    else if (borrartodo == false) {
                        etiqueta1.Text = parametro;
                        if (parametro.Equals("0") && esCero == true) { esCero = true; }
                        else { esCero = false; }

                    }
                    mostrarResultado = false;
                    operadoConUn = false;
                }
            }
        }

        private void MetodoBorrar(String parametro) {
            //Boton AC
            if (parametro.Equals("0")) {
                etiqueta1.Text = parametro;
                valor2.Text = " ";
                operante.Text = " ";
                esCero = true;
                coma.Enabled = true;
                hayComa = false;
                mostrarResultado = false;
            }
            //Boton C
            else if (parametro.Equals("1")){
                if (mostrarResultado == true){
                    etiqueta1.Text = "0";
                    mostrarResultado = false;
                }
                String numeros = etiqueta1.Text;
                String comprovarComa = numeros.Substring(numeros.Length - 1, 1);

                if (comprovarComa.Equals(",")) {
                    hayComa = false;
                    coma.Enabled = true;
                    if (numeros.Equals("0,")) {esCero = true;}
                }
                numeros = numeros.Remove(numeros.Length - 1);
                etiqueta1.Text = numeros;
                if (numeros.Length == 0){
                    etiqueta1.Text = "0";
                    esCero = true;
                }
            }
            error = false;
            CuandoEsCero_Error();
        }
        

        //Gestiona las variables "esCero" y "error".
        private void CuandoEsCero_Error() {
            if (error == true){
                for (int i = 0; i < listControls.Length; i++){
                    if (i >= 11 && i < 24) {
                        if (i == 19) { listControls[i].Enabled = true; }
                        else {listControls[i].Enabled = false;}
                    }
                }
                esCero = true;
            }
            else if (error == false){
                for (int i = 0; i < listControls.Length; i++){
                    if (i >= 11 && i < 24){listControls[i].Enabled = true;}
                }
                if (hayComa == true) {
                    coma.Enabled = false;
                }
            }

            if (esCero == true) {
                Borrar.Enabled = false;
                numero0.Enabled = false;
            }
            else {
                Borrar.Enabled = true;
                numero0.Enabled = true;
            }
            
        }

        // Botones haciendo click
        private void Numero0_Click(object sender, EventArgs e) { MetodoCalc("0", false); }
        private void Numero1_Click(object sender, EventArgs e) { MetodoCalc("1", false); }
        private void Numero2_Click_1(object sender, EventArgs e) { MetodoCalc("2", false); }
        private void Numero3_Click(object sender, EventArgs e) { MetodoCalc("3", false); }
        private void Numero4_Click(object sender, EventArgs e) { MetodoCalc("4", false); }
        private void Numero5_Click(object sender, EventArgs e) { MetodoCalc("5", false); }
        private void Numero6_Click(object sender, EventArgs e) { MetodoCalc("6", false); }
        private void Numero7_Click(object sender, EventArgs e) { MetodoCalc("7", false); }
        private void Numero8_Click(object sender, EventArgs e) { MetodoCalc("8", false); }
        private void Numero9_Click(object sender, EventArgs e) { MetodoCalc("9", false); }
        private void Borrar_Click(object sender, EventArgs e) { MetodoCalc("1", true); }
        private void Borratodo_Click(object sender, EventArgs e) { MetodoCalc("0", true); }
        private void Sumar_Click(object sender, EventArgs e) { MetodoCalc("+", false); }
        private void Resta_Click(object sender, EventArgs e) { MetodoCalc("-", false); }
        private void Multi_Click(object sender, EventArgs e) { MetodoCalc("*", false); }
        private void Dividir_Click(object sender, EventArgs e) { MetodoCalc("÷", false); }
        private void Mitad_Click(object sender, EventArgs e) { MetodoCalc("1/", false); }
        private void Raiz_Click(object sender, EventArgs e){ MetodoCalc("v", false); }
        private void Expotencial_Click(object sender, EventArgs e) { MetodoCalc("^", false); }
        private void Igual_Click(object sender, EventArgs e) { OperarCalc(operante.Text);}
        private void Coma_Click(object sender, EventArgs e){
            if (hayComa == false){
                MetodoCalc(",", false);
                hayComa = true;
                coma.Enabled = false;
            }
        }
        private void posneg_Click(object sender, EventArgs e){MetodoCalc("+/-", false);}
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Barra superior:
            if (e.KeyCode == Keys.F1) { APropositDeToolStripMenuItem_Click(null, null); }
            if (e.KeyCode == Keys.X && e.Alt){apagatToolStripMenuItem_Click(null, null);}
            if (e.KeyCode == Keys.Q && e.Control) { ConfiguracioToolStripMenuItem_Click(null, null); }

            //Numeros i numeros de teclat numeric

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0){ MetodoCalc("0", false);}
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1){ MetodoCalc("1", false);}
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2){ MetodoCalc("2", false);}
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3){ MetodoCalc("3", false);}
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4){ MetodoCalc("4", false);}
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5){ MetodoCalc("5", false);}
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6){ MetodoCalc("6", false);}
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7){ MetodoCalc("7", false);}
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8){ MetodoCalc("8", false);}
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9){ MetodoCalc("9", false);}

            //Operacions basiques.
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) { MetodoCalc("+", false);}
            if (e.KeyCode == Keys.Subtract) { MetodoCalc("-", false);}
            if (e.KeyCode == Keys.Multiply) { MetodoCalc("*", false);}
            if (e.KeyCode == Keys.Divide) { MetodoCalc("÷", false);}
            if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma) {
                if (hayComa == false) {
                    MetodoCalc(",", false);
                    hayComa = true;
                    coma.Enabled = false;
                }

            }
            //Boto enter
            if (e.KeyCode == Keys.Return) {
            }
            // Botons borrar
            if (e.KeyCode == Keys.Escape) { MetodoCalc("0", true);}
            if (e.KeyCode == Keys.Back) { MetodoCalc("1", true);}

        }
        private void Calculadora_Enter(object sender, EventArgs e)
        {
            OperarCalc(recordarOperante);
        }
        private void porcent_Click(object sender, EventArgs e){MetodoCalc("%", false);}
        private void Igual_Enter(object sender, EventArgs e){
            //OperarCalc
        }

        //BARRA SUPERIOR
        private void ConfiguracioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Radios
            for (int i = 0; i < listRadios.Length; i++){
                    if (radios[i] == true){listRadios[i].Checked = true;}
                    else{listRadios[i].Checked = false;}
            }
            for (int i = 0; i < listCombos.Length; i++) { listCombos[i].SelectedIndex = combo[i]; }

            adios.ShowDialog();
            components_Form3();

        }
        private void components_Form3() {
            for (int i = 0; i < listRadios.Length; i++)
            {
                if (listRadios[i].Checked == true) { radios[i] = true; }
                else { radios[i] = false; }
            }
            for (int i = 0; i < listCombos.Length; i++) { combo[i] = listCombos[i].SelectedIndex; }

        }

        private void APropositDeToolStripMenuItem_Click(object sender, EventArgs e){
            Form2 hola = new Form2();
            hola.ShowDialog();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) { MetodoBorrar("0"); }


        private void apagatToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }
    }
}
