module P5Reference.ThreeD.PointLight

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
    let locX = mouseX p5 - width / 2.0
    let locY = mouseY p5 - height / 2.0
    // to set the light position,
    // think of the world's coordinate as:
    // -width/2,-height/2 ----------- width/2,-height/2
    //                   |           |
    //                   |    0,0    |
    //                   |           |
    //  -width/2,height/2 ----------- width/2,height/2
    pointLight p5 (Grayscale 250) locX locY 50
    noStroke p5
    sphere p5 40

let run node = animate node setup draw
