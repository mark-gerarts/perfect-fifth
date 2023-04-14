module P5Reference.Shape.Point2

open P5.Core
open P5.Shape
open P5.Math

let draw p5 =
    let a = createVector2D 10 10
    pointFromVector p5 a
    let b = createVector2D 10 20
    pointFromVector p5 b
    pointFromVector p5 <| createVector2D 20 10
    pointFromVector p5 <| createVector2D 20 20

let run node = display node draw
