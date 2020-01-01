using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using System.Linq;
namespace WebServer.Controllers
{
  [Route("api/posts")]
  public class PostsController : Controller
  {
    [HttpGet]
    public Post[] Get() 
    {
      return Repository.Posts.ToArray();
    }
    [HttpGet("{id}")]
    public Post Get(int id)
    {
      return Repository.getPostByID(id);
    }
    [HttpPost]
    public Post Post([FromBody]Post post)
    {
      return Repository.AddPost(post);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Post post)
    {
      Repository.UpdatePost(id, post);
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Repository.DeletePost(id);
    }
  }
}