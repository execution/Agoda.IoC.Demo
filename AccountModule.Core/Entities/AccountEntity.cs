using System;

namespace AccountModule.Core.Entities
{
    public record AccountEntity(Guid AccountId, string FirstName, string LastName);
}
