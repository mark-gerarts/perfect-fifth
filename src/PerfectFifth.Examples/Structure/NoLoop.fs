module P5Examples.Structure.NoLoop

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    let y = (height p5 |> float) * 0.5
    let width = width p5 |> float

    background p5 (Grayscale 0)
    line2D p5 0 y width y

// Instead of using `noLoop`, you can use the `display` function to create your
// sketch. This already uses `noLoop` behind to scenes to draw to the canvas a
// single time.
let run node = display node draw
