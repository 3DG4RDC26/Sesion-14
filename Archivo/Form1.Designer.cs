namespace Archivo
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.tbName = new System.Windows.Forms.TextBox();
         this.tbNota = new System.Windows.Forms.TextBox();
         this.cmbGenero = new System.Windows.Forms.ComboBox();
         this.dtpAge = new System.Windows.Forms.DateTimePicker();
         this.btnSaved = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(47, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombre:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 69);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Edad:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(22, 99);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(33, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Nota:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(22, 130);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(45, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Genero:";
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(106, 37);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(200, 20);
         this.tbName.TabIndex = 4;
         // 
         // tbNota
         // 
         this.tbNota.Location = new System.Drawing.Point(106, 99);
         this.tbNota.Name = "tbNota";
         this.tbNota.Size = new System.Drawing.Size(136, 20);
         this.tbNota.TabIndex = 5;
         // 
         // cmbGenero
         // 
         this.cmbGenero.FormattingEnabled = true;
         this.cmbGenero.Location = new System.Drawing.Point(106, 130);
         this.cmbGenero.Name = "cmbGenero";
         this.cmbGenero.Size = new System.Drawing.Size(136, 21);
         this.cmbGenero.TabIndex = 6;
         // 
         // dtpAge
         // 
         this.dtpAge.Location = new System.Drawing.Point(106, 73);
         this.dtpAge.Name = "dtpAge";
         this.dtpAge.Size = new System.Drawing.Size(200, 20);
         this.dtpAge.TabIndex = 7;
         // 
         // btnSaved
         // 
         this.btnSaved.Location = new System.Drawing.Point(167, 179);
         this.btnSaved.Name = "btnSaved";
         this.btnSaved.Size = new System.Drawing.Size(75, 23);
         this.btnSaved.TabIndex = 8;
         this.btnSaved.Text = "Guardar Datos";
         this.btnSaved.UseVisualStyleBackColor = true;
         this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(75, 219);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(240, 150);
         this.dataGridView1.TabIndex = 9;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(408, 381);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnSaved);
         this.Controls.Add(this.dtpAge);
         this.Controls.Add(this.cmbGenero);
         this.Controls.Add(this.tbNota);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Formulario Archivos";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.TextBox tbNota;
      private System.Windows.Forms.ComboBox cmbGenero;
      private System.Windows.Forms.DateTimePicker dtpAge;
      private System.Windows.Forms.Button btnSaved;
      private System.Windows.Forms.DataGridView dataGridView1;
   }
}

