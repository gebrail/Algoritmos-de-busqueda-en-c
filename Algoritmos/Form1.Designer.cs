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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_crear_vector = new System.Windows.Forms.Button();
            this.btn_agregar_elemento = new System.Windows.Forms.Button();
            this.txt_vector = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.elementos_agregados = new System.Windows.Forms.Label();
            this.tx_tam = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.elementos_normales = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.elementos_ordenados = new System.Windows.Forms.Label();
            this.txt_time_3 = new System.Windows.Forms.Label();
            this.txt_time_2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Ejercicio01.SuspendLayout();
            this.Ejercicio02.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_time_3);
            this.tabPage1.Controls.Add(this.elementos_ordenados);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.elementos_normales);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.tx_tam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(742, 322);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ejercicio03";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(742, 322);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Ejercicio04";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Metodo de ordenamiento QuickSort";
            // 
            // txt_longitud
            // 
            this.txt_longitud.Location = new System.Drawing.Point(413, 124);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(103, 20);
            this.txt_longitud.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "longitud del vector";
            // 
            // btn_crear_vector
            // 
            this.btn_crear_vector.Location = new System.Drawing.Point(263, 163);
            this.btn_crear_vector.Name = "btn_crear_vector";
            this.btn_crear_vector.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_vector.TabIndex = 5;
            this.btn_crear_vector.Text = "crear vector";
            this.btn_crear_vector.UseVisualStyleBackColor = true;
            this.btn_crear_vector.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_agregar_elemento
            // 
            this.btn_agregar_elemento.Enabled = false;
            this.btn_agregar_elemento.Location = new System.Drawing.Point(368, 163);
            this.btn_agregar_elemento.Name = "btn_agregar_elemento";
            this.btn_agregar_elemento.Size = new System.Drawing.Size(127, 23);
            this.btn_agregar_elemento.TabIndex = 6;
            this.btn_agregar_elemento.Text = "agregar elementos";
            this.btn_agregar_elemento.UseVisualStyleBackColor = true;
            this.btn_agregar_elemento.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_vector
            // 
            this.txt_vector.AutoSize = true;
            this.txt_vector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(257, 280);
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(281, 25);
            this.txt_vector.TabIndex = 8;
            this.txt_vector.Text = "vector con sus elementos";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Enabled = false;
            this.btn_ordenar.Location = new System.Drawing.Point(318, 254);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(158, 23);
            this.btn_ordenar.TabIndex = 9;
            this.btn_ordenar.Text = "Ordenar Elementos";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // elementos_agregados
            // 
            this.elementos_agregados.AutoSize = true;
            this.elementos_agregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementos_agregados.Location = new System.Drawing.Point(300, 206);
            this.elementos_agregados.Name = "elementos_agregados";
            this.elementos_agregados.Size = new System.Drawing.Size(238, 25);
            this.elementos_agregados.TabIndex = 10;
            this.elementos_agregados.Text = "elementos agregados";
            // 
            // tx_tam
            // 
            this.tx_tam.Location = new System.Drawing.Point(327, 71);
            this.tx_tam.Name = "tx_tam";
            this.tx_tam.Size = new System.Drawing.Size(100, 20);
            this.tx_tam.TabIndex = 0;
            this.tx_tam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "generar vector";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "tamaño del vector";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // elementos_normales
            // 
            this.elementos_normales.AutoSize = true;
            this.elementos_normales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementos_normales.Location = new System.Drawing.Point(271, 110);
            this.elementos_normales.Name = "elementos_normales";
            this.elementos_normales.Size = new System.Drawing.Size(200, 25);
            this.elementos_normales.TabIndex = 3;
            this.elementos_normales.Text = "aqui van el vector";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "ordenar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // elementos_ordenados
            // 
            this.elementos_ordenados.AutoSize = true;
            this.elementos_ordenados.Location = new System.Drawing.Point(286, 216);
            this.elementos_ordenados.Name = "elementos_ordenados";
            this.elementos_ordenados.Size = new System.Drawing.Size(35, 13);
            this.elementos_ordenados.TabIndex = 5;
            this.elementos_ordenados.Text = "label7";
            // 
            // txt_time_3
            // 
            this.txt_time_3.AutoSize = true;
            this.txt_time_3.Location = new System.Drawing.Point(485, 254);
            this.txt_time_3.Name = "txt_time_3";
            this.txt_time_3.Size = new System.Drawing.Size(89, 13);
            this.txt_time_3.TabIndex = 6;
            this.txt_time_3.Text = "tado tanto tiempo";
            // 
            // txt_time_2
            // 
            this.txt_time_2.AutoSize = true;
            this.txt_time_2.Location = new System.Drawing.Point(39, 259);
            this.txt_time_2.Name = "txt_time_2";
            this.txt_time_2.Size = new System.Drawing.Size(92, 13);
            this.txt_time_2.TabIndex = 11;
            this.txt_time_2.Text = "tardo tanto tiempo";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tx_tam;
        private System.Windows.Forms.Label elementos_normales;
        private System.Windows.Forms.Label elementos_ordenados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label txt_time_2;
        private System.Windows.Forms.Label txt_time_3;
    }
}

