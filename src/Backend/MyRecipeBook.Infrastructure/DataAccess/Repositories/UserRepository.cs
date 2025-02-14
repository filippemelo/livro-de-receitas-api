﻿using Microsoft.EntityFrameworkCore;
using MyRecipeBook.Domain.Entities;
using MyRecipeBook.Domain.Repositories.User;

namespace MyRecipeBook.Infrastructure.DataAccess.Repositories;

public class UserRepository : IUserWriteOnlyRepository, IUserReadOnlyRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext) => _dbContext = dbContext;
    
    public async Task Add(User user) => 
        await _dbContext.Users.AddAsync(user);
    
    public async Task<bool> ExistActiveUserWithEmail(string email) =>
        await _dbContext.Users.AnyAsync(u => u.Email.Equals(email) && u.Active);

}
