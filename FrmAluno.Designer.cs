namespace Apresentacao
{
    partial class FrmAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            btnBuscarAluno = new Button();
            imageListAluno = new ImageList(components);
            txtBuscarAluno = new TextBox();
            pbLogoAluno = new PictureBox();
            dgvAluno = new DataGridView();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarAluno
            // 
            btnBuscarAluno.BackColor = Color.DodgerBlue;
            btnBuscarAluno.FlatStyle = FlatStyle.Flat;
            btnBuscarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarAluno.ForeColor = SystemColors.Control;
            btnBuscarAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarAluno.ImageKey = "search.png";
            btnBuscarAluno.ImageList = imageListAluno;
            btnBuscarAluno.Location = new Point(250, 40);
            btnBuscarAluno.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAluno.Name = "btnBuscarAluno";
            btnBuscarAluno.Size = new Size(82, 22);
            btnBuscarAluno.TabIndex = 0;
            btnBuscarAluno.Text = "Buscar";
            btnBuscarAluno.UseVisualStyleBackColor = false;
            btnBuscarAluno.Click += btnBuscarAluno_Click;
            // 
            // imageListAluno
            // 
            imageListAluno.ColorDepth = ColorDepth.Depth32Bit;
            imageListAluno.ImageStream = (ImageListStreamer)resources.GetObject("imageListAluno.ImageStream");
            imageListAluno.TransparentColor = Color.Transparent;
            imageListAluno.Images.SetKeyName(0, "remove.png");
            imageListAluno.Images.SetKeyName(1, "update.png");
            imageListAluno.Images.SetKeyName(2, "delete.png");
            imageListAluno.Images.SetKeyName(3, "save.png");
            imageListAluno.Images.SetKeyName(4, "search.png");
            // 
            // txtBuscarAluno
            // 
            txtBuscarAluno.Location = new Point(86, 42);
            txtBuscarAluno.Margin = new Padding(3, 2, 3, 2);
            txtBuscarAluno.Name = "txtBuscarAluno";
            txtBuscarAluno.PlaceholderText = "Informe o nome a Buscar";
            txtBuscarAluno.Size = new Size(160, 23);
            txtBuscarAluno.TabIndex = 1;
            // 
            // pbLogoAluno
            // 
            pbLogoAluno.Image = Properties.Resources.aluno;
            pbLogoAluno.Location = new Point(10, 9);
            pbLogoAluno.Margin = new Padding(3, 2, 3, 2);
            pbLogoAluno.Name = "pbLogoAluno";
            pbLogoAluno.Size = new Size(70, 53);
            pbLogoAluno.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoAluno.TabIndex = 2;
            pbLogoAluno.TabStop = false;
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(10, 74);
            dgvAluno.Margin = new Padding(3, 2, 3, 2);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.RowHeadersWidth = 51;
            dgvAluno.Size = new Size(322, 198);
            dgvAluno.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSpringGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.ImageKey = "save.png";
            btnCadastrar.ImageList = imageListAluno;
            btnCadastrar.Location = new Point(10, 276);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 22);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Inserir";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.DarkOrange;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.ForeColor = SystemColors.ActiveCaptionText;
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.ImageKey = "update.png";
            btnAlterar.ImageList = imageListAluno;
            btnAlterar.Location = new Point(109, 276);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 22);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Tomato;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = SystemColors.Control;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.ImageKey = "delete.png";
            btnSair.ImageList = imageListAluno;
            btnSair.Location = new Point(244, 276);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 22);
            btnSair.TabIndex = 6;
            btnSair.Text = "Esc Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(348, 311);
            Controls.Add(btnSair);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvAluno);
            Controls.Add(pbLogoAluno);
            Controls.Add(txtBuscarAluno);
            Controls.Add(btnBuscarAluno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Alunos";
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarAluno;
        private TextBox txtBuscarAluno;
        private PictureBox pbLogoAluno;
        private DataGridView dgvAluno;
        private ImageList imageListAluno;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnSair;
    }
}
