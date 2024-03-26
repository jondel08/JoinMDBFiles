using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JoinMDBFiles {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnOriginFile_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Seleccionar Archivo MDB";
                openFileDialog.Filter = "Archivos MDB (*.mdb)|*.mdb|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    // El usuario ha seleccionado un archivo, puedes obtener la ruta con openFileDialog.FileName
                    string rutaArchivoSeleccionado = openFileDialog.FileName;
                    // Hacer algo con la ruta del archivo seleccionado, por ejemplo, asignarla a un cuadro de texto
                    txtOriginFile.Text = rutaArchivoSeleccionado;
                }
            }
        }

        private void btnTargetFile_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Seleccionar Archivo MDB";
                openFileDialog.Filter = "Archivos MDB (*.mdb)|*.mdb|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    // El usuario ha seleccionado un archivo, puedes obtener la ruta con openFileDialog.FileName
                    string rutaArchivoSeleccionado = openFileDialog.FileName;
                    // Hacer algo con la ruta del archivo seleccionado, por ejemplo, asignarla a un cuadro de texto
                    txtTargetFile.Text = rutaArchivoSeleccionado;
                }
            }

        }

        private void btnJoinMDBs_Click(object sender, EventArgs e) {
            try {
                if (TextFileValidation()) {
                    //Se obtiene la ruta de la fuente y del destino
                    string sourceFilePath = string.Concat(@"", txtOriginFile.Text);
                    string destinationFilePath = string.Concat(@"", txtTargetFile.Text);

                    //Cadena de conexión para los archivos de base de datos de Access
                    string sourceConnectionStr = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={sourceFilePath};";
                    string destinationConnectionStr = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={destinationFilePath};";

                    //Se establecen conexiones a BDD Access
                    using (OleDbConnection sourceConnection = new OleDbConnection(sourceConnectionStr))
                    using (OleDbConnection destinationConn = new OleDbConnection(destinationConnectionStr)) {

                        //Abriendo conexión
                        sourceConnection.Open();
                        destinationConn.Open();

                        using (ProgressDialog progressDialog = new ProgressDialog()) {
                            progressDialog.Show();
                            // Copiar datos de la tabla "Transacciones" de la base de datos de origen a la base de datos de destino
                            string copyTransaccionesQuery = "INSERT INTO Transacciones IN '" + destinationFilePath + "' SELECT * FROM Transacciones";
                            using (OleDbCommand copyTransaccionesCommand = new OleDbCommand(copyTransaccionesQuery, sourceConnection)) {
                                copyTransaccionesCommand.ExecuteNonQuery();
                            }

                            // Copiar datos de la tabla "Inicializacion" de la base de datos de origen a la base de datos de destino
                            string copyInicializacionQuery = "INSERT INTO Inicializacion IN '" + destinationFilePath + "' SELECT * FROM Inicializacion";
                            using (OleDbCommand copyInicializacionCommand = new OleDbCommand(copyInicializacionQuery, sourceConnection)) {
                                copyInicializacionCommand.ExecuteNonQuery();
                            }
                            progressDialog.Close();
                        }

                        MessageBox.Show("Los archivos MDB se han unido correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } else {
                    MessageBox.Show("El MDB origen/destino no puede ser nulo/vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Verifica que los MDB origen/destino sean correctos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool TextFileValidation() {
            if (txtOriginFile.Text == null || txtOriginFile.Text == string.Empty || txtTargetFile.Text == null || txtTargetFile.Text == string.Empty) {
                return false;
            } else {
                return true;
            }
        }

    }//EndClass

    public class ProgressDialog : Form {
        public ProgressDialog() {
            this.Text = "Procesando";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(200, 100);

            Label label = new Label();
            label.Text = "Procesando...";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(50, 20);

            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Size = new System.Drawing.Size(100, 20);
            progressBar.Location = new System.Drawing.Point(50, 50);

            this.Controls.Add(label);
            this.Controls.Add(progressBar);
        }
    }//EndClass

}//EndNamespace
