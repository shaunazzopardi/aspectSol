using AspectSol.Lib.Infra.Enums;

namespace AspectSol.Lib.Domain.Tokenization;

public class TokenMatch
{
    public bool IsMatch { get; set; }
    public TokenType TokenType { get; set; }
    public string Value { get; set; }
    public string RemainingText { get; set; }
}