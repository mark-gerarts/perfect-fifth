module P5Reference.ThreeD.DebugMode4

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 =
    createWebGLCanvas p5 100 100
    camera p5 0 -30 100 0 0 0 0 1 0
    normalMaterial p5

    let gridOpts =
        { gridSize = 100
          gridDivisions = 10
          xOff = 0
          yOff = 0
          zOff = 0 }

    let axesOpts =
        { axesSize = 20
          xOff = 0
          yOff = -40
          zOff = 0 }

    debugModeAll p5 gridOpts axesOpts

let draw p5 _ =
    noStroke p5
    background p5 (Grayscale 200)
    orbitControl p5
    box p5 15 30 30

    // set the stroke color and weight for the grid!
    stroke p5 (RGB(255, 0, 150))
    strokeWeight p5 0.8

let run node = animate node setup draw
