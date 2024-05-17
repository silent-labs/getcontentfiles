using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObtenerContenidosArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    directoryLabel.Text = "Directorio seleccionado: " + folderBrowserDialog.SelectedPath;
                    fileListBox.Items.Clear();

                    var filters = filterTextBox.Text.Split(',').Select(f => f.Trim()).ToArray();
                    var fileTypes = fileTypeTextBox.Text.Split(',').Select(f => f.Trim()).ToArray();

                    var files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories)
                                         .Where(f => !filters.Any(filter => f.Contains(filter)))
                                         .Where(f => fileTypes.Length == 0 || fileTypes.Any(type => f.EndsWith(type)))
                                         .ToList();

                    files.ForEach(file => fileListBox.Items.Add(file));
                    outputButton.Enabled = true;
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.ToLower();
            for (int i = 0; i < fileListBox.Items.Count; i++)
            {
                var fileName = fileListBox.Items[i].ToString().ToLower();
                fileListBox.SetItemChecked(i, fileName.Contains(searchText));
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputLabel.Text = "Ubicación de output seleccionada: " + saveFileDialog.FileName;
                    generateButton.Enabled = true;
                }
            }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            var outputFilePath = outputLabel.Text.Replace("Ubicación de output seleccionada: ", "");
            using (var writer = new StreamWriter(outputFilePath))
            {
                var selectedFiles = fileListBox.CheckedItems;
                progressBar.Minimum = 0;
                progressBar.Maximum = selectedFiles.Count;
                progressBar.Value = 0;

                foreach (var filePath in selectedFiles)
                {
                    await writer.WriteLineAsync("Ruta: " + filePath);
                    await writer.WriteLineAsync(await File.ReadAllTextAsync(filePath.ToString()));
                    await writer.WriteLineAsync();
                    progressBar.Value++;
                }
            }

            MessageBox.Show("El contenido de los archivos seleccionados se ha guardado en " + outputFilePath, "Operación Completada");
        }
    }
}
