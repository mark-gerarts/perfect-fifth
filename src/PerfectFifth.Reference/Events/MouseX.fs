module P5Reference.Events.MouseX

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let draw p5 _ =
    background p5 (RGB(244, 248, 252))
    line p5 (mouseX p5) 0 (mouseX p5) 100

let run node = animate node noSetup draw
