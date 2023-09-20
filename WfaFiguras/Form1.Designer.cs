namespace WfaFiguras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.label_Down = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.button_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma Figurar Geómetrica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfaFiguras.Properties.Resources.WhatsApp_Image_2023_09_11_at_15_01_44__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDown);
            this.panel1.Controls.Add(this.tbTop);
            this.panel1.Controls.Add(this.label_Down);
            this.panel1.Controls.Add(this.label_top);
            this.panel1.Location = new System.Drawing.Point(24, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 100);
            this.panel1.TabIndex = 2;
            // 
            // tbDown
            // 
            this.tbDown.Location = new System.Drawing.Point(67, 62);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(161, 20);
            this.tbDown.TabIndex = 3;
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(67, 16);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(161, 20);
            this.tbTop.TabIndex = 2;
            // 
            // label_Down
            // 
            this.label_Down.AutoSize = true;
            this.label_Down.Location = new System.Drawing.Point(13, 69);
            this.label_Down.Name = "label_Down";
            this.label_Down.Size = new System.Drawing.Size(35, 13);
            this.label_Down.TabIndex = 1;
            this.label_Down.Text = "label3";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Location = new System.Drawing.Point(13, 16);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(35, 13);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "label2";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 434);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 109);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Location = new System.Drawing.Point(386, 40);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rbQuadrado.TabIndex = 4;
            this.rbQuadrado.TabStop = true;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            this.rbQuadrado.CheckedChanged += new System.EventHandler(this.rbQuadrado_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Location = new System.Drawing.Point(386, 119);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rbRetangulo.TabIndex = 5;
            this.rbRetangulo.TabStop = true;
            this.rbRetangulo.Text = "Retangulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(386, 202);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 6;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(386, 270);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbCirculo.TabIndex = 7;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(386, 344);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(120, 34);
            this.button_calcular.TabIndex = 8;
            this.button_calcular.Text = "Calcular ";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_calcular_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 555);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbQuadrado);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Figuras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.TextBox tbTop;
        private System.Windows.Forms.Label label_Down;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Button button_calcular;
    }
}

