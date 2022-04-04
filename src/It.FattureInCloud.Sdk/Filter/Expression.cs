namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    /// Expression
    /// </summary>
    public interface Expression
    {
        /// <summary>
        /// Builds the query from the expression
        /// </summary>
        /// <returns>(string)</returns>
        string BuildQuery();
    }
}