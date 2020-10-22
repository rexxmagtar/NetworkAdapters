namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxAdapterName = new System.Windows.Forms.TextBox();
            this.buttonDisableAdapter = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.labelAdapterName = new System.Windows.Forms.Label();
            this.cloclLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(423, 371);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // textBoxAdapterName
            // 
            this.textBoxAdapterName.Location = new System.Drawing.Point(481, 68);
            this.textBoxAdapterName.Name = "textBoxAdapterName";
            this.textBoxAdapterName.Size = new System.Drawing.Size(329, 22);
            this.textBoxAdapterName.TabIndex = 1;
            // 
            // buttonDisableAdapter
            // 
            this.buttonDisableAdapter.Location = new System.Drawing.Point(481, 106);
            this.buttonDisableAdapter.Name = "buttonDisableAdapter";
            this.buttonDisableAdapter.Size = new System.Drawing.Size(75, 23);
            this.buttonDisableAdapter.TabIndex = 2;
            this.buttonDisableAdapter.Text = "Disable ";
            this.buttonDisableAdapter.UseVisualStyleBackColor = true;
            this.buttonDisableAdapter.Click += new System.EventHandler(this.buttonDisableAdapter_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(562, 106);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(75, 23);
            this.buttonEnable.TabIndex = 3;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // labelAdapterName
            // 
            this.labelAdapterName.AutoSize = true;
            this.labelAdapterName.Location = new System.Drawing.Point(478, 48);
            this.labelAdapterName.Name = "labelAdapterName";
            this.labelAdapterName.Size = new System.Drawing.Size(97, 17);
            this.labelAdapterName.TabIndex = 4;
            this.labelAdapterName.Text = "Adapter name";
            // 
            // cloclLabel
            // 
            this.cloclLabel.AutoSize = true;
            this.cloclLabel.Location = new System.Drawing.Point(641, 421);
            this.cloclLabel.Name = "cloclLabel";
            this.cloclLabel.Size = new System.Drawing.Size(40, 17);
            this.cloclLabel.TabIndex = 5;
            this.cloclLabel.Text = "clock";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 398);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(423, 40);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cloclLabel);
            this.Controls.Add(this.labelAdapterName);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonDisableAdapter);
            this.Controls.Add(this.textBoxAdapterName);
            this.Controls.Add(this.textBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxAdapterName;
        private System.Windows.Forms.Button buttonDisableAdapter;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Label labelAdapterName;
        private System.Windows.Forms.Label cloclLabel;
        private System.Windows.Forms.Button updateButton;
    }
}

