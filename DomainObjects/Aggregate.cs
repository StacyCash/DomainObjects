﻿using System;

namespace DomainDrivenDesign.DomainObjects
{

    public class Aggregate<T, TKey> : Entity<T, TKey> where T : Aggregate<T, TKey>
        where TKey : PrimaryKey<T>
    {
        protected Aggregate(TKey id) : base(id)
        {
        }
    }

    public class Aggregate<T> : Entity<T> where T : Aggregate<T>
    {
        protected Aggregate(Id<T> id) : base(id)
        {
        }
    }
}
