module P5Reference.Math.P5VectorSet1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Math
open P5.Structure
open P5.Transform
open P5.Typography

let setup p5 =
    createCanvas p5 100 100

    (createVector2D 0 0, createVector2D 50 50)

let drawArrow p5 (baseVec: P5Vector) (vec: P5Vector) col =
    push p5
    stroke p5 (col)
    strokeWeight p5 3
    fill p5 (col)
    translate p5 baseVec.x baseVec.y
    line p5 0 0 vec.x vec.y
    rotate p5 (vec.heading ())
    let arrowSize = 7.0
    translate p5 (vec.mag () - arrowSize) 0
    triangle p5 0 (arrowSize / 2.0) 0 (-arrowSize / 2.0) arrowSize 0
    pop p5

let draw p5 (v0: P5Vector, v1: P5Vector) =
    background p5 (Grayscale 240)

    drawArrow p5 v0 v1 (Name "Black")
    v1.set (v1.x + (randomInRange p5 -1 1), v1.y + (randomInRange p5 -1 1))

    noStroke p5
    text p5 (sprintf "x: %.0f y: %.0f" v1.x v1.y) 20 90

let run node = simulate node setup noUpdate draw
