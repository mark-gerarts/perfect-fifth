module P5Reference.ThreeD.AmbientLight1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 =
    createWebGLCanvas p5 100 100
    noStroke p5

let draw p5 _ =
    background p5 (Grayscale 100)
    ambientLight p5 (Grayscale 255)
    ambientMaterial p5 (RGB(255, 127, 80)) // coral material
    sphere p5 40

let run node = animate node setup draw
