
namespace Pooo
{
    partial class cargar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnCleantxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de cuenta";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(364, 139);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(260, 20);
            this.txtID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(364, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(364, 285);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(260, 20);
            this.txtBirthday.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre y apellido real";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(364, 383);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(260, 20);
            this.txtOwner.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo electronico";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(364, 464);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(646, 484);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(183, 49);
            this.btnregistrarse.TabIndex = 11;
            this.btnregistrarse.Text = "Registrarse";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(646, 95);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(534, 342);
            this.lstDatos.TabIndex = 12;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(877, 484);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(168, 49);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Salir";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnCleantxt
            // 
            this.btnCleantxt.Location = new System.Drawing.Point(1053, 484);
            this.btnCleantxt.Name = "btnCleantxt";
            this.btnCleantxt.Size = new System.Drawing.Size(118, 49);
            this.btnCleantxt.TabIndex = 14;
            this.btnCleantxt.Text = "Registrar otra cuenta";
            this.btnCleantxt.UseVisualStyleBackColor = true;
            this.btnCleantxt.Click += new System.EventHandler(this.btnCleantxt_Click);
            // 
            // cargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 545);
            this.Controls.Add(this.btnCleantxt);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnregistrarse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cargar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnregistrarse;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnCleantxt;
    }
}

