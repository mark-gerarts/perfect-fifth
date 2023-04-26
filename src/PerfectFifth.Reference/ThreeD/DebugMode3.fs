module P5Reference.ThreeD.DebugMode3

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 =
    createWebGLCanvas p5 100 100
    camera p5 0 -30 100 0 0 0 0 1 0
    normalMaterial p5

    let opts =
        { gridSize = 100
          gridDivisions = 10
          xOff = 0
          yOff = 0
          zOff = 0 }

    debugModeGridWithOptions p5 opts

let draw p5 _ =
    background p5 (Grayscale 200)
    orbitControl p5
    box p5 15 30 30

let run node = animate node setup draw
