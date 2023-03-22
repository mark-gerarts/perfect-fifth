module P5Reference.Shape.CurveTightness

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Events
open P5.Math
open P5.Environment

let getT p5 = map p5 (mouseX p5) 0 (width p5) -5 5

let setup p5 =
    createCanvas p5 100 100
    noFill p5
    getT p5

let update p5 _ = getT p5

let draw p5 t =
    background p5 (Grayscale 204)
    curveTightness p5 t
    beginShape p5
    curveVertex p5 10 26
    curveVertex p5 10 26
    curveVertex p5 83 24
    curveVertex p5 83 61
    curveVertex p5 25 65
    curveVertex p5 25 65
    endShape p5

let run node = simulate node setup update draw
