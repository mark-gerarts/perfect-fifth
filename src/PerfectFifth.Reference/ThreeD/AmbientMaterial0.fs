module P5Reference.ThreeD.AmbientMaterial0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 0)
    noStroke p5
    ambientLight p5 (Grayscale 255)
    ambientMaterial p5 (RGB(70, 130, 230))
    sphere p5 40

let run node = display node draw
