namespace PessoasApi.Models;

public class PagedList<T>
{
    public List<T> Items { get; set; }
    public int TotalRecords { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);
    public int PageSize { get; set; }
    public int PageNumber { get; set; }

    public PagedList()
    {
        Items = new List<T>();
    }

    public PagedList(List<T> items, int totalRecords, int pageNumber, int pageSize)
    {
        Items = items;
        TotalRecords = totalRecords;
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}
