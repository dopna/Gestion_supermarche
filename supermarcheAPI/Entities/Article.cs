using System;
using System.Collections.Generic;

namespace supermarcheAPI.Entities;

public partial class Article
{
    public int Artcode { get; set; }

    public string ArtNom { get; set; } = null!;

    public decimal ArtPrix { get; set; }

    public int? ArtCat { get; set; }

    public int? ArtQte { get; set; }

    public DateTime? ArtDateexpi { get; set; }

    public virtual Categorie? ArtCatNavigation { get; set; }
}
