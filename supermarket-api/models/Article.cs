﻿using System;
using System.Net;

public class Article
{
    

    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }
    public string Categorie { get; set; }
    public int Stock { get; set; }
    public DateTime DateExpiration { get; set; }
}