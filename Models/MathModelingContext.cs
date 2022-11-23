using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class MathModelingContext : IdentityDbContext<User>
    {
        public MathModelingContext(DbContextOptions<MathModelingContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    Title = "Sample Article",
                    Image = "asffsfssfshoian-26.jpg",
                    Body = "This page shares my best articles to read on topics like health, happiness, creativity, productivity and more. The central question that drives my work is, “How can we live better?” To answer that question, I like to write about science-based ways to solve practical problems.\nYou’ll find interesting articles to read on topics like how to stop procrastinating as well as personal recommendations like my list of the best books to read and my minimalist travel guide.Ready to dive in? You can use the categories below to browse my best articles.",
                    PostDate = DateTime.Now,
                    IsPublished = false
                }
                );
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "Sample Event",
                    IsBigEvent = true,
                    Brief = "This Info Session covers math modeling.",
                    Body = "This Info Session covers fundamental knowledge about math modeling. This Info Session covers fundamental knowledge about math modeling.",
                    Location = "182 Lương Thế Vinh, Thanh Xuân, Hà Nội",
                    DateStart = new DateTime(2021, 7, 23),
                    DateEnd = new DateTime(2021, 7, 25),
                    SignUpLink = "",
                    Image = "asffsfssfshoian-26.jpg"
                }
                );
            modelBuilder.Entity<Faq>().HasData(
                new Faq
                {
                    Id = 1,
                    Question = "Mình là sinh viên năm nhất. Mình có thể tham gia cuộc thi không?",
                    Answer = "Xin lỗi bạn. Đối tượng tham gia là học sinh cấp ba."
                }
                );
            modelBuilder.Entity<Media>().HasData(
                new Media
                {
                    Id = 1,
                    Image = "feffsfsf3434vietnam-travel.jpg",
                    Year = 2018
                }
                );
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    Name = "Nguyễn Ngọc Hải",
                    Role = "Trưởng Ban Tổ Chức",
                    Image = "",
                    Gif = "",
                    FacebookUrl = "https://www.facebook.com/hai.nguyenngoc.129794",
                    InstagramUrl = "",
                    LinkedInUrl = "",
                }
                );
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = 1,
                    FullName = "Levi Nguyen",
                    PhoneNumber = "0379111111",
                    Email = "levinguyen@email.co",
                    Body = "Mong admin facebook rep tin nhắn em sớm ạ. Em cảm ơn.",
                    ReviewStatus = false,
                    PostDate = DateTime.Now
                }
                );
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "Toanmh@1";
            string roleName = "Admin";

            //if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            } 

            //if username doesn't exist, create it and add it to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
