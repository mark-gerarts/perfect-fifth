module P5Reference.ThreeD.NormalMaterial

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 200)
    normalMaterial p5
    sphere p5 40

let run node = display node draw
