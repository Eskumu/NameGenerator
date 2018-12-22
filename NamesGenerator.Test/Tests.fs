module Tests

open System
open Xunit
open NamesGenerator.Text

[<Fact>]
let ``Test GetName`` () =
    Assert.Equal(GetName 0 0, "admiring albattani")

[<Fact>]
let ``Test RandomName is not empty``  () =
    Assert.True(RandomName().Length > 0)
    
[<Fact>]
let ``Test RandomName is in right format``  () =
    let name = RandomName()
    // printfn "%s" name
    Assert.Matches("(?<first_name>[a-z]+) (?<last_name>[a-z]+)", name)

[<Fact>]
let ``Test RandomNameWithNumber is in right format``  () =
    let name = RandomNameWithNumber()
    printfn "%s" name
    Assert.Matches("(?<first_name>[a-z]+) (?<last_name>[a-z]+) (?<number>)[0-9]", name)

