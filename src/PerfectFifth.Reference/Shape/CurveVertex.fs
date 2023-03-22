module P5Reference.Shape.CurveVertex

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    strokeWeight p5 5
    point p5 84 91
    point p5 68 19
    point p5 21 17
    point p5 32 91
    strokeWeight p5 1

    noFill p5
    beginShape p5
    curveVertex p5 84 91
    curveVertex p5 84 91
    curveVertex p5 68 19
    curveVertex p5 21 17
    curveVertex p5 32 91
    curveVertex p5 32 91
    endShape p5

let run node = display node draw
