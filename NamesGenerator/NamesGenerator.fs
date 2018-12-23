namespace System.Text

open NamesGenerator.Constants

module NamesGenerator =
    /// <summary>
    /// Random Name Generator inspired by c# NamesGenerator (https://github.com/rkttu/NamesGenerator)
    /// Which itself is inspired by Docker NamesGenerator (https://github.com/docker/docker/blob/master/pkg/namesgenerator/names-generator.go)
    /// </summary>
    let GetName firstNameIndex lastNameIndex = firstNames.[firstNameIndex] + " " + lastNames.[lastNameIndex]
    
    let random = System.Random()
    
    // RandomName generates a random name from the list of adjectives and surnames in this package
    // formatted as "adjective surname". For example 'focused turing'.
    let rec RandomName() =
        let randomFirst = random.Next firstNames.Length
        let randomLast = random.Next lastNames.Length
        let name = GetName randomFirst randomLast
        if name = "boring wozniak" then // Steve Wozniak is not boring
            RandomName()
        else name
    
    // Gets random name with integer appended to the name
    // integer between 0 and 10 (exclusive) will be added to the end of the name, e.g `focused turing 3`
    let RandomNameWithNumber() =
        let num = random.Next 10 |> string
        RandomName() + " " + num
