namespace appFrench
{
    partial class FormGame
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
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.buttonOption2 = new System.Windows.Forms.Button();
            this.buttonOption3 = new System.Windows.Forms.Button();
            this.buttonSkipLevel = new System.Windows.Forms.Button();
            this.buttonNextLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(212, 47);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(128, 42);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Слово";
            // 
            // buttonOption1
            // 
            this.buttonOption1.Location = new System.Drawing.Point(61, 124);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(438, 60);
            this.buttonOption1.TabIndex = 1;
            this.buttonOption1.Text = "button1";
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.Location = new System.Drawing.Point(61, 190);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(438, 56);
            this.buttonOption2.TabIndex = 2;
            this.buttonOption2.Text = "button2";
            this.buttonOption2.UseVisualStyleBackColor = true;
            this.buttonOption2.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption3
            // 
            this.buttonOption3.Location = new System.Drawing.Point(61, 252);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(438, 63);
            this.buttonOption3.TabIndex = 3;
            this.buttonOption3.Text = "button3";
            this.buttonOption3.UseVisualStyleBackColor = true;
            this.buttonOption3.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonSkipLevel
            // 
            this.buttonSkipLevel.Location = new System.Drawing.Point(449, 430);
            this.buttonSkipLevel.Name = "buttonSkipLevel";
            this.buttonSkipLevel.Size = new System.Drawing.Size(98, 22);
            this.buttonSkipLevel.TabIndex = 4;
            this.buttonSkipLevel.Text = "skip";
            this.buttonSkipLevel.UseVisualStyleBackColor = true;
            this.buttonSkipLevel.Click += new System.EventHandler(this.buttonSkipLevel_Click);
            // 
            // buttonNextLevel
            // 
            this.buttonNextLevel.Location = new System.Drawing.Point(219, 381);
            this.buttonNextLevel.Name = "buttonNextLevel";
            this.buttonNextLevel.Size = new System.Drawing.Size(98, 22);
            this.buttonNextLevel.TabIndex = 5;
            this.buttonNextLevel.Text = "след лвл";
            this.buttonNextLevel.UseVisualStyleBackColor = true;
            this.buttonNextLevel.Click += new System.EventHandler(this.buttonNextLevel_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 464);
            this.Controls.Add(this.buttonNextLevel);
            this.Controls.Add(this.buttonSkipLevel);
            this.Controls.Add(this.buttonOption3);
            this.Controls.Add(this.buttonOption2);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.labelWord);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button buttonOption2;
        private System.Windows.Forms.Button buttonOption3;
        private System.Windows.Forms.Button buttonSkipLevel;
        private System.Windows.Forms.Button buttonNextLevel;
    }
}