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
using Newtonsoft.Json;
using CloudyApi;

namespace Asteroid_Client
{
    public partial class MainWindow : Form
    {
        private async void InitializeAsync()
        {
            try
            {
                await Editor.EnsureCoreWebView2Async();

                if (Editor.CoreWebView2 != null)
                {
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Editor", "index.html");

                    if (!File.Exists(filePath))
                    {
                        Clipboard.SetText(filePath);
                        MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fileUri = new Uri(filePath).AbsoluteUri;
                    Editor.CoreWebView2.Navigate(fileUri);
                }
                else
                {
                    MessageBox.Show("WebView2 initialization failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void executebutton_Click(object sender, EventArgs e)
        {
            string scriptToExecute = await Editor.ExecuteScriptAsync("GetText();");
            string rawScript = JsonConvert.DeserializeObject<string>(scriptToExecute);
            Api.execute(rawScript);
        }

        private async void clearbutton_Click(object sender, EventArgs e)
        {
            await Editor.ExecuteScriptAsync($"SetText(``);");
        }

        private async void savefilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
                    DefaultExt = "lua",
                    Title = "Save Lua or Text File"
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string textToSave = await Editor.ExecuteScriptAsync("GetText();");
                    string rawText = JsonConvert.DeserializeObject<string>(textToSave);
                    File.WriteAllText(saveFileDialog1.FileName, rawText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void loadbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string script = File.ReadAllText(dialog.FileName);
                await Editor.CoreWebView2.ExecuteScriptAsync($"editor.setValue(`{script}`)");
            }
        }

        private void injectbutton_Click(object sender, EventArgs e)
        {
            Api.inject();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
