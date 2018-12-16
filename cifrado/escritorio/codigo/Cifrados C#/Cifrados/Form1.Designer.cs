namespace Cifrados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoclaro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxdesplazamiento = new System.Windows.Forms.TextBox();
            this.txtcifradocesar = new System.Windows.Forms.TextBox();
            this.txtcifradoinverso = new System.Windows.Forms.TextBox();
            this.boxgrupos = new System.Windows.Forms.TextBox();
            this.cifradogruposinverso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // textoclaro
            // 
            this.textoclaro.Location = new System.Drawing.Point(275, 52);
            this.textoclaro.Multiline = true;
            this.textoclaro.Name = "textoclaro";
            this.textoclaro.Size = new System.Drawing.Size(211, 53);
            this.textoclaro.TabIndex = 0;
            this.textoclaro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textoclaro_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto a cifrar";
            // 
            // boxdesplazamiento
            // 
            this.boxdesplazamiento.Location = new System.Drawing.Point(44, 159);
            this.boxdesplazamiento.Name = "boxdesplazamiento";
            this.boxdesplazamiento.Size = new System.Drawing.Size(151, 20);
            this.boxdesplazamiento.TabIndex = 2;
            this.boxdesplazamiento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.boxdesplazamiento_KeyUp);
            // 
            // txtcifradocesar
            // 
            this.txtcifradocesar.Location = new System.Drawing.Point(44, 226);
            this.txtcifradocesar.Multiline = true;
            this.txtcifradocesar.Name = "txtcifradocesar";
            this.txtcifradocesar.ReadOnly = true;
            this.txtcifradocesar.Size = new System.Drawing.Size(151, 57);
            this.txtcifradocesar.TabIndex = 3;
            // 
            // txtcifradoinverso
            // 
            this.txtcifradoinverso.Location = new System.Drawing.Point(311, 159);
            this.txtcifradoinverso.Multiline = true;
            this.txtcifradoinverso.Name = "txtcifradoinverso";
            this.txtcifradoinverso.ReadOnly = true;
            this.txtcifradoinverso.Size = new System.Drawing.Size(157, 64);
            this.txtcifradoinverso.TabIndex = 4;
            // 
            // boxgrupos
            // 
            this.boxgrupos.Location = new System.Drawing.Point(546, 159);
            this.boxgrupos.Name = "boxgrupos";
            this.boxgrupos.Size = new System.Drawing.Size(161, 20);
            this.boxgrupos.TabIndex = 5;
            this.boxgrupos.TextChanged += new System.EventHandler(this.boxgrupos_TextChanged);
            // 
            // cifradogruposinverso
            // 
            this.cifradogruposinverso.Location = new System.Drawing.Point(546, 226);
            this.cifradogruposinverso.Multiline = true;
            this.cifradogruposinverso.Name = "cifradogruposinverso";
            this.cifradogruposinverso.ReadOnly = true;
            this.cifradogruposinverso.Size = new System.Drawing.Size(161, 57);
            this.cifradogruposinverso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desplazamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Texto cifrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Texto cifrado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Texto cifrado";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(753, 467);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(498, 125);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(254, 190);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(257, 125);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(241, 190);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(16, 125);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(241, 190);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(753, 467);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cifradogruposinverso);
            this.Controls.Add(this.boxgrupos);
            this.Controls.Add(this.txtcifradoinverso);
            this.Controls.Add(this.txtcifradocesar);
            this.Controls.Add(this.boxdesplazamiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoclaro);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Cifrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
      
        private System.Windows.Forms.TextBox textoclaro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxdesplazamiento;
        private System.Windows.Forms.TextBox txtcifradocesar;
        private System.Windows.Forms.TextBox txtcifradoinverso;
        private System.Windows.Forms.TextBox boxgrupos;
        private System.Windows.Forms.TextBox cifradogruposinverso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}

