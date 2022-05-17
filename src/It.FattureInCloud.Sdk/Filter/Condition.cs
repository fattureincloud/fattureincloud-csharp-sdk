namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    ///     Condition
    /// </summary>
    public class Condition<T> : Expression
    {
        /// <summary>
        ///     Initializes a new instance of the Condition class.
        /// </summary>
        /// <param name="field">Condition field</param>
        /// <param name="op">Condition operator</param>
        /// <param name="value">Condition value</param>
        public Condition(string field, Operator op, T value)
        {
            Field = field;
            Op = op;
            Value = value;
        }

        /// <summary>
        ///     Gets or Sets Field
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        ///     Gets or Sets Op
        /// </summary>
        public Operator Op { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        ///     Builds the query from the condition
        /// </summary>
        /// <returns>(string)</returns>
        public string BuildQuery()
        {
            if (Value == null)
                return string.Format("{0} {1} {2}", Field, OperatorExtensions.GetOperatorValue(Op), "null");
            if (Value is bool)
                return string.Format("{0} {1} {2}", Field, OperatorExtensions.GetOperatorValue(Op),
                    Value.ToString().ToLower());
            if (Value is string)
                return string.Format("{0} {1} {2}", Field, OperatorExtensions.GetOperatorValue(Op), "'" + Value + "'");
            return string.Format("{0} {1} {2}", Field, OperatorExtensions.GetOperatorValue(Op), Value);
        }

        /// <summary>
        ///     Builds the query from the condition
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
            if (o is Condition<T>)
                return Equals(o as Condition<T>);
            return false;
        }

        /// <summary>
        ///     Condition specific Equals method
        /// </summary>
        /// <returns>(boolean)</returns>
        public bool Equals(Condition<T> c)
        {
            return c != null &&
                   Field.Equals(c.Field) &&
                   Op.Equals(c.Op) &&
                   Value.Equals(c.Value);
        }

        /// <summary>
        ///     Override of the GetHashCode method
        /// </summary>
        /// <returns>(int)</returns>
        public override int GetHashCode()
        {
            return Field.GetHashCode() ^ Op.GetHashCode() ^ Value.GetHashCode();
        }
    }
}