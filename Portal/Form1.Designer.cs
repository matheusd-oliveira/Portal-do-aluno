namespace Portal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Name = new TextBox();
            txt_Idade = new TextBox();
            txt_Curso = new TextBox();
            btn_Adicionar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            list_view_Alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 32);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 104);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 205);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 293);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 3;
            label4.Text = "Curso:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(46, 142);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(261, 23);
            txt_Name.TabIndex = 4;
            // 
            // txt_Idade
            // 
            txt_Idade.Location = new Point(46, 238);
            txt_Idade.Name = "txt_Idade";
            txt_Idade.Size = new Size(261, 23);
            txt_Idade.TabIndex = 5;
            // 
            // txt_Curso
            // 
            txt_Curso.Location = new Point(46, 331);
            txt_Curso.Name = "txt_Curso";
            txt_Curso.Size = new Size(261, 23);
            txt_Curso.TabIndex = 6;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Location = new Point(102, 386);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(140, 48);
            btn_Adicionar.TabIndex = 7;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(list_view_Alunos);
            panel1.Location = new Point(423, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 494);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 32);
            label5.Name = "label5";
            label5.Size = new Size(192, 29);
            label5.TabIndex = 1;
            label5.Text = "Lista de Alunos";
            // 
            // list_view_Alunos
            // 
            list_view_Alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            list_view_Alunos.Location = new Point(47, 104);
            list_view_Alunos.Name = "list_view_Alunos";
            list_view_Alunos.Size = new Size(364, 330);
            list_view_Alunos.TabIndex = 0;
            list_view_Alunos.UseCompatibleStateImageBehavior = false;
            list_view_Alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 180;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 487);
            Controls.Add(panel1);
            Controls.Add(btn_Adicionar);
            Controls.Add(txt_Curso);
            Controls.Add(txt_Idade);
            Controls.Add(txt_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulário";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Name;
        private TextBox txt_Idade;
        private TextBox txt_Curso;
        private Button btn_Adicionar;
        private Panel panel1;
        private ListView list_view_Alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
    }
}