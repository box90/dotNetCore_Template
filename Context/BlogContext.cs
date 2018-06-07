using Microsoft.EntityFrameworkCore;
using dotNetCore_Template.Models;

namespace dotNetCore_Template.Context {
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) 
        {}

        public DbSet<Post> Posts { get; set; }
    }
}