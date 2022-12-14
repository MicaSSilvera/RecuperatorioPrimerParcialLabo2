
namespace WinFormsHospital
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstEgresado = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.cboOrdenarEgresados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEgresar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.lstIngresado);
            this.groupBox2.Location = new System.Drawing.Point(3, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 351);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboOrdenarEgresados);
            this.groupBox3.Controls.Add(this.lstEgresado);
            this.groupBox3.Location = new System.Drawing.Point(479, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 348);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Egresados";
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.ItemHeight = 15;
            this.lstIngresado.Location = new System.Drawing.Point(3, 22);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(461, 259);
            this.lstIngresado.TabIndex = 0;
            // 
            // lstEgresado
            // 
            this.lstEgresado.FormattingEnabled = true;
            this.lstEgresado.ItemHeight = 15;
            this.lstEgresado.Location = new System.Drawing.Point(6, 19);
            this.lstEgresado.Name = "lstEgresado";
            this.lstEgresado.Size = new System.Drawing.Size(598, 259);
            this.lstEgresado.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(3, 302);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(120, 43);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEgresar
            // 
            this.btnEgresar.BackColor = System.Drawing.Color.Red;
            this.btnEgresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEgresar.Location = new System.Drawing.Point(343, 302);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(120, 43);
            this.btnEgresar.TabIndex = 2;
            this.btnEgresar.Text = "Egresar";
            this.btnEgresar.UseVisualStyleBackColor = false;
            this.btnEgresar.Click += new System.EventHandler(this.btnEgresar_Click);
            // 
            // cboOrdenarEgresados
            // 
            this.cboOrdenarEgresados.FormattingEnabled = true;
            this.cboOrdenarEgresados.Location = new System.Drawing.Point(6, 311);
            this.cboOrdenarEgresados.Name = "cboOrdenarEgresados";
            this.cboOrdenarEgresados.Size = new System.Drawing.Size(170, 23);
            this.cboOrdenarEgresados.TabIndex = 2;
            this.cboOrdenarEgresados.SelectedIndexChanged += new System.EventHandler(this.cboOrdenarEgresados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenar por:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 400);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrdenarEgresados;
        private System.Windows.Forms.ListBox lstEgresado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lstIngresado;
    }
}

