module P5Reference.Shape.StrokeJoin1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    strokeWeight p5 10.0
    strokeJoin p5 JoinBevel
    beginShape p5
    vertex p5 35 20
    vertex p5 65 50
    vertex p5 35 80
    endShape p5

let run node = display node draw
