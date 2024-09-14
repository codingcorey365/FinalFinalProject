namespace FinalFinalProject.Models;

public class Reviews
{
    public int ReviewId { get; set; }
    public int ProductId { get; set; }

    public string Reviewer { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }
}