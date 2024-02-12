namespace appFrench
{
    partial class FormMain
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
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLearnSlowed = new System.Windows.Forms.Button();
            this.buttonLearnSpeed = new System.Windows.Forms.Button();
            this.buttonTopArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(12, 247);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(283, 23);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonLearnSlowed
            // 
            this.buttonLearnSlowed.Location = new System.Drawing.Point(12, 134);
            this.buttonLearnSlowed.Name = "buttonLearnSlowed";
            this.buttonLearnSlowed.Size = new System.Drawing.Size(128, 107);
            this.buttonLearnSlowed.TabIndex = 1;
            this.buttonLearnSlowed.Text = "Постепенное изучение";
            this.buttonLearnSlowed.UseVisualStyleBackColor = true;
            this.buttonLearnSlowed.Click += new System.EventHandler(this.buttonLearnSlowed_Click);
            // 
            // buttonLearnSpeed
            // 
            this.buttonLearnSpeed.Location = new System.Drawing.Point(163, 134);
            this.buttonLearnSpeed.Name = "buttonLearnSpeed";
            this.buttonLearnSpeed.Size = new System.Drawing.Size(132, 107);
            this.buttonLearnSpeed.TabIndex = 2;
            this.buttonLearnSpeed.Text = "Быстрая игра";
            this.buttonLearnSpeed.UseVisualStyleBackColor = true;
            this.buttonLearnSpeed.Click += new System.EventHandler(this.buttonLearnSpeed_Click);
            // 
            // buttonTopArray
            // 
            this.buttonTopArray.Location = new System.Drawing.Point(12, 276);
            this.buttonTopArray.Name = "buttonTopArray";
            this.buttonTopArray.Size = new System.Drawing.Size(283, 23);
            this.buttonTopArray.TabIndex = 3;
            this.buttonTopArray.Text = "Топ игроков";
            this.buttonTopArray.UseVisualStyleBackColor = true;
            this.buttonTopArray.Click += new System.EventHandler(this.buttonTopArray_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 360);
            this.Controls.Add(this.buttonTopArray);
            this.Controls.Add(this.buttonLearnSpeed);
            this.Controls.Add(this.buttonLearnSlowed);
            this.Controls.Add(this.buttonProfile);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLearnSlowed;
        private System.Windows.Forms.Button buttonLearnSpeed;
        private System.Windows.Forms.Button buttonTopArray;
    }
}