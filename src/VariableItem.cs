using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdvancedCalculator
{
    public class VariableItem
    {
        #region Properties

        public string VariableName { get; set; }

        public string Value { get; set; }

        public Visibility ExpressionVisibility { get; set; }

        public string ExpressionComputation { get; set; }

        #endregion
    }
}
