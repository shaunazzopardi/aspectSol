﻿using System.Text;

namespace AspectSol.Compiler.Domain.AST
{
    public class AspectRemoveTagExpressionNode : AspectExpressionNode
    {
        public string Modifier { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetIndentation()}<AspectRemoveTagExpressionNode>");
            IncreaseIndentation();

            stringBuilder.AppendLine($"{GetIndentation()}<Modifier>{Modifier}</Modifier>");

            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</AspectRemoveTagExpressionNode>");

            return stringBuilder.ToString();
        }
    }
}