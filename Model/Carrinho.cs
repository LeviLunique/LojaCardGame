using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Carrinho
    {
        public string Item { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
