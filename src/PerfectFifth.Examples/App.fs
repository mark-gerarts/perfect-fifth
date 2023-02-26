module P5Examples

open Browser.Dom
open P5Examples
open P5.Core

let runSketch name =
    let node = Element <| document.querySelector (".canvas-wrapper")

    match name with
    | "Structure/Coordinates" -> Structure.Coordinates.run node
    | "Structure/WidthAndHeight" -> Structure.WidthAndHeight.run node
    | "Structure/SetupAndDraw" -> Structure.SetupAndDraw.run node
    | "Structure/NoLoop" -> Structure.NoLoop.run node
    | "Structure/Loop" -> Structure.Loop.run node
    | "Structure/Redraw" -> Structure.Redraw.run node
    | "Structure/Functions" -> Structure.Functions.run node
    | "Form/PointsAndLines" -> Form.PointsAndLines.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
