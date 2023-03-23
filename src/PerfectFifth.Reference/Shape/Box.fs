module P5Reference.Shape.Box

open P5.Core
open P5.Rendering
open P5.Color
open P5.Shape
open P5.Transform

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    background p5 (Grayscale 200)
    rotateX p5 (float t * 0.001)
    rotateY p5 (float t * 0.001)
    // `cube p5 50` is the same as `box p5 50 50 50`.
    cube p5 50

let run node = animate node setup draw
