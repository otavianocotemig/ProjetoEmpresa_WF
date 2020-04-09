namespace ProjetoEmpresa_WF
{
    class Horista: Empregado
    {
        public double precoHora, horasTrabalhadas;

        public double CalcularSalario()
        {
            return precoHora * horasTrabalhadas;
        }
    }
}
