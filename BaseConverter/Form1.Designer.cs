namespace BaseConverter
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
            MainGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            Btn_Convert = new Button();
            TextBox_output_hexidecimal = new RichTextBox();
            TextBox_output_basetwo = new RichTextBox();
            TextBox_Input = new RichTextBox();
            MainGroup.SuspendLayout();
            SuspendLayout();
            // 
            // MainGroup
            // 
            MainGroup.Controls.Add(label2);
            MainGroup.Controls.Add(label1);
            MainGroup.Controls.Add(Btn_Convert);
            MainGroup.Controls.Add(TextBox_output_hexidecimal);
            MainGroup.Controls.Add(TextBox_output_basetwo);
            MainGroup.Controls.Add(TextBox_Input);
            MainGroup.Location = new Point(12, 22);
            MainGroup.Name = "MainGroup";
            MainGroup.Size = new Size(404, 202);
            MainGroup.TabIndex = 0;
            MainGroup.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 147);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Hexidecimal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 97);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Base 2";
            // 
            // Btn_Convert
            // 
            Btn_Convert.Location = new Point(311, 40);
            Btn_Convert.Name = "Btn_Convert";
            Btn_Convert.Size = new Size(77, 32);
            Btn_Convert.TabIndex = 3;
            Btn_Convert.Text = "Convert";
            Btn_Convert.UseVisualStyleBackColor = true;
            Btn_Convert.Click += Btn_Convert_Click;
            // 
            // TextBox_output_hexidecimal
            // 
            TextBox_output_hexidecimal.Location = new Point(15, 144);
            TextBox_output_hexidecimal.Name = "TextBox_output_hexidecimal";
            TextBox_output_hexidecimal.Size = new Size(260, 32);
            TextBox_output_hexidecimal.TabIndex = 2;
            TextBox_output_hexidecimal.Text = "";
            // 
            // TextBox_output_basetwo
            // 
            TextBox_output_basetwo.Location = new Point(15, 94);
            TextBox_output_basetwo.Name = "TextBox_output_basetwo";
            TextBox_output_basetwo.Size = new Size(260, 32);
            TextBox_output_basetwo.TabIndex = 1;
            TextBox_output_basetwo.Text = "";
            // 
            // TextBox_Input
            // 
            TextBox_Input.Location = new Point(15, 40);
            TextBox_Input.Name = "TextBox_Input";
            TextBox_Input.Size = new Size(260, 32);
            TextBox_Input.TabIndex = 0;
            TextBox_Input.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 249);
            Controls.Add(MainGroup);
            Name = "Form1";
            Text = "Base Converter";
            MainGroup.ResumeLayout(false);
            MainGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainGroup;
        private Label label2;
        private Label label1;
        private Button Btn_Convert;
        private RichTextBox TextBox_output_hexidecimal;
        private RichTextBox TextBox_output_basetwo;
        private RichTextBox TextBox_Input;
    }
}