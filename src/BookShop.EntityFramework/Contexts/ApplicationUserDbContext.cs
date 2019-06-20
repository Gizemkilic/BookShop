using BookShop.Core.Book;
using BookShop.Core.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.EntityFramework.Contexts
{
    public class ApplicationUserDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserDbContext(DbContextOptions options) : base(options)
        {

        }

             public DbSet<BookList> BookLists { get; set; }
             public DbSet<BookListItem> BookListItems { get; set; }
             public DbSet<Books> Books { get; set; }

    }
}
