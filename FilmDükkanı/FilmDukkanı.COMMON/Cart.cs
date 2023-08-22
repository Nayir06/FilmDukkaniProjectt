using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDukkanı.COMMON
{
    public class Cart
    {
        public Dictionary<int, CartItem> _myCart = new Dictionary<int, CartItem>();


        public void AddItem(CartItem cartItem)
        {
            if (_myCart.ContainsKey(cartItem.Id))
            {
                _myCart[cartItem.Id].Quantity += 1;
                return;
            }
            _myCart.Add(cartItem.Id, cartItem);
        }
    }
}
