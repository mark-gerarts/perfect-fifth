module P5Examples.Structure.Recursion

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let rec drawCircle p5 x radius level =
    let height = height p5 |> float
    let tt = (126 * level) / 4
    fill p5 (Grayscale tt)
    circle p5 x (height / 2.0) (radius * 2.0)

    if level > 1 then
        do
            drawCircle p5 (x - radius / 2.0) (radius / 2.0) (level - 1)
            drawCircle p5 (x + radius / 2.0) (radius / 2.0) (level - 1)

let draw p5 =
    resizeCanvas p5 720 560
    noStroke p5

    let width = width p5 |> float

    drawCircle p5 (width / 2.0) 280 6

let run node = display node draw
