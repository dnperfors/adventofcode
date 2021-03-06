module Utils

open System
open System.IO

let getFileContent fileName =
    File.ReadAllText(fileName)

let splitLines (content : string) =
    content.Split('\n')
    |> Array.toList