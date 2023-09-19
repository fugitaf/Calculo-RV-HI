﻿using System.Net.NetworkInformation;

namespace Calculo_RV_HI.Entities
{
    public class Certificado
    {
        public string DataCotizacao { get; set; }
        public decimal SaldoCotasCertificado { get; set; }
        public decimal CotacaoAplicacao { get; set; }
        public decimal CotacaoUltimaTributacao { get; set; }
        public decimal SaldoAmortizacaoDePrincipal { get; set; }
        public decimal valorUfirAplicacao { get; set; }

        public decimal CotacaoAplicacaoAjustada()
        {
            int anoDoCertificado = int.Parse(DataCotizacao.Substring(6));

            if (anoDoCertificado <= 1994)
            {
                return Utils.Utils.TruncarValor(CotacaoUltimaTributacao / valorUfirAplicacao * 0.6767m);
            }
            else
            {
                return CotacaoUltimaTributacao;
            }
        }
    }
}
