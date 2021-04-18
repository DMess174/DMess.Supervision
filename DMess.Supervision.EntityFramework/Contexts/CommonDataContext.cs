using DMess.Supervision.CommonModel.ModelConfiguration;
using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.ModelConfiguration.Contracts;
using DMess.Supervision.CommonModel.ModelConfiguration.Customers;
using DMess.Supervision.CommonModel.ModelConfiguration.Factories;
using DMess.Supervision.CommonModel.ModelConfiguration.Orders;
using DMess.Supervision.CommonModel.ModelConfiguration.Products;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Models.Contracts;
using DMess.Supervision.CommonModel.Models.Customers;
using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.CommonModel.Models.Orders;
using DMess.Supervision.CommonModel.Models.Products;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DMess.Supervision.EntityFramework.Contexts
{
    public class CommonDataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<PID> PIDs { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<SubdivisionDepartment> SubdivisionDepartments { get; set; }
        public DbSet<ValvePID> ValvePIDs { get; set; }

        public CommonDataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new FactoryConfiguration());
            modelBuilder.ApplyConfiguration(new SpecificationConfiguration());
            modelBuilder.ApplyConfiguration(new PIDConfiguration());
            modelBuilder.ApplyConfiguration(new ValvePIDConfigration());
            modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new SubdivisionConfiguration());
            modelBuilder.ApplyConfiguration(new SubdivisionDepartmentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
