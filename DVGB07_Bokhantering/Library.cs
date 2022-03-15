using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace DVGB07_Bokhantering
{
	public class Library
	{
		public BindingList<Book> BookList { get; private set; }

		public Library()
		{
			BookList = new BindingList<Book>();
			// {
			// 	new Book() { Title = "Linear Algebra", Author = "Poole", ISBN = "123", Description = "" },
			// 	new Book() { Title = "The Invisible Computer", Author = "Donald Norman", ISBN = "234", Description = "" },
			// 	new Book() { Title = "Datorsystem", Author = "Mats Brorsson", ISBN = "345", Description = "" }
			// };
		}

		public void SaveFile()
		{
			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("book_library"); // <book_library>
			foreach (var entry in BookList)
			{
				XmlElement elem = doc.CreateElement("book"); // <book>
				
				XmlElement title = doc.CreateElement("title"); // <title>
				title.InnerText = entry.Title;
				elem.AppendChild(title); // </title>
				
				XmlElement author = doc.CreateElement("author"); 
				author.InnerText = entry.Author;
				elem.AppendChild(author); 
				
				XmlElement isbn = doc.CreateElement("isbn"); 
				isbn.InnerText = entry.ISBN;
				elem.AppendChild(isbn); 
				
				XmlElement description = doc.CreateElement("description"); 
				description.InnerText = entry.Description;
				elem.AppendChild(description); 
				
				XmlElement lended = doc.CreateElement("lended"); 
				lended.InnerText = entry.Lended.ToString();
				elem.AppendChild(lended); 
				
				root.AppendChild(elem); // </book>
			}
			doc.AppendChild(root); // </book_library>
			doc.Save("db.xml");
		}

		public void LoadFile()
		{
			XmlDocument document = new XmlDocument();
			document.Load("db.xml");

			var root = document.FirstChild;
			foreach (XmlElement entry in root.ChildNodes)
			{
				var book = new Book();
				
				foreach (XmlElement entry_ in entry.ChildNodes)
				{
					if (entry_.Name == "title")
						book.Title = entry_.InnerText;
					if (entry_.Name == "author")
						book.Author = entry_.InnerText;
					if (entry_.Name == "isbn")
						book.ISBN = entry_.InnerText;
					if (entry_.Name == "description")
						book.Description = entry_.InnerText;
					if (entry_.Name == "lended")
						book.Lended = bool.Parse(entry_.InnerText);
				}
				BookList.Add(book);
			}

		}


	}
}