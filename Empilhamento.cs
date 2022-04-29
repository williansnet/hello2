namespace Hello2
{
    class Empilhamento
    {
        private Stack<string> pilha;

        public Empilhamento()
        {
            this.pilha = new Stack<string>();
        }

        public void Empilhar(string valor)
        {
            pilha.Push(valor);
        }

        public void Desempilhar()
        {
            pilha.Pop();
        }

        public List<string> Lista()
        {
            return pilha.ToList();
        }
    }
}