module P5Reference.Structure.Preload

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform
open P5.Image

// Preloading state has to use a mutable var at the moment. It should definitely
// be handled in a more elegant way in the future, but this requires some
// thinking first.
let mutable img = None
let mutable centerPixel = [| 0.0; 0.0; 0.0; 0.0 |]

let preload p5 =
    img <- Some <| loadImage p5 "assets/laDefense.png"

let setup p5 =
    let img = Option.get img
    img.loadPixels ()
    centerPixel <- img.getPixel (img.width / 2 |> float) (img.height / 2 |> float)

let draw p5 _ =
    background p5 (Values centerPixel)
    imageWithSize p5 (Option.get img) 25 25 50 50

let run node =
    // Also, until the preload problem is handled, we have to run createSketch
    // manually.
    createSketch
        { defaultSketch setup with
            preload = Some preload
            draw = draw
            node = node }
