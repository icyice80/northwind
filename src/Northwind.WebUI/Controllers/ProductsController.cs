﻿using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.Application.Products.Queries;
using Northwind.Persistence;


namespace Northwind.WebUI.Controllers
{
    public class ProductsController : ControllerBase
    {

        private readonly IMediator _mediator;

        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            this._mediator = mediator;
            this._logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ProductsListResult), (int)HttpStatusCode.OK)]
        public Task<ProductsListResult> GetAll()
        {
            return this._mediator.Send(new GetAllProductsQuery());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok("1");
        }

    }
}