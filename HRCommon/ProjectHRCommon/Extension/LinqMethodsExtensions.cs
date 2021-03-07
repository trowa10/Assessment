﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectHRCommon.Extension
{
    public static class LinqMethodsExtensions
    {
        public static IEnumerable<TA> Except<TA, TB, TK>(
        this IEnumerable<TA> a,
        IEnumerable<TB> b,
        Func<TA, TK> selectKeyA,
        Func<TB, TK> selectKeyB,
        IEqualityComparer<TK> comparer = null)
        {
            return a.Where(aItem => !b.Select(bItem => selectKeyB(bItem)).Contains(selectKeyA(aItem), comparer));
        }
    }
}
