
namespace Queues
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.AppointmentDate = new System.Windows.Forms.Label();
            this.AppointmentName = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentNameTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(15, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSize = true;
            this.AppointmentDate.Location = new System.Drawing.Point(15, 65);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(30, 13);
            this.AppointmentDate.TabIndex = 1;
            this.AppointmentDate.Text = "Date";
            // 
            // AppointmentName
            // 
            this.AppointmentName.AutoSize = true;
            this.AppointmentName.Location = new System.Drawing.Point(15, 40);
            this.AppointmentName.Name = "AppointmentName";
            this.AppointmentName.Size = new System.Drawing.Size(66, 13);
            this.AppointmentName.TabIndex = 3;
            this.AppointmentName.Text = "Appointment";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(125, 8);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // AppointmentNameTextBox
            // 
            this.AppointmentNameTextBox.Location = new System.Drawing.Point(125, 35);
            this.AppointmentNameTextBox.Name = "AppointmentNameTextBox";
            this.AppointmentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentNameTextBox.TabIndex = 5;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Location = new System.Drawing.Point(125, 62);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentDatePicker.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.AppointmentNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AppointmentName);
            this.Controls.Add(this.AppointmentDate);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label AppointmentDate;
        private System.Windows.Forms.Label AppointmentName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AppointmentNameTextBox;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
    }
}

