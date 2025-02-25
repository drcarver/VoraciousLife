﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Voracious.Database;

#nullable disable

namespace Voracious.Database.Migrations
{
    [DbContext(typeof(CatalogDataContext))]
    partial class CatalogDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CreatorResource", b =>
                {
                    b.Property<string>("CreatorsAbout")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourcesAbout")
                        .HasColumnType("TEXT");

                    b.HasKey("CreatorsAbout", "ResourcesAbout");

                    b.HasIndex("ResourcesAbout");

                    b.ToTable("CreatorResource");
                });

            modelBuilder.Entity("Voracious.RDF.Model.Creator", b =>
                {
                    b.Property<string>("About")
                        .HasColumnType("TEXT")
                        .HasComment("An unambiguous reference to the resource within a given context. Recommended practice is to identify the resource by means of a string conforming to an identification system");

                    b.Property<string>("Aliases")
                        .HasColumnType("TEXT")
                        .HasComment("Alias for the contributor");

                    b.Property<string>("AlternateScript")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BirthDate")
                        .HasColumnType("INTEGER")
                        .HasComment("The year of birth of the contributor");

                    b.Property<int?>("DeathDate")
                        .HasColumnType("INTEGER")
                        .HasComment("The year of death of the contributor");

                    b.Property<string>("FileAs")
                        .HasColumnType("TEXT")
                        .HasComment("The name the contributor should be filed nder");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasComment("The name of the contributor");

                    b.Property<int?>("Role")
                        .HasColumnType("INTEGER")
                        .HasComment("The nature or genre of the content of the resource. Type includes terms describing general categories, functions, genres, or aggregation levels for content.");

                    b.Property<string>("Webpage")
                        .HasColumnType("TEXT")
                        .HasComment("The web page for the contributor");

                    b.HasKey("About");

                    b.ToTable("Creators", (string)null);
                });

            modelBuilder.Entity("Voracious.RDF.Model.FileFormat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasComment("The key of the file.");

                    b.Property<int>("CurrentFileStatus")
                        .HasColumnType("INTEGER")
                        .HasComment("Current file status.");

                    b.Property<DateTime>("DownloadDate")
                        .HasColumnType("TEXT")
                        .HasComment("The download date");

                    b.Property<int>("Extent")
                        .HasColumnType("INTEGER")
                        .HasComment("The file extent.");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("The name of the file with this format.");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("The type of the file with this format.");

                    b.Property<DateTime?>("LastModified")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("The date and time the file was created.");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("The file Mime Type.");

                    b.Property<string>("ResourceAbout")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FileName");

                    b.HasIndex("ResourceAbout");

                    b.ToTable("FileFormats", (string)null);
                });

            modelBuilder.Entity("Voracious.RDF.Model.Resource", b =>
                {
                    b.Property<string>("About")
                        .HasColumnType("TEXT")
                        .HasComment("An unambiguous reference to the resource within a given context. Recommended practice is to identify the resource by means of a string conforming to an identification system");

                    b.Property<string>("BookSeries")
                        .HasColumnType("TEXT")
                        .HasComment("Marc440 - Series statement consisting of a series title alone");

                    b.Property<int?>("BookType")
                        .HasColumnType("INTEGER")
                        .HasComment("Most are Text. Human genome project e.g 3501 is Dataset.");

                    b.Property<string>("CreationProductionCreditsNote")
                        .HasColumnType("TEXT")
                        .HasComment("Credits for persons or organizations, other than members of the cast, who have participated in the creation and/or production of the work. The introductory term Credits: is usually generated as a display constant.");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasComment("An account of the resource. Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource.");

                    b.Property<int?>("Downloads")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileAs")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("Title to file the resource under");

                    b.Property<string>("Imprint")
                        .HasColumnType("TEXT")
                        .HasComment("Information relating to the publication, printing, distribution, issue, release, or production of a work.");

                    b.Property<DateTime>("Issued")
                        .HasColumnType("TEXT")
                        .HasComment("A related resource of which the described resource is a version, edition, or adaptation. Changes in version imply substantive changes in content rather than differences in format. dcterms:issued Date of formal issuance (e.g., publication) of the resource.");

                    b.Property<string>("LCC")
                        .HasColumnType("TEXT")
                        .HasComment("The Library of Congress call number scheme is a standard used in academic libraries nationwide.");

                    b.Property<string>("LCCN")
                        .HasColumnType("TEXT")
                        .HasComment("Unique number assigned to a record by the Library of Congress (LC) or a cooperative cataloging partner contributing authority records to the Name Authority Cooperative Program (NACO) database. The field is also assigned to records created by LC for the Library of Congress Subject Headings (LCSH).");

                    b.Property<string>("LCSH")
                        .HasColumnType("TEXT")
                        .HasComment("The set of labeled concepts specified by the Library of Congress Subject Headings.");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT")
                        .HasComment("A language of the resource.");

                    b.Property<string>("License")
                        .HasColumnType("TEXT");

                    b.Property<string>("PGEditionInfo")
                        .HasColumnType("TEXT")
                        .HasComment("PG Edition Info.");

                    b.Property<string>("PGProducedBy")
                        .HasColumnType("TEXT")
                        .HasComment("PG Edition Info.");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT")
                        .HasComment("Book Source - usually Gutenberg");

                    b.Property<string>("Rights")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sources")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("A name given to the resource.");

                    b.Property<string>("TitleAlternative")
                        .HasColumnType("TEXT")
                        .HasComment("An alternative name for the resource.");

                    b.HasKey("About");

                    b.HasIndex("FileAs");

                    b.ToTable("Resources", (string)null);
                });

            modelBuilder.Entity("CreatorResource", b =>
                {
                    b.HasOne("Voracious.RDF.Model.Creator", null)
                        .WithMany()
                        .HasForeignKey("CreatorsAbout")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voracious.RDF.Model.Resource", null)
                        .WithMany()
                        .HasForeignKey("ResourcesAbout")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voracious.RDF.Model.FileFormat", b =>
                {
                    b.HasOne("Voracious.RDF.Model.Resource", "Resource")
                        .WithMany("FileFormats")
                        .HasForeignKey("ResourceAbout")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Voracious.RDF.Model.Resource", b =>
                {
                    b.Navigation("FileFormats");
                });
#pragma warning restore 612, 618
        }
    }
}
