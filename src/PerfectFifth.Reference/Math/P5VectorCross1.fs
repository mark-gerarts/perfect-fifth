module P5Reference.Math.P5VectorCross1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    // Static method
    let v1 = P5Vector.create (1, 0, 0)
    let v2 = P5Vector.create (0, 1, 0)

    let crossProduct = P5Vector.cross (v1, v2)
    // crossProduct has components [0, 0, 1]
    print p5 (string crossProduct)

let run node = display node draw
