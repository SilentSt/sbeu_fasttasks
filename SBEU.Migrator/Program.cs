﻿// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

using SBEU.Tasklet.DataLayer.DataBase;
using SBEU.Tasklet.DataLayer.DataBase.Entities;
using SBEU.Tasklet.Models.Enums;

var factory = new DbContextOptionsBuilder<ApiDbContext>();
factory.UseNpgsql("User ID = postgres; Password = 1namQfeg1; Host = localhost; Port = 5432; Database = sbeu_tasklet;");
using var context = new ApiDbContext(factory.Options);
    
var users = context.Users.ToList();
var tables = context.XTables.ToList();

var tasks = Enumerable.Range(0, 400).Select(x =>
{
    return new XTask
    {
        Author = users[new Random().Next(0, users.Count)],
        Description = $"description {x}",
        Executor = users[new Random().Next(0, users.Count)],
        Duration = TimeSpan.FromHours(new Random().Next(0, 300)),
        Hidden = false,
        Id = Guid.NewGuid().ToString(),
        Price = (uint)new Random().Next(0, 30),
        StartTime = DateTime.Now.AddMinutes(new Random().Next(-60, 60)),
        Status = (TaskProgress)new Random().Next(0, 5),
        Title = $"title {x}",
        Table = tables[new Random().Next(0, tables.Count)],
        Links = new List<string>()        
    };
});

context.XTasks.AddRange(tasks);

    
context.SaveChanges();

