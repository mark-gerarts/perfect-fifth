module P5Examples.Structure.Functions

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let drawTarget p5 xloc yloc size num =
    let grayvalues = 255.0 / num
    let steps = size / num

    for i in { 0.0 .. num - 1.0 } do
        let d = size - i * steps |> float
        fill p5 (Grayscale(i * grayvalues))
        circle p5 xloc yloc d

let draw p5 =
    resizeCanvas p5 720 400
    background p5 (Grayscale 51)
    noStroke p5

    let width = width p5 |> float
    let height = height p5 |> float

    drawTarget p5 (width * 0.25) (height * 0.4) 200 4
    drawTarget p5 (width * 0.5) (height * 0.5) 300 10
    drawTarget p5 (width * 0.75) (height * 0.3) 120 6

// Instead of using `noLoop`, you can use the `display` function to create your
// sketch. This already uses `noLoop` behind to scenes to draw to the canvas a
// single time.
let run node = display node draw
