using AspectSol.Lib.Domain.Filtering;
using AspectSol.Lib.Domain.JavascriptExecution;
using Newtonsoft.Json.Linq;

namespace AspectSol.Lib.Domain.AST;

public abstract class ExecutableNode : Node
{
    /// <summary> 
    /// Executes the AST node on the passed JSON encoded smart contract AST 
    /// </summary>
    /// <param name="smartContract"></param>
    /// <param name="abstractFilteringService"></param>
    /// <param name="javascriptExecutor"></param>
    /// <returns>JToken containing the updated JSON encoded smart contract</returns>
    public abstract JToken Execute(JToken smartContract, AbstractFilteringService abstractFilteringService, IJavascriptExecutor javascriptExecutor);
}