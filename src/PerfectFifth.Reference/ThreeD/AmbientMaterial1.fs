module P5Reference.ThreeD.AmbientMaterial1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 70)
    ambientLight p5 (RGB(255, 0, 255)) // magenta light
    ambientMaterial p5 (Grayscale 255) // white material
    cube p5 30

let run node = display node draw
