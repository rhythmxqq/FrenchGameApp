namespace appFrench
{
    partial class TopBoardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLider = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Топ пользователей";
            // 
            // dataGridViewLider
            // 
            this.dataGridViewLider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLider.Location = new System.Drawing.Point(69, 52);
            this.dataGridViewLider.Name = "dataGridViewLider";
            this.dataGridViewLider.Size = new System.Drawing.Size(397, 298);
            this.dataGridViewLider.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(199, 372);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 33);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TopBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 430);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewLider);
            this.Controls.Add(this.label1);
            this.Name = "TopBoardForm";
            this.Text = "TopBoardForm";
            this.Load += new System.EventHandler(this.TopBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLider;
        private System.Windows.Forms.Button buttonExit;
    }
}