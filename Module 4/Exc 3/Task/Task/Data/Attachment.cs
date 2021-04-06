using System;

namespace Task.Data
{
	public class Attachment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Data { get; set; }
		public AttachmentType Type { get; set; }
		public int ObjectId { get; set; }
	}
}
