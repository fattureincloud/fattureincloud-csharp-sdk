namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    /// Disjunction
    /// </summary>
    public class Disjunction : Expression
    {
        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        public Expression Left { get; set; }
        
        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        public Expression Right { get; set; }

        /// <summary>
        /// Initializes a new instance of the Disjunction class.
        /// </summary>
        /// <param name="left">Left xpression</param>
        /// <param name="right">Right expression</param>
        public Disjunction(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Builds the query from the disjunction
        /// </summary>
        /// <returns>(string)</returns>
        public string BuildQuery()
        {
            return string.Format("({0} or {1})", Left.BuildQuery(), Right.BuildQuery());
        }

        /// <summary>
        /// Builds the query from the disjunction
        /// </summary>
        /// <returns>(string)</returns>
        public override string ToString()
        {
            return BuildQuery();
        }

        /// <summary>
        /// Override of the Equals method
        /// </summary>
        /// <param name="o">Object to check for equality</param>
        /// <returns>(boolean)</returns>
        public override bool Equals(object o)
        {
            if (o is Disjunction)
            {
                return Equals(o as Disjunction);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Condition specific Equals method
        /// </summary>
        /// <param name="d">Disjunction to check for equality</param>
        /// <returns>(boolean)</returns>
        public bool Equals(Disjunction d)
        {
            return d != null &&
                   Left.Equals(d.Left) &&
                   Right.Equals(d.Right);
        }

        /// <summary>
        /// Override of the GetHashCode method
        /// </summary>
        /// <returns>(int)</returns>
        public override int GetHashCode()
        {
            return Left.GetHashCode() ^ Right.GetHashCode();
        }
    }
}