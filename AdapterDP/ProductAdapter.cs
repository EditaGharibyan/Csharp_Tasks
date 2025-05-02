using System;
using ProdInt;
using Prod;
namespace Adapter
{
	public class ProductAdapter : IProductProvide
	{
		private Product p;
		public ProductAdapter(string csv)
		{
			string[] arr = csv.Split( );
			p = new Product
			{
				Name = arr[0],
				Price = Convert.ToDouble(arr[1])
			};
		}
		public Product GetProduct()
		{
			return p;
		}
	}
}
