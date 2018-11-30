namespace TruSite.Api.Enumerations
{
    public enum PurchaseOrderState
    {
        Created = 0,
        Ordered,
        Partial,
        Missing,
        Damaged,
        Received,
        MissingResolved,
        DamagedResolved
    }
}