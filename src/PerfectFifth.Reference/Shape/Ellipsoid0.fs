module P5Reference.Shape.Ellipsoid0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Transform

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    background p5 (RGB(205, 105, 94))
    rotateX p5 (float t * 0.001)
    rotateZ p5 (float t * 0.001)
    ellipsoid p5 30 40 40

let run node = animate node setup draw
