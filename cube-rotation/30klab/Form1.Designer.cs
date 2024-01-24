namespace _30klab
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OPENGLC = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.btnxtransform = new System.Windows.Forms.Button();
            this.btnytransform = new System.Windows.Forms.Button();
            this.btnztransform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnanmstart = new System.Windows.Forms.Button();
            this.endanimation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // OPENGLC
            // 
            this.OPENGLC.AccumBits = ((byte)(0));
            this.OPENGLC.AutoCheckErrors = false;
            this.OPENGLC.AutoFinish = false;
            this.OPENGLC.AutoMakeCurrent = true;
            this.OPENGLC.AutoSwapBuffers = true;
            this.OPENGLC.BackColor = System.Drawing.Color.Black;
            this.OPENGLC.ColorBits = ((byte)(32));
            this.OPENGLC.DepthBits = ((byte)(16));
            this.OPENGLC.Dock = System.Windows.Forms.DockStyle.Left;
            this.OPENGLC.Location = new System.Drawing.Point(0, 0);
            this.OPENGLC.Name = "OPENGLC";
            this.OPENGLC.Size = new System.Drawing.Size(604, 458);
            this.OPENGLC.StencilBits = ((byte)(0));
            this.OPENGLC.TabIndex = 0;
            this.OPENGLC.Paint += new System.Windows.Forms.PaintEventHandler(this.OPENGLC_Paint);
            // 
            // btnxtransform
            // 
            this.btnxtransform.Location = new System.Drawing.Point(610, 63);
            this.btnxtransform.Name = "btnxtransform";
            this.btnxtransform.Size = new System.Drawing.Size(87, 23);
            this.btnxtransform.TabIndex = 1;
            this.btnxtransform.Text = "X ROTATE";
            this.btnxtransform.UseVisualStyleBackColor = true;
            this.btnxtransform.Click += new System.EventHandler(this.btnxtransform_Click);
            // 
            // btnytransform
            // 
            this.btnytransform.Location = new System.Drawing.Point(610, 122);
            this.btnytransform.Name = "btnytransform";
            this.btnytransform.Size = new System.Drawing.Size(87, 23);
            this.btnytransform.TabIndex = 2;
            this.btnytransform.Text = "Y ROTATE";
            this.btnytransform.UseVisualStyleBackColor = true;
            this.btnytransform.Click += new System.EventHandler(this.btnytransform_Click);
            // 
            // btnztransform
            // 
            this.btnztransform.Location = new System.Drawing.Point(610, 184);
            this.btnztransform.Name = "btnztransform";
            this.btnztransform.Size = new System.Drawing.Size(87, 23);
            this.btnztransform.TabIndex = 3;
            this.btnztransform.Text = "Z ROTATE";
            this.btnztransform.UseVisualStyleBackColor = true;
            this.btnztransform.Click += new System.EventHandler(this.btnztransform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SPEED";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(610, 240);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnanmstart
            // 
            this.btnanmstart.Location = new System.Drawing.Point(610, 282);
            this.btnanmstart.Name = "btnanmstart";
            this.btnanmstart.Size = new System.Drawing.Size(87, 23);
            this.btnanmstart.TabIndex = 6;
            this.btnanmstart.Text = "Start Animation";
            this.btnanmstart.UseVisualStyleBackColor = true;
            this.btnanmstart.Click += new System.EventHandler(this.btnanmstart_Click);
            // 
            // endanimation
            // 
            this.endanimation.Location = new System.Drawing.Point(610, 322);
            this.endanimation.Name = "endanimation";
            this.endanimation.Size = new System.Drawing.Size(87, 23);
            this.endanimation.TabIndex = 7;
            this.endanimation.Text = "end animation";
            this.endanimation.UseVisualStyleBackColor = true;
            this.endanimation.Click += new System.EventHandler(this.endanimation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 458);
            this.Controls.Add(this.endanimation);
            this.Controls.Add(this.btnanmstart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnztransform);
            this.Controls.Add(this.btnytransform);
            this.Controls.Add(this.btnxtransform);
            this.Controls.Add(this.OPENGLC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OPENGLC;
        private System.Windows.Forms.Button btnxtransform;
        private System.Windows.Forms.Button btnytransform;
        private System.Windows.Forms.Button btnztransform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnanmstart;
        private System.Windows.Forms.Button endanimation;
    }
}

