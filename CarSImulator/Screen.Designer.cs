namespace CarSImulator
{
    partial class Screen
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
            this.rightB = new System.Windows.Forms.Button();
            this.leftB = new System.Windows.Forms.Button();
            this.upB = new System.Windows.Forms.Button();
            this.downB = new System.Windows.Forms.Button();
            this.speedTB = new System.Windows.Forms.TextBox();
            this.speedB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightB
            // 
            this.rightB.Location = new System.Drawing.Point(241, 374);
            this.rightB.Name = "rightB";
            this.rightB.Size = new System.Drawing.Size(88, 56);
            this.rightB.TabIndex = 0;
            this.rightB.Text = "RIght";
            this.rightB.UseVisualStyleBackColor = true;
            this.rightB.Click += new System.EventHandler(this.rightB_Click);
            // 
            // leftB
            // 
            this.leftB.Location = new System.Drawing.Point(53, 374);
            this.leftB.Name = "leftB";
            this.leftB.Size = new System.Drawing.Size(88, 56);
            this.leftB.TabIndex = 1;
            this.leftB.Text = "Left";
            this.leftB.UseVisualStyleBackColor = true;
            this.leftB.Click += new System.EventHandler(this.leftB_Click);
            // 
            // upB
            // 
            this.upB.Location = new System.Drawing.Point(147, 312);
            this.upB.Name = "upB";
            this.upB.Size = new System.Drawing.Size(88, 56);
            this.upB.TabIndex = 2;
            this.upB.Text = "Up";
            this.upB.UseVisualStyleBackColor = true;
            this.upB.Click += new System.EventHandler(this.upB_Click);
            // 
            // downB
            // 
            this.downB.Location = new System.Drawing.Point(147, 374);
            this.downB.Name = "downB";
            this.downB.Size = new System.Drawing.Size(88, 56);
            this.downB.TabIndex = 3;
            this.downB.Text = "Down";
            this.downB.UseVisualStyleBackColor = true;
            this.downB.Click += new System.EventHandler(this.downB_Click);
            // 
            // speedTB
            // 
            this.speedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTB.Location = new System.Drawing.Point(452, 333);
            this.speedTB.Multiline = true;
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(115, 35);
            this.speedTB.TabIndex = 4;
            // 
            // speedB
            // 
            this.speedB.Location = new System.Drawing.Point(464, 374);
            this.speedB.Name = "speedB";
            this.speedB.Size = new System.Drawing.Size(88, 35);
            this.speedB.TabIndex = 5;
            this.speedB.Text = "Set Speed";
            this.speedB.UseVisualStyleBackColor = true;
            this.speedB.Click += new System.EventHandler(this.speedB_Click);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 433);
            this.Controls.Add(this.speedB);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.downB);
            this.Controls.Add(this.upB);
            this.Controls.Add(this.leftB);
            this.Controls.Add(this.rightB);
            this.Name = "Screen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rightB;
        private System.Windows.Forms.Button leftB;
        private System.Windows.Forms.Button upB;
        private System.Windows.Forms.Button downB;
        private System.Windows.Forms.TextBox speedTB;
        private System.Windows.Forms.Button speedB;

    }
}

