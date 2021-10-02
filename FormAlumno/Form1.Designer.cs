
namespace FormAlumno
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtInsc = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(72, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 33);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(178, 75);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(171, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(519, 75);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(171, 20);
            this.txtAp.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(413, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 33);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(178, 161);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(171, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(72, 151);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(72, 33);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "D.N.I:";
            // 
            // txtLeg
            // 
            this.txtLeg.Location = new System.Drawing.Point(519, 161);
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(171, 20);
            this.txtLeg.TabIndex = 7;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(413, 151);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(84, 33);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(178, 241);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(171, 20);
            this.txtCar.TabIndex = 9;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(72, 231);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(94, 33);
            this.lblCarrera.TabIndex = 8;
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtInsc
            // 
            this.txtInsc.Location = new System.Drawing.Point(278, 316);
            this.txtInsc.Name = "txtInsc";
            this.txtInsc.Size = new System.Drawing.Size(171, 20);
            this.txtInsc.TabIndex = 11;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(72, 306);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(200, 33);
            this.lblInscripcion.TabIndex = 10;
            this.lblInscripcion.Text = "Año de inscripcion:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(112, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(658, 434);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 13);
            this.lblCont.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInsc);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtLeg);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtInsc;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCont;
    }
}

