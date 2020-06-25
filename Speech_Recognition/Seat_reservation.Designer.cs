namespace Speech_Recognition
{
    partial class Seat_reservation
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
            this.backBtn = new System.Windows.Forms.Button();
            this.U_name = new System.Windows.Forms.TextBox();
            this.U_departure = new System.Windows.Forms.TextBox();
            this.U_destenation = new System.Windows.Forms.TextBox();
            this.no_seats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(62, 406);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 32);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // U_name
            // 
            this.U_name.Location = new System.Drawing.Point(276, 101);
            this.U_name.Name = "U_name";
            this.U_name.Size = new System.Drawing.Size(223, 22);
            this.U_name.TabIndex = 10;
            // 
            // U_departure
            // 
            this.U_departure.Location = new System.Drawing.Point(276, 158);
            this.U_departure.Name = "U_departure";
            this.U_departure.Size = new System.Drawing.Size(223, 22);
            this.U_departure.TabIndex = 11;
            // 
            // U_destenation
            // 
            this.U_destenation.Location = new System.Drawing.Point(276, 214);
            this.U_destenation.Name = "U_destenation";
            this.U_destenation.Size = new System.Drawing.Size(223, 22);
            this.U_destenation.TabIndex = 12;
            // 
            // no_seats
            // 
            this.no_seats.Location = new System.Drawing.Point(276, 271);
            this.no_seats.Name = "no_seats";
            this.no_seats.Size = new System.Drawing.Size(223, 22);
            this.no_seats.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Destenation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "No of Seats";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(276, 329);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(223, 22);
            this.phone.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "User id";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(276, 43);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(223, 22);
            this.user_id.TabIndex = 22;
            // 
            // Seat_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(636, 453);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_seats);
            this.Controls.Add(this.U_destenation);
            this.Controls.Add(this.U_departure);
            this.Controls.Add(this.U_name);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seat_reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seat_reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox U_name;
        private System.Windows.Forms.TextBox U_departure;
        private System.Windows.Forms.TextBox U_destenation;
        private System.Windows.Forms.TextBox no_seats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_id;
    }
}