module P5Reference.Shape.Circle

open P5.Core
open P5.Shape
open P5.Environment

let draw p5 =
    circle p5 30 30 20
    describe p5 "white circle with black outline in mid of gray canvas"

let run node = display node draw
