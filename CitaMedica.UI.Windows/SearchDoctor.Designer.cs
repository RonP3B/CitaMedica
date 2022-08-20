namespace CitaMedica.UI.Windows
{
    partial class SearchDoctor
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
            this.txt_Titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.txt_Titulo.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.txt_Titulo.Location = new System.Drawing.Point(131, 22);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(185, 35);
            this.txt_Titulo.TabIndex = 23;
            this.txt_Titulo.Text = "Buscar Doctor";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.Transparent;
            this.txt_Id.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_Id.BorderRadius = 12;
            this.txt_Id.BorderThickness = 2;
            this.txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id.DefaultText = "";
            this.txt_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Id.DisabledState.Parent = this.txt_Id;
            this.txt_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Id.FillColor = System.Drawing.Color.LightCyan;
            this.txt_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Id.FocusedState.Parent = this.txt_Id;
            this.txt_Id.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Id.HoverState.Parent = this.txt_Id;
            this.txt_Id.Location = new System.Drawing.Point(184, 99);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.PasswordChar = '\0';
            this.txt_Id.PlaceholderText = "";
            this.txt_Id.SelectedText = "";
            this.txt_Id.ShadowDecoration.Parent = this.txt_Id;
            this.txt_Id.Size = new System.Drawing.Size(168, 27);
            this.txt_Id.TabIndex = 25;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 99);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 27);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Ingresa el ID:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderThickness = 2;
            this.btn_cancelar.CheckedState.Parent = this.btn_cancelar;
            this.btn_cancelar.CustomImages.Parent = this.btn_cancelar;
            this.btn_cancelar.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.HoverState.Parent = this.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(197, 147);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(155, 32);
            this.btn_cancelar.TabIndex = 28;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_buscar.BorderRadius = 10;
            this.btn_buscar.BorderThickness = 2;
            this.btn_buscar.CheckedState.Parent = this.btn_buscar;
            this.btn_buscar.CustomImages.Parent = this.btn_buscar;
            this.btn_buscar.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.HoverState.Parent = this.btn_buscar;
            this.btn_buscar.Location = new System.Drawing.Point(36, 147);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.ShadowDecoration.Parent = this.btn_buscar;
            this.btn_buscar.Size = new System.Drawing.Size(155, 32);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CitaMedica.UI.Windows.Properties.Resources.buscarLogo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(60, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(65, 58);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SearchDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 200);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txt_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txt_Titulo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_buscar;
        public Guna.UI2.WinForms.Guna2TextBox txt_Id;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}