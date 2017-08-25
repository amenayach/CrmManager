using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Metadata;

namespace CrmManager.Models
{
    public class CrmField
    {

        public string InternalName { get; set; }

        public string DisplayName { get; set; }

        public AttributeTypeCode? Type { get; set; }
        
    }
}
