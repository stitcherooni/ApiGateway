namespace Models;

public partial class TblEventProduct
{
    public int EventProductId { get; set; }

    public int EventId { get; set; }

    public int ProductId { get; set; }

    public TblEvent Event { get; set; }
    public TblProduct Product { get; set; }
}
