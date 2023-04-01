module P5Reference.Events.PMouseY

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events

let draw p5 =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)

    //draw a square only if the mouse is not moving
    if mouseY p5 = pmouseY p5 && mouseX p5 = pmouseX p5 then
        do square p5 20 20 60

    print p5 (sprintf "%f -> %f" (pmouseY p5) (mouseY p5))

let run node = display node draw
