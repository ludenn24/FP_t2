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
            btn_listar = new Button();
            SuspendLayout();
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(127, 199);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(190, 23);
            txt_cantidad.TabIndex = 5;
            txt_cantidad.TextChanged += txt_cantidad_TextChanged;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(127, 121);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(190, 23);
            txt_codigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 129);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 202);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(127, 80);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(286, 23);
            txt_nombre.TabIndex = 4;
            txt_nombre.TextChanged += textBox2_TextChanged;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(127, 159);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(190, 23);
            txt_precio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 167);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio unitario";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 28);
            label5.Name = "label5";
            label5.Size = new Size(364, 32);
            label5.TabIndex = 8;
            label5.Text = "CONTROL DE MEDICAMENTOS";
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(38, 254);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(157, 23);
            btn_registrar.TabIndex = 9;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // lviewMedicamentos
            // 
            lviewMedicamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewMedicamentos.Location = new Point(37, 295);
            lviewMedicamentos.Name = "lviewMedicamentos";
            lviewMedicamentos.Size = new Size(375, 227);
            lviewMedicamentos.TabIndex = 12;
            lviewMedicamentos.UseCompatibleStateImageBehavior = false;
            lviewMedicamentos.View = View.Details;
            lviewMedicamentos.SelectedIndexChanged += lviewMedicamentos_SelectedIndexChanged;
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
            // btn_listar
            // 
            btn_listar.Location = new Point(338, 254);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(75, 23);
            btn_listar.TabIndex = 13;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 554);
            Controls.Add(btn_listar);
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
            Name = "Form1";
            Text = "Form1";
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
        private Button btn_listar;
    }
}