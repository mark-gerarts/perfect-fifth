module P5Reference.Shape.Line0

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    line p5 30 20 85 75
    describe p5 "a 78 pixels long line running from mid-top to bottom-right of canvas"

let run node = display node draw
