using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmManager.Models
{
    public class ClassOptions
    {
        public string Namespace { get; set; }

        public string ClassName { get; set; }

        public string InternalName { get; set; }

        public string DisplayName { get; set; }

        public override string ToString() => $"{InternalName} ({DisplayName})";

        public static ClassOptions FromCrmEntity(CrmEntity crmEntity, string nameSpace)
        {
            return new ClassOptions
            {
                Namespace = nameSpace,
                InternalName = crmEntity.InternalName,
                DisplayName = crmEntity.DisplayName,
                ClassName = crmEntity.DisplayName.SplitterByUnderscore()
            };
        }
    }
}
