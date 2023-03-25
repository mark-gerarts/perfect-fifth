module P5Reference.Shape.BezierDetail

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let draw p5 =
    createCanvasWithMode p5 100 100 WebGL
    noFill p5
    bezierDetail p5 5

    background p5 (Grayscale 200)
    bezier3D p5 -40 -40 0 90 -40 0 -90 40 0 40 40 0

let run node = display node draw
