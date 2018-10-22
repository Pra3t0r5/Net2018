namespace Escritorio
{
    partial class Lista
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
            this.cbApeyNom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbApeyNom
            // 
            this.cbApeyNom.AccessibleName = "s";
            this.cbApeyNom.FormattingEnabled = true;
            this.cbApeyNom.Location = new System.Drawing.Point(111, 16);
            this.cbApeyNom.Name = "cbApeyNom";
            this.cbApeyNom.Size = new System.Drawing.Size(173, 21);
            this.cbApeyNom.TabIndex = 0;
            this.cbApeyNom.SelectionChangeCommitted += new System.EventHandler(this.cbApeyNom_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y Apellido";
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(209, 69);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(75, 23);
            this.btnVal.TabIndex = 2;
            this.btnVal.Text = "Validar";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 104);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbApeyNom);
            this.Name = "Lista";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbApeyNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVal;
    }
}