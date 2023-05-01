module P5Reference.ThreeD.DebugMode2

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 =
    createWebGLCanvas p5 100 100
    camera p5 0 -30 100 0 0 0 0 1 0
    normalMaterial p5
    debugModeAxes p5

let draw p5 _ =
    background p5 (Grayscale 200)
    orbitControl p5
    box p5 15 30 30

let run node = animate node setup draw
