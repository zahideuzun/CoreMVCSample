using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class Content
	{
		public int ContentId { get; set; }
		public string ContentName { get; set; }


		public List<ProductContent> ProductContents { get; set; }
	}
}
