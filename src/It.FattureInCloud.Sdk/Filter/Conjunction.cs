namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    ///     Conjunction
    /// </summary>
    public class Conjunction : Expression
    {
        /// <summary>
        ///     Initializes a new instance of the Conjunction class.
        /// </summary>
        /// <param name="left">Left expression</param>
        /// <param name="right">Right expression</param>
        public Conjunction(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        /// <summary>
        ///     Gets or Sets Left
        /// </summary>
        public Expression Left { get; set; }

        /// <summary>
        ///     Gets or Sets Right
        /// </summary>
        public Expression Right { get; set; }

        /// <summary>
        ///     Builds the query from the conjunction
        /// </summary>
        /// <returns>(string)</returns>
        public string BuildQuery()
        {
            return string.Format("({0} and {1})", Left.BuildQuery(), Right.BuildQuery());
        }

        /// <summary>
        ///     Builds the query from the conjunction
        /// </summary>
        /// <returns>(string)</returns>
        public override string ToString()
        {
            return BuildQuery();
        }

        /// <summary>
        ///     Override of the Equals method
        /// </summary>
        /// <param name="o">Object to check for equality</param>
        /// <returns>(boolean)</returns>
        public override bool Equals(object o)
        {
            if (o is Conjunction)
                return Equals(o as Conjunction);
            return false;
        }

        /// <summary>
        ///     Conjunction specific Equals method
        /// </summary>
        /// <param name="c">Conjunction to check for equality</param>
        /// <returns>(boolean)</returns>
        public bool Equals(Conjunction c)
        {
            return c != null &&
                   Left.Equals(c.Left) &&
                   Right.Equals(c.Right);
        }

        /// <summary>
        ///     Override of the GetHashCode method
        /// </summary>
        /// <returns>(int)</returns>
        public override int GetHashCode()
        {
            return Left.GetHashCode() ^ Right.GetHashCode();
        }
    }
}