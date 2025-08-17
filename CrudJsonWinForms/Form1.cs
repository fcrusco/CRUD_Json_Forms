using CrudJsonWinForms.Model;
using System.Text.Json;

namespace CrudJsonWinForms
{
    public partial class Form1 : Form
    {

        private string pastaDados;
        private string caminhoJson;
        private JsonSerializerOptions jsonOpts = new JsonSerializerOptions { WriteIndented = true };
        private List<Pessoa> pessoas = new List<Pessoa>();
        private Guid? editandoId = null;


        public Form1()
        {
            InitializeComponent();

            pastaDados = Path.Combine(AppContext.BaseDirectory, "data");
            caminhoJson = Path.Combine(pastaDados, "pessoas.json");
            Directory.CreateDirectory(pastaDados);
        }


        private void SalvarJson()
        {
            try
            {
                string json = JsonSerializer.Serialize(pessoas, jsonOpts);
                File.WriteAllText(caminhoJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar JSON: " + ex.Message);
            }
        }


        private bool ValidarFormulario(out string msg)
        {
            msg = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    msg = "Informe o Nome.";
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
                {
                    msg = "Informe o Sobrenome.";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                msg = "Erro na validação: " + ex.Message;
                return false;
            }
        }


        private void SalvarOuAtualizar()
        {
            try
            {
                if (!ValidarFormulario(out string msg))
                {
                    MessageBox.Show(msg);
                    return;
                }

                if (editandoId.HasValue)
                {
                    Pessoa p = pessoas.FirstOrDefault(x => x.Id == editandoId.Value);
                    if (p != null)
                    {
                        p.Nome = txtNome.Text.Trim();
                        p.Sobrenome = txtSobrenome.Text.Trim();
                        MessageBox.Show("Registro atualizado.");
                    }
                }
                else
                {
                    Pessoa p = new Pessoa();
                    p.Nome = txtNome.Text.Trim();
                    p.Sobrenome = txtSobrenome.Text.Trim();
                    pessoas.Add(p);
                    MessageBox.Show("Registro incluído.");
                }

                SalvarJson();
                RecarregarLista();
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar/atualizar: " + ex.Message);
            }
        }


        private void ExcluirSelecionado()
        {
            try
            {
                if (lstPessoas.SelectedItem is not Pessoa sel)
                {
                    MessageBox.Show("Selecione um registro para excluir.");
                    return;
                }

                DialogResult result = MessageBox.Show("Excluir '" + sel.Nome + " " + sel.Sobrenome + "'?",
                                                      "Confirmação",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pessoas.RemoveAll(x => x.Id == sel.Id);
                    SalvarJson();
                    RecarregarLista();
                    LimparFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }


        private void CarregarJson()
        {
            try
            {
                if (File.Exists(caminhoJson))
                {
                    string json = File.ReadAllText(caminhoJson);
                    pessoas = JsonSerializer.Deserialize<List<Pessoa>>(json);
                    if (pessoas == null) pessoas = new List<Pessoa>();
                }
                else
                {
                    pessoas = new List<Pessoa>();
                    SalvarJson(); // cria arquivo vazio na primeira execução
                }
                RecarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar JSON: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarJson();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar formulário: " + ex.Message);
            }
        }


        private void RecarregarLista()
        {
            try
            {
                lstPessoas.BeginUpdate();
                lstPessoas.Items.Clear();
                foreach (Pessoa p in pessoas.OrderBy(p => p.Nome).ThenBy(p => p.Sobrenome))
                {
                    lstPessoas.Items.Add(p);
                }
                lstPessoas.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recarregar lista: " + ex.Message);
            }
        }


        private void LimparFormulario()
        {
            try
            {
                editandoId = null;
                txtNome.Clear();
                txtSobrenome.Clear();
                lstPessoas.ClearSelected();
                lblNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar formulário: " + ex.Message);
            }
        }

        private void CarregarParaEdicao()
        {
            try
            {
                if (lstPessoas.SelectedItem is not Pessoa sel) return;
                editandoId = sel.Id;
                txtNome.Text = sel.Nome;
                txtSobrenome.Text = sel.Sobrenome;
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registro para edição: " + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar formulário: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarOuAtualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar registro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ExcluirSelecionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }

        private void lstPessoas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CarregarParaEdicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registro para edição: " + ex.Message);
            }
        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstPessoas.SelectedItem is Pessoa sel)
                {
                    editandoId = sel.Id;
                    txtNome.Text = sel.Nome;
                    txtSobrenome.Text = sel.Sobrenome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar registro: " + ex.Message);
            }
        }
    }
}
