# Decoratoromatic!

Easily decorate CS classes with another CS class

## Usage
```dotnet run source/sourcefile.cs decorator.cs```

## Notes
I wrote this quick and dirty, and will break under many conditions.

It also only copies the constructor and properties for now.

## When I'm bored
- Copy methods
- Handle multiple classes in one file
- Using native ```CodeAnalysis``` objects to create a new SyntaxTree of the new decorator, rather than writing raw strings.