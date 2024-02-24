using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Prenotazione{
    [Key]
    public int IdPrenotazione { get; set; }

    [Required,StringLength(10), Display(Name="Nome dell'utente")]
    public string Nome { get; set; }
    public string? Cognome { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public DateOnly DataDiNascita { get; set; }
    public string? Sesso { get; set; }
    public string? Ruolo { get; set; }

    
}