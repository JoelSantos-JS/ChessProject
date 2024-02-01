namespace tabuleiro;

public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    public Posicao posicao { get; protected set; }
    private Peca[,] pecas;

    public Tabuleiro(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        pecas = new Peca[linhas, colunas];
    }
}