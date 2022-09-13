﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBackend.Model
{
    public abstract class Senha
    {
        public char Sigla { get; set; }
        public int Numero { get; set; }
        public double Prioridade { get; set; }
        public double FatorCorrecao { get; set; }

        public Senha()
        {
            Prioridade = DateTime.Now.ToOADate();
            Thread.Sleep(10);
        }

        public override string ToString()
        {
            return $"{Sigla}{Numero}";
        }

        public virtual void CorrigirPrioridade()
        {
            FatorCorrecao = 1;
        }
    }
}