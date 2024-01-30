namespace CodeGenie
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.applicationCloseButton = new System.Windows.Forms.Button();
            this.contextTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionSubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionClearButton = new System.Windows.Forms.Button();
            this.contextClearButton = new System.Windows.Forms.Button();
            this.selectFileToRead = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedFileText = new System.Windows.Forms.Label();
            this.includeSelectedFileContent = new System.Windows.Forms.CheckBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applicationCloseButton
            // 
            this.applicationCloseButton.Location = new System.Drawing.Point(643, 335);
            this.applicationCloseButton.Name = "applicationCloseButton";
            this.applicationCloseButton.Size = new System.Drawing.Size(131, 49);
            this.applicationCloseButton.TabIndex = 0;
            this.applicationCloseButton.Text = "Close Application";
            this.applicationCloseButton.UseVisualStyleBackColor = true;
            this.applicationCloseButton.Click += new System.EventHandler(this.applicationCloseButton_Click);
            // 
            // contextTextbox
            // 
            this.contextTextbox.Location = new System.Drawing.Point(35, 74);
            this.contextTextbox.Multiline = true;
            this.contextTextbox.Name = "contextTextbox";
            this.contextTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contextTextbox.Size = new System.Drawing.Size(419, 310);
            this.contextTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actual Program to analyse:";
            // 
            // questionSubmitButton
            // 
            this.questionSubmitButton.Location = new System.Drawing.Point(643, 264);
            this.questionSubmitButton.Name = "questionSubmitButton";
            this.questionSubmitButton.Size = new System.Drawing.Size(129, 52);
            this.questionSubmitButton.TabIndex = 3;
            this.questionSubmitButton.Text = "Prompt";
            this.questionSubmitButton.UseVisualStyleBackColor = true;
            this.questionSubmitButton.Click += new System.EventHandler(this.questionSubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your question:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(478, 74);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionTextBox.Size = new System.Drawing.Size(294, 158);
            this.questionTextBox.TabIndex = 5;
            // 
            // questionClearButton
            // 
            this.questionClearButton.Location = new System.Drawing.Point(508, 264);
            this.questionClearButton.Name = "questionClearButton";
            this.questionClearButton.Size = new System.Drawing.Size(129, 52);
            this.questionClearButton.TabIndex = 3;
            this.questionClearButton.Text = "Clear question";
            this.questionClearButton.UseVisualStyleBackColor = true;
            this.questionClearButton.Click += new System.EventHandler(this.questionClearButton_Click);
            // 
            // contextClearButton
            // 
            this.contextClearButton.Location = new System.Drawing.Point(508, 335);
            this.contextClearButton.Name = "contextClearButton";
            this.contextClearButton.Size = new System.Drawing.Size(129, 52);
            this.contextClearButton.TabIndex = 3;
            this.contextClearButton.Text = "Clear context";
            this.contextClearButton.UseVisualStyleBackColor = true;
            this.contextClearButton.Click += new System.EventHandler(this.contextClearButton_Click);
            // 
            // selectFileToRead
            // 
            this.selectFileToRead.Location = new System.Drawing.Point(508, 411);
            this.selectFileToRead.Name = "selectFileToRead";
            this.selectFileToRead.Size = new System.Drawing.Size(129, 52);
            this.selectFileToRead.TabIndex = 6;
            this.selectFileToRead.Text = "Select File";
            this.selectFileToRead.UseVisualStyleBackColor = true;
            this.selectFileToRead.Click += new System.EventHandler(this.selectFileToRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected file:";
            // 
            // selectedFileText
            // 
            this.selectedFileText.AutoSize = true;
            this.selectedFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFileText.Location = new System.Drawing.Point(601, 489);
            this.selectedFileText.Name = "selectedFileText";
            this.selectedFileText.Size = new System.Drawing.Size(44, 16);
            this.selectedFileText.TabIndex = 8;
            this.selectedFileText.Text = "None";
            this.selectedFileText.Click += new System.EventHandler(this.selectFileToRead_Click);
            // 
            // includeSelectedFileContent
            // 
            this.includeSelectedFileContent.AutoSize = true;
            this.includeSelectedFileContent.Location = new System.Drawing.Point(509, 518);
            this.includeSelectedFileContent.Name = "includeSelectedFileContent";
            this.includeSelectedFileContent.Size = new System.Drawing.Size(190, 20);
            this.includeSelectedFileContent.TabIndex = 9;
            this.includeSelectedFileContent.Text = "Include selected filecontent";
            this.includeSelectedFileContent.UseVisualStyleBackColor = true;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(10, 582);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 16);
            this.errorMessage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 646);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.includeSelectedFileContent);
            this.Controls.Add(this.selectedFileText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectFileToRead);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contextClearButton);
            this.Controls.Add(this.questionClearButton);
            this.Controls.Add(this.questionSubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contextTextbox);
            this.Controls.Add(this.applicationCloseButton);
            this.Name = "Form1";
            this.Text = "CodeGenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contextTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button questionSubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button questionClearButton;
        private System.Windows.Forms.Button applicationCloseButton;
        private System.Windows.Forms.Button contextClearButton;
        private System.Windows.Forms.Button selectFileToRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedFileText;
        private System.Windows.Forms.CheckBox includeSelectedFileContent;
        private System.Windows.Forms.Label errorMessage;
    }
}

