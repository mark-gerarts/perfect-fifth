module P5Reference.ThreeD.AmbientMaterial2

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 70)
    ambientLight p5 (RGB(0, 255, 0)) // green light
    ambientMaterial p5 (RGB(255, 0, 255)) // magenta material
    cube p5 30

let run node = display node draw
