module P5Reference.Shape.EndShape

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5

    beginShape p5
    vertex p5 20 20
    vertex p5 45 20
    vertex p5 45 80
    endShapeAndClose p5

    beginShape p5
    vertex p5 50 20
    vertex p5 75 20
    vertex p5 75 80
    endShape p5

let run node = display node draw
