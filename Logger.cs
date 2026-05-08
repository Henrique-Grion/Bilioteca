namespace Bilioteca;

public enum LogNivel
{
    Debug = 0,
    Informacao = 1,
    Aviso = 2,
    Erro = 3,
    Critico = 4,
}

public class Logger
{
    private static Logger? _instance = null;

    public LogNivel NivelMinimo { get; set; } = LogNivel.Debug;

    private Logger() { }

    public static Logger GetInstance()
    {
        _instance ??= new Logger();
        return _instance;
    }

    public static Logger Instance => GetInstance();

    public void Log(string mensagem, LogNivel nivel)
    {
        if (nivel < NivelMinimo) return;

        string prefixo = nivel switch
        {
            LogNivel.Debug => "[DEBUG]",
            LogNivel.Informacao => "[INFO]",
            LogNivel.Aviso => "[WARNING]",
            LogNivel.Erro => "[ERROR]",
            LogNivel.Critico => "[CRITICAL]",
            _ => "[UNKNOWN]"
        };
        string fileName = $"log_{DateTime.Now:yyyy-MM-dd}.log";
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string logsDir = Path.Combine(exeDir, "logs");
        if (!Directory.Exists(logsDir)) Directory.CreateDirectory(logsDir);
        string filePath = Path.Combine(logsDir, fileName);
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {prefixo} {mensagem}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }

    public void Debug(string mensagem) => Log(mensagem, LogNivel.Debug);
    public void Informacao(string mensagem) => Log(mensagem, LogNivel.Informacao);
    public void Aviso(string mensagem) => Log(mensagem, LogNivel.Aviso);
    public void Erro(string mensagem) => Log(mensagem, LogNivel.Erro);
    public void Critico(string mensagem) => Log(mensagem, LogNivel.Critico);
}

