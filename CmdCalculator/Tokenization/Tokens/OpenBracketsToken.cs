﻿using CmdCalculator.Interfaces.Operators;
using CmdCalculator.Interfaces.Tokens;

namespace CmdCalculator.Tokenization.Tokens
{
    public class OpenBracketsToken<TOp> : IOperatorToken<TOp>
        where TOp : IOperator, new()
    {
        public TOp Op { get; }

        public string OpRepresentation
        {
            get { return Op.OpRepresentation; }
        }

        public OpenBracketsToken()
        {
            Op = new TOp();
        }

        public override bool Equals(object obj)
        {
            var token = obj as IOperatorToken<TOp>;
            if (token != null)
            {
                return token.Op.OpRepresentation == Op.OpRepresentation;
            }
            return base.Equals(obj);
        }
    }
}