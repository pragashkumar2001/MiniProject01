namespace UserProfile
{
    partial class UserDetails
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
            this.Variable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Variable
            // 
            this.Variable.AutoSize = true;
            this.Variable.Location = new System.Drawing.Point(274, 61);
            this.Variable.Name = "Variable";
            this.Variable.Size = new System.Drawing.Size(74, 25);
            this.Variable.TabIndex = 0;
            this.Variable.Text = "Variable";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 156);
            this.Controls.Add(this.Variable);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Variable;
    }
}