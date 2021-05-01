using CSharpier.DocTypes;
using CSharpier.SyntaxPrinter;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintContinueStatementSyntax(ContinueStatementSyntax node)
        {
            return Doc.Concat(
                Token.Print(node.ContinueKeyword),
                Token.Print(node.SemicolonToken)
            );
        }
    }
}
