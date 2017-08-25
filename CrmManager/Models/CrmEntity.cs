namespace CrmManager.Models
{
    public class CrmEntity
    {

        public string InternalName { get; set; }

        public string DisplayName { get; set; }

        public override string ToString() => $"{InternalName} ({DisplayName})";
    }
}
