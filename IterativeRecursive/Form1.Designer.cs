namespace IterativeRecursive
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
            txtNumber = new TextBox();
            btnIterative = new Button();
            label1 = new Label();
            lblResult = new Label();
            btnRecursive = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(131, 78);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 0;
            // 
            // btnIterative
            // 
            btnIterative.Location = new Point(237, 77);
            btnIterative.Name = "btnIterative";
            btnIterative.Size = new Size(75, 23);
            btnIterative.TabIndex = 1;
            btnIterative.Text = "Iterative";
            btnIterative.UseVisualStyleBackColor = true;
            btnIterative.Click += btnIterative_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter the number";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(121, 148);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            // 
            // btnRecursive
            // 
            btnRecursive.Location = new Point(237, 106);
            btnRecursive.Name = "btnRecursive";
            btnRecursive.Size = new Size(75, 23);
            btnRecursive.TabIndex = 4;
            btnRecursive.Text = "Recursive";
            btnRecursive.UseVisualStyleBackColor = true;
            btnRecursive.Click += btnRecursive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecursive);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnIterative);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnIterative;
        private Label label1;
        private Label lblResult;
        private Button btnRecursive;
    }
}
