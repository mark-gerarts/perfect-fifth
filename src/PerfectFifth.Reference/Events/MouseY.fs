module P5Reference.Events.MouseY

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let draw p5 _ =
    background p5 (RGB(244, 248, 252))
    line p5 0 (mouseY p5) 100 (mouseY p5)

let run node = animate node noSetup draw
