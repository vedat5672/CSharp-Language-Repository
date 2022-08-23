using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    // Gereksinimler eklenme temizleme çıkartma
    public class CartManager
    {
        List<CartItem> _cartItems;

        public CartManager()
        {
            this._cartItems = new List<CartItem>();  
        }
        public void Add(CartItem cartItem)
        {
            var CartItem = _cartItems.SingleOrDefault(t => t.product.ProductId == cartItem.product.ProductId);
            if (CartItem==null)
            {
                _cartItems.Add(cartItem);
            }
            else
            {
                throw new Exception("Product already has been added");
            }
            
        }
        public void Remove(int ProductId)
        {
            var product=_cartItems.FirstOrDefault(x => x.product.ProductId == ProductId);
            _cartItems.Remove(product);
        }
        public List<CartItem> CartItems { get { return _cartItems; } }
        public void Clear()
        {
            _cartItems.Clear();
        }
        public decimal TotalPrice
        {
            get { return _cartItems.Sum(t => t.Quantity * t.product.UnitInPrice); }
        }
        public int TotalQuantity { get { return _cartItems.Sum(t => t.Quantity); } }
        public int TotalItem { get { return _cartItems.Count; } }
    }
}
