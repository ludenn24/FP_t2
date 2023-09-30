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
            components = new System.ComponentModel.Container();
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
            groupBox1 = new GroupBox();
            label_cantidadMed = new Label();
            btn_listar = new Button();
            toolTipEliminar = new ToolTip(components);
            text_buscar = new TextBox();
            groupBox2 = new GroupBox();
            btn_buscar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(145, 262);
            txt_cantidad.Margin = new Padding(3, 4, 3, 4);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(226, 27);
            txt_cantidad.TabIndex = 5;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(117, 88);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(226, 27);
            txt_codigo.TabIndex = 0;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
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
            txt_nombre.Location = new Point(117, 33);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(326, 27);
            txt_nombre.TabIndex = 4;
            txt_nombre.TextChanged += textBox2_TextChanged;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(117, 135);
            txt_precio.Margin = new Padding(3, 4, 3, 4);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(226, 27);
            txt_precio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 138);
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
            btn_registrar.BackColor = Color.Lime;
            btn_registrar.Location = new Point(11, 234);
            btn_registrar.Margin = new Padding(3, 4, 3, 4);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(179, 31);
            btn_registrar.TabIndex = 9;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // lviewMedicamentos
            // 
            lviewMedicamentos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewMedicamentos.Location = new Point(28, 487);
            lviewMedicamentos.Margin = new Padding(3, 4, 3, 4);
            lviewMedicamentos.Name = "lviewMedicamentos";
            lviewMedicamentos.Size = new Size(455, 301);
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
            btn_limpiar.Location = new Point(389, 451);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(94, 29);
            btn_limpiar.TabIndex = 14;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(128, 451);
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
            btn_eliminar.Location = new Point(349, 88);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 17;
            btn_eliminar.Text = "Eliminar";
            toolTipEliminar.SetToolTip(btn_eliminar, "Escriba un codigo y de click para eliminar el medicamento");
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_cantidadMed);
            groupBox1.Controls.Add(btn_registrar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(txt_codigo);
            groupBox1.Controls.Add(txt_precio);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(28, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 272);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // label_cantidadMed
            // 
            label_cantidadMed.AutoSize = true;
            label_cantidadMed.Location = new Point(196, 239);
            label_cantidadMed.Name = "label_cantidadMed";
            label_cantidadMed.Size = new Size(159, 20);
            label_cantidadMed.TabIndex = 18;
            label_cantidadMed.Text = "(Hay 0 medicamentos)";
            // 
            // btn_listar
            // 
            btn_listar.Location = new Point(28, 451);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(94, 29);
            btn_listar.TabIndex = 19;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += btn_listar_Click;
            // 
            // text_buscar
            // 
            text_buscar.Location = new Point(15, 26);
            text_buscar.Name = "text_buscar";
            text_buscar.Size = new Size(328, 27);
            text_buscar.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(text_buscar);
            groupBox2.Location = new Point(28, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 66);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por nombre";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(349, 24);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 22;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 821);
            Controls.Add(btn_listar);
            Controls.Add(button1);
            Controls.Add(btn_limpiar);
            Controls.Add(lviewMedicamentos);
            Controls.Add(label5);
            Controls.Add(txt_cantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btn_listar;
        private ToolTip toolTipEliminar;
        private Label label_cantidadMed;
        private TextBox text_buscar;
        private GroupBox groupBox2;
        private Button btn_buscar;
    }
}