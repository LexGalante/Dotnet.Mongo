using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Mongo.Domain.Entities
{
    public class Member
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Enable { get; set; }
    }
}
