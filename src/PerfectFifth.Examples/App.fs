module P5Examples

open Browser.Dom
open P5Examples
open P5.Core

let runSketch name =
    let node = Element <| document.querySelector (".canvas-wrapper")

    match name with
    | "Structure/Coordinates" -> Structure.Coordinates.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
