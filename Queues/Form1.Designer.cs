
namespace Queues
{
    partial class Appointments
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
            this.components = new System.ComponentModel.Container();
            this.AppointmentDate = new System.Windows.Forms.Label();
            this.AppointmentName = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentNameTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PatientName = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.TimeManager = new System.Windows.Forms.Timer(this.components);
            this.TextCurrentDate = new System.Windows.Forms.Label();
            this.Enqueue = new System.Windows.Forms.Button();
            this.StopQueue = new System.Windows.Forms.Button();
            this.AddToQueue = new System.Windows.Forms.Button();
            this.RemoveFromQueue = new System.Windows.Forms.Button();
            this.InsertIntoQueue = new System.Windows.Forms.Button();
            this.TextCurrentHour = new System.Windows.Forms.Label();
            this.Blinker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.NameTextBox.Location = new System.Drawing.Point(90, 8);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // AppointmentNameTextBox
            // 
            this.AppointmentNameTextBox.Location = new System.Drawing.Point(90, 33);
            this.AppointmentNameTextBox.Name = "AppointmentNameTextBox";
            this.AppointmentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentNameTextBox.TabIndex = 5;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppointmentDatePicker.Location = new System.Drawing.Point(90, 58);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(100, 20);
            this.AppointmentDatePicker.TabIndex = 6;
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Location = new System.Drawing.Point(15, 15);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(69, 13);
            this.PatientName.TabIndex = 7;
            this.PatientName.Text = "Patient name";
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Location = new System.Drawing.Point(15, 90);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(65, 13);
            this.CurrentDate.TabIndex = 8;
            this.CurrentDate.Text = "Current date";
            // 
            // TimeManager
            // 
            this.TimeManager.Enabled = true;
            this.TimeManager.Interval = 1000;
            this.TimeManager.Tick += new System.EventHandler(this.TimeManager_Tick);
            // 
            // TextCurrentDate
            // 
            this.TextCurrentDate.AutoSize = true;
            this.TextCurrentDate.Location = new System.Drawing.Point(90, 90);
            this.TextCurrentDate.Name = "TextCurrentDate";
            this.TextCurrentDate.Size = new System.Drawing.Size(80, 13);
            this.TextCurrentDate.TabIndex = 9;
            this.TextCurrentDate.Text = "timeDateHolder";
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(200, 7);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(100, 20);
            this.Enqueue.TabIndex = 10;
            this.Enqueue.Text = "Start queue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.StartQueue_Click);
            // 
            // StopQueue
            // 
            this.StopQueue.Location = new System.Drawing.Point(310, 7);
            this.StopQueue.Name = "StopQueue";
            this.StopQueue.Size = new System.Drawing.Size(100, 20);
            this.StopQueue.TabIndex = 11;
            this.StopQueue.Text = "Stop queue";
            this.StopQueue.UseVisualStyleBackColor = true;
            this.StopQueue.Click += new System.EventHandler(this.StopQueue_Click);
            // 
            // AddToQueue
            // 
            this.AddToQueue.Location = new System.Drawing.Point(200, 32);
            this.AddToQueue.Name = "AddToQueue";
            this.AddToQueue.Size = new System.Drawing.Size(100, 20);
            this.AddToQueue.TabIndex = 12;
            this.AddToQueue.Text = "Add to queue";
            this.AddToQueue.UseVisualStyleBackColor = true;
            this.AddToQueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // RemoveFromQueue
            // 
            this.RemoveFromQueue.Location = new System.Drawing.Point(310, 32);
            this.RemoveFromQueue.Name = "RemoveFromQueue";
            this.RemoveFromQueue.Size = new System.Drawing.Size(100, 20);
            this.RemoveFromQueue.TabIndex = 13;
            this.RemoveFromQueue.Text = "Rem. from queue";
            this.RemoveFromQueue.UseVisualStyleBackColor = true;
            this.RemoveFromQueue.Click += new System.EventHandler(this.RemoveFromQueue_Click);
            // 
            // InsertIntoQueue
            // 
            this.InsertIntoQueue.Location = new System.Drawing.Point(200, 58);
            this.InsertIntoQueue.Name = "InsertIntoQueue";
            this.InsertIntoQueue.Size = new System.Drawing.Size(100, 20);
            this.InsertIntoQueue.TabIndex = 14;
            this.InsertIntoQueue.Text = "Insert into queue";
            this.InsertIntoQueue.UseVisualStyleBackColor = true;
            this.InsertIntoQueue.Click += new System.EventHandler(this.InsertIntoQueue_Click);
            // 
            // TextCurrentHour
            // 
            this.TextCurrentHour.AutoSize = true;
            this.TextCurrentHour.Location = new System.Drawing.Point(176, 90);
            this.TextCurrentHour.Name = "TextCurrentHour";
            this.TextCurrentHour.Size = new System.Drawing.Size(107, 13);
            this.TextCurrentHour.TabIndex = 15;
            this.TextCurrentHour.Text = "timeHourPlaceHolder";
            // 
            // Blinker
            // 
            this.Blinker.Tick += new System.EventHandler(this.Blinker_Tick);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 117);
            this.Controls.Add(this.TextCurrentHour);
            this.Controls.Add(this.InsertIntoQueue);
            this.Controls.Add(this.RemoveFromQueue);
            this.Controls.Add(this.AddToQueue);
            this.Controls.Add(this.StopQueue);
            this.Controls.Add(this.Enqueue);
            this.Controls.Add(this.TextCurrentDate);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.AppointmentNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AppointmentName);
            this.Controls.Add(this.AppointmentDate);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentDate;
        private System.Windows.Forms.Label AppointmentName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AppointmentNameTextBox;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Timer TimeManager;
        private System.Windows.Forms.Label TextCurrentDate;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.Button StopQueue;
        private System.Windows.Forms.Button AddToQueue;
        private System.Windows.Forms.Button RemoveFromQueue;
        private System.Windows.Forms.Button InsertIntoQueue;
        private System.Windows.Forms.Label TextCurrentHour;
        private System.Windows.Forms.Timer Blinker;
    }
}

