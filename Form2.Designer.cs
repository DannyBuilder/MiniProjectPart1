namespace MiniProjectPart1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            adminButton = new Button();
            comboBoxTowns = new ComboBox();
            comboBoxCountries = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // adminButton
            // 
            adminButton.Location = new Point(283, 302);
            adminButton.Margin = new Padding(4, 5, 4, 5);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(173, 38);
            adminButton.TabIndex = 0;
            adminButton.Text = "Make Changes";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // comboBoxTowns
            // 
            comboBoxTowns.FormattingEnabled = true;
            comboBoxTowns.Location = new Point(416, 160);
            comboBoxTowns.Margin = new Padding(4, 5, 4, 5);
            comboBoxTowns.Name = "comboBoxTowns";
            comboBoxTowns.Size = new Size(171, 33);
            comboBoxTowns.TabIndex = 1;
            comboBoxTowns.SelectedIndexChanged += comboBoxTowns_SelectedIndexChanged;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(124, 160);
            comboBoxCountries.Margin = new Padding(4, 5, 4, 5);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(171, 33);
            comboBoxCountries.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 123);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 123);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "City";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCountries);
            Controls.Add(comboBoxTowns);
            Controls.Add(adminButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminButton;
        private ComboBox comboBoxTowns;
        private ComboBox comboBoxCountries;
        private Label label1;
        private Label label2;
    }
}