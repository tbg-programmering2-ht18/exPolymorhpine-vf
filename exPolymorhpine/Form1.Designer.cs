namespace exPolymorhpine
{
    partial class Form1
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
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(0, 12);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(104, 24);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "Välj Typ A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(0, 62);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(104, 24);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "Välj Typ B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(713, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 43);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Baton";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(0, 116);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(104, 24);
            this.rbC.TabIndex = 3;
            this.rbC.TabStop = true;
            this.rbC.Text = "Välj Typ C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(53, 386);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(715, 26);
            this.Text.TabIndex = 4;
            this.Text.Text = "How to";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Name =("Form1");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.TextBox Text;
    }
}

