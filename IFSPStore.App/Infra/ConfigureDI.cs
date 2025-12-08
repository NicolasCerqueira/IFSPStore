using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.App.Models;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureService()
        {
            var dbConfigFile = "Base/Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                });
            // Repositories
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();

            // Services
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();//se der bosta comente isso
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();

            //Formularios
            services.AddTransient<Login, Login>();
            services.AddTransient<CategoryForm, CategoryForm>();
            services.AddTransient<CityForm, CityForm>();
            services.AddTransient<CustomerForm, CustomerForm>();
            services.AddTransient<ProductForm, ProductForm>();
            services.AddTransient<SaleForm, SaleForm>();
            services.AddTransient<UserForm, UserForm>();

            services.AddSingleton(
                new MapperConfiguration(config => {
                    config.CreateMap<Category, CategoryModel>();
                    config.CreateMap<User, UserModel>();
                    config.CreateMap<Product, ProductModel>()
                        .ForMember(d => d.Category, d => d.MapFrom(x => x.Category!.Name))
                        .ForMember(d => d.IdCategory, d => d.MapFrom(x => x.CategoryId));
                    config.CreateMap<Customer, CustomerModel>();
                    config.CreateMap<City, CityModel>();
                    config.CreateMap<Sale, SaleModel>();

                    config.CreateMap<User, User>();        
                    config.CreateMap<Category, Category>(); 
                    config.CreateMap<Product, Product>();   
                    config.CreateMap<Customer, Customer>(); 
                    config.CreateMap<City, City>();         
                    config.CreateMap<Sale, Sale>();         
                    config.CreateMap<SaleItem, SaleItem>();
                },
                NullLoggerFactory.Instance).CreateMapper());
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
