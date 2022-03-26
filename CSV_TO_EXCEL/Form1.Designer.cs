
namespace CSV_TO_EXCEL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GradientPanel_TOP = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.DataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Buttonimport = new Guna.UI.WinForms.GunaGradientButton();
            this.TextBoxchemin = new Guna.UI.WinForms.GunaTextBox();
            this.ButtonImprimer_Excel = new Guna.UI.WinForms.GunaGradientButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.GradientPanel_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GradientPanel_TOP
            // 
            this.GradientPanel_TOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanel_TOP.BackgroundImage")));
            this.GradientPanel_TOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanel_TOP.Controls.Add(this.gunaControlBox2);
            this.GradientPanel_TOP.Controls.Add(this.gunaControlBox1);
            this.GradientPanel_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.GradientPanel_TOP.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.GradientPanel_TOP.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.GradientPanel_TOP.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.GradientPanel_TOP.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.GradientPanel_TOP.Location = new System.Drawing.Point(0, 0);
            this.GradientPanel_TOP.Name = "GradientPanel_TOP";
            this.GradientPanel_TOP.Size = new System.Drawing.Size(789, 30);
            this.GradientPanel_TOP.TabIndex = 1;
            this.GradientPanel_TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientPanel_TOP_MouseDown);
            this.GradientPanel_TOP.MouseHover += new System.EventHandler(this.GradientPanel_TOP_MouseHover);
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(701, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.DarkGray;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(44, 30);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(745, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(44, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(30, 126);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(722, 309);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Buttonimport
            // 
            this.Buttonimport.AnimationHoverSpeed = 0.07F;
            this.Buttonimport.AnimationSpeed = 0.03F;
            this.Buttonimport.BackColor = System.Drawing.Color.Transparent;
            this.Buttonimport.BaseColor1 = System.Drawing.Color.Blue;
            this.Buttonimport.BaseColor2 = System.Drawing.Color.Green;
            this.Buttonimport.BorderColor = System.Drawing.Color.Black;
            this.Buttonimport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Buttonimport.FocusedColor = System.Drawing.Color.Empty;
            this.Buttonimport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Buttonimport.ForeColor = System.Drawing.Color.White;
            this.Buttonimport.Image = ((System.Drawing.Image)(resources.GetObject("Buttonimport.Image")));
            this.Buttonimport.ImageSize = new System.Drawing.Size(20, 20);
            this.Buttonimport.Location = new System.Drawing.Point(627, 72);
            this.Buttonimport.Name = "Buttonimport";
            this.Buttonimport.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Buttonimport.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Buttonimport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Buttonimport.OnHoverForeColor = System.Drawing.Color.White;
            this.Buttonimport.OnHoverImage = null;
            this.Buttonimport.OnPressedColor = System.Drawing.Color.Black;
            this.Buttonimport.Radius = 6;
            this.Buttonimport.Size = new System.Drawing.Size(125, 30);
            this.Buttonimport.TabIndex = 5;
            this.Buttonimport.Text = "Importer CSV";
            this.Buttonimport.Click += new System.EventHandler(this.Buttonimport_Click);
            // 
            // TextBoxchemin
            // 
            this.TextBoxchemin.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxchemin.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxchemin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            this.TextBoxchemin.BorderSize = 3;
            this.TextBoxchemin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxchemin.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxchemin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxchemin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxchemin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxchemin.Location = new System.Drawing.Point(30, 72);
            this.TextBoxchemin.Name = "TextBoxchemin";
            this.TextBoxchemin.PasswordChar = '\0';
            this.TextBoxchemin.Radius = 6;
            this.TextBoxchemin.SelectedText = "";
            this.TextBoxchemin.Size = new System.Drawing.Size(565, 30);
            this.TextBoxchemin.TabIndex = 6;
            this.TextBoxchemin.TextChanged += new System.EventHandler(this.TextBoxchemin_TextChanged);
            // 
            // ButtonImprimer_Excel
            // 
            this.ButtonImprimer_Excel.AnimationHoverSpeed = 0.07F;
            this.ButtonImprimer_Excel.AnimationSpeed = 0.03F;
            this.ButtonImprimer_Excel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonImprimer_Excel.BaseColor1 = System.Drawing.Color.Blue;
            this.ButtonImprimer_Excel.BaseColor2 = System.Drawing.Color.Green;
            this.ButtonImprimer_Excel.BorderColor = System.Drawing.Color.Black;
            this.ButtonImprimer_Excel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonImprimer_Excel.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonImprimer_Excel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonImprimer_Excel.ForeColor = System.Drawing.Color.White;
            this.ButtonImprimer_Excel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonImprimer_Excel.Image")));
            this.ButtonImprimer_Excel.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonImprimer_Excel.Location = new System.Drawing.Point(338, 457);
            this.ButtonImprimer_Excel.Name = "ButtonImprimer_Excel";
            this.ButtonImprimer_Excel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.ButtonImprimer_Excel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonImprimer_Excel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonImprimer_Excel.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonImprimer_Excel.OnHoverImage = null;
            this.ButtonImprimer_Excel.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonImprimer_Excel.Radius = 6;
            this.ButtonImprimer_Excel.Size = new System.Drawing.Size(125, 30);
            this.ButtonImprimer_Excel.TabIndex = 7;
            this.ButtonImprimer_Excel.Text = "Imprimer Excel";
            this.ButtonImprimer_Excel.Click += new System.EventHandler(this.ButtonImprimer_Excel_Click);
            // 
            // openFile
            // 
            this.openFile.Tag = "CSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 501);
            this.Controls.Add(this.ButtonImprimer_Excel);
            this.Controls.Add(this.TextBoxchemin);
            this.Controls.Add(this.Buttonimport);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GradientPanel_TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.GradientPanel_TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel GradientPanel_TOP;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDataGridView DataGridView1;
        private Guna.UI.WinForms.GunaGradientButton Buttonimport;
        private Guna.UI.WinForms.GunaTextBox TextBoxchemin;
        private Guna.UI.WinForms.GunaGradientButton ButtonImprimer_Excel;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

