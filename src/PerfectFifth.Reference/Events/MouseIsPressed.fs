module P5Reference.Events.MouseIsPressed

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let draw p5 _ =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)

    if mouseIsPressed p5 then
        do circle p5 50 50 50
    else
        square p5 25 25 50

let run node = animate node noSetup draw
