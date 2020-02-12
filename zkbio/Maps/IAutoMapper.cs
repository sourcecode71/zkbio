﻿using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace zkbio.Maps
{
    public interface IAutoMapper
    {
        IConfigurationProvider Configuration { get; }
        T Map<T>(object objectToMap);
        void Map<TSource, TDestination>(TSource source, TDestination destination);
        TResult[] Map<TSource, TResult>(IEnumerable<TSource> sourceQuery);
        IQueryable<TResult> Map<TSource, TResult>(IQueryable<TSource> sourceQuery);
    }
}
