using It.FattureInCloud.Sdk.FilterHelper;

namespace It.FattureInCloud.Sdk.Test.FilterHelper
{
    public class OperatorTest : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test a Operator instance
        /// </summary>
        [Fact]
        public void OperatorInstanceTest()
        {
            var eq = Operator.EQ;
            Assert.Equal("=", OperatorExtensions.GetOperatorValue(eq));

            var neq = Operator.NEQ;
            Assert.Equal("<>", OperatorExtensions.GetOperatorValue(neq));

            var gt = Operator.GT;
            Assert.Equal(">", OperatorExtensions.GetOperatorValue(gt));

            var gte = Operator.GTE;
            Assert.Equal(">=", OperatorExtensions.GetOperatorValue(gte));

            var lt = Operator.LT;
            Assert.Equal("<", OperatorExtensions.GetOperatorValue(lt));

            var lte = Operator.LTE;
            Assert.Equal("<=", OperatorExtensions.GetOperatorValue(lte));

            var isOp = Operator.IS;
            Assert.Equal("is", OperatorExtensions.GetOperatorValue(isOp));

            var isNot = Operator.IS_NOT;
            Assert.Equal("is not", OperatorExtensions.GetOperatorValue(isNot));

            var like = Operator.LIKE;
            Assert.Equal("like", OperatorExtensions.GetOperatorValue(like));

            var contains = Operator.CONTAINS;
            Assert.Equal("contains", OperatorExtensions.GetOperatorValue(contains));

            var startsWith = Operator.STARTS_WITH;
            Assert.Equal("starts with", OperatorExtensions.GetOperatorValue(startsWith));

            var endsWith = Operator.ENDS_WITH;
            Assert.Equal("ends with", OperatorExtensions.GetOperatorValue(endsWith));
        }
    }
}