module P5Reference.Shape.BezierPoint

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    let x1 = 85
    let x2 = 10
    let x3 = 90
    let x4 = 15
    let y1 = 20
    let y2 = 10
    let y3 = 90
    let y4 = 80
    bezier p5 x1 y1 x2 y2 x3 y3 x4 y4
    fill p5 (Grayscale 255)

    for i in seq { 0..10 } do
        let t = float i / 10.0
        let x = bezierPoint p5 x1 x2 x3 x4 t
        let y = bezierPoint p5 y1 y2 y3 y4 t
        circle p5 x y 5

let run node = display node draw
