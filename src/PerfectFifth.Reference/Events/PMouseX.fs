module P5Reference.Events.PMouseX

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events

let setup p5 = setFrameRate p5 10

let draw p5 _ =
    background p5 (RGB(244, 248, 252))
    line p5 (mouseX p5) (mouseY p5) (pmouseX p5) (pmouseY p5)
    print p5 (sprintf "%f -> %f" (pmouseX p5) (mouseX p5))

let run node = animate node setup draw
