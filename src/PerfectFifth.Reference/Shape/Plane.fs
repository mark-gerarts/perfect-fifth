module P5Reference.Shape.Plane

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let draw p5 =
    createCanvasWithMode p5 100 100 WebGL
    background p5 (Grayscale 200)
    plane p5 50 50

let run node = display node draw
