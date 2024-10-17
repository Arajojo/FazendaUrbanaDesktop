using System.Collections.Generic;
using System.Linq;

namespace FazendaUrbanaDesktop.Classes
{
    public class Produto
    {
        public static products GetProduct(int _id)
        {
            Entities data = new Entities();
            products product = new products();
            product = data.products.Where(c => c.id == _id).FirstOrDefault();
            return product;
        }
    }
}