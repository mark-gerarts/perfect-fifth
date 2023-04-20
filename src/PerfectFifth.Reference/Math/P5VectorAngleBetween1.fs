module P5Reference.Math.P5VectorAngleBetween1

open P5.Core
open P5.Color
open P5.Shape
open P5.Math
open P5.Transform
open P5.Structure
open P5.Events
open P5.Typography

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

let draw p5 _ =
    background p5 (Grayscale 240)

    let v0 = P5Vector.create (50, 50)
    let v1 = P5Vector.create (50, 0)
    drawArrow p5 v0 v1 (Name "red")

    let v2 = P5Vector.create (mouseX p5 - 50.0, mouseY p5 - 50.0)
    drawArrow p5 v0 v2 (Name "blue")

    let angleBetween = v1.angleBetween (v2)
    noStroke p5

    let message =
        sprintf "angle between: %.2f radians or %.2f degrees" angleBetween (degrees p5 angleBetween)

    textBounded p5 message 10 50 90 50


let run node = animate node noSetup draw
