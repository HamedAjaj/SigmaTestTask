﻿using Microsoft.EntityFrameworkCore;
using SigmaTestTask.Domain;
using SigmaTestTask.Repository.Data;

namespace SigmaTestTask.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly CandidateContext _context;
        public CandidateRepository(CandidateContext context)
        {
            _context = context;
        }

        //public async Task AddCandidateAsync(Candidate contact)=>
        //    await _context.AddAsync(contact);
        
        public async Task<Candidate> GetCandidateByEmailAsync(string email) { 
           return await _context.Candidates.AsNoTracking().
                Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefaultAsync();
        }

        public void UpdateCandidate(Candidate contact) => _context.Candidates.Update(contact);

        public async Task AddCandidateAsync(Candidate contact) =>await _context.Candidates.AddAsync(contact);
    
        public async Task Complete()
        {
          await  _context.SaveChangesAsync();
        }

       
    }
}
