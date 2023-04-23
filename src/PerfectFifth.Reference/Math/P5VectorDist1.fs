module P5Reference.Math.P5VectorDist1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    // Static method
    let v1 = P5Vector.create (1, 0, 0)
    let v2 = P5Vector.create (0, 1, 0)

    let distance = P5Vector.dist (v1, v2)
    // distance is 1.4142...
    print p5 (string distance)

let run node = display node draw
