using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 20;
        }
    }
}
