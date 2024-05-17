class Cadastro
{
    private string nome;
    private string sobrenome;
    private string cpf;
    private string username;
    private string email;
    private string senha;
    private string confirmaSenha;
    private int idade;
    private string sexo;
    private string jogoFavorito;
    private int jogaQuantoTempo;
    private string celular;
    private string telefone;
    
    // Métodos
    public Cadastro()
    {
        this.nome = "";
        this.sobrenome = "";
        this.cpf = "";
        this.username = "";
        this.email = "";
        this.senha = "";
        this.confirmaSenha = "";
        this.idade = 0;
        this.sexo = "";
        this.jogoFavorito = "";
        this.jogaQuantoTempo = 0;
        this.celular = "";
        this.telefone = "";
    }

    public Cadastro(
        string p_nome, string p_sobrenome, string p_cpf, string p_username, string p_email,
        string p_senha, string p_confirmaSenha,  int p_idade, string p_sexo, string p_jogoFavorito,
        int p_jogaQuantoTempo, string p_celular, string p_telefone
        )
    {
        this.nome = p_nome;
        this.sobrenome = p_sobrenome;
        this.cpf = p_cpf;
        this.username = p_username;
        this.email = p_email;
        this.senha = p_senha;
        this.confirmaSenha = p_confirmaSenha;
        this.idade = p_idade;
        this.sexo = p_sexo;
        this.jogoFavorito= p_jogoFavorito;
        this.jogaQuantoTempo = p_jogaQuantoTempo;
        this.celular = p_celular;
        this.telefone = p_telefone;
    }

    // Getter / Setter

    public string getNome() { return this.nome; }
    public void setNome(string p_nome) { this.nome = p_nome; }

    public string getSobrenome() { return this.sobrenome; }
    public void setSobrenome(string p_sobrenome) { this.sobrenome = p_sobrenome; }

    public string getCPf() { return this.cpf; }
    public void setCPf(string p_cpf) { this.cpf = p_cpf; }

    public string getUsername() { return this.username;}
    public void setUsername(string p_username) { this.username = p_username; }

    public string getEmail() { return this.email; }
    public void setEmail(string p_email) { this.email = p_email; }

    public string getSenha() { return this.senha; }
    public void setSenha(string p_senha) { this.senha = p_senha; }

    public string getConfirmaSenha() { return this.confirmaSenha; }
    public void setConfirmaSenha(string p_confirmaSenha) { this.confirmaSenha = p_confirmaSenha; }

    public int getIdade() { return this.idade; }
    public void setIdade(int p_idade) { this.idade = p_idade; }

    public string getSexo() { return this.sexo; }
    public void setSexo(string p_sexo) { this.sexo = p_sexo; }

    public string getJogoFavorito() { return this.jogoFavorito; }
    public void setJogoFavorito(string p_jogoFavorito) { this.jogoFavorito= p_jogoFavorito; }

    public int getJogaQuantoTempo() { return this.jogaQuantoTempo; }
    public void setJogaQuantoTempo(int p_jogaQuantoTempo) { this.jogaQuantoTempo = p_jogaQuantoTempo; }

    public string getCelular() { return this.celular; }
    public void setCelular(string p_celular) { this.celular = p_celular;}

    public string getTelefone() { return this.telefone; }
    public void setTelefone(string p_telefone) { this.telefone = p_telefone; }
}
