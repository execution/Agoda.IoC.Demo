using System;

namespace ContactModule.Core.Entities
{
    public record ContactEntity(Guid ContactId, string FirstName, string LastName,string PhoneNumber);
}
