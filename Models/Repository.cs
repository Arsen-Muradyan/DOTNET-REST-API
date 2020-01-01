using System.Collections.Generic;
using System.Linq;

namespace WebServer.Models
{
  public class Repository 
  {
    private static int counter;
    public static IList<Post> Posts{get;} = new List<Post>(); 
    public static Post getPostByID(int id) 
    {
      var target = Posts.SingleOrDefault(p => p.ID == id);
      return target;
    }
    public static Post AddPost(Post post) 
    {
      post.ID = counter++;
      Posts.Add(post);
      return post;
    } 
    public static void UpdatePost(int id, Post post) 
    {
      var target = Posts.SingleOrDefault(p => p.ID == id);
      if (target != null) {
        Posts.Remove(target);
        post.ID = id;
        Posts.Add(post);
      }
    }
    public static void DeletePost(int id) 
    {
      var target = Posts.SingleOrDefault(p => p.ID == id);
      if (target != null) Posts.Remove(target);
    }
  }
}