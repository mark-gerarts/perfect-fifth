module P5Reference.Shape.CurveTangent

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    noFill p5
    curve p5 5 26 73 24 73 61 15 65
    let steps = 6.0

    for i in seq { 0.0 .. steps } do
        let t = i / steps
        let x = curvePoint p5 5 73 73 15 t
        let y = curvePoint p5 26 24 61 65 t

        let tx = curveTangent p5 5 73 73 15 t
        let ty = curveTangent p5 26 24 61 65 t
        let a = atan2 ty tx - halfPi

        line p5 x y (cos (a) * 8.0 + x) (sin (a) * 8.0 + y)

let run node = display node draw
