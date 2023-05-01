﻿// <copyright file="CommentDtos.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;
using OnlineSales.DataAnnotations;
using OnlineSales.Entities;

namespace OnlineSales.DTOs;

public class CommentCreateDto
{
    private string authorEmail = string.Empty;

    [Required]
    [EmailAddress]
    public string AuthorEmail
    {
        get
        {
            return authorEmail;
        }

        set
        {
            authorEmail = value.ToLower();
        }
    }

    public string AuthorName { get; set; } = string.Empty;

    [Required]
    public string Body { get; set; } = string.Empty;

    [Required]
    public int ContentId { get; set; }

    public int? ContactId { get; set; }

    public int? ParentId { get; set; }

    [Optional]
    public string? Source { get; set; }
}

public class CommentUpdateDto
{
    [Required]
    public string Body { get; set; } = string.Empty;
}

public class CommentDetailsDto : CommentCreateDto
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

public class CommentImportDto : BaseImportDto
{
    private string authorEmail = string.Empty;

    [Optional]
    public int? ContactId { get; set; }

    public string AuthorName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [SurrogateForeignKey(typeof(Contact), "Email", "ContactId")]
    public string AuthorEmail
    {
        get
        {
            return authorEmail;
        }

        set
        {
            authorEmail = value.ToLower();
        }
    }

    [Required]
    public string Body { get; set; } = string.Empty;

    [Optional]
    public CommentStatus? Status { get; set; }

    [Optional]
    public string? Language { get; set; }

    [Optional]
    public int? ContentId { get; set; }

    [Optional]
    [SurrogateForeignKey(typeof(Content), "Slug", "ContentId")]
    public string? ContentSlug { get; set; }

    [Optional]
    public int? ParentId { get; set; }

    [Optional]
    public string? Key { get; set; }

    [Optional]
    [SurrogateForeignKey(typeof(Comment), "Key", "ParentId")]
    public string? ParentKey { get; set; }
}