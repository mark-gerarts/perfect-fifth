module P5Reference.Environment.GridOutput0

open P5.Core
open P5.Shape
open P5.Environment
open P5.Color

let setup _ = ()

let draw p5 _ =
    // Use gridOutputWithDisplay to pass a display mode as well:
    // gridOutputWithDisplay p5 Fallback
    gridOutput p5
    background p5 (RGB(148, 196, 0))
    fill p5 (RGB(255, 0, 0))
    circle p5 20 20 20
    fill p5 (RGB(0, 0, 255))
    square p5 50 50 50

let run node = animate node setup draw
