// <copyright file="CustomersController.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineSales.Data;
using OnlineSales.DTOs;
using OnlineSales.Entities;

namespace OnlineSales.Controllers;

[Route("api/[controller]")]
public class CustomersController : BaseController<Customer, CustomerCreateDto, CustomerUpdateDto>
{
    public CustomersController(ApiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }
}