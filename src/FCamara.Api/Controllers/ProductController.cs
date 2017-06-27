using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FCamaraProject.Domain.Repositories;

namespace FCamaraProject.Api.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("v1/get/products")]
        //[AllowAnonymous]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
    }
}
