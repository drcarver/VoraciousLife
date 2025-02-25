﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Voracious.RDF.Model;

namespace Voracious.Database.Configuration;

public class FileFormatEntityTypeConfiguration : IEntityTypeConfiguration<FileFormat>
{
    public void Configure(EntityTypeBuilder<FileFormat> builder)
    {
        builder
            .HasKey(e => e.Id);

        builder
            .HasIndex(e => e.FileName);

        builder
            .Property(f => f.Id)
            .IsRequired()
            .HasComment("The key of the file.");

        builder
            .ToTable("FileFormats");

        builder
            .Property(f => f.FileName)
            .IsRequired()
            .HasComment("The name of the file with this format.");

        builder
            .Property(f => f.FileType)
            .IsRequired()
            .HasComment("The type of the file with this format.");

        builder
            .Property(f => f.CurrentFileStatus)
            .IsRequired()
            .HasComment("Current file status.");

        builder
            .Property(f => f.DownloadDate)
            .HasComment("The download date");

        builder
            .Property(f => f.FileType)
            .IsRequired()
            .HasComment("The type of the file with this format.");

        builder
            .Property(f => f.LastModified)
            .IsRequired()
            .HasComment("The date and time the file was created.");

        builder
            .Property(f => f.Extent)
            .IsRequired()
            .HasComment("The file extent.");

        builder
            .Property(f => f.MimeType)
            .IsRequired()
            .HasComment("The file Mime Type.");
    }
}