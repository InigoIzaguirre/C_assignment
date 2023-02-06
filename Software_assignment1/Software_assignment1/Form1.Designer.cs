namespace Software_assignment1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSamplingTime = new System.Windows.Forms.TextBox();
            this.btnSample = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoggingTime = new System.Windows.Forms.TextBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSensorValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSamplingTime);
            this.groupBox1.Controls.Add(this.btnSample);
            this.groupBox1.Location = new System.Drawing.Point(69, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSamplingTime
            // 
            this.txtSamplingTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSamplingTime.Location = new System.Drawing.Point(113, 30);
            this.txtSamplingTime.Multiline = true;
            this.txtSamplingTime.Name = "txtSamplingTime";
            this.txtSamplingTime.Size = new System.Drawing.Size(100, 20);
            this.txtSamplingTime.TabIndex = 1;
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(99, 69);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 23);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLoggingTime);
            this.groupBox2.Controls.Add(this.btnLogging);
            this.groupBox2.Location = new System.Drawing.Point(69, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // txtLoggingTime
            // 
            this.txtLoggingTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLoggingTime.Location = new System.Drawing.Point(113, 34);
            this.txtLoggingTime.Multiline = true;
            this.txtLoggingTime.Name = "txtLoggingTime";
            this.txtLoggingTime.Size = new System.Drawing.Size(100, 20);
            this.txtLoggingTime.TabIndex = 1;
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(87, 69);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(96, 24);
            this.btnLogging.TabIndex = 0;
            this.btnLogging.Text = "Logging on time";
            this.btnLogging.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSensorValues);
            this.groupBox3.Location = new System.Drawing.Point(377, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor values";
            // 
            // txtSensorValues
            // 
            this.txtSensorValues.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSensorValues.Location = new System.Drawing.Point(6, 19);
            this.txtSensorValues.Multiline = true;
            this.txtSensorValues.Name = "txtSensorValues";
            this.txtSensorValues.Size = new System.Drawing.Size(129, 203);
            this.txtSensorValues.TabIndex = 0;
            this.txtSensorValues.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Next sampling time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next logging time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSensorValues;
        private System.Windows.Forms.TextBox txtSamplingTime;
        private System.Windows.Forms.TextBox txtLoggingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

