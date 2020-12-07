using Fin.Models;
using Fin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Data.FileManager.Repository
{
    public interface IRepository
    {
        //Post
        Post GetPost(int id);
        List<Post> GetAllPosts();
        IndexViewModel GetAllPosts(int pageNumber, string category);
        void RemovePost(int id);
        void UpdatePost(Post post);
        void AddPost(Post post);

        //TalkForm
        TalkForm GetTalkForm(int id);
        List<TalkForm> GetAllTalkForms();
        void RemoveTalkForm(int id);
        void UpdateTalkForm(TalkForm talkForm);
        void AddTalkForm(TalkForm talkForm);

        //Contact
        Contact GetContact(int id);
        List<Contact> GetAllContacts();
        void RemoveContact(int id);
        void UpdateContact(Contact contact);
        void AddContact(Contact contact);

        //SaveChanges
        Task<bool> SaveChangesAsync();
    }
}
