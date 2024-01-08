using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class MainForm : Form
    {
        private string currentFilePath = "Unsaved"; // Initialize with "Unsaved File"

        public MainForm()
        {
            InitializeComponent();
            InitializeRichTextBox();
            UpdateCurrentFileLabel(); // Call to set the initial label
        }

        private void InitializeRichTextBox()
        {
            // Enable vertical and horizontal scrolls
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;

            // Wrap text
            richTextBox.WordWrap = true;
        }

        private void UpdateCurrentFileLabel()
        {
            lblCurrentFile.Text = $"Current File: {currentFilePath}";
        }

        private void SaveToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Save text
                    File.WriteAllText(filePath, richTextBox.Text);

                    // Update the current file path
                    currentFilePath = filePath;

                    // Update the label
                    UpdateCurrentFileLabel();

                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Read the content of the selected file
                    string fileContent = File.ReadAllText(filePath);

                    // Display the content in the RichTextBox
                    richTextBox.Text = fileContent;

                    // Update the current file path
                    currentFilePath = filePath;

                    // Update the label
                    UpdateCurrentFileLabel();

                    MessageBox.Show("File opened successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
