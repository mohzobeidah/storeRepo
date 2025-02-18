using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MOZ.StoreManagement.Categories;

using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;


    public class Category : FullAuditedEntity<int>, IMultiTenant
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        // IMultiTenant implementation
        public Guid? TenantId { get; set; }

        

        
    }

