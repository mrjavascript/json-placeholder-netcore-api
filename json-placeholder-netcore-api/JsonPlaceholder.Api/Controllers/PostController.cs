using System.Collections.Generic;
using JsonPlaceholder.Api.Models;
using JsonPlaceholder.Api.Services;
using JsonPlaceholder.Api.Services.Impl;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace JsonPlaceholder.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IDataService _dataService;

        public PostController(IDataService dataService)
        {
            _dataService = dataService;
        }
        
        [HttpGet]
        public List<Post> Get()
        {
            return _dataService.GetPosts();
        }
    }
}