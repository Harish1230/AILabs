namespace CarRacingGame
{
    partial class Form1
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
            this.roadPanel = new System.Windows.Forms.Panel();
            this.playerCar = new System.Windows.Forms.PictureBox();
            this.roadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            this.SuspendLayout();
            // 
            // roadPanel
            // 
            this.roadPanel.BackColor = System.Drawing.Color.Gray;
            this.roadPanel.Controls.Add(this.playerCar);
            this.roadPanel.Location = new System.Drawing.Point(25, 0);
            this.roadPanel.Name = "roadPanel";
            this.roadPanel.Size = new System.Drawing.Size(300, 500);
            this.roadPanel.TabIndex = 0;
            // 
            // playerCar
            // 
            this.playerCar.BackColor = System.Drawing.Color.Blue;
            this.playerCar.Image = global::CarRacingGame.Properties.Resources.car;
            this.playerCar.Location = new System.Drawing.Point(120, 350);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(50, 70);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCar.TabIndex = 0;
            this.playerCar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(328, 444);
            this.Controls.Add(this.roadPanel);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.roadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roadPanel;
        private System.Windows.Forms.PictureBox playerCar;
    }
}

