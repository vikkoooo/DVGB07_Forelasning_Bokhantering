namespace DVGB07_Bokhantering
{
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public string Description { get; set; }
		public bool Lended { get; set; }

		public Book()
		{
			Lended = false;
		}
		
		public override string ToString()
		{
			return $"{Title} ({ISBN})";
		}
	}
}