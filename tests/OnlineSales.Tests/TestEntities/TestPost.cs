﻿// <copyright file="TestPost.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using Microsoft.AspNetCore.Mvc.Formatters;
using OnlineSales.DTOs;

namespace OnlineSales.Tests.TestEntities;

public class TestPostCreateDto : PostCreateDto
{
    public TestPostCreateDto()
    {
        Slug = "Test Slug " + new Random().Next(0, 50000).ToString() + " - " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
        Template = "Test Template";
        Author = "Peter Liapin";
        Title = "Test Title (via test suit)";
        Description = "This is a sample test description";
        Content = "This is a sample Content";
        CoverImageUrl = "This is a sample Cover";
        CoverImageAlt = "This is a sample Cover alt";
        Language = "en-US";
        Categories = "This is Categories";
        Tags = "Sample Tags";
        AllowComments = true;
    }
}

public class TestPostUpdateDto : PostUpdateDto
{
    public TestPostUpdateDto()
    {
        Slug = "Test Slug " + new Random().Next(0, 50000).ToString() + " - " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
        Template = "Test Template Update";
        Author = "Peter Liapin Update";
        Title = "Test Title (via test suit) Update";
        Description = "This is a sample test description Update";
        Content = "This is a sample Content Update";
        CoverImageUrl = "This is a sample Cover Update";
        CoverImageAlt = "This is a sample Cover alt Update";
        Language = "ru-RU";
        Categories = "This is Categories Update";
        Tags = "Sample Tags Update";
        AllowComments = false;
    }
}