using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmManager.Models;

namespace CrmManager.Crm
{
    public class ClassGenerator
    {

        public static void GenerateClass(ClassOptions classOptions, Manager manager)
        {
            var fields = manager.GetCrmEntityFields(classOptions.InternalName);

            if (fields.NotEmpty())
            {

                var stringBuilder = new StringBuilder();

                stringBuilder.Append($@"using System;
using System.Collections.Generic;
using System.Linq;
using Fluent.Crm;

namespace {classOptions.Namespace}
{{
        [CrmEntity(""{classOptions.InternalName}"")]
        public class {classOptions.ClassName}
        {{
");

                foreach (var field in fields)
                {
                    stringBuilder.Append(GetFieldProperty(field));
                }

                stringBuilder.Append($@"
        }}
}}");

                var filepath = GetFilepath(classOptions);
                File.WriteAllText(filepath, stringBuilder.ToString());
                Process.Start(filepath);
            }

        }

        public static void GenerateConstants(ClassOptions classOptions, Manager manager)
        {
            var fields = manager.GetCrmEntityFields(classOptions.InternalName);

            if (fields.NotEmpty())
            {

                var stringBuilder = new StringBuilder();

                stringBuilder.Append($@"using System;

namespace {classOptions.Namespace}
{{
        public class {classOptions.ClassName}
        {{
            public const string LogicalName = ""{classOptions.InternalName}"";
            public const string Id = ""{classOptions.InternalName}id"";");

                foreach (var field in fields)
                {
                    stringBuilder.Append(GetFieldConstant(field));
                }

                stringBuilder.Append($@"
        }}
}}");

                var filepath = GetFilepath(classOptions);
                File.WriteAllText(filepath, stringBuilder.ToString());
                Process.Start(filepath);
            }
        }

        private static string GetFilepath(ClassOptions classOptions)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $@"{classOptions.ClassName}.cs");
        }

        private static string GetFieldProperty(CrmField field)
        {
            return $@"
                [CrmField(""{field.InternalName}"")]
                public {field.Type.GetDotnetType()} {field.DisplayName.SplitterByUnderscore()} {{ get; set; }}
";
        }

        private static string GetFieldConstant(CrmField field)
        {
            return $@"
            /// <summary>
            /// {field.Type}
            /// </summary>
            public const string {field.DisplayName.SplitterByUnderscore()} = ""{field.InternalName}"";";
        }

    }
}
