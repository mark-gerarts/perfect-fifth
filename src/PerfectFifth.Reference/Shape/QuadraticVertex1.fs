module P5Reference.Shape.QuadraticVertex1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    strokeWeight p5 5
    point p5 20 20
    point p5 80 20
    point p5 50 50

    point p5 20 80
    point p5 80 80
    point p5 80 60

    noFill p5
    strokeWeight p5 1
    beginShape p5
    vertex p5 20 20
    quadraticVertex p5 80 20 50 50
    quadraticVertex p5 20 80 80 80
    vertex p5 80 60
    endShape p5

let run node = display node draw
