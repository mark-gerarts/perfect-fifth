module P5Reference.Environment.Focused

open P5.Core
open P5.Color
open P5.Shape
open P5.Environment

let setup _ = ()

let draw p5 _ =
    background p5 (Grayscale 200)
    noStroke p5
    fill p5 (RGB(0, 200, 0))
    circle p5 25 25 50

    if not (focused p5) then
        do
            stroke p5 (RGB(200, 0, 0))
            line p5 0 0 100 100
            line p5 100 0 0 100

let run node = animate node setup draw
