module P5Reference.Math.P5VectorDiv4

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    // Static method
    let v1 = P5Vector.create (6, 4, 2)
    let v2 = P5Vector.divScalar (v1, 2)
    print p5 (string v2)

let run node = display node draw
