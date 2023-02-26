module P5Examples.Structure.Coordinates

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering

let draw (p5: P5) =
    resizeCanvas p5 720 400

    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 0)
    noFill p5

    stroke p5 (Grayscale 255)
    point2D p5 (width * 0.5) (height * 0.25)

    stroke p5 (RGB(0, 153, 255))
    line2D p5 0 (height * 0.33) width (height * 0.33)

    stroke p5 (RGB(255, 153, 0))
    rect p5 (width * 0.25) (height * 0.1) (width * 0.5) (height * 0.8)

let run node = display node draw
