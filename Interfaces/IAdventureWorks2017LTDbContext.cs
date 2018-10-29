// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Interfaces
{
    using Entities;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    public interface IAdventureWorks2017LTDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<BuildVersion> BuildVersions { get; set; } // BuildVersion
        System.Data.Entity.DbSet<ErrorLog> ErrorLogs { get; set; } // ErrorLog
        System.Data.Entity.DbSet<SalesLT_Address> SalesLT_Addresses { get; set; } // Address
        System.Data.Entity.DbSet<SalesLT_Customer> SalesLT_Customers { get; set; } // Customer
        System.Data.Entity.DbSet<SalesLT_CustomerAddress> SalesLT_CustomerAddresses { get; set; } // CustomerAddress
        System.Data.Entity.DbSet<SalesLT_Product> SalesLT_Products { get; set; } // Product
        System.Data.Entity.DbSet<SalesLT_ProductCategory> SalesLT_ProductCategories { get; set; } // ProductCategory
        System.Data.Entity.DbSet<SalesLT_ProductDescription> SalesLT_ProductDescriptions { get; set; } // ProductDescription
        System.Data.Entity.DbSet<SalesLT_ProductModel> SalesLT_ProductModels { get; set; } // ProductModel
        System.Data.Entity.DbSet<SalesLT_ProductModelProductDescription> SalesLT_ProductModelProductDescriptions { get; set; } // ProductModelProductDescription
        System.Data.Entity.DbSet<SalesLT_SalesOrderDetail> SalesLT_SalesOrderDetails { get; set; } // SalesOrderDetail
        System.Data.Entity.DbSet<SalesLT_SalesOrderHeader> SalesLT_SalesOrderHeaders { get; set; } // SalesOrderHeader
        System.Data.Entity.DbSet<SalesLT_VGetAllCategory> SalesLT_VGetAllCategories { get; set; } // vGetAllCategories
        System.Data.Entity.DbSet<SalesLT_VProductAndDescription> SalesLT_VProductAndDescriptions { get; set; } // vProductAndDescription
        System.Data.Entity.DbSet<SalesLT_VProductModelCatalogDescription> SalesLT_VProductModelCatalogDescriptions { get; set; } // vProductModelCatalogDescription

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        int UspLogError(out int? errorLogId);
        // UspLogErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspPrintError();
        // UspPrintErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)


        // Table Valued Functions
        [System.Data.Entity.DbFunction("AdventureWorks2017LTDbContext", "ufnGetAllCategories")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        System.Linq.IQueryable<UfnGetAllCategoriesReturnModel> UfnGetAllCategories();
        [System.Data.Entity.DbFunction("AdventureWorks2017LTDbContext", "ufnGetCustomerInformation")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        System.Linq.IQueryable<UfnGetCustomerInformationReturnModel> UfnGetCustomerInformation(int? customerId);
    }

}
// </auto-generated>
