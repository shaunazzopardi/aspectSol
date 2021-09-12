﻿using System.Text;

namespace AspectSol.Compiler.Domain.AST
{
    public class AspectGenericExpressionNode : AspectExpressionNode
    {
        public string Expression { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetIndentation()}<AspectGenericExpressionNode>");
            IncreaseIndentation();

            stringBuilder.AppendLine($"{GetIndentation()}<Expression>");
            IncreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}{Expression}");
            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</Expression>");

            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</AspectGenericExpressionNode>");

            return stringBuilder.ToString();
        }
    }
}