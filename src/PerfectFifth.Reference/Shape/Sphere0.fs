module P5Reference.Shape.Sphere0

open P5.Core
open P5.Color
open P5.Rendering
open P5.Shape

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (RGB(205, 102, 94))
    sphere p5 40

let run node = display node draw
