using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Tools
{
    public static class PredicateBuilder
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            var parameter = Expression.Parameter(typeof(T));

            var visitor = new ReplacingExpressionVisitor();
            visitor.Add(first.Parameters[0], parameter);
            visitor.Add(second.Parameters[0], parameter);

            var combined = visitor.Visit(Expression.AndAlso(first.Body, second.Body));

            return Expression.Lambda<Func<T, bool>>(combined, parameter);
        }

        private class ReplacingExpressionVisitor : ExpressionVisitor
        {
            private readonly Dictionary<Expression, Expression> _replacements = new Dictionary<Expression, Expression>();

            public void Add(Expression original, Expression replacement)
            {
                _replacements[original] = replacement;
            }

            public override Expression Visit(Expression node)
            {
                if (node != null && _replacements.TryGetValue(node, out var replacement))
                {
                    return replacement;
                }

                return base.Visit(node);
            }
        }
    }

}
