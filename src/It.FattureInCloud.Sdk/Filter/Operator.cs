namespace It.FattureInCloud.Sdk.FilterHelper
{
    /// <summary>
    /// Operator enum
    /// </summary>
    public enum Operator
    {
        /// <summary>Equals Operator</summary>
        EQ,
        /// <summary>Greater Than Operator</summary>
        GT,
        /// <summary>Greater or Equal Than Operator</summary>
        GTE,
        /// <summary>Lower Than Operator</summary>
        LT,
        /// <summary>Lower or Equal Than Operator</summary>
        LTE,
        /// <summary>Not Equal Operator</summary>
        NEQ,
        /// <summary>Is Operator</summary>
        IS,
        /// <summary>Is Not Operator</summary>
        IS_NOT,
        /// <summary>Like Operator</summary>
        LIKE,
        /// <summary>Contains Operator</summary>
        CONTAINS,
        /// <summary>Not Like Operator</summary>
        NOT_LIKE,
        /// <summary>Not Contains Operator</summary>
        NOT_CONTAINS,
        /// <summary>Starts With Operator</summary>
        STARTS_WITH,
        /// <summary>Ends With Operator</summary>
        ENDS_WITH
    }

    /// <summary>
    /// Operator extensions class
    /// </summary>
    public class OperatorExtensions
    {
        /// <summary>
        /// Returns the Operator value.
        /// </summary>
        /// <param name="op">operator</param>
        public static string GetOperatorValue(Operator op)
        {
            string stringOperator = string.Empty;
            switch (op.ToString())
            {
                case "EQ":
                    stringOperator = "=";
                    break;
                case "GT":
                    stringOperator = ">";
                    break;
                case "GTE":
                    stringOperator = ">=";
                    break;
                case "LT":
                    stringOperator = "<";
                    break;
                case "LTE":
                    stringOperator = "<=";
                    break;
                case "NEQ":
                    stringOperator = "<>";
                    break;
                case "IS":
                    stringOperator = "is";
                    break;
                case "IS_NOT":
                    stringOperator = "is not";
                    break;
                case "LIKE":
                    stringOperator = "like";
                    break;
                case "CONTAINS":
                    stringOperator = "contains";
                    break;
                case "NOT_LIKE":
                    stringOperator = "not like";
                    break;
                case "NOT_CONTAINS":
                    stringOperator = "not contains";
                    break;
                case "STARTS_WITH":
                    stringOperator = "starts with";
                    break;
                case "ENDS_WITH":
                    stringOperator = "ends with";
                    break;
            }
            return stringOperator;
        }
    }
}