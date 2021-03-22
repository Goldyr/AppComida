
namespace AplicacionComida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_food3 = new System.Windows.Forms.Label();
            this.lbl_food2 = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_food1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.img_arrow4 = new System.Windows.Forms.PictureBox();
            this.img_arrow3 = new System.Windows.Forms.PictureBox();
            this.img_arrow2 = new System.Windows.Forms.PictureBox();
            this.img_arrow1 = new System.Windows.Forms.PictureBox();
            this.icon_github = new System.Windows.Forms.PictureBox();
            this.icon_linkedin = new System.Windows.Forms.PictureBox();
            this.img_icono = new System.Windows.Forms.PictureBox();
            this.sopaScene1 = new AplicacionComida.SopaScene();
            this.sangucheScene1 = new AplicacionComida.SangucheScene();
            this.anvorgesaview = new AplicacionComida.AnvorgesaScene();
            this.inicioScene1 = new AplicacionComida.InicioScene();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_linkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_icono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 542);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_food3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_food2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_inicio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_food1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_food3
            // 
            this.lbl_food3.AutoSize = true;
            this.lbl_food3.BackColor = System.Drawing.Color.Silver;
            this.lbl_food3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_food3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_food3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food3.Location = new System.Drawing.Point(3, 354);
            this.lbl_food3.Name = "lbl_food3";
            this.lbl_food3.Size = new System.Drawing.Size(111, 121);
            this.lbl_food3.TabIndex = 3;
            this.lbl_food3.Text = "Sanguche giratorio";
            this.lbl_food3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_food3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_food3_MouseClick);
            this.lbl_food3.MouseEnter += new System.EventHandler(this.lbl_food3_MouseEnter);
            this.lbl_food3.MouseLeave += new System.EventHandler(this.lbl_food3_MouseLeave);
            // 
            // lbl_food2
            // 
            this.lbl_food2.AutoSize = true;
            this.lbl_food2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_food2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_food2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food2.Location = new System.Drawing.Point(3, 236);
            this.lbl_food2.Name = "lbl_food2";
            this.lbl_food2.Size = new System.Drawing.Size(111, 118);
            this.lbl_food2.TabIndex = 2;
            this.lbl_food2.Text = "Burger";
            this.lbl_food2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_food2.Click += new System.EventHandler(this.lbl_food2_Click);
            this.lbl_food2.MouseEnter += new System.EventHandler(this.lbl_food2_MouseEnter);
            this.lbl_food2.MouseLeave += new System.EventHandler(this.lbl_food2_MouseLeave);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_inicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.Location = new System.Drawing.Point(3, 0);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(111, 118);
            this.lbl_inicio.TabIndex = 0;
            this.lbl_inicio.Text = "Inicio";
            this.lbl_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inicio.Click += new System.EventHandler(this.lbl_inicio_Click);
            this.lbl_inicio.MouseEnter += new System.EventHandler(this.lbl_inicio_MouseEnter);
            this.lbl_inicio.MouseLeave += new System.EventHandler(this.lbl_inicio_MouseLeave);
            // 
            // lbl_food1
            // 
            this.lbl_food1.AutoSize = true;
            this.lbl_food1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_food1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_food1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food1.Location = new System.Drawing.Point(3, 118);
            this.lbl_food1.Name = "lbl_food1";
            this.lbl_food1.Size = new System.Drawing.Size(111, 118);
            this.lbl_food1.TabIndex = 1;
            this.lbl_food1.Text = "Sopa";
            this.lbl_food1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_food1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_food1_MouseClick);
            this.lbl_food1.MouseEnter += new System.EventHandler(this.lbl_food1_MouseEnter);
            this.lbl_food1.MouseLeave += new System.EventHandler(this.lbl_food1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.icon_github);
            this.panel2.Controls.Add(this.icon_linkedin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.img_icono);
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 61);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# WinForm Design By Enzo Bogado";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1071, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 43);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inicioScene1);
            this.panel3.Controls.Add(this.sopaScene1);
            this.panel3.Controls.Add(this.sangucheScene1);
            this.panel3.Controls.Add(this.anvorgesaview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(123, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 478);
            this.panel3.TabIndex = 6;
            // 
            // img_arrow4
            // 
            this.img_arrow4.Image = global::AplicacionComida.Properties.Resources.arrowicon;
            this.img_arrow4.Location = new System.Drawing.Point(124, 464);
            this.img_arrow4.Name = "img_arrow4";
            this.img_arrow4.Size = new System.Drawing.Size(48, 24);
            this.img_arrow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow4.TabIndex = 5;
            this.img_arrow4.TabStop = false;
            this.img_arrow4.Visible = false;
            // 
            // img_arrow3
            // 
            this.img_arrow3.Image = global::AplicacionComida.Properties.Resources.arrowicon;
            this.img_arrow3.Location = new System.Drawing.Point(124, 341);
            this.img_arrow3.Name = "img_arrow3";
            this.img_arrow3.Size = new System.Drawing.Size(48, 24);
            this.img_arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow3.TabIndex = 4;
            this.img_arrow3.TabStop = false;
            this.img_arrow3.Visible = false;
            // 
            // img_arrow2
            // 
            this.img_arrow2.Image = global::AplicacionComida.Properties.Resources.arrowicon;
            this.img_arrow2.Location = new System.Drawing.Point(124, 223);
            this.img_arrow2.Name = "img_arrow2";
            this.img_arrow2.Size = new System.Drawing.Size(48, 24);
            this.img_arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow2.TabIndex = 3;
            this.img_arrow2.TabStop = false;
            this.img_arrow2.Visible = false;
            // 
            // img_arrow1
            // 
            this.img_arrow1.Image = global::AplicacionComida.Properties.Resources.arrowicon;
            this.img_arrow1.Location = new System.Drawing.Point(124, 104);
            this.img_arrow1.Name = "img_arrow1";
            this.img_arrow1.Size = new System.Drawing.Size(48, 24);
            this.img_arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow1.TabIndex = 2;
            this.img_arrow1.TabStop = false;
            this.img_arrow1.Visible = false;
            this.img_arrow1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.img_arrow1_LoadCompleted);
            // 
            // icon_github
            // 
            this.icon_github.Image = global::AplicacionComida.Properties.Resources.github;
            this.icon_github.Location = new System.Drawing.Point(904, 8);
            this.icon_github.Name = "icon_github";
            this.icon_github.Size = new System.Drawing.Size(46, 50);
            this.icon_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_github.TabIndex = 4;
            this.icon_github.TabStop = false;
            // 
            // icon_linkedin
            // 
            this.icon_linkedin.Image = global::AplicacionComida.Properties.Resources.linkedinicon2;
            this.icon_linkedin.Location = new System.Drawing.Point(968, 8);
            this.icon_linkedin.Name = "icon_linkedin";
            this.icon_linkedin.Size = new System.Drawing.Size(46, 50);
            this.icon_linkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_linkedin.TabIndex = 3;
            this.icon_linkedin.TabStop = false;
            // 
            // img_icono
            // 
            this.img_icono.BackColor = System.Drawing.Color.White;
            this.img_icono.Image = ((System.Drawing.Image)(resources.GetObject("img_icono.Image")));
            this.img_icono.ImageLocation = "";
            this.img_icono.Location = new System.Drawing.Point(11, 0);
            this.img_icono.Name = "img_icono";
            this.img_icono.Size = new System.Drawing.Size(117, 58);
            this.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_icono.TabIndex = 0;
            this.img_icono.TabStop = false;
            // 
            // sopaScene1
            // 
            this.sopaScene1.Location = new System.Drawing.Point(-12, -3);
            this.sopaScene1.Name = "sopaScene1";
            this.sopaScene1.Size = new System.Drawing.Size(996, 478);
            this.sopaScene1.TabIndex = 2;
            this.sopaScene1.Visible = false;
            // 
            // sangucheScene1
            // 
            this.sangucheScene1.Location = new System.Drawing.Point(29, -3);
            this.sangucheScene1.Name = "sangucheScene1";
            this.sangucheScene1.Size = new System.Drawing.Size(964, 478);
            this.sangucheScene1.TabIndex = 1;
            this.sangucheScene1.Visible = false;
            // 
            // anvorgesaview
            // 
            this.anvorgesaview.Location = new System.Drawing.Point(20, -3);
            this.anvorgesaview.Name = "anvorgesaview";
            this.anvorgesaview.Size = new System.Drawing.Size(976, 481);
            this.anvorgesaview.TabIndex = 0;
            this.anvorgesaview.Visible = false;
            // 
            // inicioScene1
            // 
            this.inicioScene1.Location = new System.Drawing.Point(20, 0);
            this.inicioScene1.Name = "inicioScene1";
            this.inicioScene1.Size = new System.Drawing.Size(982, 475);
            this.inicioScene1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1119, 542);
            this.Controls.Add(this.img_arrow4);
            this.Controls.Add(this.img_arrow3);
            this.Controls.Add(this.img_arrow2);
            this.Controls.Add(this.img_arrow1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOODCHAIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_linkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox img_icono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_food3;
        private System.Windows.Forms.Label lbl_food2;
        private System.Windows.Forms.Label lbl_food1;
        private System.Windows.Forms.PictureBox img_arrow1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox img_arrow2;
        private System.Windows.Forms.PictureBox img_arrow3;
        private System.Windows.Forms.PictureBox img_arrow4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icon_github;
        private System.Windows.Forms.PictureBox icon_linkedin;
        private System.Windows.Forms.Panel panel3;
        private AnvorgesaScene anvorgesaview;
        private SopaScene sopaScene1;
        private SangucheScene sangucheScene1;
        private InicioScene inicioScene1;
    }
}

