namespace ProjetoEmpresa_WF
{
    class Comissionado: Empregado
    {
        public double totalVenda, taxaComissao = 0.01; //1%

        public double CalcularSalario()
        {
            return totalVenda * taxaComissao;
        }
    }
}
