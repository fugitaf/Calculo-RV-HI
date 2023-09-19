namespace Calculo_RV_HI.Entities
{
    public class Saldo
    {
        public decimal SaldoCotasSubconta { get; set; }
        public decimal ValorCustoMedio { get; set; }
        public decimal SaldoPrejuizo { get; set; }
        public List<AliquotasIR> AliquotasIR { get; set; } = new List<AliquotasIR>();

        public Saldo() { }

        public void AddAliquotaIR(AliquotasIR aliquotasIR)
        {
            AliquotasIR.Add(aliquotasIR);
        }
        public List<AliquotasIR> AliquotasIRDoCertificado(string dataCotizacao)
        {
            int anoDoCertificado = int.Parse(dataCotizacao.Substring(6));
            return AliquotasIR.FindAll(x => x.Ano >= anoDoCertificado);

        }
    }
}
