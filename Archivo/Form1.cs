using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         cmbGenero.Items.AddRange(new string[] { "Masculino", "Femenino", "Otro" });
         ConfigurarDataGridView();
         LeerDatos(); 
      }

      private void ConfigurarDataGridView()
      {
         dataGridView1.ColumnCount = 4;
         dataGridView1.Columns[0].Name = "Nombre";
         dataGridView1.Columns[1].Name = "Edad";
         dataGridView1.Columns[2].Name = "Nota";
         dataGridView1.Columns[3].Name = "Género";
      }

      private void btnSaved_Click(object sender, EventArgs e)
      {
         try
         {
            int edad = DateTime.Now.Year - dtpAge.Value.Year;

            using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Append, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
               string nombre = tbName.Text;
               int nota = int.Parse(tbNota.Text);
               char genero = cmbGenero.Text[0];

               Escritor.Write(nombre.Length);
               Escritor.Write(nombre.ToCharArray());
               Escritor.Write(edad);
               Escritor.Write(nota);
               Escritor.Write(genero);

               MessageBox.Show("Datos guardados correctamente.");
               LimpiarCampos(); 
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al guardar los datos: " + ex.Message);
         }
      }

      private void LeerDatos()
      {
         try
         {
            dataGridView1.Rows.Clear(); 

            using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
               while (mArchivoLector.Position != mArchivoLector.Length)
               {
                  int length = Lector.ReadInt32();
                  char[] nombreArray = Lector.ReadChars(length);
                  string nombre = new string(nombreArray);
                  int edad = Lector.ReadInt32();
                  int nota = Lector.ReadInt32();
                  char genero = Lector.ReadChar();

                  dataGridView1.Rows.Add(nombre, edad, nota, genero);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al leer los datos: " + ex.Message);
         }
      }

      private void LimpiarCampos()
      {
         tbName.Clear();
         tbNota.Clear();
         cmbGenero.SelectedIndex = -1; 
         dtpAge.Value = DateTime.Now; 
      }
   }
}