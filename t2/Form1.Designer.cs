namespace t2
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
            txt_cantidad = new TextBox();
            txt_codigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nombre = new TextBox();
            txt_precio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btn_registrar = new Button();
            lviewMedicamentos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btn_limpiar = new Button();
            button1 = new Button();
            btn_eliminar = new Button();
            SuspendLayout();
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(145, 265);
            txt_cantidad.Margin = new Padding(3, 4, 3, 4);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(217, 27);
            txt_cantidad.TabIndex = 5;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(145, 161);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(217, 27);
            txt_codigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 172);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 117);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 269);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Cantidad";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(145, 107);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(326, 27);
            txt_nombre.TabIndex = 4;
            txt_nombre.TextChanged += textBox2_TextChanged;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(145, 212);
            txt_precio.Margin = new Padding(3, 4, 3, 4);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(217, 27);
            txt_precio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 223);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio unitario";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 37);
            label5.Name = "label5";
            label5.Size = new Size(457, 41);
            label5.TabIndex = 8;
            label5.Text = "CONTROL DE MEDICAMENTOS";
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(39, 322);
            btn_registrar.Margin = new Padding(3, 4, 3, 4);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(179, 31);
            btn_registrar.TabIndex = 9;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // lviewMedicamentos
            // 
            lviewMedicamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewMedicamentos.Location = new Point(43, 435);
            lviewMedicamentos.Margin = new Padding(3, 4, 3, 4);
            lviewMedicamentos.Name = "lviewMedicamentos";
            lviewMedicamentos.Size = new Size(428, 301);
            lviewMedicamentos.TabIndex = 12;
            lviewMedicamentos.UseCompatibleStateImageBehavior = false;
            lviewMedicamentos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Código";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cantidad";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Monto inv.";
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.Control;
            btn_limpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = SystemColors.ActiveCaptionText;
            btn_limpiar.Location = new Point(377, 399);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(94, 29);
            btn_limpiar.TabIndex = 14;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.IndianRed;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = SystemColors.ButtonFace;
            btn_eliminar.Location = new Point(368, 161);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 17;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 886);
            Controls.Add(btn_eliminar);
            Controls.Add(button1);
            Controls.Add(btn_limpiar);
            Controls.Add(lviewMedicamentos);
            Controls.Add(btn_registrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_precio);
            Controls.Add(txt_cantidad);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_codigo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_codigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nombre;
        private TextBox txt_cantidad;
        private TextBox txt_precio;
        private Label label4;
        private Label label5;
        private Button btn_registrar;
        private ListView lviewMedicamentos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btn_limpiar;
        private Button button1;
        private Button btn_eliminar;
    }
}