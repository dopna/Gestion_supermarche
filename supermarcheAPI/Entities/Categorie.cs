using System;
using System.Collections.Generic;

namespace supermarcheAPI.Entities;

public partial class Categorie
{
    public int Catcode { get; set; }

    public string CatNom { get; set; } = null!;

    public string? CatRemarque { get; set; }

    public virtual ICollection<Article> Articles { get; } = new List<Article>();
}
