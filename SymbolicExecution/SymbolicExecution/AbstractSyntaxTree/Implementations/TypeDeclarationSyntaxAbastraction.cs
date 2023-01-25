namespace SymbolicExecution.AbstractSyntaxTree.Implementations;

public class TypeDeclarationSyntaxAbastraction : BaseTypeDeclarationSyntaxAbstraction, ITypeDeclarationSyntaxAbastraction
{
	public TypeDeclarationSyntaxAbastraction(ImmutableArray<SyntaxNodeAbstraction> children, ISymbol? symbol) : base(children, symbol)
	{
	}
}