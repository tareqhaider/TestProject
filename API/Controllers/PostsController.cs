using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.DTO;
using API.Data.Interface;
using API.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPost _repository;

        public PostsController(IPost repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PostDto>> GetAllPosts()
        {
            var Items = _repository.GetAllPostsAsync();

            return Ok(Items);
        }

        [HttpGet("{id}", Name = "GetPostById")]
        public ActionResult<PostDto> GetPostById(int id)
        {
            var Item = _repository.GetPostIdAsync(id);
            if (Item != null)
            {
                return Ok(Item);

            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PostDto> CreatePost(PostDto dto)
        {
          

            _repository.CreatePostAsync(Post item);

            _repository.SaveChanges();


            //return Ok(PostDto);
            return CreatedAtRoute(nameof(GetPostById), new { Id = PostDto.Id }, PostDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, PostDto dto)
        {
            var Item = _repository.GetPostIdAsync(id);

            if (Item == null)
            {
                return NotFound();
            }

            //Mapping necessary

            _repository.UpdatePostAsync(Item);

            _repository.SaveChanges();

            return NoContent();

        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdatePost(int id, JsonPatchDocument<Postdto> patchItem)
        {
            var Item = _repository.GetPostIdAsync(id);

            if (Item == null)
            {
                return NotFound();
            }

            

            patchItem.ApplyTo(patchItem, ModelState);

            if (!TryValidateModel(patchItem))
            {
                return ValidationProblem(ModelState);
            }

            //Mapping necessary

            _repository.UpdatePostAsync(patchItem);

            _repository.SaveChanges();

            return NoContent();


        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            var Item =  _repository.GetPostIdAsync(id);

            if (Item == null)
            {
                return NotFound();
            }

            _repository.DeletePostAsync(Item);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
