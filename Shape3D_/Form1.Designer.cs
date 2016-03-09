namespace Shape3D_
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
            this.openGlControlBckgrnd = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // openGlControlBckgrnd
            // 
            this.openGlControlBckgrnd.AccumBits = ((byte)(0));
            this.openGlControlBckgrnd.AutoCheckErrors = false;
            this.openGlControlBckgrnd.AutoFinish = false;
            this.openGlControlBckgrnd.AutoMakeCurrent = true;
            this.openGlControlBckgrnd.AutoSwapBuffers = true;
            this.openGlControlBckgrnd.BackColor = System.Drawing.Color.Black;
            this.openGlControlBckgrnd.ColorBits = ((byte)(32));
            this.openGlControlBckgrnd.DepthBits = ((byte)(16));
            this.openGlControlBckgrnd.Location = new System.Drawing.Point(-1, -2);
            this.openGlControlBckgrnd.Name = "openGlControlBckgrnd";
            this.openGlControlBckgrnd.Size = new System.Drawing.Size(831, 412);
            this.openGlControlBckgrnd.StencilBits = ((byte)(0));
            this.openGlControlBckgrnd.TabIndex = 0;
            this.openGlControlBckgrnd.Paint += new System.Windows.Forms.PaintEventHandler(this.openGlControlBckgrnd_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 409);
            this.Controls.Add(this.openGlControlBckgrnd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openGlControlBckgrnd;
    }
}

