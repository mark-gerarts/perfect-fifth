module P5Examples

open P5Examples
open P5.Core

let runSketch name =
    let sketch =
        match name with
        | "structure/coordinates" -> Structure.Coordinates.sketch
        | _ -> failwith <| "No sketch with name " + name + " exists"

    createSketch sketch
