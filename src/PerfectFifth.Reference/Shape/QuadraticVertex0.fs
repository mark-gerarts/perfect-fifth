module P5Reference.Shape.QuadraticVertex0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    strokeWeight p5 5
    point p5 20 20
    point p5 80 20
    point p5 50 50

    noFill p5
    strokeWeight p5 1
    beginShape p5
    vertex p5 20 20
    quadraticVertex p5 80 20 50 50
    endShape p5

let run node = display node draw
