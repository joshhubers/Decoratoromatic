using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Decoratoromatic
{
  public class Decorator
  {
    private string _rawCSharp;
    private CSBuilder _builder;
    private IEnumerable<SyntaxNode> _nodes;

    public Decorator(string rawCSharp)
    {
      _rawCSharp = rawCSharp;
      _builder = new CSBuilder();
      _nodes = CSharpSyntaxTree.ParseText(_rawCSharp).GetRoot().DescendantNodes();
    }

    public string Generate(string className)
    {
      WriteClassHeader(className);
      WriteProperties();
      WriteClassClose();

      return _builder.ToString();
    }

    private IEnumerable<PropertyDeclarationSyntax> GetProperties()
    {
      var properties = _nodes.OfType<PropertyDeclarationSyntax>().Cast<PropertyDeclarationSyntax>();
      var publicProperties = properties.Where(p => p.ToString().Contains("public"));
      return publicProperties;
    }

    private void WriteClassClose()
    {
      _builder.WriteClassClose();
    }

    private void WriteProperties()
    {
      IEnumerable<PropertyDeclarationSyntax> properties = GetProperties();
      _builder.WriteProperties(properties);
    }

    private void WriteClassHeader(string className)
    {
      string baseClassName = GetClassName();
      _builder.WriteClassHeader(className, baseClassName);
    }

    private string GetClassName()
    {
      ClassDeclarationSyntax classNode = _nodes.OfType<ClassDeclarationSyntax>().First();
      string className = classNode.Identifier.ValueText;
      return className;
    }
  }
}