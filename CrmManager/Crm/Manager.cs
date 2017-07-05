using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace CrmManager.Crm
{
	public class Manager
	{

		private readonly string _crmUrl;

		public Manager(string crmUrl)
		{
			this._crmUrl = crmUrl;
		}

		public CrmOrganizationServiceContext GetCrmProxy()
		{
			return new CrmOrganizationServiceContext(new CrmConnection(new ConnectionStringSettings("crmcon", _crmUrl)));
		}

		public EntityCollection GetEntity(string entityName)
		{
			using (var proxy = GetCrmProxy())
			{
				return proxy.RetrieveMultiple(new QueryExpression(entityName) { ColumnSet = new ColumnSet(true) });
			}
		}

		public List<string> GetAllEntities()
		{
			using (var proxy = GetCrmProxy())
			{
				RetrieveAllEntitiesRequest retrieveAllEntityRequest = new RetrieveAllEntitiesRequest
				{
					RetrieveAsIfPublished = true,
					EntityFilters = EntityFilters.Entity
				};

				var retrieveAllEntityResponse = (RetrieveAllEntitiesResponse)proxy.Execute(retrieveAllEntityRequest);

				if (retrieveAllEntityResponse?.EntityMetadata != null && retrieveAllEntityResponse.EntityMetadata.Length > 0)
				{
					return retrieveAllEntityResponse.EntityMetadata.Select(m => m.LogicalName).ToList();
				}

				return new List<string>();
			}
		}

		public List<Tuple<string, AttributeTypeCode?>> GetEntityFields(string entityName)
		{
			using (var proxy = GetCrmProxy())
			{
				RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
				{
					RetrieveAsIfPublished = true,
					EntityFilters = EntityFilters.Attributes,
					LogicalName = entityName
				};

				var entityResponse = (RetrieveEntityResponse)proxy.Execute(entityRequest);

				if (entityResponse?.EntityMetadata?.Attributes != null && entityResponse.EntityMetadata.Attributes.Length > 0)
				{
					return entityResponse.EntityMetadata.Attributes
						.Select(m => new Tuple<string, AttributeTypeCode?>(m.LogicalName, m.AttributeType)).ToList();
				}

				return new List<Tuple<string, AttributeTypeCode?>>();
			}
		}

	}
}
