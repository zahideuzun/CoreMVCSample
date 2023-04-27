namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class ProductContent
	{
		public int ProductId { get; set; }
		public int ContentId { get; set; }


		public Product Product { get; set; }
		public Content Content { get; set; }
	}
}
