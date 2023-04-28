module P5Reference.ThreeD.DirectionalLight

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Environment
open P5.Events
open P5.ThreeD

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 0)
    //move your mouse to change light direction
    let dirX = (mouseX p5 / width - 0.5) * 2.0
    let dirY = (mouseY p5 / height - 0.5) * 2.0
    directionalLight p5 (Grayscale 250) -dirX -dirY -1
    noStroke p5
    sphere p5 40

let run node = animate node setup draw
