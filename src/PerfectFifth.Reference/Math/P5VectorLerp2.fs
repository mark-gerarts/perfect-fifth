module P5Reference.Math.P5VectorLerp2

open P5.Core
open P5.Color
open P5.Shape
open P5.Math
open P5.Transform
open P5.Structure
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

let setup p5 = (0.01, 0.0)

let update p5 (step, amount) =
    let newStep = if amount > 1.0 || amount < 0.0 then -step else step

    (newStep, amount + newStep)

let draw p5 (_, amount) =
    background p5 (Grayscale 240)
    let v0 = P5Vector.create (0, 0)

    let v1 = P5Vector.create (mouseX p5, mouseY p5)
    drawArrow p5 v0 v1 (Name "red")

    let v2 = P5Vector.create (90, 90)
    drawArrow p5 v0 v2 (Name "blue")

    let v3 = P5Vector.lerp (v1, v2, amount)

    drawArrow p5 v0 v3 (Name "purple")

let run node = simulate node setup update draw
