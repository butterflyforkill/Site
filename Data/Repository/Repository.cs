using Fin.Models;
using Fin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Data.FileManager.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;

        }

        //post
        public void AddPost(Post post)
        {

            _ctx.Posts.Add(post);
        }

        public List<Post> GetAllPosts()
        {

            return _ctx.Posts
                .ToList();
        }



        public IndexViewModel GetAllPosts(int pageNumber, string category)

        {
            Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(category.ToLower()); };

            
            int pageSize = 2;
            int skipAmount = pageSize * (pageNumber - 1);

            var query = _ctx.Posts.AsQueryable();
                


            if (!String.IsNullOrEmpty(category))
                query = query
                    .Where(x => InCategory(x));

            int postsCount = query.Count();

            return new IndexViewModel
            {

                PageNumber = pageNumber,
                PageCount =(int)Math.Ceiling((double)postsCount / pageSize),
                NextPage = postsCount > skipAmount + pageSize,
                Category = category,
                Posts = query
                    .Skip(skipAmount)
                    .Take(pageSize)
                    .ToList()
            };
        }
        public Post GetPost(int id)
        {
            return _ctx.Posts.FirstOrDefault(p => p.Id == id);
        }


        public void RemovePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
        }


        public void UpdatePost(Post post)
        {

            _ctx.Posts.Update(post);
        }

        public async Task<bool> SaveChangesAsync()
        {

            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }


        //TalkForm
        public TalkForm GetTalkForm(int id)
        {
            return _ctx.TalkForms.FirstOrDefault(p => p.Id == id);
        }

        public List<TalkForm> GetAllTalkForms()
        {
            return _ctx.TalkForms.ToList();
        }

        public void RemoveTalkForm(int id)
        {
            _ctx.TalkForms.Remove(GetTalkForm(id));
        }

        public void UpdateTalkForm(TalkForm talkForm)
        {
            _ctx.TalkForms.Update(talkForm);
        }

        public void AddTalkForm(TalkForm talkForm)
        {
            _ctx.TalkForms.Add(talkForm);
        }




        //Contact

        public Contact GetContact(int id)
        {
            return _ctx.Contacts.FirstOrDefault(p => p.Id == id);
        }

        public List<Contact> GetAllContacts()
        {
            return _ctx.Contacts.ToList();
        }

        public void RemoveContact(int id)
        {
            _ctx.Contacts.Remove(GetContact(id));
        }

        public void UpdateContact(Contact contact)
        {
            _ctx.Contacts.Update(contact);
        }

        public void AddContact(Contact contact)
        {
            _ctx.Contacts.Add(contact);
        }


    }
}
