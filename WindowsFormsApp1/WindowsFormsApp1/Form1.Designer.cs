
namespace WindowsFormsApp1
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
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblSpeaker = new WindowsFormsApp1.ParlanteVirtual();
            this.lblRight = new WindowsFormsApp1.MotorVirtual();
            this.lblLeft = new WindowsFormsApp1.MotorVirtual();
            this.chkRight = new WindowsFormsApp1.SensorVirtual();
            this.chkLeft = new WindowsFormsApp1.SensorVirtual();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(99, 165);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "btnHistorial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Location = new System.Drawing.Point(115, 132);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(46, 13);
            this.lblSpeaker.TabIndex = 4;
            this.lblSpeaker.Text = "Parlante";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(178, 79);
            this.lblRight.Name = "MotorDer";
            this.lblRight.Size = new System.Drawing.Size(78, 13);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "Motor Derecho";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(12, 79);
            this.lblLeft.Name = "MotorIzq";
            this.lblLeft.Size = new System.Drawing.Size(80, 13);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Motor Izquierdo";
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Checked = true;
            this.chkRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRight.Location = new System.Drawing.Point(181, 23);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(103, 17);
            this.chkRight.TabIndex = 1;
            this.chkRight.Text = "Sensor Derecho";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Checked = true;
            this.chkLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLeft.Location = new System.Drawing.Point(12, 23);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(105, 17);
            this.chkLeft.TabIndex = 0;
            this.chkLeft.Text = "Sensor Izquierdo";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 415);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.lblSpeaker);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.chkRight);
            this.Controls.Add(this.chkLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SensorVirtual chkLeft;
        private SensorVirtual chkRight;

        private MotorVirtual lblLeft;
        private MotorVirtual lblRight;
        private ParlanteVirtual lblSpeaker;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

