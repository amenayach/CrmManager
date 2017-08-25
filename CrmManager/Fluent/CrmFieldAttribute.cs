using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmManager.Fluent
{
	[AttributeUsage(AttributeTargets.Property)]
	public class CrmFieldAttribute : Attribute
	{

		public CrmFieldAttribute()
		{
			
		}

		public string Name { get; set; }

		public string Type { get; set; }

	}
}
