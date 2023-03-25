module P5Reference.Shape.CurveDetail

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let draw p5 =
    createCanvasWithMode p5 100 100 WebGL
    curveDetail p5 5
    background p5 (Grayscale 200)
    curve3D p5 250 600 0 -30 40 0 30 30 0 -250 600 0

let run node = display node draw
