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
            pbAluno = new PictureBox();
            txtBuscarAluno = new TextBox();
            btnBuscarAluno = new Button();
            imageListAluno = new ImageList(components);
            dgvAluno = new DataGridView();
            btnAdicionarAluno = new Button();
            btnAlterarAluno = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            SuspendLayout();
            // 
            // pbAluno
            // 
            pbAluno.Image = Properties.Resources.student_work_office_desk_work_space_computer_working_support_icon_191191__3_;
            pbAluno.Location = new Point(12, 12);
            pbAluno.Name = "pbAluno";
            pbAluno.Size = new Size(66, 64);
            pbAluno.TabIndex = 0;
            pbAluno.TabStop = false;
            // 
            // txtBuscarAluno
            // 
            txtBuscarAluno.Location = new Point(84, 12);
            txtBuscarAluno.Name = "txtBuscarAluno";
            txtBuscarAluno.PlaceholderText = "Digite o nome a buscar";
            txtBuscarAluno.Size = new Size(246, 23);
            txtBuscarAluno.TabIndex = 0;
            // 
            // btnBuscarAluno
            // 
            btnBuscarAluno.BackColor = SystemColors.ActiveCaption;
            btnBuscarAluno.FlatStyle = FlatStyle.Flat;
            btnBuscarAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarAluno.ImageKey = "WhatsApp Image 2026-03-20 at 19.51.53.jpeg";
            btnBuscarAluno.ImageList = imageListAluno;
            btnBuscarAluno.Location = new Point(84, 47);
            btnBuscarAluno.Name = "btnBuscarAluno";
            btnBuscarAluno.Size = new Size(95, 29);
            btnBuscarAluno.TabIndex = 1;
            btnBuscarAluno.Text = "Buscar";
            btnBuscarAluno.UseVisualStyleBackColor = false;
            btnBuscarAluno.Click += btnBuscarAluno_Click;
            // 
            // imageListAluno
            // 
            imageListAluno.ColorDepth = ColorDepth.Depth32Bit;
            imageListAluno.ImageStream = (ImageListStreamer)resources.GetObject("imageListAluno.ImageStream");
            imageListAluno.TransparentColor = Color.Transparent;
            imageListAluno.Images.SetKeyName(0, "WhatsApp Image 2026-03-20 at 19.51.52.jpeg");
            imageListAluno.Images.SetKeyName(1, "WhatsApp Image 2026-03-20 at 19.51.53 (2).jpeg");
            imageListAluno.Images.SetKeyName(2, "WhatsApp Image 2026-03-20 at 19.51.53 (1).jpeg");
            imageListAluno.Images.SetKeyName(3, "WhatsApp Image 2026-03-20 at 19.51.53.jpeg");
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(12, 82);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.Size = new Size(318, 250);
            dgvAluno.TabIndex = 2;
            // 
            // btnAdicionarAluno
            // 
            btnAdicionarAluno.BackColor = Color.Lime;
            btnAdicionarAluno.FlatStyle = FlatStyle.Flat;
            btnAdicionarAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarAluno.ImageKey = "WhatsApp Image 2026-03-20 at 19.51.53 (1).jpeg";
            btnAdicionarAluno.ImageList = imageListAluno;
            btnAdicionarAluno.Location = new Point(12, 338);
            btnAdicionarAluno.Name = "btnAdicionarAluno";
            btnAdicionarAluno.Size = new Size(102, 31);
            btnAdicionarAluno.TabIndex = 4;
            btnAdicionarAluno.Text = "Adicionar";
            btnAdicionarAluno.UseVisualStyleBackColor = false;
            // 
            // btnAlterarAluno
            // 
            btnAlterarAluno.BackColor = Color.FromArgb(255, 255, 128);
            btnAlterarAluno.FlatStyle = FlatStyle.Flat;
            btnAlterarAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterarAluno.ImageKey = "WhatsApp Image 2026-03-20 at 19.51.52.jpeg";
            btnAlterarAluno.ImageList = imageListAluno;
            btnAlterarAluno.Location = new Point(120, 338);
            btnAlterarAluno.Name = "btnAlterarAluno";
            btnAlterarAluno.Size = new Size(102, 31);
            btnAlterarAluno.TabIndex = 3;
            btnAlterarAluno.Text = "Aterar";
            btnAlterarAluno.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = SystemColors.ControlText;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.ImageKey = "WhatsApp Image 2026-03-20 at 19.51.53 (2).jpeg";
            btnSair.ImageList = imageListAluno;
            btnSair.Location = new Point(228, 338);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 31);
            btnSair.TabIndex = 5;
            btnSair.Text = "Esc Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 450);
            Controls.Add(btnSair);
            Controls.Add(btnAlterarAluno);
            Controls.Add(btnAdicionarAluno);
            Controls.Add(dgvAluno);
            Controls.Add(btnBuscarAluno);
            Controls.Add(txtBuscarAluno);
            Controls.Add(pbAluno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5";
            ((System.ComponentModel.ISupportInitialize)pbAluno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAluno;
        private TextBox txtBuscarAluno;
        private Button btnBuscarAluno;
        private DataGridView dgvAluno;
        private ImageList imageListAluno;
        private Button btnAdicionarAluno;
        private Button btnAlterarAluno;
        private Button btnSair;
    }
}
