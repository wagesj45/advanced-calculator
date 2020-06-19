using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class FunctionDefinitonItem
    {
        #region Properties

        public string FunctionName { get; private set; }

        public string FunctionDescription { get; private set; }

        public IEnumerable<KeyValuePair<string, string>> FunctionArguments { get; private set; }

        public static IEnumerable<FunctionDefinitonItem> DefinedFunctions
        {
            get
            {
                yield return new FunctionDefinitonItem() { FunctionName = "sin", FunctionDescription = "Returns the sine value of a given expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "cos", FunctionDescription = "Returns the cosine value of a given expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "tan", FunctionDescription = "Returns the tangent value of a given expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "round", FunctionDescription = "Rounds an expression to the nearest whole number.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "sqrt", FunctionDescription = "Returns the square root of a given expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "abs", FunctionDescription = "Returns the absolute value of a given expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("expression", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "exp", FunctionDescription = "Returns the constant e to a given power.", FunctionArguments = new[] { new KeyValuePair<string, string>("power", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "log", FunctionDescription = "Returns the log of the first expression to the base of the second expression.", FunctionArguments = new[] { new KeyValuePair<string, string>("value", "An expression to compute."), new KeyValuePair<string, string>("base", "An expression to compute.") } };
                yield return new FunctionDefinitonItem() { FunctionName = "precision", FunctionDescription = "Returns the value of expression1 to a given precision. For example, precision(12.3456789, 4) will return 12.3456.", FunctionArguments = new[] { new KeyValuePair<string, string>("value", "An expression to compute."), new KeyValuePair<string, string>("precision", "An expression to compute.") } };
            }
        }

        #endregion

        private FunctionDefinitonItem()
        {
            //
        }
    }
}
