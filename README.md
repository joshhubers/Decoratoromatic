# Decoratoromatic!

Easily decorate CS classes with another CS class

## Usage
```dotnet run source/sourcefile.cs decorator.cs```

## Example
```
namespace TestNamespace
{
  public class Foo
  {
    public Guid Id { get; set; }

    public int? FooA { get; set; }

    public string FooB { get; set; }

    public string FooC { get; set; }

    public Bar BarA { get; set; }

    public List<Bar> BarB { get; set; }
  }
}
```
Running ```dotnet run TestFiles/Foo.txt DecoratedFoo.cs```
Produces
```

public class DecoratedFoo
{
  private Foo _base;

  public DecoratedFoo() { _base = new Foo(); }

  public DecoratedFoo(Foo baseClass) { _base = baseClass; }
      

  public Guid Id
  {
    get
    {
      return _base.Id;
    }
    set
    {
      _base.Id = value;
    }
  }

  public int? FooA
  {
    get
    {
      return _base.FooA;
    }
    set
    {
      _base.FooA = value;
    }
  }

  public string FooB
  {
    get
    {
      return _base.FooB;
    }
    set
    {
      _base.FooB = value;
    }
  }

  public string FooC
  {
    get
    {
      return _base.FooC;
    }
    set
    {
      _base.FooC = value;
    }
  }

  public Bar BarA
  {
    get
    {
      return _base.BarA;
    }
    set
    {
      _base.BarA = value;
    }
  }

  public List<Bar> BarB
  {
    get
    {
      return _base.BarB;
    }
    set
    {
      _base.BarB = value;
    }
  }
}

```

## Notes
I wrote this quick and dirty, and will break under many conditions.

It also only copies the constructor and properties for now.

## When I'm bored
- Copy methods
- Handle multiple classes in one file
- Using native ```CodeAnalysis``` objects to create a new SyntaxTree of the new decorator, rather than writing raw strings.