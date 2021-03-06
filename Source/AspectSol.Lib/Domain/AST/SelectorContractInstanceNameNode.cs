using System.Text;
using AspectSol.Lib.Domain.Filtering;
using Newtonsoft.Json.Linq;

namespace AspectSol.Lib.Domain.AST;

public class SelectorContractInstanceNameNode : SelectorNode
{
    public string InstanceName { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine($"{GetIndentation()}<{nameof(SelectorContractInstanceNameNode)}>");
        IncreaseIndentation();

        stringBuilder.AppendLine($"{GetIndentation()}<InstanceName>{InstanceName}</InstanceName>");

        DecreaseIndentation();
        stringBuilder.AppendLine($"{GetIndentation()}</{nameof(SelectorContractInstanceNameNode)}>");

        return stringBuilder.ToString();
    }

    public override SelectionResult Filter(JToken smartContract, AbstractFilteringService abstractFilteringService)
    {
        // TODO - No filtering for name instance selector yet built
        throw new NotImplementedException("No filtering for name instance selector yet built");
    }
}