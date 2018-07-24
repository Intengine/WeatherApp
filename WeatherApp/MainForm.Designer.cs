namespace WeatherApp
{
    partial class MainForm
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
            this.labelCityName = new System.Windows.Forms.Label();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.labelScaleName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelTemp2 = new System.Windows.Forms.Label();
            this.labelWind2 = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.labelCondition2 = new System.Windows.Forms.Label();
            this.labelDay2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTemp3 = new System.Windows.Forms.Label();
            this.labelWind3 = new System.Windows.Forms.Label();
            this.labelDescription3 = new System.Windows.Forms.Label();
            this.labelCondition3 = new System.Windows.Forms.Label();
            this.labelDay3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCityName.ForeColor = System.Drawing.Color.Gray;
            this.labelCityName.Location = new System.Drawing.Point(46, 48);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(427, 47);
            this.labelCityName.TabIndex = 0;
            this.labelCityName.Text = "Bielsko-Biała, Poland";
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountryName.ForeColor = System.Drawing.Color.Gray;
            this.labelCountryName.Location = new System.Drawing.Point(48, 95);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(104, 32);
            this.labelCountryName.TabIndex = 1;
            this.labelCountryName.Text = "Śląskie";
            // 
            // pictureMain
            // 
            this.pictureMain.Image = global::WeatherApp.Properties.Resources.CloudRain;
            this.pictureMain.Location = new System.Drawing.Point(54, 153);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(100, 89);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMain.TabIndex = 2;
            this.pictureMain.TabStop = false;
            // 
            // labelScaleName
            // 
            this.labelScaleName.AutoSize = true;
            this.labelScaleName.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScaleName.ForeColor = System.Drawing.Color.Gray;
            this.labelScaleName.Location = new System.Drawing.Point(160, 153);
            this.labelScaleName.Name = "labelScaleName";
            this.labelScaleName.Size = new System.Drawing.Size(77, 70);
            this.labelScaleName.TabIndex = 3;
            this.labelScaleName.Text = "C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.CloudRain;
            this.pictureBox1.Location = new System.Drawing.Point(488, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.ForeColor = System.Drawing.Color.Gray;
            this.labelDay.Location = new System.Drawing.Point(560, 153);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(55, 23);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "Days";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCondition.ForeColor = System.Drawing.Color.Gray;
            this.labelCondition.Location = new System.Drawing.Point(562, 185);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(90, 19);
            this.labelCondition.TabIndex = 6;
            this.labelCondition.Text = "Conditions";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription.Location = new System.Drawing.Point(562, 204);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(94, 19);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWind.ForeColor = System.Drawing.Color.Gray;
            this.labelWind.Location = new System.Drawing.Point(695, 153);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(93, 26);
            this.labelWind.TabIndex = 9;
            this.labelWind.Text = "12km/h";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp.ForeColor = System.Drawing.Color.Gray;
            this.labelTemp.Location = new System.Drawing.Point(695, 181);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(36, 26);
            this.labelTemp.TabIndex = 10;
            this.labelTemp.Text = "26";
            // 
            // labelTemp2
            // 
            this.labelTemp2.AutoSize = true;
            this.labelTemp2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp2.ForeColor = System.Drawing.Color.Gray;
            this.labelTemp2.Location = new System.Drawing.Point(695, 283);
            this.labelTemp2.Name = "labelTemp2";
            this.labelTemp2.Size = new System.Drawing.Size(36, 26);
            this.labelTemp2.TabIndex = 16;
            this.labelTemp2.Text = "26";
            // 
            // labelWind2
            // 
            this.labelWind2.AutoSize = true;
            this.labelWind2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWind2.ForeColor = System.Drawing.Color.Gray;
            this.labelWind2.Location = new System.Drawing.Point(695, 255);
            this.labelWind2.Name = "labelWind2";
            this.labelWind2.Size = new System.Drawing.Size(93, 26);
            this.labelWind2.TabIndex = 15;
            this.labelWind2.Text = "12km/h";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription2.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription2.Location = new System.Drawing.Point(562, 306);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(94, 19);
            this.labelDescription2.TabIndex = 14;
            this.labelDescription2.Text = "Description";
            // 
            // labelCondition2
            // 
            this.labelCondition2.AutoSize = true;
            this.labelCondition2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCondition2.ForeColor = System.Drawing.Color.Gray;
            this.labelCondition2.Location = new System.Drawing.Point(562, 287);
            this.labelCondition2.Name = "labelCondition2";
            this.labelCondition2.Size = new System.Drawing.Size(90, 19);
            this.labelCondition2.TabIndex = 13;
            this.labelCondition2.Text = "Conditions";
            // 
            // labelDay2
            // 
            this.labelDay2.AutoSize = true;
            this.labelDay2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay2.ForeColor = System.Drawing.Color.Gray;
            this.labelDay2.Location = new System.Drawing.Point(560, 255);
            this.labelDay2.Name = "labelDay2";
            this.labelDay2.Size = new System.Drawing.Size(55, 23);
            this.labelDay2.TabIndex = 12;
            this.labelDay2.Text = "Days";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WeatherApp.Properties.Resources.CloudRain;
            this.pictureBox2.Location = new System.Drawing.Point(488, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // labelTemp3
            // 
            this.labelTemp3.AutoSize = true;
            this.labelTemp3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp3.ForeColor = System.Drawing.Color.Gray;
            this.labelTemp3.Location = new System.Drawing.Point(695, 385);
            this.labelTemp3.Name = "labelTemp3";
            this.labelTemp3.Size = new System.Drawing.Size(36, 26);
            this.labelTemp3.TabIndex = 22;
            this.labelTemp3.Text = "26";
            // 
            // labelWind3
            // 
            this.labelWind3.AutoSize = true;
            this.labelWind3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWind3.ForeColor = System.Drawing.Color.Gray;
            this.labelWind3.Location = new System.Drawing.Point(695, 357);
            this.labelWind3.Name = "labelWind3";
            this.labelWind3.Size = new System.Drawing.Size(93, 26);
            this.labelWind3.TabIndex = 21;
            this.labelWind3.Text = "12km/h";
            // 
            // labelDescription3
            // 
            this.labelDescription3.AutoSize = true;
            this.labelDescription3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription3.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription3.Location = new System.Drawing.Point(562, 408);
            this.labelDescription3.Name = "labelDescription3";
            this.labelDescription3.Size = new System.Drawing.Size(94, 19);
            this.labelDescription3.TabIndex = 20;
            this.labelDescription3.Text = "Description";
            // 
            // labelCondition3
            // 
            this.labelCondition3.AutoSize = true;
            this.labelCondition3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCondition3.ForeColor = System.Drawing.Color.Gray;
            this.labelCondition3.Location = new System.Drawing.Point(562, 389);
            this.labelCondition3.Name = "labelCondition3";
            this.labelCondition3.Size = new System.Drawing.Size(90, 19);
            this.labelCondition3.TabIndex = 19;
            this.labelCondition3.Text = "Conditions";
            // 
            // labelDay3
            // 
            this.labelDay3.AutoSize = true;
            this.labelDay3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay3.ForeColor = System.Drawing.Color.Gray;
            this.labelDay3.Location = new System.Drawing.Point(560, 357);
            this.labelDay3.Name = "labelDay3";
            this.labelDay3.Size = new System.Drawing.Size(55, 23);
            this.labelDay3.TabIndex = 18;
            this.labelDay3.Text = "Days";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WeatherApp.Properties.Resources.CloudRain;
            this.pictureBox3.Location = new System.Drawing.Point(488, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.labelTemp3);
            this.Controls.Add(this.labelWind3);
            this.Controls.Add(this.labelDescription3);
            this.Controls.Add(this.labelCondition3);
            this.Controls.Add(this.labelDay3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelTemp2);
            this.Controls.Add(this.labelWind2);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.labelCondition2);
            this.Controls.Add(this.labelDay2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScaleName);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.labelCityName);
            this.Name = "MainForm";
            this.Text = "Intengine Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.Label labelScaleName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelTemp2;
        private System.Windows.Forms.Label labelWind2;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.Label labelCondition2;
        private System.Windows.Forms.Label labelDay2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTemp3;
        private System.Windows.Forms.Label labelWind3;
        private System.Windows.Forms.Label labelDescription3;
        private System.Windows.Forms.Label labelCondition3;
        private System.Windows.Forms.Label labelDay3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

