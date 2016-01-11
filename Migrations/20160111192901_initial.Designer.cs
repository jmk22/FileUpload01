using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using FileUpload01.Models;

namespace FileUpload01.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160111192901_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FileUpload01.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "Uploads");
                });
        }
    }
}
