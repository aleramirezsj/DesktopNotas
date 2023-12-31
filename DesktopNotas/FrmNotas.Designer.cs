﻿namespace DesktopNotas
{
    partial class FrmNotas
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
            tabControlNotas = new TabControl();
            tabPageLista = new TabPage();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dataGridNotas = new DataGridView();
            tabPageDetalle = new TabPage();
            btnExaminar = new Button();
            btnDetenerCámara = new Button();
            btnIniciarCámara = new Button();
            pictureBoxFoto = new PictureBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtContenido = new TextBox();
            txtTitulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBorrarImagen = new Button();
            tabControlNotas.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).BeginInit();
            tabPageDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // tabControlNotas
            // 
            tabControlNotas.Controls.Add(tabPageLista);
            tabControlNotas.Controls.Add(tabPageDetalle);
            tabControlNotas.Location = new Point(12, 12);
            tabControlNotas.Name = "tabControlNotas";
            tabControlNotas.SelectedIndex = 0;
            tabControlNotas.Size = new Size(811, 483);
            tabControlNotas.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(textBox1);
            tabPageLista.Controls.Add(btnSalir);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(dataGridNotas);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(803, 450);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista de notas";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(586, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(564, 27);
            textBox1.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(686, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(686, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(686, 111);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(686, 76);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridNotas
            // 
            dataGridNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNotas.Location = new Point(6, 52);
            dataGridNotas.Name = "dataGridNotas";
            dataGridNotas.RowHeadersWidth = 51;
            dataGridNotas.RowTemplate.Height = 29;
            dataGridNotas.Size = new Size(674, 392);
            dataGridNotas.TabIndex = 0;
            // 
            // tabPageDetalle
            // 
            tabPageDetalle.Controls.Add(btnBorrarImagen);
            tabPageDetalle.Controls.Add(btnExaminar);
            tabPageDetalle.Controls.Add(btnDetenerCámara);
            tabPageDetalle.Controls.Add(btnIniciarCámara);
            tabPageDetalle.Controls.Add(pictureBoxFoto);
            tabPageDetalle.Controls.Add(label3);
            tabPageDetalle.Controls.Add(btnCancelar);
            tabPageDetalle.Controls.Add(btnGuardar);
            tabPageDetalle.Controls.Add(txtContenido);
            tabPageDetalle.Controls.Add(txtTitulo);
            tabPageDetalle.Controls.Add(label2);
            tabPageDetalle.Controls.Add(label1);
            tabPageDetalle.Location = new Point(4, 29);
            tabPageDetalle.Name = "tabPageDetalle";
            tabPageDetalle.Padding = new Padding(3);
            tabPageDetalle.Size = new Size(803, 450);
            tabPageDetalle.TabIndex = 1;
            tabPageDetalle.Text = "Detalle";
            tabPageDetalle.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(379, 336);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(156, 29);
            btnExaminar.TabIndex = 10;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnDetenerCámara
            // 
            btnDetenerCámara.Enabled = false;
            btnDetenerCámara.Location = new Point(379, 283);
            btnDetenerCámara.Name = "btnDetenerCámara";
            btnDetenerCámara.Size = new Size(156, 29);
            btnDetenerCámara.TabIndex = 9;
            btnDetenerCámara.Text = "Detener cámara";
            btnDetenerCámara.UseVisualStyleBackColor = true;
            btnDetenerCámara.Click += button1_Click;
            // 
            // btnIniciarCámara
            // 
            btnIniciarCámara.Location = new Point(379, 231);
            btnIniciarCámara.Name = "btnIniciarCámara";
            btnIniciarCámara.Size = new Size(156, 29);
            btnIniciarCámara.TabIndex = 8;
            btnIniciarCámara.Text = "Iniciar cámara";
            btnIniciarCámara.UseVisualStyleBackColor = true;
            btnIniciarCámara.Click += btnIniciarCámara_Click;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(119, 220);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(228, 201);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 7;
            pictureBoxFoto.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 231);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Imagen:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(687, 132);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(687, 97);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(119, 109);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(475, 87);
            txtContenido.TabIndex = 3;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(119, 34);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(475, 27);
            txtTitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Contenido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // btnBorrarImagen
            // 
            btnBorrarImagen.Location = new Point(379, 392);
            btnBorrarImagen.Name = "btnBorrarImagen";
            btnBorrarImagen.Size = new Size(156, 29);
            btnBorrarImagen.TabIndex = 11;
            btnBorrarImagen.Text = "Borrar imagen";
            btnBorrarImagen.UseVisualStyleBackColor = true;
            btnBorrarImagen.Click += btnBorrarImagen_Click;
            // 
            // FrmNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 507);
            Controls.Add(tabControlNotas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicación de escritorio de Notas";
            tabControlNotas.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).EndInit();
            tabPageDetalle.ResumeLayout(false);
            tabPageDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlNotas;
        private TabPage tabPageLista;
        private TabPage tabPageDetalle;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dataGridNotas;
        private Button btnBuscar;
        private TextBox textBox1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtContenido;
        private TextBox txtTitulo;
        private Label label2;
        private Label label1;
        private Button btnIniciarCámara;
        private PictureBox pictureBoxFoto;
        private Label label3;
        private Button btnDetenerCámara;
        private Button btnExaminar;
        private Button btnBorrarImagen;
    }
}