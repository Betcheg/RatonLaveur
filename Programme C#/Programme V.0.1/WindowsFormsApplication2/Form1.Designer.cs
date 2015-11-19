namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.actuTime = new System.Windows.Forms.Timer(this.components);
            this.timerOnline = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // actuTime
            // 
            this.actuTime.Enabled = true;
            this.actuTime.Interval = 5000;
            this.actuTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerOnline
            // 
            this.timerOnline.Enabled = true;
            this.timerOnline.Interval = 60000;
            this.timerOnline.Tick += new System.EventHandler(this.timerOnline_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer actuTime;
        private System.Windows.Forms.Timer timerOnline;


    }
}

