namespace MiniProjectPart1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            replacedTownTextBox = new TextBox();
            townTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(146, 487);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddTownButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 487);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(107, 38);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateTownButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(663, 487);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteTownButton_Click;
            // 
            // replacedTownTextBox
            // 
            replacedTownTextBox.Location = new Point(446, 198);
            replacedTownTextBox.Margin = new Padding(4, 5, 4, 5);
            replacedTownTextBox.Name = "replacedTownTextBox";
            replacedTownTextBox.Size = new Size(141, 31);
            replacedTownTextBox.TabIndex = 3;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(446, 293);
            townTextBox.Margin = new Padding(4, 5, 4, 5);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(141, 31);
            townTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 298);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 5;
            label1.Text = "Replace with";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 204);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 6;
            label2.Text = "Town:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(townTextBox);
            Controls.Add(replacedTownTextBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox replacedTownTextBox;
        private TextBox townTextBox;
        private Label label1;
        private Label label2;
    }
}