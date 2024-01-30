using System;
using System.Windows.Forms;
using static System.Environment;
using Azure;
using Azure.AI.OpenAI;
using System.Net;
using Microsoft.Identity.Client;
using System.IO;

namespace CodeGenie
{
    public partial class Form1 : Form
    {
        string endpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        string key = GetEnvironmentVariable("AZURE_OPENAI_KEY");
        string selectedFileContent = "";

        public Form1()
        {
            InitializeComponent();

            contextTextbox.Text += "AZURE_OPENAI_ENDPOINT : " + endpoint;
            contextTextbox.Text += NewLine;
            contextTextbox.Text += "AZURE_OPENAI_KEY: " + key;
        }

        private void contextClearButton_Click(object sender, EventArgs e)
        {
            contextTextbox.Clear();
        }

        private void applicationCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void questionClearButton_Click(object sender, EventArgs e)
        {
            questionTextBox.Clear();
        }

        private void questionSubmitButton_Click(object sender, EventArgs e)
        {
            // call api here
            callApi();
        }

        private void callApi()
        {
            if(String.IsNullOrEmpty(selectedFileContent))
            {
                MessageBox.Show("No File seleected or file is empty", "File Selection", MessageBoxButtons.OK);
                return;
            }

            OpenAIClient client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key));

            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                DeploymentName = "gpt-35-turbo", //This must match the custom deployment name you chose for your model
                Messages =
                {
                    new ChatRequestSystemMessage("You are a C# Pair programming Helper."),
                    
                    //new ChatRequestAssistantMessage("Yes, customer managed keys are supported by Azure OpenAI."),
                    //new ChatRequestUserMessage("Do other Azure AI services support this too?"),
                    includeSelectedFileContent.Checked?new ChatRequestUserMessage("Can you explain me the content of this file?"): null,
                    includeSelectedFileContent.Checked?new ChatRequestUserMessage(selectedFileContent): null
                },
                            MaxTokens = 100
            };

            try
            {
                errorMessage.Text = "";
                Response<ChatCompletions> response = client.GetChatCompletions(chatCompletionsOptions);

                this.contextTextbox.Text = response.Value.Choices[0].Message.Content;

            }catch (Exception ex) {
                this.errorMessage.Text = ex.Message;
            }

        }

        private void fileToSendText_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void selectFileToRead_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            selectedFileText.Text = filePath;
            this.selectedFileContent = fileContent;
        }
    }
}
