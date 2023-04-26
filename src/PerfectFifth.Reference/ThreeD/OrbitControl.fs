module P5Reference.ThreeD.OrbitControl

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    normalMaterial p5

let draw p5 _ =
    background p5 (Grayscale 200)
    orbitControl p5
    rotateY p5 0.5
    box p5 30 50 50

let run node = animate node setup draw
