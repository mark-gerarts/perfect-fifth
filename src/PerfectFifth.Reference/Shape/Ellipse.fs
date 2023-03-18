module P5Reference.Shape.Ellipse

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    ellipse p5 56 46 55 55
    describe p5 "white ellipse with black outline in middle of a gray canvas"

let run node = display node draw
