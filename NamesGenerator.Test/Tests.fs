module Tests

open System
open Xunit
open System.Text

[<Fact>]
let ``Test GetName`` () =
    Assert.Equal(NamesGenerator.GetName 0 0, "admiring albattani")

[<Fact>]
let ``Test RandomName is not empty``  () =
    Assert.True(NamesGenerator.RandomName().Length > 0)
    
[<Fact>]
let ``Test RandomName is in right format``  () =
    let name = NamesGenerator.RandomName()
    // printfn "%s" name
    Assert.Matches("(?<first_name>[a-z]+) (?<last_name>[a-z]+)", name)

[<Fact>]
let ``Test RandomNameWithNumber is in right format``  () =
    let name = NamesGenerator.RandomNameWithNumber()
    printfn "%s" name
    Assert.Matches("(?<first_name>[a-z]+) (?<last_name>[a-z]+) (?<number>)[0-9]", name)

