
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_Visite
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Visite));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_full_form = new System.Windows.Forms.Panel();
            this.dtp_Visite = new System.Windows.Forms.DateTimePicker();
            this.bt_info = new Gestion_Commerciale.Classes.CButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_refresh = new Gestion_Commerciale.Classes.CButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Dgv_Visite_aujourdhui = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_full_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visite_aujourdhui)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_full_form
            // 
            this.panel_full_form.Controls.Add(this.dtp_Visite);
            this.panel_full_form.Controls.Add(this.bt_info);
            this.panel_full_form.Controls.Add(this.label3);
            this.panel_full_form.Controls.Add(this.bt_refresh);
            this.panel_full_form.Controls.Add(this.label4);
            this.panel_full_form.Controls.Add(this.Dgv_Visite_aujourdhui);
            this.panel_full_form.Controls.Add(this.label1);
            this.panel_full_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full_form.Location = new System.Drawing.Point(0, 0);
            this.panel_full_form.Margin = new System.Windows.Forms.Padding(4);
            this.panel_full_form.Name = "panel_full_form";
            this.panel_full_form.Size = new System.Drawing.Size(1000, 588);
            this.panel_full_form.TabIndex = 0;
            // 
            // dtp_Visite
            // 
            this.dtp_Visite.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_Visite.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_Visite.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_Visite.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_Visite.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_Visite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_Visite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Visite.Location = new System.Drawing.Point(301, 63);
            this.dtp_Visite.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Visite.Name = "dtp_Visite";
            this.dtp_Visite.Size = new System.Drawing.Size(292, 32);
            this.dtp_Visite.TabIndex = 72;
            this.dtp_Visite.ValueChanged += new System.EventHandler(this.dtp_Visite_ValueChanged);
            // 
            // bt_info
            // 
            this.bt_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_info.BackColor = System.Drawing.Color.Transparent;
            this.bt_info.BackgroundColor = System.Drawing.Color.Transparent;
            this.bt_info.BorderColor = System.Drawing.Color.DarkMagenta;
            this.bt_info.BorderRadius = 20;
            this.bt_info.BorderSize = 0;
            this.bt_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_info.FlatAppearance.BorderSize = 0;
            this.bt_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info.ForeColor = System.Drawing.Color.White;
            this.bt_info.Image = ((System.Drawing.Image)(resources.GetObject("bt_info.Image")));
            this.bt_info.Location = new System.Drawing.Point(946, 12);
            this.bt_info.Margin = new System.Windows.Forms.Padding(4);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(44, 32);
            this.bt_info.TabIndex = 71;
            this.bt_info.TextColor = System.Drawing.Color.White;
            this.bt_info.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(36, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "- Double click sur la patient pour ajouter l\'ordonnance";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.BackColor = System.Drawing.Color.Transparent;
            this.bt_refresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.bt_refresh.BorderColor = System.Drawing.Color.DarkMagenta;
            this.bt_refresh.BorderRadius = 20;
            this.bt_refresh.BorderSize = 0;
            this.bt_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_refresh.FlatAppearance.BorderSize = 0;
            this.bt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.Location = new System.Drawing.Point(896, 12);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(44, 32);
            this.bt_refresh.TabIndex = 70;
            this.bt_refresh.TextColor = System.Drawing.Color.White;
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "NB :";
            // 
            // Dgv_Visite_aujourdhui
            // 
            this.Dgv_Visite_aujourdhui.AllowUserToAddRows = false;
            this.Dgv_Visite_aujourdhui.AllowUserToDeleteRows = false;
            this.Dgv_Visite_aujourdhui.AllowUserToResizeRows = false;
            this.Dgv_Visite_aujourdhui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Visite_aujourdhui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Visite_aujourdhui.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_Visite_aujourdhui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Visite_aujourdhui.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Visite_aujourdhui.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Visite_aujourdhui.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Visite_aujourdhui.ColumnHeadersHeight = 45;
            this.Dgv_Visite_aujourdhui.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom,
            this.Prenom,
            this.Age});
            this.Dgv_Visite_aujourdhui.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Visite_aujourdhui.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Visite_aujourdhui.EnableHeadersVisualStyles = false;
            this.Dgv_Visite_aujourdhui.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Visite_aujourdhui.Location = new System.Drawing.Point(0, 127);
            this.Dgv_Visite_aujourdhui.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Visite_aujourdhui.Name = "Dgv_Visite_aujourdhui";
            this.Dgv_Visite_aujourdhui.ReadOnly = true;
            this.Dgv_Visite_aujourdhui.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Visite_aujourdhui.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Visite_aujourdhui.RowHeadersVisible = false;
            this.Dgv_Visite_aujourdhui.RowHeadersWidth = 55;
            this.Dgv_Visite_aujourdhui.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Visite_aujourdhui.Size = new System.Drawing.Size(1000, 461);
            this.Dgv_Visite_aujourdhui.TabIndex = 0;
            this.Dgv_Visite_aujourdhui.DoubleClick += new System.EventHandler(this.Dgv_Visite_aujourdhui_DoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id_visite";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(103, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Les dates de visites ";
            // 
            // UC_Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel_full_form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Visite";
            this.Size = new System.Drawing.Size(1000, 588);
            this.Load += new System.EventHandler(this.UC_Visite_Load);
            this.panel_full_form.ResumeLayout(false);
            this.panel_full_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visite_aujourdhui)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_full_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Visite;
        private Gestion_Commerciale.Classes.CButton bt_info;
        private Gestion_Commerciale.Classes.CButton bt_refresh;
        private System.Windows.Forms.DataGridView Dgv_Visite_aujourdhui;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Label label1;
    }
}
