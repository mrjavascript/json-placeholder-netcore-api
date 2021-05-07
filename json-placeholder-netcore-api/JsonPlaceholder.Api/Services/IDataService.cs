using System.Collections.Generic;
using JsonPlaceholder.Api.Models;

namespace JsonPlaceholder.Api.Services
{
    public interface IDataService
    {
        List<Post> GetPosts();
    }
}