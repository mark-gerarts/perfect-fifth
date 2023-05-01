module P5Reference.ThreeD.EmissiveMaterial

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 0)
    noStroke p5
    ambientLight p5 (Grayscale 0)
    emissiveMaterial p5 (RGB(130, 230, 0))
    sphere p5 40

let run node = display node draw
