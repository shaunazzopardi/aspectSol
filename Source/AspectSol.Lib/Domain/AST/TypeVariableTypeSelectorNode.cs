﻿using System.Text;

namespace AspectSol.Lib.Domain.AST;

public class TypeVariableTypeSelectorNode : VariableTypeSelectorNode
{
    public string VariableType { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine($"{GetIndentation()}<TypeVariableTypeSelectorNode>");
        IncreaseIndentation();

        stringBuilder.AppendLine($"{GetIndentation()}<VariableType>{VariableType}</VariableType>");

        DecreaseIndentation();
        stringBuilder.AppendLine($"{GetIndentation()}</TypeVariableTypeSelectorNode>");

        return stringBuilder.ToString();
    }
}