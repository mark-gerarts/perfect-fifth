module P5Reference.Shape.Triangle

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    triangle p5 30 75 58 20 86 75
    describe p5 "white triangle with black outline in mid-right of canvas"

let run node = display node draw
