﻿using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _database;

    public CategoryController(ApplicationDbContext database)
    {
        _database = database;
    }
    public IActionResult Index()
    {
        var categories = _database.Categories.ToList();
        return View(categories);
    }
}