namespace Mover
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
            inputBox = new TextBox();
            outputBox = new TextBox();
            fromBox = new TextBox();
            toBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 32);
            inputBox.Multiline = true;
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(529, 68);
            inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            outputBox.Location = new Point(12, 196);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(529, 62);
            outputBox.TabIndex = 1;
            // 
            // fromBox
            // 
            fromBox.Location = new Point(66, 122);
            fromBox.Name = "fromBox";
            fromBox.Size = new Size(125, 27);
            fromBox.TabIndex = 2;
            // 
            // toBox
            // 
            toBox.Location = new Point(253, 122);
            toBox.Name = "toBox";
            toBox.Size = new Size(125, 27);
            toBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(412, 282);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 4;
            button1.Text = "Преобразовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите строку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 125);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 6;
            label2.Text = "b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 125);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 7;
            label3.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 345);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(toBox);
            Controls.Add(fromBox);
            Controls.Add(outputBox);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "Mover";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private TextBox outputBox;
        private TextBox fromBox;
        private TextBox toBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}