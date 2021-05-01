using CSharpier.DocTypes;
using CSharpier.SyntaxPrinter;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintBaseExpressionSyntax(BaseExpressionSyntax node)
        {
            return Token.Print(node.Token);
        }
    }
}
