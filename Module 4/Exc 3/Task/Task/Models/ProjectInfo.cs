using System;
using Task.Data;

namespace Task.Models
{
	public class ProjectInfo
	{
		public int ProjectId { get; set; }
		public string ProjectName { get; set; }
		public Attachment[] Attachments { get; set; }
	}
}
