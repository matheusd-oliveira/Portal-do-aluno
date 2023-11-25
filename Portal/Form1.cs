using Portal.Infrastructure;

namespace Portal
{
    public partial class Form1 : Form
    {
        // Criar uma lista para adicionar os alunos.
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        // Todos os componentes do meu Windows Forms vão estar aqui.
        public Form1()
        {
            InitializeComponent();
            ObterAlunos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Obtendo a lista de alunos do meu banco e mostrando na minha list View.
        // Esse método vai rodar toda vez que inicializarmos o programa.
        private void ObterAlunos()
        {
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            foreach (var item in Alunos)
            {
                list_view_Alunos.Items.Add(new ListViewItem(new string[] {item.nome, item.idade.ToString(), item.curso}));
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_Name.Text;
                var idade = txt_Idade.Text;
                var curso = txt_Curso.Text;

                // Percorrendo a lista e conferindo se o nome passado já está na lista de alunos.
                foreach (var item in Alunos)
                {
                    if (item.nome == nome)
                    {
                        MessageBox.Show($"{nome} já está cadastrado no sistema.");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

                // Adicionando o objeto aluno no banco de dados Postgree.
                var repository = new AlunoRepository();
                repository.Add(aluno);

                // Adicionando os dados na minha list view.
                list_view_Alunos.Items.Add(new ListViewItem(new string[] { nome, idade, curso }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}