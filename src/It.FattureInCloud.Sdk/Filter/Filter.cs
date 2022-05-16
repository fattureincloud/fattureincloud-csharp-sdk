namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    ///     Filter
    /// </summary>
    public class Filter
    {
        /// <summary>
        ///     Initializes a new instance of the Filter class.
        /// </summary>
        public Filter()
        {
            Expression = null;
        }

        /// <summary>
        ///     Initializes a new instance of the Filter class.
        /// </summary>
        /// <param name="expression">Filter expression</param>
        public Filter(Expression expression)
        {
            Expression = expression;
        }

        /// <summary>
        ///     Gets or Sets Expression
        /// </summary>
        public Expression Expression { get; set; }

        /// <summary>
        ///     Initializes the filter with a condition
        /// </summary>
        /// <param name="field">Condition field</param>
        /// <param name="op">Condition op</param>
        /// <param name="value">Condition value</param>
        /// <returns>(Filter)</returns>
        public Filter Where<T>(string field, Operator op, T value)
        {
            Expression = new Condition<T>(field, op, value);
            return this;
        }

        /// <summary>
        ///     Initializes the filter with an expression
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>(Filter)</returns>
        public Filter WhereExpression(Expression expression)
        {
            Expression = expression;
            return this;
        }

        /// <summary>
        ///     Adds an AND condition to the filter
        /// </summary>
        /// <param name="field">Condition field</param>
        /// <param name="op">Condition op</param>
        /// <param name="value">Condition value</param>
        /// <returns>(Filter)</returns>
        public Filter And<T>(string field, Operator op, T value)
        {
            if (Expression == null) throw new Exception("Cannot create a conjunction for an empty expression.");
            var left = Expression;
            Expression right = new Condition<T>(field, op, value);
            Expression = new Conjunction(left, right);
            return this;
        }

        /// <summary>
        ///     Adds an AND expression to the filter
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>(Filter)</returns>
        public Filter AndExpression(Expression expression)
        {
            if (Expression == null || expression == null)
                throw new Exception("Cannot create a conjunction for an empty expression.");
            var left = Expression;
            Expression = new Conjunction(left, expression);
            return this;
        }

        /// <summary>
        ///     Adds an AND filter to the filter
        /// </summary>
        /// <param name="filter">filter</param>
        /// <returns>(Filter)</returns>
        public Filter AndFilter(Filter filter)
        {
            if (Expression == null || filter == null || filter.Expression == null)
                throw new Exception("Cannot create a conjunction for an empty expression.");
            var left = Expression;
            Expression = new Conjunction(left, filter.Expression);
            return this;
        }

        /// <summary>
        ///     Adds an OR condition to the filter
        /// </summary>
        /// <param name="field">Condition field</param>
        /// <param name="op">Condition op</param>
        /// <param name="value">Condition value</param>
        /// <returns>(Filter)</returns>
        public Filter Or<T>(string field, Operator op, T value)
        {
            if (Expression == null) throw new Exception("Cannot create a disjunction for an empty expression.");
            var left = Expression;
            Expression right = new Condition<T>(field, op, value);
            Expression = new Disjunction(left, right);
            return this;
        }

        /// <summary>
        ///     Adds an OR expression to the filter
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>(Filter)</returns>
        public Filter OrExpression(Expression expression)
        {
            if (Expression == null || expression == null)
                throw new Exception("Cannot create a disjunction for an empty expression.");
            var left = Expression;
            Expression = new Disjunction(left, expression);
            return this;
        }

        /// <summary>
        ///     Adds an OR filter to the filter
        /// </summary>
        /// <param name="filter">filter</param>
        /// <returns>(Filter)</returns>
        public Filter OrFilter(Filter filter)
        {
            if (Expression == null || filter == null || filter.Expression == null)
                throw new Exception("Cannot create a disjunction for an empty expression.");
            var left = Expression;
            Expression = new Disjunction(left, filter.Expression);
            return this;
        }

        /// <summary>
        ///     Builds the query from the filter
        /// </summary>
        /// <returns>(string)</returns>
        public string BuildQuery()
        {
            if (Expression == null)
                return "";
            return Expression.BuildQuery();
        }

        /// <summary>
        ///     Builds the url encoded query from the filter
        /// </summary>
        /// <returns>(string)</returns>
        public string BuildUrlEncodedQuery()
        {
            return System.Web.HttpUtility.UrlEncode(BuildQuery());
        }

        /// <summary>
        ///     Builds the query from the filter
        /// </summary>
        /// <returns>(string)</returns>
        public override string ToString()
        {
            return BuildQuery();
        }

        /// <summary>
        ///     Override of the Equals method
        /// </summary>
        /// <returns>(boolean)</returns>
        public override bool Equals(object o)
        {
            if (o is Filter)
                return Equals(o as Filter);
            return false;
        }

        /// <summary>
        ///     Condition specific Equals method
        /// </summary>
        /// <returns>(boolean)</returns>
        public bool Equals(Filter f)
        {
            return f != null &&
                   Expression.Equals(f.Expression);
        }

        /// <summary>
        ///     Override of the GetHashCode method
        /// </summary>
        /// <returns>(int)</returns>
        public override int GetHashCode()
        {
            return Expression.GetHashCode();
        }
    }
}