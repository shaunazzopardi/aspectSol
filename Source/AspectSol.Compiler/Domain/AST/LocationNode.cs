﻿using AspectSol.Compiler.Infra.Enums;
using System.Text;

namespace AspectSol.Compiler.Domain.AST
{
    public class LocationNode : Node
    {
        public Location Value { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{GetIndentation()}<LocationNode>");
            IncreaseIndentation();

            stringBuilder.AppendLine($"{GetIndentation()}<Value>{Value}</Value>");

            DecreaseIndentation();
            stringBuilder.AppendLine($"{GetIndentation()}</LocationNode>");

            return stringBuilder.ToString();
        }
    }
}