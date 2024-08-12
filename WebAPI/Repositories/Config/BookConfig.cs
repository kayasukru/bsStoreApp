using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Repositories.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Hacıvat", Price = 100 },
                new Book { Id = 2, Title = "Karagöz", Price = 200 },
                new Book { Id = 3, Title = "Hacıvat ve Karagöz", Price = 300 }
                );
        }
    }
}
