﻿namespace PRESENTACION
{
    partial class frmProductoNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImgUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(105, 40);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(229, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(105, 66);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(81, 20);
            this.txtCosto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo:";
            // 
            // txtImgUrl
            // 
            this.txtImgUrl.Location = new System.Drawing.Point(105, 92);
            this.txtImgUrl.Name = "txtImgUrl";
            this.txtImgUrl.Size = new System.Drawing.Size(203, 20);
            this.txtImgUrl.TabIndex = 4;
            this.txtImgUrl.Leave += new System.EventHandler(this.txtImgUrl_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imágen:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(37, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(138, 277);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImg
            // 
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.Location = new System.Drawing.Point(314, 90);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(29, 23);
            this.btnImg.TabIndex = 5;
            this.btnImg.Text = "+";
            this.btnImg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(6, 11);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(223, 136);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 14;
            this.pbImg.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbImg);
            this.groupBox1.Location = new System.Drawing.Point(105, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // frmProductoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(375, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtImgUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmProductoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NUEVO PRODUCTO";
            this.Load += new System.EventHandler(this.frmProductoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImgUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}