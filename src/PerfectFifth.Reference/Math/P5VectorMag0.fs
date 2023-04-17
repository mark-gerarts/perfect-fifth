module P5Reference.Math.P5VectorMag0

open P5.Core
open P5.Color
open P5.Shape
open P5.Structure
open P5.Transform
open P5.Math
open P5.Typography
open P5.Events

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

    let v0 = createVector2D 0 0
    let v1 = createVector2D (mouseX p5) (mouseY p5)
    drawArrow p5 v0 v1 (Name "black")

    noStroke p5
    textBounded p5 (sprintf "vector length: %.2f" <| v1.mag ()) 10 70 90 30

let run node = animate node noSetup draw
