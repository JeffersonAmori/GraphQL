namespace GraphQL.Domain.Accounts;

public class Query
{
    private List<Account> _accounts = new()
    {
        new Account { Id = new Guid("a6a8861b-8563-425f-9690-345eaa2d8f71"), Name = "Account 1" },
        new Account { Id = new Guid("28b3e5be-df87-40d1-bf39-6a268eccab9f"), Name = "Account 2" },
        new Account { Id = new Guid("98953136-c716-4951-be82-0993e7ab92ee"), Name = "Account 3" },
        new Account { Id = new Guid("b3c3fbc7-d27f-497b-ab62-fd5cf1c6fa71"), Name = "Account 4" },
        new Account { Id = new Guid("3012ef8e-96e8-45ed-ad9c-1ddb6a242231"), Name = "Account 5" }
    };

    public IEnumerable<Account> GetAccounts() => _accounts;
}
