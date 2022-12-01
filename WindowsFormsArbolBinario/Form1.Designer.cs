namespace WindowsFormsArbolBinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btninsertarnodos = new System.Windows.Forms.Button();
            this.txtpadre = new System.Windows.Forms.TextBox();
            this.txthijo = new System.Windows.Forms.TextBox();
            this.txtarbol = new System.Windows.Forms.TextBox();
            this.btncreararbol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpreorden = new System.Windows.Forms.Button();
            this.btnentreorden = new System.Windows.Forms.Button();
            this.btnposorden = new System.Windows.Forms.Button();
            this.txtmotrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btninsertarnodos);
            this.groupBox1.Controls.Add(this.txtpadre);
            this.groupBox1.Controls.Add(this.txthijo);
            this.groupBox1.Controls.Add(this.txtarbol);
            this.groupBox1.Controls.Add(this.btncreararbol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btninsertarnodos
            // 
            this.btninsertarnodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btninsertarnodos.Location = new System.Drawing.Point(129, 106);
            this.btninsertarnodos.Name = "btninsertarnodos";
            this.btninsertarnodos.Size = new System.Drawing.Size(160, 35);
            this.btninsertarnodos.TabIndex = 3;
            this.btninsertarnodos.Text = "Insertar en el Arbol";
            this.btninsertarnodos.UseVisualStyleBackColor = true;
            this.btninsertarnodos.Click += new System.EventHandler(this.btninsertarnodos_Click);
            // 
            // txtpadre
            // 
            this.txtpadre.Location = new System.Drawing.Point(299, 68);
            this.txtpadre.Name = "txtpadre";
            this.txtpadre.Size = new System.Drawing.Size(78, 20);
            this.txtpadre.TabIndex = 2;
            // 
            // txthijo
            // 
            this.txthijo.Location = new System.Drawing.Point(96, 68);
            this.txthijo.Name = "txthijo";
            this.txthijo.Size = new System.Drawing.Size(139, 20);
            this.txthijo.TabIndex = 2;
            // 
            // txtarbol
            // 
            this.txtarbol.Location = new System.Drawing.Point(97, 24);
            this.txtarbol.Name = "txtarbol";
            this.txtarbol.Size = new System.Drawing.Size(139, 20);
            this.txtarbol.TabIndex = 2;
            // 
            // btncreararbol
            // 
            this.btncreararbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btncreararbol.Location = new System.Drawing.Point(245, 18);
            this.btncreararbol.Name = "btncreararbol";
            this.btncreararbol.Size = new System.Drawing.Size(132, 30);
            this.btncreararbol.TabIndex = 1;
            this.btncreararbol.Text = "Crear Raiz del Arbol";
            this.btncreararbol.UseVisualStyleBackColor = true;
            this.btncreararbol.Click += new System.EventHandler(this.btncreararbol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(242, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Su Padre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raiz del Arbol";
            // 
            // btnpreorden
            // 
            this.btnpreorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnpreorden.Location = new System.Drawing.Point(21, 234);
            this.btnpreorden.Name = "btnpreorden";
            this.btnpreorden.Size = new System.Drawing.Size(175, 29);
            this.btnpreorden.TabIndex = 3;
            this.btnpreorden.Text = "Mostrar Arbol Preorden";
            this.btnpreorden.UseVisualStyleBackColor = true;
            this.btnpreorden.Click += new System.EventHandler(this.btnpreorden_Click);
            // 
            // btnentreorden
            // 
            this.btnentreorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnentreorden.Location = new System.Drawing.Point(23, 269);
            this.btnentreorden.Name = "btnentreorden";
            this.btnentreorden.Size = new System.Drawing.Size(175, 29);
            this.btnentreorden.TabIndex = 3;
            this.btnentreorden.Text = "Mostrar Arbol Entreorden";
            this.btnentreorden.UseVisualStyleBackColor = true;
            this.btnentreorden.Click += new System.EventHandler(this.btnentreorden_Click);
            // 
            // btnposorden
            // 
            this.btnposorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnposorden.Location = new System.Drawing.Point(231, 269);
            this.btnposorden.Name = "btnposorden";
            this.btnposorden.Size = new System.Drawing.Size(178, 29);
            this.btnposorden.TabIndex = 3;
            this.btnposorden.Text = "Mostrar Arbol Posorden";
            this.btnposorden.UseVisualStyleBackColor = true;
            this.btnposorden.Click += new System.EventHandler(this.btnposorden_Click);
            // 
            // txtmotrar
            // 
            this.txtmotrar.Location = new System.Drawing.Point(231, 240);
            this.txtmotrar.Name = "txtmotrar";
            this.txtmotrar.Size = new System.Drawing.Size(167, 20);
            this.txtmotrar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(127, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "ARBOLES BINARIOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnposorden);
            this.Controls.Add(this.txtmotrar);
            this.Controls.Add(this.btnentreorden);
            this.Controls.Add(this.btnpreorden);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btninsertarnodos;
        private System.Windows.Forms.TextBox txtpadre;
        private System.Windows.Forms.TextBox txthijo;
        private System.Windows.Forms.TextBox txtarbol;
        private System.Windows.Forms.Button btncreararbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpreorden;
        private System.Windows.Forms.Button btnentreorden;
        private System.Windows.Forms.Button btnposorden;
        private System.Windows.Forms.TextBox txtmotrar;
        private System.Windows.Forms.Label label4;
    }
}

