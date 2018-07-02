using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookReviewAPI.Entities;
using BookReviewAPI.Models;
using BookReviewAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BookReviewAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            String connectionString = @"Server=(localdb)\mssqllocaldb;Database=BookReviewDB;Trusted_Connection=True;";
            services.AddDbContext<BookReviewContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IBookReviewRepository, BookReviewRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Book Review Api",Version="v1" });
            });
        }

        private static DbContextOptionsBuilder NewMethod(DbContextOptionsBuilder o, string connectionString)
        {
            return o.UseSqlServer(connectionString);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,BookReviewContext bookReviewContext)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "Book Review Api");
            });

            app.UseMvc();

            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<Author, AuthorDTO>().AfterMap((src,dest)=>dest.SetBooks(src.Books));
                x.CreateMap<AuthorDTO, Author>();
                x.CreateMap<Author, AuthorInsertDTO>();
                x.CreateMap<AuthorInsertDTO, Author>();
                x.CreateMap<Author, AuthorDetailDTO>();
                x.CreateMap<Publisher, PublisherDTO>().AfterMap((src,dest)=> dest.SetBooks(src.Books));
                x.CreateMap<PublisherDTO, Publisher>();
                x.CreateMap<Publisher, PublisherDetailDTO>();
                x.CreateMap<PublisherInsertDTO, Publisher>();
                x.CreateMap<Publisher, PublisherInsertDTO>();
                x.CreateMap<User, UserProfileDTO>().AfterMap((src,dest)=>dest.SetReviews(src.Reviews));
                x.CreateMap<UserDTO, User>();
                x.CreateMap<UserProfileDTO, User>();
                x.CreateMap<User, UserProfileDetailDTO>();
                x.CreateMap<Book, BookDTO>().AfterMap((src,dest)=>dest.SetReviews(src.Reviews));
                x.CreateMap<Book, BookDetailDTO>();
                x.CreateMap<BookInsertDTO, Book>();
                x.CreateMap<Book, BookInsertDTO>();
                x.CreateMap<Review, ReviewDTO>().AfterMap((src, dest) => dest.SetCreatedDate(src.CreatedDate));
                x.CreateMap<Review, ReviewDetailDTO>().AfterMap((src,dest)=>dest.SetCreatedDate(src.CreatedDate));
                x.CreateMap<ReviewInsertDTO, Review>();
                x.CreateMap<ReviewUpdateDTO, Review>();
                x.CreateMap<Review, ReviewUpdateDTO>();
            });
        }
    }
}
