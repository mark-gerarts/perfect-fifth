module P5Reference.Events.MouseButton

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let draw p5 _ =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)

    if mouseIsPressed p5 then
        do
            match mouseButton p5 with
            | MouseLeft -> circle p5 50 50 50
            | MouseRight -> square p5 25 25 50
            | MouseCenter -> triangle p5 23 75 50 20 78 75

let run node = animate node noSetup draw
