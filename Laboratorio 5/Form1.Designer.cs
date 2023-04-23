namespace Laboratorio_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_asignar = new System.Windows.Forms.Button();
            this.out_mostrar_data = new System.Windows.Forms.Label();
            this.in_dato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_listado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.out_nombres = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.obtener = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fila = new System.Windows.Forms.TextBox();
            this.columna = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f2c2 = new System.Windows.Forms.TextBox();
            this.f2c1 = new System.Windows.Forms.TextBox();
            this.f2c0 = new System.Windows.Forms.TextBox();
            this.f1c2 = new System.Windows.Forms.TextBox();
            this.f1c1 = new System.Windows.Forms.TextBox();
            this.f1c0 = new System.Windows.Forms.TextBox();
            this.f0c2 = new System.Windows.Forms.TextBox();
            this.f0c1 = new System.Windows.Forms.TextBox();
            this.f0c0 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_asignar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_asignar.Location = new System.Drawing.Point(236, 187);
            this.btn_asignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(226, 54);
            this.btn_asignar.TabIndex = 0;
            this.btn_asignar.Text = "ASIGNAR";
            this.btn_asignar.UseVisualStyleBackColor = false;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // out_mostrar_data
            // 
            this.out_mostrar_data.AutoSize = true;
            this.out_mostrar_data.BackColor = System.Drawing.Color.DarkOrange;
            this.out_mostrar_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_mostrar_data.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_mostrar_data.Location = new System.Drawing.Point(221, 82);
            this.out_mostrar_data.Name = "out_mostrar_data";
            this.out_mostrar_data.Size = new System.Drawing.Size(262, 22);
            this.out_mostrar_data.TabIndex = 1;
            this.out_mostrar_data.Text = "POSICION QUE SE VA A MOSTRAR";
            this.out_mostrar_data.Click += new System.EventHandler(this.out_mostrar_data_Click);
            // 
            // in_dato
            // 
            this.in_dato.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.in_dato.Location = new System.Drawing.Point(153, 160);
            this.in_dato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_dato.Name = "in_dato";
            this.in_dato.Size = new System.Drawing.Size(394, 23);
            this.in_dato.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESE LA POSICION DEL VECTOR QUE DESEA MOSTRAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 339);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_asignar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.out_mostrar_data);
            this.tabPage1.Controls.Add(this.in_dato);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(692, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ARRAY ENTERO";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(692, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ARRAY STRING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.out_listado);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(404, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO DE NOMBRES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // out_listado
            // 
            this.out_listado.AutoSize = true;
            this.out_listado.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.out_listado.Location = new System.Drawing.Point(5, 21);
            this.out_listado.Name = "out_listado";
            this.out_listado.Size = new System.Drawing.Size(92, 21);
            this.out_listado.TabIndex = 0;
            this.out_listado.Text = "NOMBRES:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.out_nombres);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(97, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAMANO DEL VECTOR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // out_nombres
            // 
            this.out_nombres.AutoSize = true;
            this.out_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_nombres.Location = new System.Drawing.Point(91, 43);
            this.out_nombres.Name = "out_nombres";
            this.out_nombres.Size = new System.Drawing.Size(18, 20);
            this.out_nombres.TabIndex = 1;
            this.out_nombres.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(272, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resultado);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.obtener);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.fila);
            this.tabPage3.Controls.Add(this.columna);
            this.tabPage3.Controls.Add(this.btnguardar);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(692, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MATRIZ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(465, 222);
            this.resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(110, 23);
            this.resultado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(476, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULTADO";
            // 
            // obtener
            // 
            this.obtener.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obtener.Location = new System.Drawing.Point(413, 130);
            this.obtener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obtener.Name = "obtener";
            this.obtener.Size = new System.Drawing.Size(219, 26);
            this.obtener.TabIndex = 7;
            this.obtener.Text = "OBTENER";
            this.obtener.UseVisualStyleBackColor = true;
            this.obtener.Click += new System.EventHandler(this.obtener_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "COLUMNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "FILA";
            // 
            // fila
            // 
            this.fila.Location = new System.Drawing.Point(383, 66);
            this.fila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fila.Name = "fila";
            this.fila.Size = new System.Drawing.Size(110, 23);
            this.fila.TabIndex = 4;
            // 
            // columna
            // 
            this.columna.Location = new System.Drawing.Point(549, 66);
            this.columna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.columna.Name = "columna";
            this.columna.Size = new System.Drawing.Size(110, 23);
            this.columna.TabIndex = 3;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguardar.Location = new System.Drawing.Point(100, 247);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(219, 26);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATRIZ 3X3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.f2c2);
            this.panel1.Controls.Add(this.f2c1);
            this.panel1.Controls.Add(this.f2c0);
            this.panel1.Controls.Add(this.f1c2);
            this.panel1.Controls.Add(this.f1c1);
            this.panel1.Controls.Add(this.f1c0);
            this.panel1.Controls.Add(this.f0c2);
            this.panel1.Controls.Add(this.f0c1);
            this.panel1.Controls.Add(this.f0c0);
            this.panel1.Location = new System.Drawing.Point(100, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 188);
            this.panel1.TabIndex = 0;
            // 
            // f2c2
            // 
            this.f2c2.Location = new System.Drawing.Point(144, 127);
            this.f2c2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f2c2.Multiline = true;
            this.f2c2.Name = "f2c2";
            this.f2c2.PlaceholderText = "2,2";
            this.f2c2.Size = new System.Drawing.Size(42, 36);
            this.f2c2.TabIndex = 8;
            // 
            // f2c1
            // 
            this.f2c1.Location = new System.Drawing.Point(87, 127);
            this.f2c1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f2c1.Multiline = true;
            this.f2c1.Name = "f2c1";
            this.f2c1.PlaceholderText = "2,1";
            this.f2c1.Size = new System.Drawing.Size(43, 36);
            this.f2c1.TabIndex = 7;
            // 
            // f2c0
            // 
            this.f2c0.Location = new System.Drawing.Point(28, 127);
            this.f2c0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f2c0.Multiline = true;
            this.f2c0.Name = "f2c0";
            this.f2c0.PlaceholderText = "2,0";
            this.f2c0.Size = new System.Drawing.Size(46, 36);
            this.f2c0.TabIndex = 6;
            // 
            // f1c2
            // 
            this.f1c2.Location = new System.Drawing.Point(144, 68);
            this.f1c2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f1c2.Multiline = true;
            this.f1c2.Name = "f1c2";
            this.f1c2.PlaceholderText = "1,2";
            this.f1c2.Size = new System.Drawing.Size(42, 34);
            this.f1c2.TabIndex = 5;
            // 
            // f1c1
            // 
            this.f1c1.Location = new System.Drawing.Point(87, 68);
            this.f1c1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f1c1.Multiline = true;
            this.f1c1.Name = "f1c1";
            this.f1c1.PlaceholderText = "1,1";
            this.f1c1.Size = new System.Drawing.Size(43, 34);
            this.f1c1.TabIndex = 4;
            // 
            // f1c0
            // 
            this.f1c0.Location = new System.Drawing.Point(28, 68);
            this.f1c0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f1c0.Multiline = true;
            this.f1c0.Name = "f1c0";
            this.f1c0.PlaceholderText = "1,0";
            this.f1c0.Size = new System.Drawing.Size(46, 34);
            this.f1c0.TabIndex = 3;
            // 
            // f0c2
            // 
            this.f0c2.Location = new System.Drawing.Point(144, 11);
            this.f0c2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f0c2.Multiline = true;
            this.f0c2.Name = "f0c2";
            this.f0c2.PlaceholderText = "0,2";
            this.f0c2.Size = new System.Drawing.Size(42, 36);
            this.f0c2.TabIndex = 2;
            // 
            // f0c1
            // 
            this.f0c1.Location = new System.Drawing.Point(87, 11);
            this.f0c1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f0c1.Multiline = true;
            this.f0c1.Name = "f0c1";
            this.f0c1.PlaceholderText = "0,1";
            this.f0c1.Size = new System.Drawing.Size(43, 36);
            this.f0c1.TabIndex = 1;
            // 
            // f0c0
            // 
            this.f0c0.Location = new System.Drawing.Point(28, 11);
            this.f0c0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f0c0.Multiline = true;
            this.f0c0.Name = "f0c0";
            this.f0c0.PlaceholderText = "0,0";
            this.f0c0.Size = new System.Drawing.Size(46, 36);
            this.f0c0.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_asignar;
        private Label out_mostrar_data;
        private TextBox in_dato;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label out_nombres;
        private Button button1;
        private GroupBox groupBox2;
        private Label out_listado;
        private GroupBox groupBox1;
        private TabPage tabPage3;
        private Panel panel1;
        private TextBox f1c1;
        private TextBox f1c0;
        private TextBox f0c2;
        private TextBox f0c1;
        private TextBox f0c0;
        private Label label2;
        private TextBox f2c2;
        private TextBox f2c1;
        private TextBox f2c0;
        private TextBox f1c2;
        private TextBox resultado;
        private Label label5;
        private Button obtener;
        private Label label4;
        private Label label3;
        private TextBox fila;
        private TextBox columna;
        private Button btnguardar;
    }
}