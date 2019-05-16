﻿using System.Collections.Generic;

namespace Sixeyed.Extensions.ExtendingInterfaces.Implementation
{
    public abstract class SqlDataSource
    {
        public string Name = "SQL";
    }
    public class SqlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code="xyz", Description="from SQL"},
                new ReferenceDataItem { Code="xyz", Description="from SQL 2"}
            };
        }
    }
}
