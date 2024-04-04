
namespace Classes
{
	public class Book
	{
		public string Name { get; set; }
		public string OwnerName { get; set; }
		private float Price;
		public Book(string name)
		{
			Name = name;
		}
		public float SetPrice
		{
			get
			{ 
				return Price; 
			}
			set
			{
				Price = value;
			}
		}
		public void Show()
		{
            Console.WriteLine(Name);
			Console.WriteLine(OwnerName);
			Console.WriteLine(Price);
		}
	}
}
