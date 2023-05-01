module P5Reference.ThreeD.SpotLight

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Events
open P5.ThreeD
open P5.Math

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 0)
    // move your mouse to change light position
    let locX = mouseX p5 - width / 2.0
    let locY = mouseY p5 - height / 2.0
    // to set the light position,
    // think of the world's coordinate as:
    // -width/2,-height/2 ----------- width/2,-height/2
    //                   |           |
    //                   |    0,0    |
    //                   |           |
    //  -width/2,height/2 ----------- width/2,height/2
    ambientLight p5 (Grayscale 50)

    let color = (RGB(0, 250, 0))
    let position = P5Vector.create (locX, locY, 100)
    let direction = P5Vector.create (0, 0, -1)

    spotLightWithOptions p5 color position direction (pi / 16.0) 100
    noStroke p5
    sphere p5 40

let run node = animate node setup draw
