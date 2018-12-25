# NamesGenerator.core
![](https://img.shields.io/nuget/v/NamesGenerator.core.svg)

> .NET core random names generator. Written in F#
> Inspired by C# and docker name generation implementations.


## Usage
Import `System.Text` to your solution file.

Use method `NamesGenerator.RandomName()` for name in form "adjective surname" ex "focused turing".

To add random number from 0-9 to this name use method `NamesGenerator.RandomNameWithNumber()`.


## Installation

You can install this package from [nuget](https://www.nuget.org/packages/NamesGenerator.core/).


## Things to do:

- [ ] Provide upper case variants with names.
- [ ] Let user specify the format somehow.
- [ ] Write proper .nuspec file.

## Contributing

Feel free to fork the project.

It would be more than welcomed to add more names to random name generator.

It is my first time writing something in F#, 
so if you got some feedback on my code I'd like to know about it.

## Thanks

- [Original docker implementation](https://github.com/moby/moby/blob/master/pkg/namesgenerator/names-generator.go)
- [C# implementation](https://github.com/richardkundl/NamesGenerator/blob/master/NamesGenerator/NamesGenerator.cs) that inspired me.