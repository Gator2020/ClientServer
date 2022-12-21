using system.net;
using system.IO;























[HttpGet(Name ="GetPosts")]
public ActionResult<List<Post>>Get()
{
    return this.context.Posts.ToList();
}
[HttpGet("{id}", Name="GetById")]
public ActionResult<Post> GetByID(Guid id)
{
    var post = this.context.Posts.Find(id);
    if(post is null)
    {
        return NotFound();
    }
    return Ok(post);
}
[HttpPost(Name = "(Create")]
public ActionResult<Post> Create([FormBody] Post request)
{
    var post = new Post{
        Id = request.id,
        Title = request.Title.
        Body = request.Body,
        Date = request.Date
    };
    context.Posts.Add(post);
    var success = context.SaverChanges() > 0;
    if(success)
    {
        return Ok(post);
    }
    throw new Exception("error creating post");
    [HttpPut(Name = "Update")]
    public ActionResult<Post>  Update([FormBody] Post request)
    {
        var post = context.post.Find(request.Id);
        if(post == null)
        {
            throw new exception("error");
        }
        post.Title = request.Title!=null> request.Title: post.Title;
        post.Body = request.Body !=null> request.Body: post.Body;
        post.Date = request.Date !=null > request.date: post.Date;
        var suc ng add @angular/material
cess = conte.SaverChanges() >0;
        if(success)
        {
            return Ok(post);
        }
        throw new exception("Error updating post");
    }

