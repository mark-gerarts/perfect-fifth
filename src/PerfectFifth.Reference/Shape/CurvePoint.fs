module P5Reference.Shape.CurvePoint

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    curve p5 5 26 5 26 73 24 73 61
    curve p5 5 26 73 24 73 61 15 65
    fill p5 (Grayscale 255)
    ellipseMode p5 Center
    let steps = 6.0

    for i in seq { 0.0 .. steps } do
        let t = i / steps

        let x1 = curvePoint p5 5 5 73 73 t
        let y1 = curvePoint p5 26 26 24 61 t
        circle p5 x1 y1 5

        let x2 = curvePoint p5 5 73 73 15 t
        let y2 = curvePoint p5 26 24 61 65 t
        circle p5 x2 y2 5

let run node = display node draw
