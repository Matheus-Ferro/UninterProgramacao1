namespace Pratica1
{
    public class ClasseComplexa : IImprimirValores
    {
        public string PropInterface { get; set; }
        private int PropInt { get; set; }
        protected bool PropBool { get; set; }
        public decimal MeuDecimal { get; set; }
        protected DateTime dataAtual;
        float floatField;
        public Direcoes Direcao { get; set; }

        public enum Direcoes
        {
            Cima = 1,
            Baixo = 10,
            Esquerda = 20,
            Direita = 67
        }
    }
}
