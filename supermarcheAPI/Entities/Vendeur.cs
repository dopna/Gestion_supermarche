using System;
using System.Collections.Generic;

namespace supermarcheAPI.Entities;

public partial class Vendeur
{
    public int Vendcode { get; set; }

    public string VendNom { get; set; } = null!;

    public string VendPseudo { get; set; } = null!;

    public string VendmotPass { get; set; } = null!;

    public string? VendPhone { get; set; }

    public string? VendAdresse { get; set; }
}
