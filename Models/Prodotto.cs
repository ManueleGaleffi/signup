using System.ComponentModel.DataAnnotations;

public class Prodotto{
    [Key]
    public int? IdProdotto { get; set; }
    public string? Articolo { get; set; }
    public int Quantita { get; set; }
    
}