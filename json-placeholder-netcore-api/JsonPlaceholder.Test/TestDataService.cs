using System.Collections.Generic;
using JsonPlaceholder.Api.Models;
using JsonPlaceholder.Api.Services;
using JsonPlaceholder.Api.Services.Impl;
using Xunit;

namespace JsonPlaceholder.Test
{
    public class TestDataService
    {
        //
        //  instance data
        private readonly IDataService _dataService;

        public TestDataService()
        {
            this._dataService = new DataService();
        }

        [Fact]
        public void test_get_posts()
        {
            var posts = _dataService.GetPosts();
            Assert.Equal(100, posts.Count);
        }
    }
}