using System.Text.Json;

namespace Bilioteca;

internal class ConfiguracaoSistema
{

    private readonly JsonSerializerOptions _options;
    public ConfiguracaoSistema()
    {
        _options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
    }

    public LogNivel LogNivel { get; set; } = LogNivel.Debug;

    public void Salvar()
    {
        string json = JsonSerializer.Serialize(this, this._options);
        File.WriteAllText("configuracao.json", json);
    }

    public void Carregar()
    {
        if (!File.Exists("configuracao.json")) return;
        try
        {

            string json = File.ReadAllText("configuracao.json");
            ConfiguracaoSistema? config = JsonSerializer.Deserialize<ConfiguracaoSistema>(json, this._options);
            if (config != null)
            {
                this.LogNivel = config.LogNivel;
            }
        }
        catch (Exception ex)
        {
            Logger.GetInstance().Erro($"Erro ao carregar configuração: {ex.Message}");
        }
    }
}
