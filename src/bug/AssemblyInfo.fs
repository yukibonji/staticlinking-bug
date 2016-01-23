namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("bug")>]
[<assembly: AssemblyProductAttribute("bug")>]
[<assembly: AssemblyDescriptionAttribute("bug")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
