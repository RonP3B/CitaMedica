namespace CitaMedica.UI.Windows
{
    partial class Appoinments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Nuevo = new Guna.UI2.WinForms.Guna2Button();
            this.dataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(264, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(260, 41);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Citas registradas";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CitaMedica.UI.Windows.Properties.Resources.cita;
            this.guna2PictureBox1.Location = new System.Drawing.Point(187, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(71, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_eliminar.BorderRadius = 10;
            this.btn_eliminar.BorderThickness = 2;
            this.btn_eliminar.CheckedState.Parent = this.btn_eliminar;
            this.btn_eliminar.CustomImages.Parent = this.btn_eliminar;
            this.btn_eliminar.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.HoverState.Parent = this.btn_eliminar;
            this.btn_eliminar.Location = new System.Drawing.Point(496, 423);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ShadowDecoration.Parent = this.btn_eliminar;
            this.btn_eliminar.Size = new System.Drawing.Size(140, 32);
            this.btn_eliminar.TabIndex = 30;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(350, 423);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.ShadowDecoration.Parent = this.btn_buscar;
            this.btn_buscar.Size = new System.Drawing.Size(140, 32);
            this.btn_buscar.TabIndex = 29;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_editar.BorderRadius = 10;
            this.btn_editar.BorderThickness = 2;
            this.btn_editar.CheckedState.Parent = this.btn_editar;
            this.btn_editar.CustomImages.Parent = this.btn_editar;
            this.btn_editar.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.HoverState.Parent = this.btn_editar;
            this.btn_editar.Location = new System.Drawing.Point(204, 423);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ShadowDecoration.Parent = this.btn_editar;
            this.btn_editar.Size = new System.Drawing.Size(140, 32);
            this.btn_editar.TabIndex = 28;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.Btn_Nuevo.BorderRadius = 10;
            this.Btn_Nuevo.BorderThickness = 2;
            this.Btn_Nuevo.CheckedState.Parent = this.Btn_Nuevo;
            this.Btn_Nuevo.CustomImages.Parent = this.Btn_Nuevo;
            this.Btn_Nuevo.FillColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_Nuevo.HoverState.Parent = this.Btn_Nuevo;
            this.Btn_Nuevo.Location = new System.Drawing.Point(58, 423);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.ShadowDecoration.Parent = this.Btn_Nuevo;
            this.Btn_Nuevo.Size = new System.Drawing.Size(140, 32);
            this.Btn_Nuevo.TabIndex = 27;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // dataView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView.EnableHeadersVisualStyles = false;
            this.dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataView.Location = new System.Drawing.Point(12, 87);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersVisible = false;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(657, 332);
            this.dataView.TabIndex = 31;
            this.dataView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataView.ThemeStyle.HeaderStyle.Height = 23;
            this.dataView.ThemeStyle.ReadOnly = true;
            this.dataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataView.ThemeStyle.RowsStyle.Height = 22;
            this.dataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataView_DataBindingComplete);
            // 
            // Appoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 467);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appoinments";
            this.Text = "Appoiments";
            this.Load += new System.EventHandler(this.Appoinments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button btn_buscar;
        private Guna.UI2.WinForms.Guna2Button btn_editar;
        private Guna.UI2.WinForms.Guna2Button Btn_Nuevo;
        private Guna.UI2.WinForms.Guna2DataGridView dataView;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}