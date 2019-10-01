namespace Algoritmos
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ejercicio01 = new System.Windows.Forms.TabPage();
            this.txt_ordenado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ejercicio02 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_time_2 = new System.Windows.Forms.Label();
            this.elementos_agregados = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.txt_vector = new System.Windows.Forms.Label();
            this.btn_agregar_elemento = new System.Windows.Forms.Button();
            this.btn_crear_vector = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_time_3 = new System.Windows.Forms.Label();
            this.elementos_ordenados = new System.Windows.Forms.Label();
            this.btn_ordenar_03 = new System.Windows.Forms.Button();
            this.elementos_normales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_crear_asignar_03 = new System.Windows.Forms.Button();
            this.tx_tam = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.valor_numero_vector = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.elementos_vector_04 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_merge = new System.Windows.Forms.Label();
            this.txt_quiq = new System.Windows.Forms.Label();
            this.txt_shell = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tiempo_mergesort = new System.Windows.Forms.Label();
            this.tiempo_quiq = new System.Windows.Forms.Label();
            this.tiempo_shell = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Ejercicio01.SuspendLayout();
            this.Ejercicio02.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ejercicio01);
            this.tabControl1.Controls.Add(this.Ejercicio02);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // Ejercicio01
            // 
            this.Ejercicio01.Controls.Add(this.txt_ordenado);
            this.Ejercicio01.Controls.Add(this.label4);
            this.Ejercicio01.Controls.Add(this.button1);
            this.Ejercicio01.Controls.Add(this.txt_tiempo);
            this.Ejercicio01.Controls.Add(this.label2);
            this.Ejercicio01.Location = new System.Drawing.Point(4, 22);
            this.Ejercicio01.Name = "Ejercicio01";
            this.Ejercicio01.Padding = new System.Windows.Forms.Padding(3);
            this.Ejercicio01.Size = new System.Drawing.Size(742, 322);
            this.Ejercicio01.TabIndex = 0;
            this.Ejercicio01.Text = "Ejercicio01";
            this.Ejercicio01.UseVisualStyleBackColor = true;
            // 
            // txt_ordenado
            // 
            this.txt_ordenado.AutoSize = true;
            this.txt_ordenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ordenado.Location = new System.Drawing.Point(99, 181);
            this.txt_ordenado.Name = "txt_ordenado";
            this.txt_ordenado.Size = new System.Drawing.Size(128, 16);
            this.txt_ordenado.TabIndex = 5;
            this.txt_ordenado.Text = "Array ordenado : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(583, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Array establecido : 22, 15, 3, 16, 30, 45, 9, 27, 7, 12, 44, 85, 24, 47, 33, 67, " +
    "55, 1, 93, 16";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LLENAR Y EJECUTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.AutoSize = true;
            this.txt_tiempo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo.Location = new System.Drawing.Point(236, 213);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(302, 30);
            this.txt_tiempo.TabIndex = 1;
            this.txt_tiempo.Text = "Tiempo que tardo en ordenar";
            this.txt_tiempo.Click += new System.EventHandler(this.txt_tiempo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Metodo de ordenamientoShellSort";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ejercicio02
            // 
            this.Ejercicio02.Controls.Add(this.label9);
            this.Ejercicio02.Controls.Add(this.label8);
            this.Ejercicio02.Controls.Add(this.label7);
            this.Ejercicio02.Controls.Add(this.txt_time_2);
            this.Ejercicio02.Controls.Add(this.elementos_agregados);
            this.Ejercicio02.Controls.Add(this.btn_ordenar);
            this.Ejercicio02.Controls.Add(this.txt_vector);
            this.Ejercicio02.Controls.Add(this.btn_agregar_elemento);
            this.Ejercicio02.Controls.Add(this.btn_crear_vector);
            this.Ejercicio02.Controls.Add(this.label5);
            this.Ejercicio02.Controls.Add(this.txt_longitud);
            this.Ejercicio02.Controls.Add(this.label3);
            this.Ejercicio02.Location = new System.Drawing.Point(4, 22);
            this.Ejercicio02.Name = "Ejercicio02";
            this.Ejercicio02.Padding = new System.Windows.Forms.Padding(3);
            this.Ejercicio02.Size = new System.Drawing.Size(742, 322);
            this.Ejercicio02.TabIndex = 1;
            this.Ejercicio02.Text = "Ejercicio02";
            this.Ejercicio02.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "tiempo de ejecucion : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "elementos ordenados: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "elementos agregados :  ";
            // 
            // txt_time_2
            // 
            this.txt_time_2.AutoSize = true;
            this.txt_time_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time_2.Location = new System.Drawing.Point(252, 295);
            this.txt_time_2.Name = "txt_time_2";
            this.txt_time_2.Size = new System.Drawing.Size(170, 24);
            this.txt_time_2.TabIndex = 11;
            this.txt_time_2.Text = "................................";
            // 
            // elementos_agregados
            // 
            this.elementos_agregados.AutoSize = true;
            this.elementos_agregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementos_agregados.Location = new System.Drawing.Point(311, 177);
            this.elementos_agregados.Name = "elementos_agregados";
            this.elementos_agregados.Size = new System.Drawing.Size(229, 25);
            this.elementos_agregados.TabIndex = 10;
            this.elementos_agregados.Text = "...............................";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Enabled = false;
            this.btn_ordenar.Location = new System.Drawing.Point(72, 214);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(158, 23);
            this.btn_ordenar.TabIndex = 9;
            this.btn_ordenar.Text = "Ordenar Elementos";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // txt_vector
            // 
            this.txt_vector.AutoSize = true;
            this.txt_vector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(311, 255);
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(166, 25);
            this.txt_vector.TabIndex = 8;
            this.txt_vector.Text = "......................";
            // 
            // btn_agregar_elemento
            // 
            this.btn_agregar_elemento.Enabled = false;
            this.btn_agregar_elemento.Location = new System.Drawing.Point(162, 126);
            this.btn_agregar_elemento.Name = "btn_agregar_elemento";
            this.btn_agregar_elemento.Size = new System.Drawing.Size(127, 23);
            this.btn_agregar_elemento.TabIndex = 6;
            this.btn_agregar_elemento.Text = "agregar elementos";
            this.btn_agregar_elemento.UseVisualStyleBackColor = true;
            this.btn_agregar_elemento.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_crear_vector
            // 
            this.btn_crear_vector.Location = new System.Drawing.Point(56, 126);
            this.btn_crear_vector.Name = "btn_crear_vector";
            this.btn_crear_vector.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_vector.TabIndex = 5;
            this.btn_crear_vector.Text = "crear vector";
            this.btn_crear_vector.UseVisualStyleBackColor = true;
            this.btn_crear_vector.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Longitud del vector";
            // 
            // txt_longitud
            // 
            this.txt_longitud.Location = new System.Drawing.Point(271, 93);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(103, 20);
            this.txt_longitud.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metodo de ordenamiento QuickSort";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txt_time_3);
            this.tabPage1.Controls.Add(this.elementos_ordenados);
            this.tabPage1.Controls.Add(this.btn_ordenar_03);
            this.tabPage1.Controls.Add(this.elementos_normales);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btn_crear_asignar_03);
            this.tabPage1.Controls.Add(this.tx_tam);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(742, 322);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ejercicio03";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(389, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "Metodo de ordenamiento MergeSort";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Elementos ordenados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(306, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Elementos del vector ingresado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tiempo de ejecución";
            // 
            // txt_time_3
            // 
            this.txt_time_3.AutoSize = true;
            this.txt_time_3.Location = new System.Drawing.Point(385, 287);
            this.txt_time_3.Name = "txt_time_3";
            this.txt_time_3.Size = new System.Drawing.Size(159, 25);
            this.txt_time_3.TabIndex = 6;
            this.txt_time_3.Text = ".....................";
            // 
            // elementos_ordenados
            // 
            this.elementos_ordenados.AutoSize = true;
            this.elementos_ordenados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementos_ordenados.Location = new System.Drawing.Point(386, 245);
            this.elementos_ordenados.Name = "elementos_ordenados";
            this.elementos_ordenados.Size = new System.Drawing.Size(172, 24);
            this.elementos_ordenados.TabIndex = 5;
            this.elementos_ordenados.Text = "...........................";
            // 
            // btn_ordenar_03
            // 
            this.btn_ordenar_03.Enabled = false;
            this.btn_ordenar_03.Location = new System.Drawing.Point(264, 207);
            this.btn_ordenar_03.Name = "btn_ordenar_03";
            this.btn_ordenar_03.Size = new System.Drawing.Size(117, 35);
            this.btn_ordenar_03.TabIndex = 4;
            this.btn_ordenar_03.Text = "ordenar";
            this.btn_ordenar_03.UseVisualStyleBackColor = true;
            this.btn_ordenar_03.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // elementos_normales
            // 
            this.elementos_normales.AutoSize = true;
            this.elementos_normales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementos_normales.Location = new System.Drawing.Point(410, 161);
            this.elementos_normales.Name = "elementos_normales";
            this.elementos_normales.Size = new System.Drawing.Size(159, 25);
            this.elementos_normales.TabIndex = 3;
            this.elementos_normales.Text = ".....................";
            this.elementos_normales.Click += new System.EventHandler(this.elementos_normales_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tamaño del vector";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_crear_asignar_03
            // 
            this.btn_crear_asignar_03.Location = new System.Drawing.Point(41, 107);
            this.btn_crear_asignar_03.Name = "btn_crear_asignar_03";
            this.btn_crear_asignar_03.Size = new System.Drawing.Size(249, 36);
            this.btn_crear_asignar_03.TabIndex = 1;
            this.btn_crear_asignar_03.Text = "Crear y asignar valores al vector";
            this.btn_crear_asignar_03.UseVisualStyleBackColor = true;
            this.btn_crear_asignar_03.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // tx_tam
            // 
            this.tx_tam.Location = new System.Drawing.Point(332, 68);
            this.tx_tam.Name = "tx_tam";
            this.tx_tam.Size = new System.Drawing.Size(100, 31);
            this.tx_tam.TabIndex = 0;
            this.tx_tam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tiempo_shell);
            this.tabPage2.Controls.Add(this.tiempo_quiq);
            this.tabPage2.Controls.Add(this.tiempo_mergesort);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.txt_shell);
            this.tabPage2.Controls.Add(this.txt_quiq);
            this.tabPage2.Controls.Add(this.txt_merge);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.elementos_vector_04);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.valor_numero_vector);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(742, 322);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Ejercicio04";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "crear vector y agregar vector";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // valor_numero_vector
            // 
            this.valor_numero_vector.Location = new System.Drawing.Point(141, 89);
            this.valor_numero_vector.Name = "valor_numero_vector";
            this.valor_numero_vector.Size = new System.Drawing.Size(100, 20);
            this.valor_numero_vector.TabIndex = 2;
            this.valor_numero_vector.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "tamaño del vector";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(113, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(512, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Metodo de ordenamientos con letras y numeros";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taller de Algorimos de Ordenamiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Elementos en el vector";
            // 
            // elementos_vector_04
            // 
            this.elementos_vector_04.AutoSize = true;
            this.elementos_vector_04.Location = new System.Drawing.Point(224, 179);
            this.elementos_vector_04.Name = "elementos_vector_04";
            this.elementos_vector_04.Size = new System.Drawing.Size(70, 13);
            this.elementos_vector_04.TabIndex = 5;
            this.elementos_vector_04.Text = ".....................";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Vector ordenado con MergeSort";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Vector ordenado con QuiqSort";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 298);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Vector ordenado con ShellSort";
            // 
            // txt_merge
            // 
            this.txt_merge.AutoSize = true;
            this.txt_merge.Location = new System.Drawing.Point(224, 222);
            this.txt_merge.Name = "txt_merge";
            this.txt_merge.Size = new System.Drawing.Size(70, 13);
            this.txt_merge.TabIndex = 9;
            this.txt_merge.Text = ".....................";
            // 
            // txt_quiq
            // 
            this.txt_quiq.AutoSize = true;
            this.txt_quiq.Location = new System.Drawing.Point(224, 260);
            this.txt_quiq.Name = "txt_quiq";
            this.txt_quiq.Size = new System.Drawing.Size(70, 13);
            this.txt_quiq.TabIndex = 10;
            this.txt_quiq.Text = ".....................";
            // 
            // txt_shell
            // 
            this.txt_shell.AutoSize = true;
            this.txt_shell.Location = new System.Drawing.Point(224, 298);
            this.txt_shell.Name = "txt_shell";
            this.txt_shell.Size = new System.Drawing.Size(70, 13);
            this.txt_shell.TabIndex = 11;
            this.txt_shell.Text = ".....................";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(394, 222);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "tiempo de ejecucion";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(394, 260);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "tiempo de ejecucion";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(394, 298);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 14;
            this.label26.Text = "tiempo de ejecucion";
            // 
            // tiempo_mergesort
            // 
            this.tiempo_mergesort.AutoSize = true;
            this.tiempo_mergesort.Location = new System.Drawing.Point(571, 222);
            this.tiempo_mergesort.Name = "tiempo_mergesort";
            this.tiempo_mergesort.Size = new System.Drawing.Size(70, 13);
            this.tiempo_mergesort.TabIndex = 15;
            this.tiempo_mergesort.Text = ".....................";
            // 
            // tiempo_quiq
            // 
            this.tiempo_quiq.AutoSize = true;
            this.tiempo_quiq.Location = new System.Drawing.Point(571, 260);
            this.tiempo_quiq.Name = "tiempo_quiq";
            this.tiempo_quiq.Size = new System.Drawing.Size(70, 13);
            this.tiempo_quiq.TabIndex = 16;
            this.tiempo_quiq.Text = ".....................";
            // 
            // tiempo_shell
            // 
            this.tiempo_shell.AutoSize = true;
            this.tiempo_shell.Location = new System.Drawing.Point(571, 298);
            this.tiempo_shell.Name = "tiempo_shell";
            this.tiempo_shell.Size = new System.Drawing.Size(70, 13);
            this.tiempo_shell.TabIndex = 17;
            this.tiempo_shell.Text = ".....................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Algoritmos de Ordenamiento";
            this.tabControl1.ResumeLayout(false);
            this.Ejercicio01.ResumeLayout(false);
            this.Ejercicio01.PerformLayout();
            this.Ejercicio02.ResumeLayout(false);
            this.Ejercicio02.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ejercicio01;
        public  System.Windows.Forms.Label txt_tiempo;       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Ejercicio02;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txt_ordenado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_longitud;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Label txt_vector;
        private System.Windows.Forms.Button btn_agregar_elemento;
        private System.Windows.Forms.Button btn_crear_vector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label elementos_agregados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_crear_asignar_03;
        private System.Windows.Forms.TextBox tx_tam;
        private System.Windows.Forms.Label elementos_normales;
        private System.Windows.Forms.Label elementos_ordenados;
        private System.Windows.Forms.Button btn_ordenar_03;
        private System.Windows.Forms.Label txt_time_2;
        private System.Windows.Forms.Label txt_time_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valor_numero_vector;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tiempo_shell;
        private System.Windows.Forms.Label tiempo_quiq;
        private System.Windows.Forms.Label tiempo_mergesort;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txt_shell;
        private System.Windows.Forms.Label txt_quiq;
        private System.Windows.Forms.Label txt_merge;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label elementos_vector_04;
        private System.Windows.Forms.Label label16;
    }
}

