﻿using System.Text.RegularExpressions;
using CmdCalculator.Interfaces.Expressions;
using CmdCalculator.Interfaces.Operators;

namespace CmdCalculator.Operators
{
    public class DivideOperator : IBinaryOperator
    {
        public Regex OpRegex { get; }

        public int Priority { get; }

        public string OpString { get; }

        public DivideOperator(int priority)
        {
            Priority = priority;
            OpRegex = new Regex(".+\\/.+");
            OpString = "/";
        }

        public int GetResult(IExpression firstOperand, IExpression secondOperand)
        {
            var firstOperandValue = firstOperand.Evaluate();
            var secondOperandValue = secondOperand.Evaluate();
            return firstOperandValue / secondOperandValue;
        }
    }
}
