using Lecture.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture
{
    public class PostController : Controller
    {
        private MyContext DbContext;
        public PostController(MyContext context){
            DbContext=context;
        }

        [HttpGet("success")]
        public IActionResult success(){
            if(HttpContext.Session.GetInt32("userId")==null){
                return RedirectToAction("Index","Home");
            }
            List<Post> allPosts = DbContext.Posts.Include(userposted=>userposted.UserPosted).ToList();
            ViewBag.allPosts = allPosts;
            return View();
        }

        [HttpPost("Post/new")]
        public IActionResult newPost(Post newPost){
            if(HttpContext.Session.GetInt32("userId")==null){
                return RedirectToAction("Index","Home");
            }
            if(ModelState.IsValid){
                User user = DbContext.Users.FirstOrDefault(userfromdb =>userfromdb.UserId==HttpContext.Session.GetInt32("userId"));
                newPost.UserPosted = user;
                DbContext.Add(newPost);
                DbContext.SaveChanges();
                return RedirectToAction("success");
            }
            return View("success");
        }
        [HttpPost("Post/delete/{pId}")]
        public IActionResult delete(int pId){
            if(HttpContext.Session.GetInt32("userId")==null){
                return RedirectToAction("Index","Home");
            }
            Post postToDelete = DbContext.Posts.FirstOrDefault(post => post.PostId==pId);
            DbContext.Remove(postToDelete);
            DbContext.SaveChanges();
            return RedirectToAction("success");
        }
        [HttpGet("Post/edit/{pId}")]
        public IActionResult edit(int pId){
            Post postToEdit = DbContext.Posts.FirstOrDefault(post => post.PostId==pId);
            return View(postToEdit);
        }
        [HttpPost("Post/edit/{pId}")]
        public IActionResult editPost(int pId, Post postFromForm){
            if(HttpContext.Session.GetInt32("userId")==null){
                return RedirectToAction("Index","Home");
            }
            Post postToEdit = DbContext.Posts.FirstOrDefault(post => post.PostId==pId);
            if(ModelState.IsValid){
                postToEdit.Content = postFromForm.Content;
                postToEdit.UpdatedAt = DateTime.Now;
                DbContext.SaveChanges();
                return RedirectToAction("success");
            }
            return View("edit", postToEdit);
        }
    }
}