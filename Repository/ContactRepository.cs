﻿using Microsoft.EntityFrameworkCore;
using SigmaTestTask.Domain;
using SigmaTestTask.Repository.Data;

namespace SigmaTestTask.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly CandidateContext _context;
        public ContactRepository(CandidateContext context)
        {
            _context = context;
        }

        //public async Task AddCandidateAsync(Contact contact)=>
        //    await _context.AddAsync(contact);
        
        public async Task<Contact> GetCandidateByEmailAsync(string email) { 
           return await _context.Contacts.AsNoTracking().
                Where(x => x.Email == email.ToLower()).FirstOrDefaultAsync();
        }

        public void UpdateCandidate(Contact contact) => _context.Contacts.Update(contact);

        public async Task AddCandidateAsync(Contact contact) =>await _context.Contacts.AddAsync(contact);
    
        public async Task Complete()
        {
          await  _context.SaveChangesAsync();
        }

       
    }
}
