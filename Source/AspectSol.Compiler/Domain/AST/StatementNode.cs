﻿using System.Collections.Generic;
using System.Text;

namespace AspectSol.Compiler.Domain.AST
{
    public abstract class StatementNode : Node
    {
        public List<AspectExpressionNode> Body { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetIndentation()}<Body>");
            IncreaseIndentation();

            stringBuilder.AppendLine(string.Join('n', Body));

            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</Body>");

            return stringBuilder.ToString();
        }
    }
}