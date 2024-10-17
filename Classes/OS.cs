using System;
using System.Collections.Generic;

namespace FazendaUrbanaDesktop.Classes
{
    public class OS
    {
    
        public static decimal calcPrice(decimal _descount, decimal _price, decimal _qtd)
        {

            //decimal descount = decimal.Parse(cmbDescont.Text) / 100;
            //txtTitleProd.Text = Product.title;
            //txtIdProd.Text = Product.id.ToString();
            //decimal totalPrice = Product.price * nQtd.Value;
            //decimal descountPrice = ((descount * totalPrice) - totalPrice) * (-1);
            //txtValor.Text = descountPrice.ToString();

            decimal descount = _descount / 100;
            decimal totalPrice = _price * _qtd;
            decimal descountPrice = ((descount * totalPrice) - totalPrice) * (-1);

            return descountPrice;
        }
    }
}