module P5Examples

open P5Examples
open P5.Core

let runSketch name =
    match name with
    | "Structure/Coordinates" -> Structure.Coordinates.run
    | _ -> failwith <| "No sketch with name " + name + " exists"
