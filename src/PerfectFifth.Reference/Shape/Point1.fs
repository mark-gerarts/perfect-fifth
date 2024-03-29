module P5Reference.Shape.Point1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    point p5 30 20
    point p5 85 20
    stroke p5 (Name "purple")
    strokeWeight p5 10
    point p5 85 75
    point p5 30 75

let run node = display node draw
