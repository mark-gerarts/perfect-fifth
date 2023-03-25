module P5Reference.Shape.BezierTangent1

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    noFill p5
    bezier p5 85 20 10 10 90 90 15 80
    stroke p5 (RGB(255, 102, 0))

    for i in seq { 0..16 } do
        let t = float i / 16.0
        let x = bezierPoint p5 85 10 90 15 t
        let y = bezierPoint p5 20 10 90 80 t
        let tx = bezierTangent p5 85 10 90 15 t
        let ty = bezierTangent p5 20 10 90 80 t
        let a = atan2 ty tx - halfPi
        line p5 x y (cos a * 8.0 + x) (sin a * 8.0 + y)


let run node = display node draw
