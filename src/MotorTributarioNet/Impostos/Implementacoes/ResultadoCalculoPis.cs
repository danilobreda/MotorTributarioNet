﻿namespace MotorTributarioNet.Impostos.Implementacoes
{
    public class ResultadoCalculoPis : IResultadoCalculoPis
    {
        public ResultadoCalculoPis(decimal baseCalculo, decimal valor)
        {
            BaseCalculo = baseCalculo;
            Valor = valor;
        }

        public decimal BaseCalculo { get; }
        public decimal Valor { get; }
    }
}