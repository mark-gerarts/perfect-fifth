module P5Reference.Math.P5VectorAngleBetween0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (1, 0, 0)
    let v2 = P5Vector.create (0, 1, 0)

    let angle = v1.angleBetween (v2)

    // angle is PI/2
    print p5 (string angle)

let run node = display node draw
