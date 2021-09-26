﻿using AspectSol.Compiler.Infra.Enums;
using System.Text;

namespace AspectSol.Compiler.Domain.AST
{
    public class VariableSyntaxNode : Node
    {
        public VariableAccess Value { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetIndentation()}<VariableSyntaxNode>");
            IncreaseIndentation();

            stringBuilder.AppendLine($"{GetIndentation()}<Value>{Value}</Value>");

            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</VariableSyntaxNode>");

            return stringBuilder.ToString();
        }
    }
}