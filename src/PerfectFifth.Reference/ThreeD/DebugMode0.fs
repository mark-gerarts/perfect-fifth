module P5Reference.ThreeD.DebugMode0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events

let setup p5 =
    createWebGLCanvas p5 100 100
    camera p5 0 -30 100 0 0 0 0 1 0
    normalMaterial p5
    debugMode p5

let draw p5 _ =
    background p5 (Grayscale 200)
    orbitControl p5
    box p5 15 30 30

    // Press the spacebar to turn debugMode off!
    if keyIsDown p5 32 then
        do noDebugMode p5

let run node = animate node setup draw
