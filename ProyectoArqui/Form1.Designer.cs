﻿namespace ProyectoArqui
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.txtVerLista = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQuantum);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Location = new System.Drawing.Point(816, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 235);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "SIMULADOR MIPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantum:";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(141, 88);
            this.txtQuantum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(110, 26);
            this.txtQuantum.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(141, 155);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 35);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(1263, 18);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(439, 233);
            this.txtArchivo.TabIndex = 4;
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Location = new System.Drawing.Point(957, 315);
            this.btnCargarArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(201, 35);
            this.btnCargarArchivos.TabIndex = 4;
            this.btnCargarArchivos.Text = "Cargar Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // txtVerLista
            // 
            this.txtVerLista.Location = new System.Drawing.Point(221, 20);
            this.txtVerLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerLista.Multiline = true;
            this.txtVerLista.Name = "txtVerLista";
            this.txtVerLista.Size = new System.Drawing.Size(439, 893);
            this.txtVerLista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2084, 975);
            this.Controls.Add(this.txtVerLista);
            this.Controls.Add(this.btnCargarArchivos);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.TextBox txtVerLista;
    }
}

