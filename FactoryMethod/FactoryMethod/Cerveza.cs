using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Cerveza : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 5;
        }
    }
}
