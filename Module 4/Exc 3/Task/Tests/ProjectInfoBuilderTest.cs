using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Task;
using Task.Data;
using Task.Models;

namespace Tests
{
	public class ProjectInfoBuilderTest
	{
		[Test]
		public void CreateProjectInfosTest()
		{
			var projects = GenerateTestProjects(10).ToArray();
			var attachments = GenerateTestAttachments(projects, 20);

			var projectInfos = new ProjectInfoBuilder().CreateProjectInfos(projects, attachments);

			Assert.IsTrue(Verify(projectInfos, projects, attachments));
		}
		private IEnumerable<Project> GenerateTestProjects(int count)
		{
			for (var i = 1; i <= count; i++)
			{
				yield return new Project
				{
					Id = i,
					Name = $"Project_{i}",
				};
			}
		}

		private IEnumerable<Attachment> GenerateTestAttachments(ICollection<Project> projects, int count)
		{
			var random = new Random();
			for (var i = 1; i <= count; i++)
			{
				AttachmentType type = random.NextDouble() > 0.5 ? AttachmentType.Project : AttachmentType.User;
				yield return new Attachment
				{
					Id = i,
					Name = $"Attachment_{i}",
					Type = type,
					ObjectId = type == AttachmentType.Project ? projects.ElementAt(random.Next(projects.Count)).Id : random.Next(),
					Data = "additional data",
				};
			}
		}

		private bool Verify(IEnumerable<ProjectInfo> projectInfos, IEnumerable<Project> projects, IEnumerable<Attachment> attachments)
		{
			if (projectInfos.Count() != projects.Count())
			{
				return false;
			}

			foreach (var projectInfo in projectInfos)
			{
				var project = projects.FirstOrDefault(p => p.Id == projectInfo.ProjectId);
				if (project == null || project.Name != projectInfo.ProjectName)
				{
					return false;
				}

				foreach (var projectAttachment in projectInfo.Attachments)
				{
					var attachment = attachments.FirstOrDefault(a => a.Id == projectAttachment.Id);
					if (attachment == null
					    || attachment.Name != projectAttachment.Name
					    || attachment.Type != projectAttachment.Type
					    || attachment.Type != AttachmentType.Project
					    || attachment.Data != projectAttachment.Data)
					{
						return false;
					}
				}

				if (projectInfo.Attachments.Length != attachments.Count(a => a.Type == AttachmentType.Project && a.ObjectId == projectInfo.ProjectId))
				{
					return false;
				}
			}

			return true;
		}
	}
}