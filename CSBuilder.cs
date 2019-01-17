using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Decoratoromatic
{
  public class CSBuilder
  {
    StringBuilder _stringBuilder;
    public CSBuilder()
    {
      _stringBuilder = new StringBuilder();
    }

    public void WriteClassHeader(string className, string toDecorateName)
    {
      _stringBuilder.AppendLine($@"
public class {className}
{{
  private {toDecorateName} _base;

  public {className}() {{ _base = new {toDecorateName}(); }}

  public {className}({toDecorateName} baseClass) {{ _base = baseClass; }}
      ");
    }

    public void WriteClassClose()
    {
      _stringBuilder.AppendLine($@"
}}
      ");
    }

    public void WriteProperties(IEnumerable<PropertyDeclarationSyntax> properties)
    {
      foreach(var prop in properties)
      {
        WriteProperty(prop);
      }
    }

    private void WriteProperty(PropertyDeclarationSyntax property)
    {
      string propertyName = property.Identifier.ValueText;
      _stringBuilder.AppendLine($@"
  public {property.Type.ToString()} {propertyName}
  {{
    get
    {{
      return _base.{propertyName};
    }}
    set
    {{
      _base.{propertyName} = value;
    }}
  }}");
    }

    public override string ToString()
    {
      return _stringBuilder.ToString();
    }
  }
}