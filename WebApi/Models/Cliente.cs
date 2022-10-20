using WebApi.Models.Base;

namespace WebApi.Models;

public class Cliente: Model
{
    public string? Name {get; set; }

    public string? lastname {get; set;}

    public string? streed {get; set;}

    public int? old {get; set;}

    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;

}