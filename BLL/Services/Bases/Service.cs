using BLL.DAL;
namespace BLL.Services.Bases;

public abstract class Service
{
    public bool IsSuccessfull { get; set; }
    
    public string Message { get; set; } = string.Empty;

    protected readonly Db _db;
    protected Service(Db db)
    {
        _db = db;
    }

    public Service Success (string message = "")
    {
        IsSuccessfull = true;
        Message = message;
        return this;
    }
    
    public Service Error (string message = "")
    {
        IsSuccessfull = false;
        Message = message;
        return this;
    }

}