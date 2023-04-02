module P5Reference.Events.RotationX

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Transform
open P5.Math
open P5.Events

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    background p5 (Grayscale 200)
    rotateX p5 (radians p5 (rotationX p5))
    cube p5 200

let run node = animate node setup draw
