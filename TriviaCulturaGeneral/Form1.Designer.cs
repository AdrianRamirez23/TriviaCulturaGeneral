
namespace TriviaCulturaGeneral
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblPregunta = new System.Windows.Forms.Label();
            this.chkListPreguntas = new System.Windows.Forms.CheckedListBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pctPreguntas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(278, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a la Trivia de Cultura General";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación responde las preguntas para ver que tanto de Cultura General Sabes" +
    "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(73, 327);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(0, 15);
            this.lblPregunta.TabIndex = 2;
            // 
            // chkListPreguntas
            // 
            this.chkListPreguntas.FormattingEnabled = true;
            this.chkListPreguntas.Location = new System.Drawing.Point(73, 366);
            this.chkListPreguntas.Name = "chkListPreguntas";
            this.chkListPreguntas.Size = new System.Drawing.Size(224, 94);
            this.chkListPreguntas.TabIndex = 3;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(689, 393);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(141, 41);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(368, 229);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(158, 67);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Cuestionario";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pctPreguntas
            // 
            this.pctPreguntas.Location = new System.Drawing.Point(73, 111);
            this.pctPreguntas.Name = "pctPreguntas";
            this.pctPreguntas.Size = new System.Drawing.Size(633, 213);
            this.pctPreguntas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPreguntas.TabIndex = 6;
            this.pctPreguntas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 494);
            this.Controls.Add(this.pctPreguntas);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.chkListPreguntas);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.CheckedListBox chkListPreguntas;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pctPreguntas;
    }
}

