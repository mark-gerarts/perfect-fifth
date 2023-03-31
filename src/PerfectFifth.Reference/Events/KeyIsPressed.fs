module P5Reference.Events.KeyIsPressed

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let draw p5 _ =
    let fillColor =
        match keyIsPressed p5 with
        | true -> (Grayscale 0)
        | false -> (Grayscale 255)

    fill p5 fillColor
    square p5 25 25 50

let run node = animate node noSetup draw
